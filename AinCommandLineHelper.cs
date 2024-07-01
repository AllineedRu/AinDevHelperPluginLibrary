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
    public static class AinCommandLineHelper {
        /// <summary>
        /// [RU] Создаёт процесс без отдельного окна и передаёт процессу заданные аргументы <paramref name="arguments"/><br/>
        /// [EN] Creates a process without a separate window and passes the given arguments to the process <paramref name="arguments"/>
        /// </summary>
        /// <param name="fileName">[RU] имя файла при запуске процесса;<br/>[EN] file name when process starts</param>
        /// <param name="arguments">[RU] аргументы, передаваемые при запуске процесса;<br/>[EN] arguments passed when starting a process</param>
        /// <returns>[RU] значение свойства <see cref="Process.ExitCode"/> после запуска процесса и ожидания его завершения, в случае исключения возвращает -1;<br/>[EN] the value of the <see cref="Process.ExitCode"/> property after starting the process and waiting for it to complete, returns -1 in case of an exception</returns>
        public static int RunProcessWithoutWindow(string fileName, string arguments) {
            try {
                ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName, arguments);
                processStartInfo.CreateNoWindow = true;
                processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                Process process = new Process();
                process.StartInfo = processStartInfo;

                process.Start();
                process.WaitForExit();
                return process.ExitCode;
            } catch (Exception) {
                return -1;
            }            
        }

        /// <summary>
        /// [RU] Создаёт процесс без отдельного окна и передаёт процессу заданные аргументы <paramref name="arguments"/><br/>
        /// [EN] Creates a process without a separate window and passes the given arguments to the process <paramref name="arguments"/>
        /// </summary>
        /// <param name="workingDirectory">[RU] рабочий каталог, который следует использовать при запуске процесса;<br/>[EN] the working directory to use when starting the process</param>
        /// <param name="fileName">[RU] имя файла при запуске процесса;<br/>[EN] file name when process starts</param>
        /// <param name="arguments">[RU] аргументы, передаваемые при запуске процесса;<br/>[EN] arguments passed when starting a process</param>
        /// <returns>[RU] значение свойства <see cref="Process.ExitCode"/> после запуска процесса и ожидания его завершения, в случае исключения возвращает -1;<br/>[EN] the value of the <see cref="Process.ExitCode"/> property after starting the process and waiting for it to complete, returns -1 in case of an exception</returns>
        public static int RunProcessWithoutWindow(string workingDirectory, string fileName, string arguments) {
            try {
                ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName, arguments);
                processStartInfo.CreateNoWindow = true;
                processStartInfo.WorkingDirectory = workingDirectory;
                processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                Process process = new Process();
                process.StartInfo = processStartInfo;

                process.Start();
                process.WaitForExit();
                return process.ExitCode;
            } catch (Exception) {
                return -1;
            }
            
        }

        /// <summary>
        /// [RU] Создаёт процесс в отдельном окне и передаёт процессу заданные аргументы <paramref name="arguments"/><br/>
        /// [EN] Creates a process in a separate window and passes the specified arguments to the process <paramref name="arguments"/>
        /// </summary>
        /// <param name="workingDirectory">[RU] рабочий каталог, который следует использовать при запуске процесса;<br/>[EN] the working directory to use when starting the process</param>
        /// <param name="fileName">[RU] имя файла при запуске процесса;<br/>[EN] file name when process starts</param>
        /// <param name="arguments">[RU] аргументы, передаваемые при запуске процесса;<br/>[EN] arguments passed when starting a process</param>
        /// <returns>[RU] значение свойства <see cref="Process.ExitCode"/> после запуска процесса и ожидания его завершения, в случае исключения возвращает -1;<br/>[EN] the value of the <see cref="Process.ExitCode"/> property after starting the process and waiting for it to complete, returns -1 in case of an exception</returns>
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

        /// <summary>
        /// [RU] Создаёт процесс в отдельном окне и передаёт процессу заданные аргументы <paramref name="arguments"/><br/>
        /// [EN] Creates a process in a separate window and passes the specified arguments to the process <paramref name="arguments"/>
        /// </summary>
        /// <param name="fileName">[RU] имя файла при запуске процесса;<br/>[EN] file name when process starts</param>
        /// <param name="arguments">[RU] аргументы, передаваемые при запуске процесса;<br/>[EN] arguments passed when starting a process</param>
        /// <returns>[RU] значение свойства <see cref="Process.ExitCode"/> после запуска процесса и ожидания его завершения, в случае исключения возвращает -1;<br/>[EN] the value of the <see cref="Process.ExitCode"/> property after starting the process and waiting for it to complete, returns -1 in case of an exception</returns>
        public static int RunProcessWithWindow(string fileName, string arguments) {
            try {
                ProcessStartInfo processStartInfo = arguments != null ? new ProcessStartInfo(fileName, arguments) : new ProcessStartInfo(fileName);

                Process process = new Process();
                process.StartInfo = processStartInfo;

                process.Start();
                process.WaitForExit();
                return process.ExitCode;
            } catch (Exception) {
                return -1;
            }            
        }

        /// <summary>
        /// [RU] Создаёт процесс в отдельном окне без передачи процессу аргументов<br/>
        /// [EN] Creates a process in a separate window without passing any arguments to the process
        /// </summary>
        /// <param name="fileName">[RU] имя файла при запуске процесса;<br/>[EN] file name when process starts</param>
        /// <returns>[RU] значение свойства <see cref="Process.ExitCode"/> после запуска процесса и ожидания его завершения, в случае исключения возвращает -1;<br/>[EN] the value of the <see cref="Process.ExitCode"/> property after starting the process and waiting for it to complete, returns -1 in case of an exception</returns>
        public static int RunProcessWithWindow(string fileName) {
            return RunProcessWithWindow(fileName, null);
        }

        /// <summary>
        /// [RU] Создаёт процесс в отдельном окне под Администратором и передаёт процессу заданные аргументы <paramref name="arguments"/><br/>
        /// [EN] Creates a process in a separate window under Administrator and passes the specified arguments to the process <paramref name="arguments"/><br/>
        /// </summary>
        /// <param name="fileName">[RU] имя файла при запуске процесса;<br/>[EN] file name when process starts</param>
        /// <param name="arguments">[RU] аргументы, передаваемые при запуске процесса;<br/>[EN] arguments passed when starting a process</param>
        /// <returns>[RU] значение свойства <see cref="Process.ExitCode"/> после запуска процесса и ожидания его завершения, в случае исключения возвращает -1;<br/>[EN] the value of the <see cref="Process.ExitCode"/> property after starting the process and waiting for it to complete, returns -1 in case of an exception</returns>
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

        /// <summary>
        /// [RU] Создаёт процесс в отдельном окне под Администратором без передачи процессу аргументов<br/>
        /// [EN] Creates a process in a separate window under Administrator without passing arguments to the process
        /// </summary>
        /// <param name="fileName">[RU] имя файла при запуске процесса;<br/>[EN] file name when process starts</param>
        /// <returns>[RU] значение свойства <see cref="Process.ExitCode"/> после запуска процесса и ожидания его завершения, в случае исключения возвращает -1;<br/>[EN] the value of the <see cref="Process.ExitCode"/> property after starting the process and waiting for it to complete, returns -1 in case of an exception</returns>
        public static int RunProcessWithWindowAsAdmin(string fileName) {
            return RunProcessWithWindowAsAdmin(fileName, null);
        }
    }
}
