namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //• ask user to Enter the size and take items From User Then Print Items 
            Console.Write("Enter Size : ");
            int n =int.Parse( Console.ReadLine());
            int[] arr= new int[n];
            Console.Write("\nEnter array elements [Space separated] : ");
            string input= Console.ReadLine();
            string[] items = input.Split(' ');
            Console.Write("\nArray elements: ");
            for(int i=0; i<n; i++)
            {
                int item=int.Parse(items[i] );
                arr[i]=item;
                Console.Write(arr[i] + " ");
            }
        }
    }
}