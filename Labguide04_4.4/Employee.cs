using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labguide04_4._4
{
    internal abstract class Employee : Person
    {
        public decimal Salary { get; set; }
        public string Department { get; set; }
        public DateTime DateHired { get; set; }

        public abstract decimal CalculateBonus();
        public abstract int CalculateVacation();
    }
}
