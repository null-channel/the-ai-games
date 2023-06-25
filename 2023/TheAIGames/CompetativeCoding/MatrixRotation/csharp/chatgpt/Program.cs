using System;

/*
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

        int[,] rotatedMatrix = RotateMatrix(matrix, rotationCount);

        Console.WriteLine("\nRotated Matrix:");
        PrintMatrix(rotatedMatrix);
    }

    static int[,] RotateMatrix(int[,] matrix, int rotationCount)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Determine the number of rotations required
        rotationCount = rotationCount % 4;

        for (int r = 0; r < rotationCount; r++)
        {
            int[,] tempMatrix = new int[cols, rows];

            // Perform rotation by swapping rows and columns
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    tempMatrix[j, rows - i - 1] = matrix[i, j];
                }
            }

            // Update the original matrix with the rotated matrix
            matrix = tempMatrix;

            // Update the number of rows and columns
            int temp = rows;
            rows = cols;
            cols = temp;
        }

        return matrix;
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
*/


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

        int[,] rotatedMatrix = RotateMatrixLeft_butBetter(matrix, rotationCount);

        Console.WriteLine("\nRotated Matrix:");
        PrintMatrix(rotatedMatrix);
    }

    static int[,] RotateMatrixLeft(int[,] matrix, int rotationCount)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Determine the number of rotations required
        rotationCount = rotationCount % 4;

        for (int r = 0; r < rotationCount; r++)
        {
            int[,] tempMatrix = new int[cols, rows];

            // Perform rotation by swapping rows and columns
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    tempMatrix[i, j] = matrix[j, cols - i - 1];
                }
            }

            // Update the original matrix with the rotated matrix
            matrix = tempMatrix;

            // Update the number of rows and columns
            int temp = rows;
            rows = cols;
            cols = temp;
        }

        return matrix;
    }

    // updated function after asking if it was possible to improve the time complexity
    static int[,] RotateMatrixLeft_butBetter(int[,] matrix, int rotationCount)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Determine the number of rotations required
        rotationCount = rotationCount % 4;

        for (int r = 0; r < rotationCount; r++)
        {
            // Perform rotation by swapping elements in the matrix
            for (int layer = 0; layer < Math.Min(rows, cols) / 2; layer++)
            {
                int first = layer;
                int lastRow = rows - 1 - layer;
                int lastCol = cols - 1 - layer;

                for (int i = first; i < lastRow; i++)
                {
                    int offset = i - first;
                    int top = matrix[first, i];

                    // Left -> Top
                    matrix[first, i] = matrix[lastRow - offset, first];

                    // Bottom -> Left
                    matrix[lastRow - offset, first] = matrix[lastRow, lastCol - offset];

                    // Right -> Bottom
                    matrix[lastRow, lastCol - offset] = matrix[i, lastCol];

                    // Top -> Right
                    matrix[i, lastCol] = top;
                }
            }
        }

        return matrix;
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



