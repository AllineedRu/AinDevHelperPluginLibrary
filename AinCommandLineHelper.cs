/*
Copyright 2024 Allineed.Ru, Max Damascus

Permission is hereby granted, free of charge, to any person obtaining a copy of this software 
and associated documentation files (the "Software"), to deal in the Software without restriction, 
including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, 
subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE 
OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
using System;
using System.Diagnostics;

namespace AinDevHelperPluginLibrary {
    /// <summary>
    /// [RU] Класс с различными вспомогательными методами для работы в командной строке и запуска процессов<br/>
    /// [EN] A class with various helper methods for working on the command line and running processes
    /// </summary>
    public class AinCommandLineHelper {
        public static string processOutputData;

        /// <summary>
        /// Создаёт процесс без отдельного окна и передаёт процессу заданные аргументы <paramref name="arguments"/>
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="arguments"></param>
        public static int RunProcessWithoutWindow(string fileName, string arguments) {
            ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName, arguments);
            processStartInfo.CreateNoWindow = true;             
            processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            Process process = new Process();
            process.StartInfo = processStartInfo;

            process.Start();
            process.WaitForExit();
            return process.ExitCode;
        }

        public static int RunProcessWithoutWindow(string workingDirectory, string fileName, string arguments) {
            ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName, arguments);
            processStartInfo.CreateNoWindow = true;
            processStartInfo.WorkingDirectory = workingDirectory;
            processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            Process process = new Process();
            process.StartInfo = processStartInfo;

            process.Start();
            process.WaitForExit();
            return process.ExitCode;
        }

        public static int RunProcessWithWindow(string workingDirectory, string fileName, string arguments) {
            try {
                ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName, arguments);
                processStartInfo.WorkingDirectory = workingDirectory;

                Process process = new Process();
                process.StartInfo = processStartInfo;

                process.Start();
                process.WaitForExit();
                return process.ExitCode;
            } catch (Exception) {
                return -1;
            }
        }

        public static int RunProcessWithWindow(string fileName, string arguments) {
            ProcessStartInfo processStartInfo = arguments != null ? new ProcessStartInfo(fileName, arguments) : new ProcessStartInfo(fileName);

            Process process = new Process();
            process.StartInfo = processStartInfo;

            process.Start();
            process.WaitForExit();
            return process.ExitCode;
        }

        public static int RunProcessWithWindow(string fileName) {
            return RunProcessWithWindow(fileName, null);
        }


        public static int RunProcessWithWindowAsAdmin(string fileName, string arguments) {
            try {
                ProcessStartInfo processStartInfo = arguments != null ? new ProcessStartInfo(fileName, arguments) : new ProcessStartInfo(fileName);
                processStartInfo.Verb = "runas";

                Process process = new Process();
                process.StartInfo = processStartInfo;

                process.Start();
                process.WaitForExit();
                return process.ExitCode;
            } catch (Exception) {
                return -1;
            }
            
        }

        public static int RunProcessWithWindowAsAdmin(string fileName) {
            return RunProcessWithWindowAsAdmin(fileName, null);
        }
    }
}
