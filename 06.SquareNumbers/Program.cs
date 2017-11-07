using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = new List<int>();
            foreach (var num in list)
            {
                if (Math.Sqrt(num) == Math.Floor(Math.Sqrt(num)))
                {
                    result.Add(num);
                }
            }
            result.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(String.Join(" ", result));
        }

       
    }
}
