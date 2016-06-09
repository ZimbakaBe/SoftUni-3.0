using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilledSquare
{
    class Program
    {
        static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }

        static void PrintBody(int n)
        {
            for (int i = 0; i < n-2; i++)
            {
                char symbol1 = '\\';
                char symbol2 = '/';
                
                Console.WriteLine("-{0}-", new string('\\', n - 1));
            }    
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeaderRow(n);
            PrintBody(n);
            PrintHeaderRow(n);
        }
    }
}
