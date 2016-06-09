using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(' ');
            List<int> nums = strings.Select(int.Parse).ToList();
            var sortedNums = nums.OrderBy(x => -x).Take(3);

            Console.WriteLine(string.Join(" ", sortedNums));
        }
    }
}
