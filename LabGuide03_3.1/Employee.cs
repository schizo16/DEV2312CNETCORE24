using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabGuide03_3._1
{
    internal class Employee
    {
        //khai bao cac bien
        private int Id {  get; set; }
        private string Name { get; set; }
        private int YearOfBirth { get; set; }
        private double SalaryLevel { get; set; }
        private double BasicSalary {  get; set; }
        public Employee() { }

        public Employee(int id, string name, int yearOfBirth, double salaryLevel, double basicSalary)
        {
            Id = id;
            Name = name;
            YearOfBirth = yearOfBirth;
            SalaryLevel = salaryLevel;
            BasicSalary = basicSalary;
        }

        public double GetIncome()
        {
            return BasicSalary * SalaryLevel;
        }

        public void Display()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " +  Name);
            Console.WriteLine("Year of birth: "+  YearOfBirth);
            Console.WriteLine("Basic Salary: " + BasicSalary);
            Console.WriteLine("Income: " + GetIncome());
        }
    }
}
