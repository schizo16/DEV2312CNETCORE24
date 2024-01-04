using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    internal class Car
    {
        // khai báo các trường public
        public string make;
        public string model;
        public string color;
        public int year;

        // định nghĩa pt Start
        public void Start()
        {
            System.Console.WriteLine(model + " khoi dong");
        }
        // định nghĩa pt stop
        public void stop()
        {
            System.Console.WriteLine(model + " dung");
        }
    }
}
