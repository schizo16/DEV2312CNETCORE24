using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_3_3
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public float BaseSalary { get; set; }

        public Person() { }
        public Person(int id, string name, string address, string phone, float baseSalary)
        {
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
            BaseSalary = baseSalary;
        }

        public void Print()
        {
            Console.WriteLine("Id: {0}", Id);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Address: {0}", Address);
            Console.WriteLine("Phone: {0}", Phone);
        }


        //Phuong thuc cho phep ghi de
        public virtual float GetSalary()
        {
            return BaseSalary;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
