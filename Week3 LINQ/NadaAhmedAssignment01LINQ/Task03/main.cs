using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>(){

            //Student 1
            new Student(){
                ID=1,
                FirstName="Ali",
                LastName="Mohammed",
                subjects= new Subject[]{
                          new Subject(){ Code=22,Name="EF"},
                          new Subject(){Code=33,Name="UML"}
                          }
            },

            //Student 2
            new Student(){
                ID=2,
                FirstName="Mona",
                LastName="Gala",
                subjects=new Subject []{
                         new Subject(){ Code=22,Name="EF"},
                         new Subject (){Code=34,Name="XML"},
                         new Subject (){ Code=25, Name="JS"}
                        }
            },
                

            //Student 3
            new Student(){
                ID=3,
                FirstName="Yara",
                LastName="Yousf",
                subjects=new Subject[]{
                         new Subject (){ Code=22,Name="EF"},
                         new Subject (){Code=25,Name="JS"}
                }
            },

            //Students 4
            new Student(){
                ID=1,
                FirstName="Ali",
                LastName="Ali",
                subjects=new Subject []{
                         new Subject (){ Code=33,Name="UML"}
                }
            },

            };



            //Query1: Display Full name and number of subjects for each student as follow
            students.Select(student => $"( Full Name = {student.FirstName} {student.LastName} , NoOfSubjects = {student.subjects.Length} )")
                    .ToList()
                    .ForEach(Console.WriteLine);

            Console.WriteLine("-------------------");

            //Query2: Write a query which orders the elements in the list by FirstName
            // Descending then by LastName Ascending and result of query displays only first
            //names and last names for the elements in list as follow
            students.OrderByDescending(student => student.FirstName)
                    .ThenBy(student => student.LastName)
                    .Select(student => $"{student.FirstName} {student.LastName}")
                    .ToList().ForEach(Console.WriteLine);


            Console.WriteLine("-------------------");

            //Query3:Display each student and student’s subject as follow (use selectMany)
            var studentSubjectList = students.SelectMany(student => student.subjects
                                , (student, subject) => new { student.FirstName, student.LastName, subject.Name }
                                ).ToList();

            foreach( var stud in studentSubjectList)
            {
                Console.WriteLine($"( Student Name = {stud.FirstName} {stud.LastName} , Subject= {stud.Name} )");
            }

            Console.WriteLine("-------------------");

            //BONUS: Then as follow (use GroupBy)

            var GroupedList = studentSubjectList.GroupBy(student => new {student.FirstName , student.LastName}); //Group by student first and last name
            
            foreach (var group in GroupedList)
            {
                Console.WriteLine($"{group.Key.FirstName} {group.Key.LastName}");
                foreach (var subject in group)
                {
                    Console.WriteLine(subject.Name);

                }

            }
        }
    }
}