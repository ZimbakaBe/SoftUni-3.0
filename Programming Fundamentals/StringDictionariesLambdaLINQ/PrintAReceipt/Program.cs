using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Console.WriteLine("/" + new string('-', 22) + "\\");

            double sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("| {0,20:f2} |", nums[i]);
                sum += Math.Round(nums[i],2);
            }

            Console.WriteLine("|" + new string('-', 22) + "|");
            Console.WriteLine("| Total: {0,13:f2} |", sum);
            Console.WriteLine("\\" + new string('-', 22) + "/");


        }
    }
}
