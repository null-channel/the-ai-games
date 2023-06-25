/*
In c# You are given a 2D matrix of dimension and a positive integer. You have to rotate the matrix a give number of times and print the resulting matrix. Rotation of the matrix should be in anti-clockwise direction. 
For example: 
1) If you want to rotate an array by one time, then it will become like this : [3][4] -> [[4][3]]
 
2) If you want to rotate an array by two times, then it will become like this : [5][6] ->[[6][5],[5][6]]

3) If you want to rotate an array by three times,then it will become like this :[7][8]->[[8][7], [7][8], [8][7]].
*/
using System;
namespace RotateMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[, ] arr = new int[3, 4];

            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 4; ++j)
                    Console.Write("Enter element at " + "[" + i + "," + j + "]");

                //Inputting elements into the Array
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 4; ++j)
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
    */
        int[,] arr = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
            /*
             * The above code is used only when we need to input data from user 
             */
            
            //Rotating Matrix 
            for (int k=0 ;k<arr.GetLength(0);++k){
                
                for (int l=0;l<(arr.GetLength(0)-k)%arr.GetLength(0)+arr.GetLength(0)/2;++l){
                    
                    if((k+l)<arr.GetLength(0)){
                        var temp = arr[k,l];
                        arr[k,l]=arr[(arr.GetLength(0)-k)+(arr.GetLength(0)-l),k];
                        arr[(arr.GetLength(0)-k)+(arr.GetLength(0)-l),k]=temp;
                        
                    }
                    
                }
                
            }

            
           //Printing rotated matrix 
           for (int m = 0; m < 3; ++m)
               for (int n = 0; n < 4; ++n)
                   Console.WriteLine("{0}", arr[m, n]);

        }

    }
    
}