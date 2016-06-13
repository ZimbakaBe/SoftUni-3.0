using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrifonQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = int.Parse(Console.ReadLine());
            int[] matrixSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = matrixSize[0];
            int cols = matrixSize[1];

            string[,] map = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string line = Console.ReadLine();

                for (int col = 0; col < cols; col++)
                {
                    map[row, col] = line[col].ToString();
                }
            }

            int turns = 0;

            for (int col = 0; col < cols; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < rows; row++)
                    {

                        switch (map[row, col])
                        {
                            case "F":
                                health -= turns / 2;
                                break;
                            case "H":
                                health += turns / 3;
                                break;
                            case "T":
                                turns += 2;
                                break;
                        }

                        turns++;

                        if (health <= 0)
                        {
                            Console.WriteLine("Died at: [{0}, {1}]", row, col);
                            break;
                        }
                    }
                }
                else
                {
                    for (int row = rows - 1; row >= 0; row--)
                    {
                        switch (map[row, col])
                        {
                            case "F":
                                health -= turns / 2;
                                break;
                            case "H":
                                health += turns / 3;
                                break;
                            case "T":
                                turns += 2;
                                break;
                        }

                        turns++;

                        if (health <= 0)
                        {
                            Console.WriteLine("Died at: [{0}, {1}]", row, col);
                            break;
                        }
                    }
                }

                if (health <= 0)
                {
                    break;
                }
            }

            if (health > 0)
            {
                Console.WriteLine("Quest completed!");
                Console.WriteLine("Health: {0}", health);
                Console.WriteLine("Turns: {0}", turns);
            }         
        }
    }
}
