using EnglishCenterManagement.Data;
using EnglishCenterManagement.Forms;
using EnglishCenterManagement.Models;
using EnglishCenterManagement.Services;

namespace EnglishCenterManagement;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Db.Init();

        while (true)
        {
            string role;
            using (var portal = new FormPortal())
            {
                if (portal.ShowDialog() != DialogResult.OK) return;
                role = portal.SelectedRole;
            }

            DialogResult result;
            AppUser user;
            using (var login = new FormLogin(role))
            {
                result = login.ShowDialog();
                user = login.User;
            }
            if (result == DialogResult.Retry) continue;
            if (result != DialogResult.OK) return;

            AppSession.User = user;
            using var main = new FormMain();
            main.ShowDialog();
            if (!main.LoggedOut) return;
        }
    }
}
