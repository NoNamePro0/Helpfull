using Helpfull.Exeption;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Helpfull
{
    public class Exec
    {
        /// <summary>
        /// Execute a Command on the Linux Bash.
        /// </summary>
        /// <param name="command">The Command witch will be executed.</param>
        /// <returns>The String, that the Command returns.</returns>
        public static string Bash(string command)
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) { throw new IsNotLinuxExeption(); }

            var escapedArgs = command.Replace("\"", "\\\"");
            var process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "/bin/bash",
                    Arguments = $"-c \"{escapedArgs}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };
            process.Start();
            string result = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return result;
        }
    }
}
