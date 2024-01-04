using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02_01Theory
{
    /// <summary>
    /// Tạo lớp đối tượng Employees
    /// Tạo các thuộc tính tự động
    ///  Id, Fullname, Salary
    ///  Tạo phương thức PrintInfor
    ///     hiển thị thông tin nhân viên
    ///  - Test trong main program.cs
    /// </summary>
    internal class Employees
    {
        //prob
        public int Id { get; set; }
        public string Fullname { get; set; }
        public double Salary { get; set; }

        //method
        public void PrintInfor()
        {
            Console.WriteLine("Id\t : " + Id);
            Console.WriteLine("Fullname : " + Fullname);
            Console.WriteLine("Salary\t : " + Salary);
        }
        //Contructor 3 tham số
        public Employees() { }
        public Employees(int id, string fullname, double salary)
        {
            Id = id;
            Fullname = fullname;
            Salary = salary;
        }
    }
}
