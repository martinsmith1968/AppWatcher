using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWatcherWin
{
    public class ApplicationContext : System.Windows.Forms.ApplicationContext
    {
        private readonly NotifyIcon _trayIcon;
        private readonly CancellationTokenSource _tokenSource = new CancellationTokenSource();
        private Task? _watcherTask;

        public ApplicationContext()
        {
            var trayContextMenuItems = new ToolStripItem[]
            {
                new ToolStripMenuItem("Configure...", Resources.ExitImage, ConfigureClick),
                new ToolStripSeparator(),
                new ToolStripMenuItem("Exit", Resources.ExitImage, ExitClick)
            };

            _trayIcon = new NotifyIcon()
            {
                Icon = Icon.FromHandle(Resources.ApplicationImage.GetHicon()),
                ContextMenuStrip = new ContextMenuStrip()
            };

            trayContextMenuItems
                .ToList()
                .ForEach(x => _trayIcon.ContextMenuStrip.Items.Add(x));

            _trayIcon.Visible = true;

            StartWatcherTask();
        }

        private void StartWatcherTask()
        {
            if (_watcherTask != null)
                _tokenSource.Cancel();

            _watcherTask = Task.Run(
                () => Watcher.Monitor(_tokenSource.Token, Program.AppSettings, Program.AppSettings.Applications)
            );
        }

        private void ConfigureClick(object? sender, EventArgs e)
        {
            using var frm = new ConfigurationForm();

            if (frm.ShowDialog() == DialogResult.OK)
                StartWatcherTask();
        }

        private void ExitClick(object? sender, EventArgs e)
        {
            _tokenSource.Cancel();
            _trayIcon.Visible = false;
            Application.Exit();
        }
    }
}
