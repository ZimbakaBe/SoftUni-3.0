using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;

            foreach (var num in arr)
            {
                sum += num;
            }

            double average = (double)sum / arr.Length;
            List<int> topFive = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > average)
                {
                    topFive.Add(arr[i]);
                }
            }

            topFive = (from num in topFive
                       orderby num descending
                       select num).Take(5).ToList();

            if(topFive.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var num in topFive)
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
