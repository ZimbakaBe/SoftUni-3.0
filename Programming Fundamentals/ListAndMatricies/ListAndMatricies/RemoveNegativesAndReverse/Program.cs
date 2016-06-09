using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isEmpty = true;

            for (int i = line.Length - 1; i >= 0 ; i--)
            {
                if (line[i] > 0) {
                    Console.Write(line[i] + " ");
                    isEmpty = false;
                }
            }

            if(isEmpty == true)
            {
                Console.WriteLine("Empty");
            }
        }
    }
}
