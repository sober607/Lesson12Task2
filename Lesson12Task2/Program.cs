using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[1500000];

            Random rnd = new Random();
            Parallel.For(0, arr.Length, (i) => arr[i] = rnd.Next(1000));

            //for (int a = 0; a<10000; a++)
            //{ 
            //    Console.WriteLine($"Значение элемента №{a} - {arr[a]}");
            //}

            ParallelQuery<int> even = from element in arr.AsParallel()
                                      where element % 2 != 0
                                      select element;

            //for (int f = 0; f < 20; f++)
            //{
            //    Console.WriteLine($"Значение элемента №{f} - {even.ToList<int>()[f]}");
            //}

            
            Console.WriteLine("Операция готова");
            Console.ReadLine();
        }

        
        
    }
}
