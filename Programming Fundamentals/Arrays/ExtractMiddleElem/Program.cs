using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMiddleElem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (nums.Length == 1)
            {
                Console.WriteLine("{ " + nums[0] + " }");
            }
            else
            {
                switch (nums.Length % 2)
                {
                    case 0: //even
                        Console.WriteLine("{ " + nums[nums.Length / 2 - 1] + ", " + nums[nums.Length / 2] + " }");
                        break;

                    case 1: //odd
                        Console.WriteLine("{ "
                                            + nums[nums.Length / 2 - 1] + ", "
                                            + nums[nums.Length / 2] + ", "
                                            + nums[nums.Length / 2 + 1] +
                                        " }");
                        break;
                }
            }
        }
    }
}
