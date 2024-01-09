namespace Lab4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Rectangle rec = new Rectangle();
            rec.InputData();
            Console.WriteLine("Dien tich hinh chu nhat la:{0:N}", rec.Area());
            Console.WriteLine("Chu vi hinh chu nhat la:{0:N}", rec.Circumference());

            Circle cir = new Circle();
            cir.InputData();
            Console.WriteLine("Dien tich hinh tron la:{0:N}", cir.Area());
            Console.WriteLine("Chu vi hinh tron la:{0:N}", cir.Circumference());
        }
    }
}
