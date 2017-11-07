using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> unSortedList = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int i = 0; i < unSortedList.Count; i++)
            {
                for (int j = 1; j < unSortedList.Count; j++)
                {
                    if (unSortedList[j] < unSortedList[j - 1])
                    {
                        decimal temp = unSortedList[j - 1];
                        unSortedList[j - 1] = unSortedList[j];
                        unSortedList[j] = temp;
                    }
                }
            }
           Console.WriteLine(String.Join(" <= ", unSortedList));
        }
    }
}
