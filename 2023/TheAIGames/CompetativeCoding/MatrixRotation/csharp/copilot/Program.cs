
/*In c# You are given a 2D matrix of dimension and a positive integer. You have to rotate the matrix a give number of times and print the resulting matrix. Rotation of the matrix should be in anti-clockwise direction. */
/*
int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int[,] matrix2 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int[,] matrix3 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int[,] matrix4 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
*/


//in c# Write a function that takes a 2d matrix of integers and a positive integer x. The function should return the matrix rotated to the left, counter clockwise, x times.
//rotateMatrix(matrix, 1) => [[2, 3, 6], [1, 5, 9], [4, 7, 8]]
//rotateMatrix(matrix, 2) => [[3, 6, 9], [2, 5, 8], [1, 4, 7]]
//rotateMatrix(matrix, 3) => [[6, 9, 8], [3, 5, 7], [2, 1, 4]]

using System;

class MatrixRotation
{
    static void Main()
    {
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int rotationCount = 3; // Number of times to rotate the matrix

        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix);

        int[,] rotatedMatrix = RotateMatrixLeft(matrix, rotationCount);

        Console.WriteLine("\nRotated Matrix:");
        PrintMatrix(rotatedMatrix);
    }
    
    static int[,] RotateMatrixLeft(int[,] matrix, int rotationCount)
    {
        int[,] rotatedMatrix = matrix;
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rotationCount; i++)
        {
            rotatedMatrix = RotateMatrixLeftOnce(rotatedMatrix, rows, columns);
        }

        return rotatedMatrix;
    }

    static int[,] RotateMatrixLeftOnce(int[,] matrix, int rows, int columns)
    {
        int[,] rotatedMatrix = new int[rows, columns];

        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {                
                rotatedMatrix[row, column] = matrix[column, rows - row - 1];
            }
        }

        return rotatedMatrix;
    }

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