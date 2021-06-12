using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppWatcher.Configuration;
using AppWatcher.Execution;

namespace AppWatcher
{
    public class ApplicationContext : System.Windows.Forms.ApplicationContext
    {
        internal static AppSettings AppSettings = new AppSettings();

        internal static IDictionary<string, ActiveApplication> ActiveApplications = new Dictionary<string, ActiveApplication>();

        private readonly NotifyIcon _trayIcon;
        private readonly CancellationTokenSource _tokenSource = new CancellationTokenSource();
        private Task? _watcherTask;

        public ApplicationContext()
        {
            AppSettings.Load();
            AppSettings.OnSaved += AppSettingsOnOnSaved;

            var trayContextMenuItems = new ToolStripItem[]
            {
                new ToolStripMenuItem("&Configure...", Resources.ConfigurationImage, ConfigureClick),
                new ToolStripSeparator(),
                new ToolStripMenuItem("&Logs...", Resources.ConfigurationImage, LogsClick),
                new ToolStripSeparator(),
                new ToolStripMenuItem("E&xit", Resources.ExitImage, ExitClick)
            };

            _trayIcon = new NotifyIcon()
            {
                Icon = Resources.ApplicationIcon,
                ContextMenuStrip = new ContextMenuStrip()
            };

            trayContextMenuItems
                .ToList()
                .ForEach(x => _trayIcon.ContextMenuStrip.Items.Add(x));

            _trayIcon.Visible = true;
            AppSettingsOnOnSaved(this, new AppSettingsSavedArgs(AppSettings));

            StartWatcherTask();

            if (!AppSettings.Applications.Any())
            {
                ShowConfigurationForm(ConfigurationForm.TabPageIndex_Applications);
            }
        }

        private void AppSettingsOnOnSaved(object? sender, AppSettingsSavedArgs e)
        {
            _trayIcon.Text = $@"Watching {e.AppSettings.Applications.Count} applications, every {e.AppSettings.WakeUpTimeout.TotalSeconds} seconds";
        }

        private void StartWatcherTask()
        {
            if (_watcherTask != null)
                _tokenSource.Cancel();

            ReloadActiveApplications();

            _watcherTask = Task.Run(
                () => Watcher.Monitor(_tokenSource.Token, AppSettings, AppSettings.Applications)
            );
        }

        private void ReloadActiveApplications()
        {
            foreach (var applicationDetails in AppSettings.Applications)
            {

            }
        }

        private void ShowConfigurationForm(int startTabPageIndex = 0)
        {
            using var frm = new ConfigurationForm
            {
                StartTabPageIndex = startTabPageIndex
            };

            if (frm.ShowDialog() == DialogResult.OK)
                StartWatcherTask();
        }

        private void ConfigureClick(object? sender, EventArgs e)
        {
            ShowConfigurationForm();
        }

        private void LogsClick(object? sender, EventArgs e)
        {
        }

        private void ExitClick(object? sender, EventArgs e)
        {
            _tokenSource.Cancel();
            _trayIcon.Visible = false;
            Application.Exit();
        }
    }
}
