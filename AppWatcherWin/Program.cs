using System;
using System.Windows.Forms;
using AppWatcherWin.Configuration;

namespace AppWatcherWin
{
    internal static class Program
    {
        internal static AppSettings AppSettings = new AppSettings();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            LoadSettings();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ApplicationContext());
        }

        private static void LoadSettings()
        {
            AppSettings.Load();
        }
    }
}
