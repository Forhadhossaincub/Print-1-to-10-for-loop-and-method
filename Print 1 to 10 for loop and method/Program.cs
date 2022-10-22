using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_1_to_10_for_loop_and_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print();


            Console.ReadKey();
        }

        public static void Print()
        {
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine($"{i}");
            }
          
        }
    }
}
