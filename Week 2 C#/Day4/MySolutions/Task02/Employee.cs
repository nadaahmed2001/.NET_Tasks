using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    enum Gender
    {
        F,M
    }
    internal class Employee
    {
        private string Fname;
        private string Lname;
        private int salary;
        private string address;
        int age;
        Gender gender;

       public Employee() { }

       public void SetName(string Fname){ this.Fname = Fname;}
        public string GetName() { return this.Fname;}

        public void SetLname(string Lname) {  this.Lname = Lname;}
        public string GetLname() { return this.Lname;}

        public void SetSalary(int sal) { this.salary = sal;}
        public int GetSalary() { return this.salary;}
        public void SetAddress(string Address) { this.address = Address;}
        public string GetAddress() { return this.address;}
        public void SetAge(int age) {  this.age = age;}
        public int GetAge() { return this.age;}

        public void SetGender(Gender gender) {  this.gender = gender;}
        public Gender GetGender() { return this.gender;}
    }
}
