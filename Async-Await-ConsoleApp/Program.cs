using System.Diagnostics;
using System;

namespace Async_Await_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleUi.DashLine();
            Console.WriteLine("Choose Operation below (Press 1 or 2 and Press Enter Key.)");
            Console.WriteLine("1.Synchronous Operation.");
            Console.WriteLine("2.Asynchronous Operation.");
            Console.WriteLine("3.Await Operation.");
            ConsoleUi.DashLine();

            Console.WriteLine("Choice: ");
            int input = Convert.ToInt32(Console.ReadLine());
            ConsoleUi.DashLine();

            try
            {
                Stopwatch sw = Stopwatch.StartNew();
                if (input == 1)
                {
                    SynchronousProcessor.Start(sw);
                }
                else if (input == 2)
                {
                    AsynchronousProcessor.Start(sw);
                }
                else if (input == 3)
                {
                    AwaitOperator.Start();
                }
                else
                {
                    ConsoleUi.Error("Wrong Choice!!");
                }
            }
            catch (Exception ex)
            {
                ConsoleUi.Error(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
