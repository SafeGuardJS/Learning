using System;

namespace SixthProject
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            int[,] matrix = new int[10, 10];
            matrix = setRandValueOfMatrixElements(matrix);
            consoleOutputMatrix(matrix);
            checkConditionMatrix(matrix);
            Console.WriteLine();
            matrix = smoothConditionMatrix(matrix);
            consoleOutputMatrix(matrix);
            Console.WriteLine();
            Console.WriteLine(botDiagonalMatrixModSum(matrix));
            
        }

        static void consoleOutputMatrix(in int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static int[,] setValueOfMatrixElements(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); i++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            return matrix;
        }

        static int[,] setRandValueOfMatrixElements(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(10, 99);
                }
            }

            return matrix;
        }

        static int[,] smoothConditionMatrix(int[,] matrix)
        {
            int[,] smoothedMatrix = new int[10, 10];

            for (int i = 0; i < smoothedMatrix.GetLength(0); i++)
            {
                for (int j = 0, counter = 0; j < smoothedMatrix.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix.GetLength(0); k++)
                    {
                        for (int l = 0; l < matrix.GetLength(1); l++)
                        {
                            if (i - l < k && i + l > k && j - 1 < l && j + 1 > l && i != k && j != k)
                            {
                                counter++;
                                smoothedMatrix[i, j]  +=  matrix[k, l];
                            }
                        }
                    }
                    if (counter == 0) continue;
                    smoothedMatrix[i, j] /= counter;
                    counter = 0;
                }
            }

            return smoothedMatrix;
        }
        static void checkConditionMatrix(int[,] matrix)
        {
            int i = 6, j = 6;

            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                for (int l = 0; l < matrix.GetLength(1); l++)
                {
                    if (i - l < k && i + l > k && j - 1 < l && j + 1 > l && i != k && j != k)
                    {
                        Console.WriteLine($"!!!!!{k}, {l}!!!!!!");
                    }
                }
            }
        }

        static int botDiagonalMatrixModSum(int[,] matrix)
        {
            int modSum = 0;

            for(int i = 1; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < i; j++)
                {
                    modSum += matrix[i, j];
                    Console.Write($"{i},{j} ");
                }
                Console.WriteLine();
            }

            return modSum;
        }
    }
}
