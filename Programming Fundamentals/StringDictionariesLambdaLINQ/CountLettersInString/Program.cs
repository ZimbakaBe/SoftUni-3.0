using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLettersInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();

            int[] count = new int[text.Max() + 1];

            foreach (char ch in text)
            {
                count[ch]++;
            }

            for (char ch = (char)0; ch < count.Length; ch++)
            {
                if(count[ch] != 0) {
                    Console.WriteLine("{0} -> {1}", ch, count[ch]);
                }
            }
        }
    }
}
