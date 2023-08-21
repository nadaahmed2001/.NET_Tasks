namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Trangle 1
            for (int i = 1; i < 6; i++)
            {
                string str = new string('*', i);
                string str2 = new string(' ', (6 - i)-1);
                Console.WriteLine(str2+str);
            }

            Console.Write("\n\n");

            //Trangle 2
            for (int i = 1 ; i < 6 ; i++)
            {
                string str = new string('*', i);
                Console.WriteLine( str );
            }

            Console.Write("\n\n");

            //Trangle 3
            for (int i = 6; i >= 1; i--)
            {
                string str = new string('*', i);
                Console.WriteLine(str);
            }


        }
    }
}