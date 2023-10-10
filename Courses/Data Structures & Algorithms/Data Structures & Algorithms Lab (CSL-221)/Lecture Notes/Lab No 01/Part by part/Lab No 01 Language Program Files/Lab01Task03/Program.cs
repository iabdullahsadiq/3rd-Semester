using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows for Matrix A");
            int rowsA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of Column for Matrix A");
            int colA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of rows for Matrix B");
            int rowsB = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of Column for Matrix B");
            int colB = int.Parse(Console.ReadLine());
            int[,] arrayA = new int[rowsA, colA];
            int[,] arrayB = new int[rowsB, colB];
            int rows = arrayA.GetLength(0);
            int cols = arrayA.GetLength(1);
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colA; j++)
                {
                    Console.WriteLine("Enter the Element for Matrix A : \t");
                    arrayA[i, j] = int.Parse(Console.ReadLine());

                }
            }
            for (int i = 0; i < rowsB; i++)
            {
                for (int j = 0; j < colB; j++)
                {
                    Console.WriteLine("Enter the Element for Matrix B: \t");
                    arrayB[i, j] = int.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine("**************Display of Matrix******************");

            Console.WriteLine("Matrix A is: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arrayA[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matrix B is: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arrayB[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int opt;
            do
            {
                Console.WriteLine("What do you want to do with matrices: \n1. Add matrices \n2. Subtract matrices \n3. Multiply matrices \n4. Calculate determinant of Matrix A \n5. Calculate inverse of Matrix A \n6. Exit");
                opt = int.Parse(Console.ReadLine());
                if (opt == 1)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            result[i, j] = arrayA[i, j] + arrayB[i, j];
                        }
                    }
                    Console.WriteLine("\nAdded Successfully! The answer is:\n");
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            Console.Write(result[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                }
                if (opt == 2)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            result[i, j] = arrayA[i, j] - arrayB[i, j];
                        }
                    }
                    Console.WriteLine("\nSubtracted Successfully! The answer is: \n");
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            Console.Write(result[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                }
                if (opt == 3)
                {
                    if (colA != rowsB)
                    {
                        Console.WriteLine("Matrix multiplication is not possible due to incompatible dimensions.");
                    }
                    else
                    {
                        for (int i = 0; i < rowsA; i++)
                        {
                            for (int j = 0; j < colB; j++)
                            {
                                result[i, j] = 0;
                                for (int k = 0; k < colA; k++)
                                {
                                    result[i, j] += arrayA[i, k] * arrayB[k, j];
                                }
                            }
                        }
                        Console.WriteLine("\nMultiplied Successfully! The result is:\n");
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < cols; j++)
                            {
                                Console.Write(result[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }
                    }
                }
                if (opt == 4)
                {
                    {
                        // Determinant of Matrix A (You need to implement the determinant calculation)
                        double determinantA = CalculateDeterminant(arrayA, rowsA);
                        Console.WriteLine($"Determinant of Matrix A is: {determinantA}");
                    }
                    Console.WriteLine("\nDeterminant complete Successfully! The result is:\n");
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            Console.Write(result[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                }
                if (opt == 5)
                {
                    double[,] inverseA = CalculateInverse(arrayA, rowsA);
                    Console.WriteLine("Inverse of Matrix A is:");
                    for (int i = 0; i < rowsA; i++)
                    {
                        for (int j = 0; j < rowsA; j++)
                        {
                            Console.Write(inverseA[i, j] + "\t");
                        }
                    }
                    Console.WriteLine("\nInverse Successfully! The result is:\n");
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            Console.Write(result[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                }
            } while (opt != 6);
        }
        static double CalculateDeterminant(int[,] matrix, int n)
        {
            return 0;
        }
        static double[,] CalculateInverse(int[,] matrix, int n)
        {
            double[,] inverse = new double[n, n];
            return inverse;
        }
    }
}