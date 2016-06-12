using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PopulationAggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\');
            Dictionary<string, int> countries= new Dictionary<string, int>();
            Dictionary<string, int> towns = new Dictionary<string, int>();

            while (input[0] != "stop")
            {
                for (int i = 0; i < input.Length - 1; i++)
                {
                    string line = Regex.Replace(input[i], @"[#@$&0-9]", "");

                    if (char.IsUpper(line[0]))
                    {
                        if(countries.ContainsKey(line))
                        {
                            countries[line]++;
                        }
                        else
                        {
                            countries[line] = 1;
                        }
                    }
                    else
                    {
                        towns[line] = int.Parse(input[2]);
                    }
                }

                input = Console.ReadLine().Split('\\');
            }

            var countryList = countries.Keys.ToList();
            countryList.Sort();

            foreach (var key in countryList)
            {
                Console.WriteLine("{0} -> {1}", key, countries[key]);
            }

            var topThree = (from key in towns
                           orderby key.Value descending
                           select key).Take(3)
                           .ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (var key in topThree)
            {
                Console.WriteLine("{0} -> {1}", key.Key, key.Value);
            }
        }
    }
}
