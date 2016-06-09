using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int newArrLenght = initialNumbers.Length / 2;
            int sideLength = initialNumbers.Length / 4;

            int[] midArr = new int[newArrLenght];
            int[] sideArr = new int[newArrLenght];

            for (int i = sideLength; i < initialNumbers.Length - sideLength; i++)
            {
                midArr[i- sideLength] = initialNumbers[i];
            }

            for (int i = 0; i < sideLength; i++)
            {
                sideArr[i] = initialNumbers[sideLength - 1 - i]; 
            }

            Array.Reverse(initialNumbers);

            for (int i = 0; i < sideLength; i++)
            {
                sideArr[sideLength + i] = initialNumbers[i];
            }

            for (int i = 0; i < midArr.Length; i++)
            {
                Console.Write(midArr[i] + sideArr[i] + " ");
            }
        }
    }
}
