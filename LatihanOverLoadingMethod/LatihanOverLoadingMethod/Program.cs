using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverLoadingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers number = new Numbers();

            Console.WriteLine("Minimum #1 : {0}", number.FindMinimum(30, 41));
            Console.WriteLine("Minimum #2 : {0}", number.FindMinimum(63, 52, 74));
            Console.WriteLine();
            Console.WriteLine("Maximum #1 : {0}", number.FindMaximum(53, 31));
            Console.WriteLine("Maximum #2 : {0}", number.FindMaximum(83, 22, 94));

            Console.ReadKey();
        }
    }
}
