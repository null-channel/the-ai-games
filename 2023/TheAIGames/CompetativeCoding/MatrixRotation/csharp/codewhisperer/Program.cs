// See https://aka.ms/new-console-template for more information

using System;

class MatrixRotation
{
    static void Main()
    {
        /*In c# You are given a 2D matrix of dimension and a positive integer. You have to rotate the matrix a give number of times and print the resulting matrix. Rotation of the matrix should be in anti-clockwise direction. */
        int [,] matrix = new int [,] {{1,2,3},{4,5,6},{7,8,9}};
        PrintMatrix(matrix);
        Console.WriteLine();
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int k = 3;
        int [,] rotatedMatrix = new int [n,m];
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                rotatedMatrix[i,j] = matrix[j,i];
            }
        }
        PrintMatrix(rotatedMatrix);

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
