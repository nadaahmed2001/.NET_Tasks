namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Longestdist = 0;
            Console.Write("Enter Size : ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.Write("\nEnter array elements [Space separated] : ");
            string input = Console.ReadLine();
            string[] items = input.Split(' ');
            for (int i = 0; i < n; i++)
            {
                int item = int.Parse(items[i]);
                arr[i] = item;
            }

            Dictionary<int, List<int>> visitedCells = new  Dictionary<int, List<int>>(); // number and its indexes

            for(int i = 0; i < n; i++) {
                if (!(visitedCells.ContainsKey(arr[i]))) { //if the number not stored in the dictionary
                    visitedCells.Add(arr[i], new List<int>());//Make dictionary entry with key=arr[i]
                    visitedCells[arr[i]].Add(i); ////add this index to the list

                }
                else {//the number exist in the dictionary

                    //add its index to the list
                    visitedCells[arr[i]].Add(i);
                }
            }
  
            foreach(int i in visitedCells.Keys)
            {
                List<int> list = visitedCells[i];
                int count = visitedCells[i].Count;
                int distance = (list[count-1] - list[0] )-1;   //diff between first and last index
                Longestdist = Math.Max(Longestdist, distance);
                
            }
            Console.WriteLine("Longest Distance between two equal cells is : {0} cell", Longestdist);


        }
    }
}