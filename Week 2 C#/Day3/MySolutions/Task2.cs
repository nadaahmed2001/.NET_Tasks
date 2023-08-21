using System;
using System.Reflection;

namespace LectureTask01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////////////
            //region Two D Array
            //int[,] marks = new int[3, 5];// [row , col]
            int[,] marks2 = new int[3, 5]
            {
                {1 , 2 ,3 , 4 ,5 } ,
                {10 , 20 ,30 ,40 ,50 },
                {100 , 200 , 300 , 400 , 500 }
            };

            //for (int i = 0; i < marks2.GetLength(0); i++)
            //    for (int j = 0; j < marks.GetLength(1); j++)
            //        Console.WriteLine(marks2[i,j]); 
            //////////////////////////////////////////////////////////////////////////////

            //Iterate using 1 for loop
            for (int i = 0; i < 3 * 5; i++)
            {
                int row = i / 5; //5 is num of columns
                int col = i % 3;
                Console.WriteLine($"marks2[{row}, {col}] = {marks2[row, col]}");
            }
        }
    }
}