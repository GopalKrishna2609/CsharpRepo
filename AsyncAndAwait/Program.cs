using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Task1();
            Task2();
            Console.ReadKey();

        }
            public static async Task Task1()
            {
                await Task.Run(() =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(" Task1 1");
                        // Do something
                        Task.Delay(100).Wait();
                    }
                });
            }


            public static void Task2()
            {
                for (int i = 0; i < 8; i++)
                {
                    Console.WriteLine(" Task2 2");
                    // Do something
                    Task.Delay(10).Wait();
                }
            }
        }
    }
    

