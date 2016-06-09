using System;

namespace LargestCommonEnd
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ');
            string[] arr2 = Console.ReadLine().Split(' ');

            int minLength = Math.Min(arr1.Length, arr2.Length);

            int checkFirst = CheckArrays(minLength, arr1, arr2);

            Array.Reverse(arr1);
            Array.Reverse(arr2);

            int checkSecond = CheckArrays(minLength, arr1, arr2);

            Console.WriteLine(Math.Max(checkFirst, checkSecond));

        }

        public static int CheckArrays(int minLength, string[] firstArray, string[] secondArray)
        {
            int count = 0;

            for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }

    }
}
