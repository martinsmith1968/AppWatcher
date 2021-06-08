using System.Diagnostics;
using AppWatcherWin.Configuration;

namespace AppWatcherWin.Converters
{
    public class ProcessStartInfoConverter
    {
        public static ProcessStartInfo GetStartInfo(ApplicationDetails applicationDetails)
        {
            return new ProcessStartInfo(applicationDetails.FileName, applicationDetails.Arguments)
            {
                WorkingDirectory = applicationDetails.WorkingDirectory,
                CreateNoWindow   = applicationDetails.CreateNoWindow,
                UseShellExecute  = applicationDetails.UseShellExecute,
                Verb             = applicationDetails.Verb,
                WindowStyle      = applicationDetails.WindowStyle
            };
        }

    }
}
