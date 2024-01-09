namespace Labguide04_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckAccount myCheckAccount = new CheckAccount(1500, 5);
            Account destinationAccount = new Account(500);
            Console.WriteLine($"So du ban dau: {myCheckAccount.GetBalance()}");

            myCheckAccount.Deposit(200);

            myCheckAccount.WithDraw(100);

            myCheckAccount.Transfer(destinationAccount, 50);

            Console.WriteLine($"So du cuoi cung: {myCheckAccount.GetBalance()}");
            Console.WriteLine($"So du tai khoan dich: {destinationAccount.GetBalance()}");
            Console.ReadLine();
        }
    }
}
