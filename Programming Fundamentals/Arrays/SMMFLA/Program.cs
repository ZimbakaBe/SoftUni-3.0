using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMMFLA
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] numArr = new int[num];
            int sum = 0;
            int min = 0;
            int max = 0;

            for (int i = 0; i < num; i++)
            {
                numArr[i] = int.Parse(Console.ReadLine());
                sum += numArr[i];

                if(numArr[i] < min)
                {
                    min = numArr[i];
                }
                if (numArr[i] > max)
                {
                    max = numArr[i];
                }
            }

            Console.WriteLine("Sum = {0} \n" +
                               "Min = {1} \n" +
                               "Max = {2} \n" +
                               "First = {3} \n" +
                               "Last = {4} \n" +
                               "Average = {5}", 
                               sum, min, max, numArr[0], numArr[numArr.Length-1], (double)sum/numArr.Length);
        }
    }
}
