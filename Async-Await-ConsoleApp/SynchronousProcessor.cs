using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Await_ConsoleApp
{
    public class SynchronousProcessor
    {
        public static void Start(Stopwatch sw)
        {
            Console.WriteLine("Started Tasks Synchronously!!");
            string clothes = WashingClothes();
            DryClothes(clothes);
            CleanHouse();
            CookFood();

            TasksCompleted(sw);

            ConsoleUi.DashLine();
            Console.WriteLine("Press any key to exit.");
        }

        public static string WashingClothes()
        {
            Console.WriteLine("-Started Washing Clothes...");
            Task.Delay(2000).Wait();
            Console.WriteLine("*Completed Washing Clothes.");
            string clothes = "Wet Clothes.";
            return clothes;
        }

        private static void DryClothes(string clothes)
        {
            Console.WriteLine("-Started Drying Clothes...");
            Task.Delay(4000).Wait();
            Console.WriteLine("*Completed Drying Clothes.");
        }

        private static void CleanHouse()
        {
            Console.WriteLine("-Started Cleaning House...");
            Task.Delay(1000).Wait();
            Console.WriteLine("*Completed Cleaning House.");
        }

        private static void CookFood()
        {
            Console.WriteLine("-Started Cooking Food...");
            Task.Delay(2000).Wait();
            Console.WriteLine("*Completed Cooking Food.");
        }

        private static void TasksCompleted(Stopwatch sw)
        {
            ConsoleUi.WriteSuccess("All tasks completed!!");
            sw.Stop();
            Console.WriteLine($"Execution Time: {Convert.ToInt32(sw.Elapsed.TotalSeconds)} seconds.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
