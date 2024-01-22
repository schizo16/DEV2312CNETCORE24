namespace Lab7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Business.House h = new Business.House();
            h.HouseNo = "D294FF";
            h.Price = 425880;

            Console.WriteLine("House detail");
            Console.WriteLine("\t House No: "+h.HouseNo);
            Console.WriteLine("\t Price: "+ h.Price);
            Business.Dealership.Car c = new Business.Dealership.Car();
            c.CarNo = "A0999";
            c.Price = 38425.50M;
            Console.WriteLine("Car detail");
            Console.WriteLine("\t Car No: " + c.CarNo);
            Console.WriteLine("\t Price: " + c.Price);
            Console.Read();
        }
    }
}
