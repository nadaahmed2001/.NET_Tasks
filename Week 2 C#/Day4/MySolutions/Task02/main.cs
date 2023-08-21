namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter number of employees: ");
            n= int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[n];

            for(int i = 0; i < n; i++)
            {
                Employee employee = new Employee();
                Console.WriteLine("\n----- Enter Details of Employee {0}: -----", i+1);
               // Console.Write("First Name: ");
                //string firstName = Console.ReadLine();
                employee.SetName(ValidateName("First Name: "));

               // Console.Write("Last Name: ");
               // string lastName = Console.ReadLine();
                employee.SetLname(ValidateName("Last Name: "));

              //  Console.Write("Salary: ");
               // int salary = int.Parse(Console.ReadLine());
                employee.SetSalary(ValidSalary("Salary: "));

                Console.Write("Address: ");
                string address = Console.ReadLine();
                employee.SetAddress(address);

               // Console.Write("Age: ");
             //   int age = int.Parse(Console.ReadLine());
                employee.SetAge(ValidaAge("Age: "));

                Console.Write("Gender (F/M): ");
                char genderChar = char.Parse(Console.ReadLine());
                Gender gender = (genderChar == 'F') ? Gender.F : Gender.M;
                employee.SetGender(gender);

                employees[i] = employee;

            }//End input

            for(int i = 0; i < n;i++)
            {
                Console.WriteLine("\n--------Employees Details--------");
                //Employee1: Name: Ali Mohamed, Age: 26, Address: Cairo, Salary: 1000, Gender:Male
                Console.WriteLine("Employee{0}: Name: {1} {2}, Age: {3}, Address: {4}, Salary: {5}, Gender:{6}"
                   , i + 1, 
                   employees[i].GetName(), 
                   employees[i].GetLname(),
                   employees[i].GetAge(),
                   employees[i].GetAddress(),
                   employees[i].GetSalary(),
                   employees[i].GetGender()
                   );
            }//End Print


        }//End Main

       static string ValidateName(string str)
        {
            string name;
            do
            {
                Console.Write(str);
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Name cannot be empty. Please try again.");
                }
            }while (string.IsNullOrEmpty(name));
            return name;
        }

        static int ValidaAge(string str)
        {
            int age;
            do
            {
                Console.Write(str);
                age = int.Parse(Console.ReadLine());
                if (age<=20)
                {
                    Console.WriteLine("Age Can't be less than 20. Please try again.");
                }
            } while (age <= 20);
            return age;
        }

        static int ValidSalary(string str)
        {
            int salary;
            do
            {
                Console.Write(str);
                salary = int.Parse(Console.ReadLine());
                if (salary <= 900)
                {
                    Console.WriteLine("Salary Can't be less than 900. Please try again.");
                }
            } while (salary <= 900);
            return salary;
        }
    }
}