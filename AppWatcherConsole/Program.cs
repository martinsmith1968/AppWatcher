using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using AppWatcherConsole.Configuration;

namespace AppWatcherConsole
{
    internal class Program
    {
        private static void Log(string text)
        {
            Console.Out.WriteLine($"{DateTime.UtcNow:HH:mm:ss}: {text}");
        }

        private static void Main(string[] args)
        {
            var appSettings = new AppSettings();

            var applications = appSettings.Applications;

            var token = new CancellationTokenSource().Token;

            Monitor(token, appSettings, applications);
        }

        private static void Monitor(CancellationToken token, AppSettings appSettings, IList<ApplicationDetails> applications)
        {
            while (!token.IsCancellationRequested)
            {
                foreach (var application in applications)
                {
                    Log($"Checking: {application.ProcessId} - {application.FileName} {application.Arguments}");
                    if (!IsAppRunning(application))
                    {
                        Log($"Starting: {application.FileName} {application.Arguments}");
                        var processId = StartApplication(application);
                        Log($"Started: {processId}");
                        application.ProcessId = processId;
                    }

                    if (token.IsCancellationRequested)
                        break;
                }

                Log($"Sleeping: {appSettings.WakeUpTimeout.TotalSeconds} seconds");
                Thread.Sleep(appSettings.WakeUpTimeout);
            }
        }

        private static int StartApplication(ApplicationDetails application)
        {
            var startInfo = new ProcessStartInfo(application.FileName, application.Arguments);

            var process = Process.Start(startInfo);

            return process?.Id ?? default;
        }

        private static bool IsAppRunning(ApplicationDetails application)
        {
            if (application.ProcessId == default)
                return false;

            var currentProcess = Process.GetProcessById(application.ProcessId);

            if (currentProcess.HasExited)
                return false;

            var canAccessStartInfo = CanAccessStartInfo(currentProcess);
            if (canAccessStartInfo)
            {
                if (currentProcess.StartInfo.FileName != application.FileName)
                    return false;
                if (currentProcess.StartInfo.Arguments != application.Arguments)
                    return false;
            }

            return true;
        }

        private static bool CanAccessStartInfo(Process currentProcess)
        {
            var canAccessStartInfo = true;
            try
            {
                var _ = currentProcess.StartInfo;
            }
            catch (InvalidOperationException)
            {
                canAccessStartInfo = false;
            }

            return canAccessStartInfo;
        }
    }
}
