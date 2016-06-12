using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[,] matrix = new int[matrixSize[0], matrixSize[1]]; 

            for (int row = 0; row < matrixSize[0]; row++)
            {
                int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int col = 0; col < matrixSize[1]; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            int[] targetedCell = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int cellNumber = matrix[targetedCell[0], targetedCell[1]];
            int sum = 0;

            for (int row = targetedCell[0] - 1; row <= targetedCell[0] + 1; row++)
            {
                for (int col = targetedCell[1] - 1; col <= targetedCell[1] + 1; col++)
                {
                    if(targetedCell[0] != row || targetedCell[1] != col)
                    {
                        sum += matrix[row, col];
                        matrix[row, col] = matrix[row, col] * matrix[targetedCell[0], targetedCell[1]];
                    }            
                }
            }

            matrix[targetedCell[0], targetedCell[1]] = sum * cellNumber;

            for (int row = 0; row < matrixSize[0]; row++)
            {
                for (int col = 0; col < matrixSize[1]; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
