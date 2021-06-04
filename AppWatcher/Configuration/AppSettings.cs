using System;
using System.Collections.Generic;

namespace AppWatcher.Configuration
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

            Applications.Add(new ApplicationDetails()
            {
                FileName = "C:\\Program Files\\VideoLAN\\VLC\\vlc.exe",
                Arguments = "\"C:\\Utils\\Videos\\WhiteNoise.mp4\" --loop --no-audio --video-x=0 --video-y=0"
            });
        }
    }
}
