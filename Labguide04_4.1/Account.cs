using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labguide04_4._1
{
    internal class Account
    {
        public decimal Balance { get; set; }

        public Account(decimal initialBalance)
        {
            if (initialBalance < 0)
            {
                Console.WriteLine("So tien ban dau khong hop le. Dat gia tri mac dinh la 0.");
                Balance = 0;
            }
            else
            {
                Balance = initialBalance;
            }
        }
        public decimal GetBalance()
        {
            return Balance;
        }
        public virtual void Deposit(decimal money)
        {
            if(money > 0)
            {
                Balance += money;
                Console.WriteLine("Nap thanh cong {0} vao tai khoan. So du moi {1}", money, Balance);

            }
            else
            {
                Console.WriteLine("So tien phai lon hon 0");
            }
        }
        
        public virtual void WithDraw(decimal money)
        {
            if(money > 0 && money <= Balance)
            {
                Balance -= money;
                Console.WriteLine("Rut thanh cong {0} tu tai khoan. So du moi la {1}", money, Balance);
            }
            else
            {
                Console.WriteLine("So tien rut phai lon hon 0 va khong duoc vuot qua so du");
            }
        }

        
    }
}
