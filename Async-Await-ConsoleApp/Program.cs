﻿using Async_Await_ConsoleApp;
using System.Diagnostics;

namespace Async_Await_ConsoleApp
{
    public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose Operation below (Press 1 or 2 and Press Enter Key.)");
            Console.WriteLine("1.Synchronous Operation.");
            Console.WriteLine("2.Asynchronous Operation.");
            Console.WriteLine("---------------------------------------------------------");
            int input = Convert.ToInt32(Console.ReadLine());

            Stopwatch sw = Stopwatch.StartNew();
            if (input == 1)
            {
                SynchronousProcessor.Start();
            }
            else if (input == 2) 
            {
                AsynchronousProcessor.Start();
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Choice!!");
                Console.ForegroundColor= ConsoleColor.White;
            }

            TasksCompleted(sw);
            
        }


        private static void TasksCompleted(Stopwatch sw)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**All tasks completed!!");
            sw.Stop();
            Console.WriteLine($"Execution Time: {sw.Elapsed.TotalMilliseconds} milliseconds.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

