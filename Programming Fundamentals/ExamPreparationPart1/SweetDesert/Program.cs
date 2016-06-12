using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDesert
{
    class Program
    {
        static void Main(string[] args)
        {
            var cash = decimal.Parse(Console.ReadLine());
            var guests = decimal.Parse(Console.ReadLine());
            var bananasPrice = decimal.Parse(Console.ReadLine());
            var eggsPrice = decimal.Parse(Console.ReadLine());
            var berriesPrice = decimal.Parse(Console.ReadLine());
            int portions = 0;

            portions = (int)(guests / 6);
            if(guests % 6 != 0)
            {
                portions++;
            }

            var pricePerSet = 2 * bananasPrice + 4 * eggsPrice + 0.2m * berriesPrice;
            decimal sum = portions * pricePerSet;

            if(sum <= cash)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", sum);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", sum - cash);
            }
        }
    }
}
