using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjEqualNums
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] initialArr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            List<double> adjLists = new List<double>();

            for (int i = 0; i < initialArr.Length; i++)
            {
                adjLists.Add(initialArr[i]);
            }

            bool isAdj = true;

            while(isAdj)
            {
                isAdj = false;

                for (int i = 0; i < adjLists.Count - 1; i++)
                {
                    if (adjLists[i] == adjLists[i + 1])
                    {
                        adjLists[i] = adjLists[i] + adjLists[i + 1];
                        adjLists.RemoveAt(i + 1);
                        isAdj = true;
                    }
                }

            }

            foreach (var item in adjLists)
            {
                Console.Write(item + " ");
            }
        }
    }
}
