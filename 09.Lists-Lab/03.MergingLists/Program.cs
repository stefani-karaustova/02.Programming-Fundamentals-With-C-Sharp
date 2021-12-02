using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToList();

            List<int> secontList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < Math.Min(firstList.Count, secontList.Count); i++)
            {
                result.Add(firstList[i]);
                result.Add(secontList[i]);
            }

            for (int i = Math.Min(firstList.Count, secontList.Count); i < Math.Max(firstList.Count, secontList.Count); i++)
            {
                if (i >= firstList.Count)
                {
                    result.Add(secontList[i]);
                }
                else
                {
                    result.Add(firstList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
