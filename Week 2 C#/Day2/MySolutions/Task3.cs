using System;

namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalCountCase1 = 0;
            int totalCountCase2 = 0;

            Console.WriteLine("Number of 1's using case 1: ");
            var watch = new System.Diagnostics.Stopwatch();//To calculate time
            watch.Start();
            for (int i = 1; i <= 99999999; i++)
            {
                int countOnes = case1(i);
                totalCountCase1 += countOnes;
            }
            watch.Stop();
            Console.WriteLine(totalCountCase1);
            Console.WriteLine("Execution time ----> {0} ms \n",watch.ElapsedMilliseconds);

            Console.WriteLine("Number of 1's using case 2: ");
            watch.Start();
            for (int i = 1; i <= 99999999; i++)
            {
                int countOnes = case2(i);
                totalCountCase2 += countOnes;
            }
            watch.Stop();
            Console.WriteLine(totalCountCase2);
            Console.WriteLine("Execution time ----> {0} ms", watch.ElapsedMilliseconds);
 
        }

        static int case1(int num)
        {
            int result = 0;
            string stringNum = num.ToString();
            for (int i = 0; i < stringNum.Length; i++)
            {
                if (stringNum[i] == '1') result++;
            }
            return result;
        }

        static int case2(int num)
        {
            int result = 0;
            while (num > 0)
            {
                if (num % 10 == 1) result++;
                num /= 10;
            }
            return result;
        }
    }
}
