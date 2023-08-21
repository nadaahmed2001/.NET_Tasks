using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

            //Query1: Select names with length equal 3.
            var newNames= names.Where(name=>name.Length==3).ToList();

            foreach(var name in newNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("----------------------------");

            //Query2: Select names that contains “a” letter (Capital or Small )then sort them by length
            //(Use toLower method and Contains method)
            var newNames2 = names.Where(name => name.ToLower().Contains('a')).ToList().OrderBy(name => name.Length);
            foreach(var name in newNames2)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("----------------------------");

            //Query3: Display the first 2 names
            var newNames3=names.Take(2).ToList();

            foreach (var name in newNames3)
            {
                Console.WriteLine(name);
            }

        }
    }
}