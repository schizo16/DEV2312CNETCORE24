﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05_ListDemo
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Student() { }
        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return String.Format("{0,-10}{1,-15}{2,-20}", Id, Name, Age);
        }

    }
}
