using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labguide04_4._4
{
    internal class Staff : Employee
    {
        public string Title { get; set; }

        
        public override decimal CalculateBonus()
        {
            
            return Salary * 0.06m; 
        }

        
        public override int CalculateVacation()
        {
            
            int baseVacation = 4; 
            
            int additionalWeeks = (DateTime.Now.Year - DateHired.Year) / 5;

            return Math.Max(baseVacation + additionalWeeks, 0); 
        }
    }
}
