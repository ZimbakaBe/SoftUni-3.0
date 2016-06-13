using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Numerics.B;

namespace SoftUniCoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < orders; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                string[] orderData = Console.ReadLine().Split('/');
                var capsuleCount = int.Parse(Console.ReadLine());

                var year = int.Parse(orderData[2]);
                var month = int.Parse(orderData[1]);
                int daysInMonth = DateTime.DaysInMonth(year, month);

                long capsules = daysInMonth * capsuleCount;

                decimal price = pricePerCapsule * capsules;

                //price = decimal.Round(price, 2);
                sum += price;

                Console.WriteLine("The price for the coffee is: ${0:f2}", price);
            }

            Console.WriteLine("Total: ${0:f2}", sum);
        }
    }
}
