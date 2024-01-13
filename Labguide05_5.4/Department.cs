using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labguide05_5._4
{
    internal class Department
    {
        public string Name { get; set; }
        public Employee[] Employees { get; set; }

        public Department(string name, Employee[] employees)
        {
            Name = name;
            Employees = employees;
        }

        // Indexer cho truy cập thông tin của nhân viên theo chỉ số
        public Employee this[int index]
        {
            get
            {
                if (index >= 0 && index < Employees.Length)
                {
                    return Employees[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }
            }
        }

        // Indexer cho truy cập thông tin của phòng ban
        public string this[string infoType]
        {
            get
            {
                if (infoType.ToLower() == "name")
                {
                    return Name;
                }
                else
                {
                    throw new ArgumentException("Invalid information type");
                }
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Department Name: {Name}");

            Console.WriteLine("Employees:");
            foreach (var employee in Employees)
            {
                employee.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}
