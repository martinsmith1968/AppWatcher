using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace AppWatcher.Configuration
{
    public class ApplicationDetails
    {
        public int ProcessId { get; set; }

        public string? DisplayName { get; set; }

        public string? FileName { get; set; }

        public string? Arguments { get; set; }

        public string? WorkingDirectory { get; set; }

        public bool CreateNoWindow { get; set; }

        public bool UseShellExecute { get; set; }

        public ProcessWindowStyle WindowStyle { get; set; }

        public string? Verb { get; set; }

        public string GetHash()
        {
            var json = JsonSerializer.Serialize(this);
            var jsonBytes = Encoding.UTF8.GetBytes(json);

            using var hashAlgorithm = new SHA1Managed();
            var sha1Bytes = hashAlgorithm.ComputeHash(jsonBytes);
            var sha1Text = Convert.ToBase64String(sha1Bytes);

            return sha1Text;
        }
    }
}
