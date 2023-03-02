using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Diagnostics;
using System.ComponentModel;
using System.IO;

namespace Demo
{
    class MyProcess
    {
        // 当找不到文件或者拒绝访问时出现的Win32错误码
        const int ERROR_FILE_NOT_FOUND = 2;
        const int ERROR_ACCESS_DENIED = 5;


        // 通过命令行获取help显示信息
        void PrintDoc()
        {
            Process process = new Process();
            try
            {
                process.StartInfo.UseShellExecute = false;   //是否使用操作系统shell启动 
                process.StartInfo.CreateNoWindow = true;   //是否在新窗口中启动该进程的值 (不显示程序窗口)
                process.StartInfo.RedirectStandardInput = true;  // 接受来自调用程序的输入信息 
                process.StartInfo.RedirectStandardOutput = true;  // 由调用程序获取输出信息
                process.StartInfo.RedirectStandardError = true;  //重定向标准错误输出
                process.StartInfo.FileName = "cmd.exe";
                process.Start();                         // 启动程序
                process.StandardInput.WriteLine("help"); //向cmd窗口发送输入信息
                process.StandardInput.AutoFlush = true;
                // 前面一个命令不管是否执行成功都执行后面(exit)命令，如果不执行exit命令，后面调用ReadToEnd()方法会假死
                process.StandardInput.WriteLine("exit");

                StreamReader reader = process.StandardOutput;//获取exe处理之后的输出信息
                string curLine = reader.ReadLine(); //获取错误信息到error
                while (!reader.EndOfStream)
                {
                    if (!string.IsNullOrEmpty(curLine))
                    {
                        Console.WriteLine(curLine);
                    }
                    curLine = reader.ReadLine();
                }
                reader.Close(); //close进程

                process.WaitForExit();  //等待程序执行完退出进程
                process.Close();

            }
            catch (Win32Exception e)
            {
                if (e.NativeErrorCode == ERROR_FILE_NOT_FOUND)
                {
                    Console.WriteLine(e.Message + ". 检查文件路径.");
                }

                else if (e.NativeErrorCode == ERROR_ACCESS_DENIED)
                {
                    Console.WriteLine(e.Message + ". 你没有权限操作文件.");
                }
            }
        }


        public static void Main()
        {
            MyProcess myProcess = new MyProcess();
            myProcess.PrintDoc();
            Console.ReadKey();
        }
    }
}