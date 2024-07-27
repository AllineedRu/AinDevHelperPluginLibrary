/*
   Copyright 2024 Allineed.Ru, Max Damascus

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
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
