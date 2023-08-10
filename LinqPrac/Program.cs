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

            // 익명객체 실습

            var output5 = from item in input
                          where item % 2 == 0
                          select new
                          {
                              A = item * 2,
                              B = item * item,
                              C = 100
                          };
            foreach (var item in output5)
            {
                Console.WriteLine(item.A);
                Console.WriteLine(item.B);
                Console.WriteLine(item.C);
                Console.WriteLine();
            }

            List<Product> foods = new List<Product>()
            {
                new Product(){ Name="고구마", Price=1500 },
                new Product(){ Name="사과", Price=2400 },
                new Product(){ Name="바나나", Price=1000 },
                new Product(){ Name="배", Price=3000 },
                new Product(){ Name="감자", Price=1000 },
                new Product(){ Name="토마토", Price=2000 },
                new Product(){ Name="옥수수", Price=1500 },
                new Product(){ Name="자두", Price=500 },
            };

            var output6 = from food in foods
                          where food.Price > 1000
                          orderby food.Price descending
                          select food;
            foreach (var item in output6)
            {
                Console.WriteLine(item);
            }
        }
    }
}
