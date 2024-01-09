using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labguide04_4._1
{
    internal class CheckAccount : Account
    {
        private decimal feeTransfer;

        public CheckAccount(decimal transferFee, decimal initialBalance) : base (initialBalance)
        {
            if (feeTransfer < 0)
            {
                Console.WriteLine("Phi chuyen khoan khong hop le.");
                feeTransfer = 0;
            }
            else
            {
                feeTransfer = transferFee;
            }
        }
        public override void Deposit(decimal money)
        {
            base.Deposit(money - feeTransfer);
            Console.WriteLine($"Gui tien thanh cong: {money}. So du moi: {GetBalance()}");
        }

        public override void WithDraw(decimal money)
        {
            base.WithDraw(money + feeTransfer);
            Console.WriteLine($"Rut tien thanh cong: {money}. So du moi: {GetBalance()}");
        }
        public void CheckBalance()
        {
            Console.WriteLine("So du trong tai khoan: "+ GetBalance());
        }

        public void Transfer(Account destinationAccount, decimal money)
        {
            if (money > 0 && money <= GetBalance())
            {
                base.WithDraw (money + feeTransfer);
                destinationAccount.Deposit(money);
                Console.WriteLine("Chuyen khoan thanh cong: {0}. So du moi: {1}", money, GetBalance());

            }
            else
            {
                Console.WriteLine("So tien chuyen khoan khong hop le hoac khong du so du");
            }
        }

    }
}
