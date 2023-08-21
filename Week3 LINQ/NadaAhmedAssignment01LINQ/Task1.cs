namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };

            //Query1: Display numbers without any repeated Data and sorted
            var newList = numbers.Distinct().ToList().OrderBy(n => n);
            foreach(var number in newList)
            {
                Console.WriteLine(number);
            }

            //Query2: using Query1 result and show each number and it’s multiplication
            foreach(var number in newList)
            {
                Console.WriteLine("( Number = {0} , Multiply = {1} )", number, number * number);
            }
        }
    }
}