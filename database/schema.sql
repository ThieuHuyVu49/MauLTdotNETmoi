-- EduCenter · Northstar English Center — SQLite schema
-- The app creates and seeds this database automatically at bin/.../english_center.db.
-- Open that file in Navicat (Connection → SQLite → Existing Database File) to browse the data.
PRAGMA foreign_keys = ON;

CREATE TABLE IF NOT EXISTS Settings(
    Key   TEXT PRIMARY KEY,
    Value TEXT
);
CREATE TABLE IF NOT EXISTS Rooms(
    Id       INTEGER PRIMARY KEY AUTOINCREMENT,
    Name     TEXT NOT NULL UNIQUE,
    Capacity INTEGER NOT NULL DEFAULT 24
);
CREATE TABLE IF NOT EXISTS Teachers(
    Id           INTEGER PRIMARY KEY AUTOINCREMENT,
    FullName     TEXT NOT NULL,
    Phone        TEXT,
    Email        TEXT,
    Specialty    TEXT,
    Years        INTEGER NOT NULL DEFAULT 0,
    Certificates TEXT,
    Availability TEXT,
    Status       TEXT NOT NULL DEFAULT 'Đang giảng dạy'
);
CREATE TABLE IF NOT EXISTS Courses(
    Id          INTEGER PRIMARY KEY AUTOINCREMENT,
    Code        TEXT NOT NULL UNIQUE,
    Name        TEXT NOT NULL,
    Weeks       INTEGER NOT NULL,
    Sessions    INTEGER NOT NULL,
    Fee         REAL NOT NULL,
    Description TEXT,
    Status      TEXT NOT NULL DEFAULT 'Đang tuyển sinh'
);
CREATE TABLE IF NOT EXISTS Students(
    Id        INTEGER PRIMARY KEY AUTOINCREMENT,
    Code      TEXT NOT NULL UNIQUE,
    FullName  TEXT NOT NULL,
    BirthDate TEXT,
    Phone     TEXT,
    Email     TEXT,
    Address   TEXT,
    Status    TEXT NOT NULL DEFAULT 'Đang học'
);
CREATE TABLE IF NOT EXISTS Users(
    Id           INTEGER PRIMARY KEY AUTOINCREMENT,
    Email        TEXT NOT NULL UNIQUE,
    PasswordHash TEXT NOT NULL,
    FullName     TEXT NOT NULL,
    Phone        TEXT,
    Role         TEXT NOT NULL CHECK(Role IN ('admin','teacher','student')),
    TeacherId    INTEGER REFERENCES Teachers(Id),
    StudentId    INTEGER REFERENCES Students(Id)
);
CREATE TABLE IF NOT EXISTS Classes(
    Id          INTEGER PRIMARY KEY AUTOINCREMENT,
    CourseId    INTEGER NOT NULL REFERENCES Courses(Id),
    Name        TEXT NOT NULL UNIQUE,
    MaxStudents INTEGER NOT NULL DEFAULT 24,
    TeacherId   INTEGER NOT NULL REFERENCES Teachers(Id),
    RoomId      INTEGER NOT NULL REFERENCES Rooms(Id),
    Status      TEXT NOT NULL DEFAULT 'Đang học'
);
-- Each scheduled session; the app refuses overlaps on the same room or teacher.
CREATE TABLE IF NOT EXISTS Sessions(
    Id          INTEGER PRIMARY KEY AUTOINCREMENT,
    ClassId     INTEGER NOT NULL REFERENCES Classes(Id) ON DELETE CASCADE,
    SessionDate TEXT NOT NULL,
    StartTime   TEXT NOT NULL,
    EndTime     TEXT NOT NULL,
    RoomId      INTEGER NOT NULL REFERENCES Rooms(Id),
    TeacherId   INTEGER NOT NULL REFERENCES Teachers(Id)
);
-- Discounts: returning student −10%, group registration −10%.
CREATE TABLE IF NOT EXISTS Enrollments(
    Id              INTEGER PRIMARY KEY AUTOINCREMENT,
    StudentId       INTEGER NOT NULL REFERENCES Students(Id),
    ClassId         INTEGER NOT NULL REFERENCES Classes(Id),
    EnrollDate      TEXT NOT NULL,
    BaseFee         REAL NOT NULL,
    DiscountPercent REAL NOT NULL DEFAULT 0,
    FinalFee        REAL NOT NULL,
    Policy          TEXT,
    Installments    INTEGER NOT NULL DEFAULT 1,
    UNIQUE(StudentId, ClassId)
);
CREATE TABLE IF NOT EXISTS Payments(
    Id            INTEGER PRIMARY KEY AUTOINCREMENT,
    EnrollmentId  INTEGER NOT NULL REFERENCES Enrollments(Id) ON DELETE CASCADE,
    InstallmentNo INTEGER NOT NULL,
    DueDate       TEXT NOT NULL,
    Amount        REAL NOT NULL,
    PaidDate      TEXT,
    ReceiptNo     TEXT
);
-- Status: 0 = Có mặt, 1 = Vắng có phép, 2 = Vắng không phép
CREATE TABLE IF NOT EXISTS Attendance(
    Id        INTEGER PRIMARY KEY AUTOINCREMENT,
    SessionId INTEGER NOT NULL REFERENCES Sessions(Id) ON DELETE CASCADE,
    StudentId INTEGER NOT NULL REFERENCES Students(Id),
    Status    INTEGER NOT NULL DEFAULT 0,
    UNIQUE(SessionId, StudentId)
);
CREATE TABLE IF NOT EXISTS Scores(
    EnrollmentId INTEGER PRIMARY KEY REFERENCES Enrollments(Id) ON DELETE CASCADE,
    Midterm      REAL,
    Final        REAL
);
