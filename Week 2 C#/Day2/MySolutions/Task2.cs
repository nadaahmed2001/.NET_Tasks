namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             ⦁	Given a list of space separated words, reverse the order of the words.

            Input: this is a test		Output: test a is this
            Input: all your base		Output: base your all
            Input: Word			Output: Word
            >> Check the Split Function (Member in String Class)
            Output will be a Single Console.WriteLine Statment

             */
            string input=Console.ReadLine();
            string[] arr = input.Split(' ');
            for(int i=arr.Length-1; i>=0; i--)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}