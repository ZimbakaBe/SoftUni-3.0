using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintStringLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                Console.WriteLine("str[{0}] -> '{1}'", i, letter);
            }
        }
    }
}
