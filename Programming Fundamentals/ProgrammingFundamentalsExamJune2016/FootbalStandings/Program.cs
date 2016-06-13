using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FootbalStandings
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            string[] input = Console.ReadLine().Split(' ');
            Dictionary<string, int> countries = new Dictionary<string, int>();
            Dictionary<string, int> goals = new Dictionary<string, int>();

            while (input[0] != "final")
            {
                List<string> list = new List<string>();
                int[] result = input[2].Split(':').Select(int.Parse).ToArray();

                for (int i = 0; i < input.Length - 1; i++)
                {
                    string line = input[i];
                    int length = line.LastIndexOf(key) - line.IndexOf(key) - key.Length;
                    string text = line.Substring(line.IndexOf(key) + key.Length, length);
                    list.Add(ReverseString(text).ToUpper());
                }

                for (int i = 0; i < list.Count; i++)
                {
                    if(goals.ContainsKey(list[i]))
                    {
                        goals[list[i]] += result[i];
                    }
                    else
                    {
                        goals[list[i]] = result[i];
                    }
                }

                if(result[0] > result[1])
                {
                    if(countries.ContainsKey(list[0]))
                    {
                        countries[list[0]] += 3;
                    }
                    else
                    {
                        countries[list[0]] = 3;
                    }

                    if (countries.ContainsKey(list[1]))
                    {
                        countries[list[1]] += 0;
                    }
                    else
                    {
                        countries[list[1]] = 0;
                    }
                }
                else if(result[0] < result[1])
                {
                    if (countries.ContainsKey(list[1]))
                    {
                        countries[list[1]] += 3;
                    }
                    else
                    {
                        countries[list[1]] = 3;
                    }
                    if (countries.ContainsKey(list[0]))
                    {
                        countries[list[0]] += 0;
                    }
                    else
                    {
                        countries[list[0]] = 0;
                    }
                }
                else
                {
                    if (countries.ContainsKey(list[0]))
                    {
                        countries[list[0]] += 1;
                    }
                    else
                    {
                        countries[list[0]] = 1;
                    }

                    if (countries.ContainsKey(list[1]))
                    {
                        countries[list[1]] += 1;
                    }
                    else
                    {
                        countries[list[1]] = 1;
                    }
                }

                input = Console.ReadLine().Split(' ');
            }

            var countriesSort = (from pair in countries
                                 orderby pair.Key
                                 orderby pair.Value descending
                                 select pair)
                                 .ToDictionary(a => a.Key, a => a.Value);

            var topThree = (from pair in goals
                            orderby pair.Key
                            orderby pair.Value descending
                            select pair).Take(3)
                            .ToDictionary(a => a.Key, a => a.Value);

            Console.WriteLine("League standings:");
            int count = 1;
            foreach (var country in countriesSort)
            {
                Console.WriteLine("{0}. {1} {2}", count, country.Key, country.Value);
                count++;
            }

            Console.WriteLine("Top 3 scored goals:");
            foreach (var goal in topThree)
            {
                Console.WriteLine(" - {0} -> {1}", goal.Key, goal.Value);
            }
        }

        public static string ReverseString(string text)
        {
            char[] arr = text.ToCharArray();
            Array.Reverse(arr);

            return new string(arr);
        }
    }
}
