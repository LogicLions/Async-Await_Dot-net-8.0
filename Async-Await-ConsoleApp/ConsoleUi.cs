using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Async_Await_ConsoleApp
{
    public class ConsoleUi
    {
        public static void Info(string message)
        {
            Console.WriteLine(message);
        }

        public static void Warn(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("**Warning**: " + message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void WriteSuccess(string message) 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"*{message}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("**Error**: " + message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void DashLine()
        {
            Console.WriteLine("---------------------------------------------------------");
        }
    }
}
