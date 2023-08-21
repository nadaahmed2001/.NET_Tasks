namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ⦁	Ask User For 
            ⦁	The range of Number 
            ⦁	  Even Or Odd 
            ⦁	Output all Even / Odd Number between the range 
            ⦁	Ask user to try again or end 
             */
            bool contProgram=true;
            while (contProgram)
            {
                Console.WriteLine("Enter range of numbers space separated [Ex : 3 10]");
                string[] inputNumbers = Console.ReadLine().Split(' ');

                int x = int.Parse(inputNumbers[0]);
                int y = int.Parse(inputNumbers[1]);
                // Console.WriteLine(x+y);
                Console.WriteLine("Press 1 for Even, 2 for Odd: ");
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        //Print all even numbers within range
                        printEven(x, y);
                        break;

                    case 2:
                        printOdd(x, y);
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }//end switch

                Console.WriteLine("Do you want to continue? (y/n)");
                char response = Convert.ToChar(Console.ReadLine());
                if (response != 'y' && response != 'Y')
                {
                    contProgram = false;
                }
            }//end while
            
            void printEven(int start, int end)
            {
                Console.WriteLine("Even numbers between {0} and {1}:", start, end);
                for(int i = start; i < end; i++)
                {
                    if (i % 2 == 0) Console.WriteLine(i);
                }

            }

            void printOdd(int start, int end)
            {
                Console.WriteLine("Odd numbers between {0} and {1}:", start, end);
                for (int i = start; i <= end; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
        }
    }
}