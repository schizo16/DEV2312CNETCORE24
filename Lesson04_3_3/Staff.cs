using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_3_3
{
    internal class Staff : Person
    {
        public float Salary { get; set; }
        public Staff() { }
        public Staff(int id, string name, string address, string phone, float baseSalary,float salary)
            : base(id, name, address, phone, baseSalary)
        {
            Salary = salary;
        }

        public void  Print()
        {
            base.Print();

            Console.WriteLine("Salary: {0}", Salary);
        }

        public override float GetSalary()
        {
            return base.GetSalary() + Salary;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("| {0} ", GetSalary());
        }
    }
}
