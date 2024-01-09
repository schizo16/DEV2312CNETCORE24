using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labguide04_4._4
{
    internal class Faculty : Employee
    {
        public string OfficeHours { get; set; }
        public string Rank { get; set; }

        
        public override decimal CalculateBonus()
        {
            
            return 1000 + Salary * 0.05m; 
        }

        
        public override int CalculateVacation()
        {
           
            int baseVacation = (DateTime.Now.Year - DateHired.Year) >= 3 ? 5 : 4; // 5 weeks if employed more than 3 years, otherwise 4 weeks

            if (Rank == "Senior Lecturer")
            {
                
                baseVacation++;
            }

            return baseVacation;
        }
    }
}
