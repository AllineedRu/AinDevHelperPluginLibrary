using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

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

        //public static void RunCmdCommand(string arguments, DataReceivedEventHandler outputDataReceived, DataReceivedEventHandler errorDataReceived) {
        //    ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd", arguments);
                       
        //    processStartInfo.RedirectStandardOutput = true;
        //    processStartInfo.RedirectStandardError = true;
        //    processStartInfo.UseShellExecute = false;
        //    processStartInfo.CreateNoWindow = true;
        //    processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;

        //    Process process = new Process();
        //    process.StartInfo = processStartInfo;

        //    process.EnableRaisingEvents = true;
        //    process.OutputDataReceived += outputDataReceived; //new DataReceivedEventHandler(Process_OutputDataReceived);
        //    process.ErrorDataReceived += errorDataReceived;// new DataReceivedEventHandler(Process_ErrorDataReceived);

        //    //process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        //    //process.StartInfo.FileName = "java.exe";
        //    //process.StartInfo.Arguments = "-version";
        //    //process.StartInfo.Arguments = "/C " + command;
        //    //process.StartInfo.UseShellExecute = false;
        //    //process.StartInfo.CreateNoWindow = true;
        //    //process.StartInfo.RedirectStandardOutput = true;            
        //    //process.StartInfo.RedirectStandardInput = true;

            
        //    //process.OutputDataReceived += Process_OutputDataReceived;

        //    Console.WriteLine("!!! Запускаю процесс...: " + process.ToString());
        //    process.Start();
        //    process.BeginOutputReadLine();
        //    process.BeginErrorReadLine();

        //    //Console.WriteLine("После process.Start()!");


        //    //Console.WriteLine("Ждём 4 секунды.");
        //    //Thread.Sleep(4000);
        //    //Console.WriteLine("Считываю: string output = process.StandardOutput.ReadToEnd()");

        //    //process.StandardOutput.BaseStream.
        //    //string output = process.StandardOutput.ReadToEnd();



        //    //process.BeginOutputReadLine();
        //    //Console.WriteLine("output = ");
        //    // Console.WriteLine(output);
        //    //process.StandardInput.WriteLine("java -version");
        //    //process.StandardInput.Flush();
        //    //process.StandardInput.Close();

        //    //string output = "";
        //    //while (!process.HasExited) {
        //    //Console.WriteLine("пока !process.HasExited: ");
        //    //output += process.StandardOutput.ReadToEnd();
        //    //Console.WriteLine("output: " + output);
        //    //process.StandardOutput.Close();
        //    ///process.StandardInput.WriteLine(command);
        //    ///process.StandardInput.Flush();
        //    ///process.StandardInput.Close();

        //    //Console.WriteLine("Жду завершения процесса...");
        //    process.WaitForExit();
        //    //Console.WriteLine("Завершено.");
        //    //StringBuilder sbOutput = new StringBuilder();


        //    //}




        //    //Console.WriteLine("Возврат из метода output: " + output);
        //    //return sbOutput.ToString();
        //    //return output;
        //    //return processOutputData;
        //}
        //static void Process_ErrorDataReceived(object sender, DataReceivedEventArgs e) {
        //    processOutputData = e.Data;
        //}
        //static void Process_OutputDataReceived(object sender, DataReceivedEventArgs e) {
        //    processOutputData = e.Data;
        //}

        //private static void Process_OutputDataReceived(object sender, DataReceivedEventArgs e) {
        //    Console.WriteLine("Called Process_OutputDataReceived!");
        //    Console.WriteLine("e.Data = " + e.Data);
        //    data += e.Data;
        //}

        //public static string GetProgramVersion(string currentStartupPath, string programName, string args, bool useShellExecute) {
        //    try {
        //        var proc = new Process {
        //            StartInfo = {
        //                FileName = programName,
        //                WorkingDirectory = currentStartupPath,
        //                Arguments = args,
        //                UseShellExecute = useShellExecute,
        //                RedirectStandardOutput = true,
        //                CreateNoWindow = true
        //            }
        //        };

        //        proc.Start();

        //        StringBuilder sbOutput = new StringBuilder();
        //        sbOutput.Append(proc.StandardOutput.ReadToEnd());
        //        proc.WaitForExit();
        //        //while (!proc.StandardOutput.EndOfStream) {
        //        //    sbOutput.Append(proc.StandardOutput.ReadLine());                    
        //        //}
        //        return sbOutput.ToString();
        //    } catch (Exception e) {
        //        return "Ошибка: " + e.Message;
        //    }
        //}
    }
}
