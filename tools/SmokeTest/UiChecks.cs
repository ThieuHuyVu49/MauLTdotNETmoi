using System.Diagnostics;
using System.Drawing.Imaging;
using System.Reflection;
using EnglishCenterManagement.Data;
using EnglishCenterManagement.Forms;
using EnglishCenterManagement.Services;

internal static class UiChecks
{
    public static int Run()
    {
        int failures = 0;
        var thread = new Thread(() =>
        {
            try
            {
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);
                Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                if (File.Exists(Db.DbPath)) File.Delete(Db.DbPath);
                Db.Init();
                string folder = Path.Combine(AppContext.BaseDirectory, "screenshots");
                Directory.CreateDirectory(folder);

                void Check(string title, Action action)
                {
                    try
                    {
                        action();
                        Pump();
                        Console.WriteLine("PASS " + title);
                    }
                    catch (Exception ex)
                    {
                        failures++;
                        Console.WriteLine("FAIL " + title + ": " + (ex.InnerException ?? ex));
                    }
                }

                void Capture(Form form, string name)
                {
                    Pump();
                    using var bitmap = new Bitmap(form.Width, form.Height);
                    form.DrawToBitmap(bitmap, new Rectangle(Point.Empty, form.Size));
                    bitmap.Save(Path.Combine(folder, name + ".png"), ImageFormat.Png);
                }

                using (var portal = new FormPortal())
                {
                    Check("portal shown", () =>
                    {
                        portal.Show();
                        Capture(portal, "portal");
                    });
                    portal.Close();
                }
                foreach (string role in new[] { "admin", "teacher", "student" })
                {
                    using (var login = new FormLogin(role))
                    {
                        Check(role + " login displayed", () =>
                        {
                            login.Show();
                            Capture(login, role + "-login");
                        });
                        Check(role + " login validation", () =>
                        {
                            Find<TextBox>(login, "txtPassword").Text = "incorrect";
                            Find<Button>(login, "btnSubmit").PerformClick();
                            if (login.User != null) throw new Exception("Incorrect password accepted.");
                        });
                        Check(role + " login submitted", () =>
                        {
                            Find<TextBox>(login, "txtPassword").Text = "12345678";
                            Find<Button>(login, "btnSubmit").PerformClick();
                            if (login.User?.Role != role) throw new Exception("Login did not return the selected role.");
                        });
                        login.Close();
                    }
                    AppSession.User = AuthService.Login(role + "@northstar.vn", "12345678", role).User;
                    using var main = new FormMain();
                    Check(role + " shell shown", () =>
                    {
                        main.Show();
                        Pump();
                        var date = Find<Label>(main, "lblToday");
                        string original = date.Text;
                        for (int day = 0; day < 7; day++)
                        {
                            date.Text = EnglishCenterManagement.Models.Fmt.LongDate(DateTime.Today.AddDays(day));
                            if (date.Right > date.Parent.ClientSize.Width || date.Bottom > date.Parent.ClientSize.Height)
                                throw new Exception("Header date is clipped: " + date.Text);
                        }
                        date.Text = original;
                    });
                    foreach (string key in new[] { "dashboard", "students", "courses", "classes", "teachers", "schedule", "finance", "attendance", "settings" })
                    {
                        Check(role + " " + key + " navigation", () =>
                        {
                            Form page = main.Navigate(key);
                            page.Refresh();
                            Pump();
                            if (!page.Visible) throw new Exception("Page is not visible.");
                            foreach (var control in Walk(page))
                                if (control is UserControl) throw new Exception("UserControl found: " + control.Name);
                            Capture(main, role + "-" + key);
                            if (key == "settings")
                            {
                                var settings = (FormSettings)page;
                                Find<TextBox>(page, "txtPhone").Text = "0901234569";
                                Find<Button>(page, "btnProfileSave").PerformClick();
                                if (AppSession.User.Phone != "0901234569") throw new Exception("Profile did not save.");
                                Find<TextBox>(page, "txtName").Text = "Unsaved name";
                                Find<Button>(page, "btnProfileCancel").PerformClick();
                                if (Find<TextBox>(page, "txtName").Text != AppSession.User.FullName) throw new Exception("Cancel did not restore the profile.");
                                Find<Button>(page, "btnRole").PerformClick();
                                Capture(main, role + "-settings-role");
                                if (role == "admin")
                                {
                                    Find<TextBox>(page, "txtCenterName").Text = "Trung tâm Anh ngữ Northstar";
                                    Find<Button>(page, "btnCenterSave").PerformClick();
                                    if (SettingService.Get("CenterName") != "Trung tâm Anh ngữ Northstar") throw new Exception("Center settings did not save.");
                                }
                                else if (role == "teacher")
                                {
                                    Find<NumericUpDown>(page, "numYears").Value = 9;
                                    Find<Button>(page, "btnTeachingSave").PerformClick();
                                    if (TeacherService.Get(AppSession.User.TeacherId.Value).Years != 9) throw new Exception("Teaching settings did not save.");
                                }
                                else
                                {
                                    Find<ComboBox>(page, "cboGoal").SelectedIndex = 1;
                                    Find<Button>(page, "btnStudySave").PerformClick();
                                    if (SettingService.Get($"Study_{AppSession.User.Id}_Goal") != "TOEIC 650+") throw new Exception("Study settings did not save.");
                                }
                                settings.ShowNotificationsTab();
                                Find<CheckBox>(page, "chkNotifySchedule").Checked = false;
                                Find<Button>(page, "btnNotificationsSave").PerformClick();
                                if (SettingService.GetBool($"Notify_{AppSession.User.Id}_Schedule")) throw new Exception("Notification preference did not save.");
                                Capture(main, role + "-settings-notifications");
                                Find<Button>(page, "btnSecurity").PerformClick();
                                Capture(main, role + "-settings-security");
                                Find<TextBox>(page, "txtCurrentPassword").Text = "incorrect";
                                Find<TextBox>(page, "txtNewPassword").Text = "Newpass123";
                                Find<TextBox>(page, "txtConfirmPassword").Text = "Newpass123";
                                Find<Button>(page, "btnPasswordSave").PerformClick();
                                if (AuthService.Login(role + "@northstar.vn", "12345678", role).User == null) throw new Exception("Incorrect current password changed the password.");
                                Find<TextBox>(page, "txtCurrentPassword").Text = "12345678";
                                Find<Button>(page, "btnPasswordSave").PerformClick();
                                if (AuthService.Login(role + "@northstar.vn", "Newpass123", role).User == null) throw new Exception("Password did not change.");
                                AuthService.ChangePassword(AppSession.User, "Newpass123", "12345678", "12345678");
                            }
                            if (key == "attendance")
                            {
                                Find<Button>(page, "btnResults").PerformClick();
                                Capture(main, role + "-scores");
                                var grid = Find<DataGridView>(page, "dgvScores");
                                if (role == "admin" && grid.Rows.Count > 0)
                                {
                                    grid.CurrentCell = grid.Rows[0].Cells[2];
                                    grid.BeginEdit(true);
                                    ((TextBox)grid.EditingControl).Text = "11";
                                    Find<Button>(page, "btnSave").PerformClick();
                                    if (!grid.IsCurrentCellInEditMode) throw new Exception("Invalid score was not blocked by the save button.");
                                    grid.CancelEdit();
                                    grid.BeginEdit(true);
                                    ((TextBox)grid.EditingControl).Text = "7,5";
                                    if (!grid.EndEdit()) throw new Exception("Valid score rejected by the UI.");
                                    var model = (EnglishCenterManagement.Models.ScoreRow)grid.Rows[0].Tag;
                                    Find<Button>(page, "btnSave").PerformClick();
                                    if (ScoreService.Roster(((EnglishCenterManagement.Models.ClassInfo)Find<ComboBox>(page, "cboClass").SelectedItem).Id)
                                        .First(r => r.StudentId == model.StudentId).Midterm != 7.5) throw new Exception("Score did not persist from the UI.");
                                }
                                Find<Button>(page, "btnAttendance").PerformClick();
                            }
                            if (role == "admin" && key == "students")
                            {
                                var search = Find<TextBox>(page, "txtSearch");
                                search.Text = "NoMatch-783489";
                                if (Find<DataGridView>(page, "dgvStudents").Rows.Count != 0) throw new Exception("Search did not filter rows.");
                                search.Clear();
                                if (Find<DataGridView>(page, "dgvStudents").Rows.Count == 0) throw new Exception("Search did not restore rows.");
                            }
                        });
                    }
                    main.Close();
                    Pump();
                }
                AppSession.User = AuthService.Login("admin@northstar.vn", "12345678", "admin").User;
                Check("student modal validates and saves input", () =>
                {
                    using var form = new FormStudentEdit();
                    form.Show();
                    Find<TextBox>(form, "txtName").Text = "UI Kiểm Thử";
                    Find<TextBox>(form, "txtPhone").Text = "0900000029";
                    Find<TextBox>(form, "txtBirth").Text = "31/02/2000";
                    Find<Button>(form, "btnSave").PerformClick();
                    if (StudentService.List("UI Kiểm Thử").Count != 0) throw new Exception("Invalid birth date accepted.");
                    Find<TextBox>(form, "txtBirth").Text = "01/02/2000";
                    Find<Button>(form, "btnSave").PerformClick();
                    if (StudentService.List("UI Kiểm Thử").Count != 1) throw new Exception("Student form did not save.");
                    form.Close();
                    using var edit = new FormStudentEdit(StudentService.List("UI Kiểm Thử")[0].Id);
                    edit.Show();
                    if (Find<TextBox>(edit, "txtBirth").Text != "01/02/2000") throw new Exception("Birth date did not reload.");
                    Find<TextBox>(edit, "txtPhone").Text = "0900000030";
                    Find<Button>(edit, "btnSave").PerformClick();
                    if (StudentService.List("UI Kiểm Thử")[0].Phone != "0900000030") throw new Exception("Student edit did not persist.");
                    edit.Close();
                });
                foreach (var type in typeof(FormMain).Assembly.GetTypes().Where(t => t.Namespace == "EnglishCenterManagement.Forms" && t.IsSubclassOf(typeof(Form)) && t.Name.EndsWith("Edit")))
                {
                    Check(type.Name + " designer and initial data", () =>
                    {
                        using var form = (Form)Activator.CreateInstance(type)!;
                        form.Show();
                        Capture(form, type.Name);
                        form.Close();
                    });
                }
                Check("registration modal shown", () =>
                {
                    var type = typeof(FormMain).Assembly.GetType("EnglishCenterManagement.Forms.FormRegistration")!;
                    using var form = (Form)Activator.CreateInstance(type)!;
                    form.Show();
                    Capture(form, "registration-modal");
                    form.Close();
                });
                Check("student detail shown", () =>
                {
                    var type = typeof(FormMain).Assembly.GetType("EnglishCenterManagement.Forms.FormStudentDetail")!;
                    using var form = (Form)Activator.CreateInstance(type, StudentService.List()[0].Id)!;
                    form.Show();
                    Capture(form, "student-detail");
                    form.Close();
                });
                Check("course modal creates and updates a course", () =>
                {
                    using var form = new FormCourseEdit();
                    form.Show();
                    Find<TextBox>(form, "txtName").Text = "Khóa học UI";
                    Find<TextBox>(form, "txtCode").Text = "UI-TEST";
                    Find<ComboBox>(form, "cboDuration").SelectedIndex = 1;
                    Find<TextBox>(form, "txtFee").Text = "1.500.000";
                    Find<Button>(form, "btnSave").PerformClick();
                    var course = CourseService.List().Single(c => c.Code == "UI-TEST");
                    if (course.Weeks != 10 || course.Sessions != 30 || course.Fee != 1500000) throw new Exception("Course form did not save its inputs.");
                    form.Close();
                    using var edit = new FormCourseEdit(course.Id);
                    edit.Show();
                    Find<TextBox>(edit, "txtFee").Text = "2.000.000";
                    Find<Button>(edit, "btnSave").PerformClick();
                    if (CourseService.List().Single(c => c.Id == course.Id).Fee != 2000000) throw new Exception("Course edit did not save.");
                    edit.Close();
                });
                Check("teacher modal creates a teacher", () =>
                {
                    using var form = new FormTeacherEdit();
                    form.Show();
                    Find<TextBox>(form, "txtName").Text = "Giảng viên UI";
                    Find<TextBox>(form, "txtPhone").Text = "0900000077";
                    Find<TextBox>(form, "txtEmail").Text = "ui-test@example.com";
                    Find<Button>(form, "btnSave").PerformClick();
                    if (TeacherService.List("Giảng viên UI").Count != 1) throw new Exception("Teacher form did not save.");
                    form.Close();
                });
                Check("class modal opens a class from a course", () =>
                {
                    using var form = new FormClassEdit();
                    form.Show();
                    var combo = Find<ComboBox>(form, "cboCourse");
                    combo.SelectedItem = combo.Items.Cast<EnglishCenterManagement.Models.Course>().Single(c => c.Code == "UI-TEST");
                    Find<TextBox>(form, "txtName").Text = "Lớp học UI";
                    Find<Button>(form, "btnSave").PerformClick();
                    var cls = ClassService.List("Lớp học UI").Single();
                    if (cls.CourseName != "Khóa học UI") throw new Exception("Class is not linked to its chosen course.");
                    form.Close();
                });
                Check("registration modal applies group discount and three installments", () =>
                {
                    using var form = new FormRegistration();
                    form.Show();
                    var studentCombo = Find<ComboBox>(form, "cboStudent");
                    studentCombo.SelectedItem = studentCombo.Items.Cast<EnglishCenterManagement.Models.Student>().Single(s => s.FullName == "UI Kiểm Thử");
                    var classCombo = Find<ComboBox>(form, "cboClass");
                    classCombo.SelectedItem = classCombo.Items.Cast<EnglishCenterManagement.Models.ClassInfo>().Single(c => c.Name == "Lớp học UI");
                    Find<ComboBox>(form, "cboPolicy").SelectedIndex = 2;
                    Find<ComboBox>(form, "cboPlan").SelectedIndex = 2;
                    Find<Button>(form, "btnSave").PerformClick();
                    if (form.EnrollmentId == 0) throw new Exception("Registration did not save.");
                    var enrollment = EnrollmentService.List(enrollmentId: form.EnrollmentId).Single();
                    if (enrollment.FinalFee != 1800000 || enrollment.Installments != 3 || EnrollmentService.Payments(enrollment.Id).Count != 3)
                        throw new Exception("Discount or payment plan did not persist.");
                    form.Close();
                    using var duplicate = new FormRegistration();
                    duplicate.Show();
                    studentCombo = Find<ComboBox>(duplicate, "cboStudent");
                    studentCombo.SelectedItem = studentCombo.Items.Cast<EnglishCenterManagement.Models.Student>().Single(s => s.FullName == "UI Kiểm Thử");
                    classCombo = Find<ComboBox>(duplicate, "cboClass");
                    classCombo.SelectedItem = classCombo.Items.Cast<EnglishCenterManagement.Models.ClassInfo>().Single(c => c.Name == "Lớp học UI");
                    Find<Button>(duplicate, "btnSave").PerformClick();
                    if (duplicate.EnrollmentId != 0) throw new Exception("Duplicate registration accepted.");
                    duplicate.Close();
                });
                Check("schedule modal saves a free slot and rejects conflicts", () =>
                {
                    var date = DateTime.Today.AddDays(30);
                    while (date.DayOfWeek == DayOfWeek.Sunday) date = date.AddDays(1);
                    using var form = new FormScheduleEdit();
                    form.Show();
                    var combo = Find<ComboBox>(form, "cboClass");
                    combo.SelectedItem = combo.Items.Cast<EnglishCenterManagement.Models.ClassInfo>().Single(c => c.Name == "Lớp học UI");
                    Find<DateTimePicker>(form, "dtpDate").Value = date;
                    Find<ComboBox>(form, "cboSlot").SelectedIndex = 4;
                    Find<Button>(form, "btnSave").PerformClick();
                    long classId = ClassService.List("Lớp học UI").Single().Id;
                    if (ScheduleService.OfClass(classId).Count != 1) throw new Exception("Schedule did not save.");
                    form.Close();
                    using var conflict = new FormScheduleEdit();
                    conflict.Show();
                    combo = Find<ComboBox>(conflict, "cboClass");
                    combo.SelectedItem = combo.Items.Cast<EnglishCenterManagement.Models.ClassInfo>().Single(c => c.Id == classId);
                    Find<DateTimePicker>(conflict, "dtpDate").Value = date;
                    Find<ComboBox>(conflict, "cboSlot").SelectedIndex = 4;
                    Find<Button>(conflict, "btnSave").PerformClick();
                    if (conflict.DialogResult == DialogResult.OK || ScheduleService.OfClass(classId).Count != 1) throw new Exception("Conflicting schedule accepted.");
                    Capture(conflict, "schedule-conflict");
                    conflict.Close();
                });
                void CheckPrint(string name, Action show)
                {
                    Exception error = null;
                    bool seen = false;
                    EventHandler idle = null;
                    idle = (_, _) =>
                    {
                        var dialog = Application.OpenForms.OfType<PrintPreviewDialog>().FirstOrDefault();
                        if (dialog == null) return;
                        Application.Idle -= idle;
                        seen = true;
                        try
                        {
                            var controller = new System.Drawing.Printing.PreviewPrintController();
                            dialog.Document.PrintController = controller;
                            dialog.Document.Print();
                            var pages = controller.GetPreviewPageInfo();
                            if (pages.Length != 1) throw new Exception("Expected one printable page.");
                            using var rendered = new Bitmap(pages[0].Image.Width, pages[0].Image.Height);
                            using (var graphics = Graphics.FromImage(rendered))
                            {
                                graphics.Clear(Color.White);
                                graphics.DrawImage(pages[0].Image, new Rectangle(Point.Empty, rendered.Size));
                            }
                            rendered.Save(Path.Combine(folder, name + ".png"), ImageFormat.Png);
                            foreach (var preview in pages) preview.Image.Dispose();
                            Capture(dialog, name + "-dialog");
                        }
                        catch (Exception ex) { error = ex; }
                        finally { dialog.Close(); }
                    };
                    Application.Idle += idle;
                    try { show(); }
                    finally { Application.Idle -= idle; }
                    if (!seen) throw new Exception("Print preview did not open.");
                    if (error != null) throw error;
                }
                Check("receipt print preview renders without physical printing", () =>
                {
                    var enrollment = EnrollmentService.List().First(en => EnrollmentService.Payments(en.Id).Any(p => p.IsPaid));
                    var payment = EnrollmentService.Payments(enrollment.Id).First(p => p.IsPaid);
                    CheckPrint("receipt-preview", () => EnglishCenterManagement.UI.Printing.Receipt(enrollment, payment));
                });
                Check("certificate print preview renders without physical printing", () =>
                {
                    var score = ClassService.List().SelectMany(c => ScoreService.Roster(c.Id)).First(s => s.Passed);
                    CheckPrint("certificate-preview", () => EnglishCenterManagement.UI.Printing.Certificate(score));
                });
                foreach (Form form in Application.OpenForms.Cast<Form>().ToArray()) form.Close();
                Pump();
                Console.WriteLine("Screenshots: " + folder);
            }
            catch (Exception ex)
            {
                failures++;
                Console.WriteLine("FAIL UI test runner: " + ex);
            }
        });
        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
        thread.Join();
        Console.WriteLine(failures == 0 ? "ALL UI CHECKS PASSED" : $"{failures} UI CHECKS FAILED");
        return failures;
    }

    private static T Find<T>(Control root, string name) where T : Control =>
        Walk(root).OfType<T>().First(c => c.Name == name);

    private static IEnumerable<Control> Walk(Control root)
    {
        foreach (Control child in root.Controls)
        {
            yield return child;
            foreach (Control descendant in Walk(child)) yield return descendant;
        }
    }

    private static void Pump()
    {
        var stopwatch = Stopwatch.StartNew();
        do { Application.DoEvents(); } while (stopwatch.ElapsedMilliseconds < 120);
    }
}
