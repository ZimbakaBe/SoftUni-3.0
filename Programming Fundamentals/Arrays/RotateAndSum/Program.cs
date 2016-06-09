using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            int[] sumArr = new int[nums.Length];

            Console.WriteLine((2 + 1) % nums.Length);

            for (int currentRotation = 0; currentRotation < k; currentRotation++)
            {
                int lastElement = nums[nums.Length - 1];

                for (int currentElement = nums.Length - 1; currentElement > 0; currentElement--)
                {
                    nums[currentElement] = nums[currentElement - 1]; 
                }

                nums[0] = lastElement;

                for (int currentElement = 0; currentElement < nums.Length; currentElement++)
                {
                    sumArr[currentElement] += nums[currentElement];
                }
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
