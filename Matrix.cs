using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program1: Program2
    {

        private static int[,] matrixA = { { 8, 2 }, { 5, 7 }, { 5, 4 }, { 8, 2 } };
        private static int[,] matrixB = { { 9, 5, 5, 3 }, { 4, 6, 1, 9 } };

        /// <summary>
        /// Performs Matrix multiplication on two multidimensional arrays
        /// </summary>
        /// <param name="matrix1">Input array 1</param>
        /// <param name="matrix2">Input array 2</param>
        private static void MatrixMultiplication(int[,] matrix1, int[,] matrix2)
        {

            if (matrixA.GetLength(0) != matrixB.GetLength(1))
            {
                Console.WriteLine("The number of Columns in matrixA must be the same as the number of rows in matrixB");
                return;
            }

            int[,] result = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

            for (int i = 0; i < result.GetLength(0); i++)
            {
                //for each column in the results matrix
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    //for each row in the results matrix
                    for (int k = 0; k < matrixA.GetLength(1); k++)
                    {
                        //iterate over every element in a single row of MatrixA
                        result[i, j] = result[i, j] + matrixA[i, k] * matrixB[k, j]; //perform matrix multiplication
                    }
                }
            }

            PrintMatrix(result);
        }

        /// <summary>
        /// Prints a multidimensional array to console
        /// </summary>
        /// <param name="matrix">The multidmensional matrix to print to terminal</param>
        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write(matrix[i, k] + " ");
                }

                Console.WriteLine();
            }
        }

        // static void Main(string[] args) {
        //
        //     // Console.WriteLine("MatrixA Columns: {0} MatrixB Rows: {1}\n", matrixA.GetLength(0), matrixB.GetLength(1));
        //     //
        //     // MatrixMultiplication(matrixA, matrixB);
        //     // GreatestDivisor(inputA, inputB);
        // }
    }
}
