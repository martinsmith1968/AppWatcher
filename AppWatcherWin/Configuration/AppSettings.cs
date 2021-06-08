using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using AppWatcherWin.Converters;

namespace AppWatcherWin.Configuration
{
    public class AppSettingsSavedArgs : EventArgs
    {
        public AppSettings AppSettings { get; }

        public AppSettingsSavedArgs(AppSettings appSettings)
        {
            AppSettings = appSettings;
        }
    }

    public class AppSettings
    {
        public TimeSpan WakeUpTimeout { get; set; } = TimeSpan.FromSeconds(30);

        public IList<ApplicationDetails> Applications = new List<ApplicationDetails>();

        public event EventHandler<AppSettingsSavedArgs> OnSaved = null!;

        public AppSettings()
        {
            //Applications.Add(new AppDetails()
            //{
            //    FileName = "notepad.exe",
            //    Arguments = "C:\\Data\\1.json"
            //});

            //Applications.Add(
            //    new ApplicationDetails("Active Desktop","C:\\Program Files\\VideoLAN\\VLC\\vlc.exe")
            //    {
            //        Arguments = "\"C:\\Utils\\Videos\\WhiteNoise.mp4\" --loop --no-audio --video-x=0 --video-y=0"
            //    }
            //);
        }

        public void Load()
        {
            if (Properties.Settings.Default.App_IsUpgraded)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.App_IsUpgraded = false;
            }

            WakeUpTimeout = Properties.Settings.Default.Monitor_WakeUpTimeout;

            Applications.Clear();
            if (Properties.Settings.Default?.Monitor_ApplicationDetails != null)
            {
                foreach (var applicationDetail in Properties.Settings.Default.Monitor_ApplicationDetails)
                {
                    Applications.Add(JsonSerializationConverter.FromJson(applicationDetail));
                }
            }
        }

        public void Save()
        {
            Properties.Settings.Default.Monitor_WakeUpTimeout = WakeUpTimeout;

            var appDetails = Applications
                .Select(JsonSerializationConverter.ToJson)
                .ToArray();
            Properties.Settings.Default.Monitor_ApplicationDetails = new StringCollection();
            Properties.Settings.Default.Monitor_ApplicationDetails.AddRange(appDetails);

            Properties.Settings.Default.Save();

            var args = new AppSettingsSavedArgs(this);
            OnSaved?.Invoke(this, args);
        }
    }
}
