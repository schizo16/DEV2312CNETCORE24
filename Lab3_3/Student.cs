using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_3
{
    internal class Student
    {
        //tạo các thuộc tính
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        //phương thức hiển thị
        public void Display()
        {
            System.Console.WriteLine("Id: " + Id);
            System.Console.WriteLine("Name: " + Name);
            System.Console.WriteLine("Age: " + Age);
        }
    }
}
