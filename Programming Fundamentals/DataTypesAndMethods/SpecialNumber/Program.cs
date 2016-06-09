using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if(i == 5 || i == 7 || i == 11)
                {
                    Console.WriteLine("{0} -> True", i);
                } else
                {
                    Console.WriteLine("{0} -> False", i);
                }
            }
        }
    }
}
