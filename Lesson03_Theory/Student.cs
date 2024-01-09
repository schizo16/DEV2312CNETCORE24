using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Theory
{
    /// <summary>
    /// 
    /// </summary>
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        //contractor
        public Student()
        {
            Id = 0;
            Name = "";
            Age = 0;
        }

        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public void Display()
        {
            Console.WriteLine("ID: {0}", Id);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            
        }
    }
}
