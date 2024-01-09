using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labguide04_4._1
{
    internal class SavingAccount : Account
    {
        public double Rate { get; set; }

        public SavingAccount(decimal initialBalance, double initialRate) : base(initialBalance)
        {
            if (initialRate < 0)
            {
                Console.WriteLine("Lai suat khong hop le. Dat mac dinh la 0.");
                Rate = 0;
            }
            else
            {
                Rate = initialRate;
            }
        }
        public decimal GetInterest()
        {
            return (decimal)(GetBalance())*(decimal)Rate;
        }
    }
}
