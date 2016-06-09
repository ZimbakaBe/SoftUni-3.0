using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] numArr = new int[num];

            for (int i = 0; i < num; i++)
            {
                numArr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = numArr.Length-1; i >= 0; i--)
            {
                Console.WriteLine(numArr[i]);
            }
        }
    }
}
