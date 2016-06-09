using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ', '.', ';', ':', '!', '(', ')', '"', '\'', '/', '\\', '[', ']', ',');
            List<string> lower = new List<string>();
            List<string> middle = new List<string>();
            List<string> upper = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                string line = text[i];
                byte count = 0;

                for (int j = 0; j < line.Length; j++)
                {
                    if(Char.IsUpper(line[j]) || Char.IsDigit(line[j])) {
                        count++;
                    }
                }

                if(count == text[i].Length)
                {
                    upper.Add(text[i]);
                } 
                else if(count < text[i].Length && count > 0)
                {
                    middle.Add(text[i]);
                }
                else if(count == 0)
                {
                    lower.Add(text[i]);
                }
            }

            Console.Write("Lower-case: ");
            lower.ForEach(a => Console.Write(a + " "));
            Console.WriteLine();
            Console.Write("Mixed-case: ");
            middle.ForEach(a => Console.Write(a + " "));
            Console.WriteLine();
            Console.Write("Upper-case: ");
            upper.ForEach(a => Console.Write(a + " "));
        }
    }
}
