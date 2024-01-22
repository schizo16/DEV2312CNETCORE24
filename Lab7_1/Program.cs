using Store;
namespace Lab7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Supply.Manufacturer dealer = new Supply.Manufacturer();
            //gan gia tri
            dealer.Name = "Coca cola";
            dealer.Email = "cocacola@gmail.com";
            dealer.Phone = "1234567890";
            //in thong tin
            Console.WriteLine("Dealer information");
            Console.WriteLine("\t Name: "+ dealer.Name);
            Console.WriteLine("\t Email: "+ dealer.Email);
            Console.WriteLine("\t Phone: "+ dealer.Phone);
            //tao moi sang pham trong namespace Store
            StoreItem si = new StoreItem();
            //gan gia  tri
            si.ItemNo = 726328;
            si.ItemName = "Fanta";
            si.Price = 80.00M;
            //in thong tin
            Console.WriteLine("Store Inventory");
            Console.Write("\t Item #:     ");
            Console.WriteLine(si.ItemNo);
            Console.Write("\t Item Name:     ");
            Console.WriteLine(si.ItemName);
            Console.Write("\t Unit Price:     ");
            Console.WriteLine(si.Price);

            Console.Read();

        }
    }
}
