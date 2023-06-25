using System;

namespace MatrixRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows, cols, rotations;
            Console.Write("Enter number of rows: ");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns: ");
            cols = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of rotations: ");
            rotations = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            // Populate the matrix
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = j + 1;
                }
            }

            // Print original matrix
            Console.WriteLine("Original Matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Rotate the matrix
            for (int rotation = 0; rotation < rotations; rotation++)
            {
                for (int layer = 0; layer < rows/2; layer++)
                {
                    int first = layer;
                    int last = rows - 1 - layer;
                    for (int i = first; i < last; i++)
                    {
                        int offset = i - first;
                        int top = matrix[first, i]; 

                        // left to top
                        matrix[first, i] = matrix[last-offset, first];

                        // bottom to left
                        matrix[last-offset, first] = matrix[last, last - offset];

                        // right to bottom
                        matrix[last, last - offset] = matrix[i, last];

                        // top to right
                        matrix[i, last] = top;
                    }
                }
            }

            // Print rotated matrix
            Console.WriteLine("Rotated Matrix: ");
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