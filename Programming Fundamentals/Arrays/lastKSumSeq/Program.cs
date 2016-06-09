using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastKSumSeq
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int sum = 0;
            int[] nums = new int[n];
            nums[0] = 1;

            Console.WriteLine(nums[0]);

            for (int i = 1; i < n; i++)
            {
                if (i >= k)
                {
                    for (int j = i - k; j < i; j++)
                    {
                        sum += nums[j];
                    }
                }
                else
                {
                    for (int s = 0; s < i; s++)
                    {
                        sum += nums[s];
                    }
                }

                nums[i] = sum;
                Console.WriteLine(nums[i]);
                sum = 0;
            }
        }
    }
}
