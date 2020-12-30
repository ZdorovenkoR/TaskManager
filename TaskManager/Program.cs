using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

//Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и
//позволяет завершить указанный процесс. Предусмотреть возможность завершения процессов с
//помощью указания его ID или имени процесса. 

namespace TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (Process process in Process.GetProcesses())
            {
                Console.WriteLine($"ID: {process.Id} Name: {process.ProcessName}");
            }
            Console.WriteLine("Введите ID процесса который необходимо завершить");
            var idProces = Convert.ToInt32(Console.ReadLine());
            foreach (Process process in Process.GetProcesses())
            {
                if (idProces == process.Id)
                {
                    process.Kill();
                }
            }
            Console.ReadKey();
        }
    }
}
