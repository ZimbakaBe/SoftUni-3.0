using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int dayNumber = int.Parse(Console.ReadLine());
            int index = dayNumber - 1;

            if(index >= 0 & index <= 6)
            {
                Console.WriteLine(days[index]);
            } else
            {
                throw new Exception("Wrong number.");
            }
        }
    }
}
