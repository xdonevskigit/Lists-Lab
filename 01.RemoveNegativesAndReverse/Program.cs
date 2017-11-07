using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            List<String> items = values.Split(' ').ToList();
            List<int> nums = new List<int>();



            int n = 0;
            for (int i = 0; i < items.Count; i++)
            {
                n = int.Parse(items[i]);
                if (n > 0)
                {
                    nums.Add(int.Parse(items[i]));
                }               
            }
            nums.Reverse();
            if (nums.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }
            
            Console.WriteLine(String.Join(" ",nums ));
                
        }
    }
}
