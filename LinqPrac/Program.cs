using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Linq를 사용하지 않은 세련되지 않은 방법 

            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> output = new List<int>();

            foreach (var item in input)
            {
                if (item % 2 == 0) output.Add(item);
            }
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

            var output2 = from item in input
                          where item % 2 == 0
                          orderby item descending
                          select item;

            foreach (var item in output2)
            {
                Console.WriteLine(item);
            }

            int[] output3 = output2.ToArray();
            List<int> output4 = output2.ToList();
        }
    }
}
