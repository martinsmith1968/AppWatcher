using System;
using System.Collections.Generic;
using System.Text.Json;

namespace AppWatcherWin.Configuration
{
    public class AppSettings
    {
        public TimeSpan WakeUpTimeout { get; set; } = TimeSpan.FromSeconds(30);

        public IList<ApplicationDetails> Applications = new List<ApplicationDetails>();

        public AppSettings()
        {
            //Applications.Add(new AppDetails()
            //{
            //    FileName = "notepad.exe",
            //    Arguments = "C:\\Data\\1.json"
            //});

            Applications.Add(
                new ApplicationDetails(
                    "C:\\Program Files\\VideoLAN\\VLC\\vlc.exe",
                    "\"C:\\Utils\\Videos\\WhiteNoise.mp4\" --loop --no-audio --video-x=0 --video-y=0"
                )
            );
        }

        public void Load()
        {
            if (Properties.Settings.Default.App_IsUpgraded)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.Save();
            }

            WakeUpTimeout = Properties.Settings.Default.Monitor_WakeUpTimeout;
            Applications.Clear();

            foreach (var applicationDetail in Properties.Settings.Default.Monitor_ApplicationDetails)
            {
                var appDetails = JsonSerializer.Deserialize<ApplicationDetails>(applicationDetail);
                Applications.Add(appDetails);
            }
        }

        public void Save()
        {
            // TODO:
        }
    }
}
