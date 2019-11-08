/*Amritpal Dhami
 Student ID - 30017389*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques3
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating Random instance for getting Random values.
            Random rand = new Random();

            //Matrix A
            int[,] matrixA = new int[3, 3];

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                { matrixA[i, j] = rand.Next(-10, 10); }

            }
            //  showing Matrix A 
            Console.WriteLine("Matrix A:");
            Display(matrixA);

            Console.WriteLine();

            //Matrix B
            int[,] matrixB = new int[3, 3];

            for (int i = 0; i < matrixB.GetLength(0); i++)

            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                { matrixB[i, j] = rand.Next(-10, 10); }
            }

            // showing  Matrix B 
            Console.WriteLine("Matrix B: ");
            Display(matrixB);

            Console.WriteLine();

            // when three matrix are equal; matrix C = matrix A = matrix B

            int[,] matrixC = new int[3, 3];
            for (int i = 0; i < matrixC.GetLength(0); i++)

            {
                for (int j = 0; j < matrixC.GetLength(1); j++)
                { matrixC[i, j] = matrixA[i, j] + matrixB[i, j]; }

            }
            Console.WriteLine("Matrix C = Matrix A + Matrix B ");
            Display(matrixC);

            Console.ReadLine();
        }
        //displaying the arrays by method
        static void Display(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write(arr[i, j] + "  ");
                Console.WriteLine();
            }
        }
    }
}
