﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using AppWatcherWin.Configuration;

namespace AppWatcherWin
{
    public class Watcher
    {
        private static void Log(string text)
        {
            // TODO: Do logging properly
        }

        public static Task Monitor(CancellationToken token, AppSettings appSettings, IList<ApplicationDetails> applications)
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

            return Task.CompletedTask;
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
