using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split('|');
            List<string> nums = new List<string>();

            for (int i = numbers.Length - 1; i >= 0 ; i--)
            {
                string[] splitBySpace = numbers[i].Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < splitBySpace.Length; j++)
                {
                    nums.Add(splitBySpace[j]);
                }
            }

            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write(nums[i].Trim() + " ");
            }
            
        }
    }
}
