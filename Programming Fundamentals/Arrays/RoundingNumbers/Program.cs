using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i] + " => {0}", nums[i] % 1 >= 0.5 ? nums[i] + (1 - nums[i] % 1)
                    : Math.Round(nums[i]));
            }
        }
    }
}
