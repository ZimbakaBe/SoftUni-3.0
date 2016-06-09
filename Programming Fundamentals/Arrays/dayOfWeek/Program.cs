using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int day = int.Parse(Console.ReadLine());

            if(day>0 && day<8)
            {
                Console.WriteLine(daysOfWeek[day - 1]);
            } else
            {
                Console.WriteLine("Invalid day");
            }
        }
    }
}
