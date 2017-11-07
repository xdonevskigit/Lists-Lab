﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split('|').ToList();
            items.Reverse();

            List<string> result = new List<string>();
            
            foreach (var item in items)
            {
               List<string> nums = item.Split(new char[] { ' ' } ,
                   StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(nums);
              
            }
             Console.WriteLine(String.Join(" ",result));
        }
    }
}
