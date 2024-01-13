using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labguide05_5._4
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor để khởi tạo đối tượng Employee
        public Employee(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        // Phương thức để hiển thị thông tin của nhân viên
        public void DisplayInfo()
        {
            Console.WriteLine($"Employee ID: {Id}");
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Employee Age: {Age}");
        }
    }
}
