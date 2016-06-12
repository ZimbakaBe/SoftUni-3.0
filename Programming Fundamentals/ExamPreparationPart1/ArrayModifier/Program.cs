using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                long[] inputArr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

                string[] command = Console.ReadLine().Split(' ');

                while (command[0] != "end")
                {
                    switch (command[0])
                    {
                        case "swap":
                            Swap(inputArr, int.Parse(command[1]), int.Parse(command[2]));
                            break;
                        case "multiply":
                            Multiply(inputArr, int.Parse(command[1]), int.Parse(command[2]));
                            break;
                        case "decrease":
                            Decrease(inputArr);
                            break;

                    }

                    command = Console.ReadLine().Split(' ');
                }

                Console.WriteLine(String.Join(", ", inputArr));

            }
        }
            

        static void Swap(long[] arr, int index1, int index2)
        {
            int num = (int)arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = num;
        }

        static void Multiply(long[] arr, int index1, int index2)
        {
            arr[index1] = arr[index1] * arr[index2];
        }

        static void Decrease(long[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]--;
            }
        }
    }
}
