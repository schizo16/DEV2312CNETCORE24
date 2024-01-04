namespace Lab3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20, b = 30;
            double area;
            Utility u = new Utility();
            Console.WriteLine("Truon khi hoan vi a={0},b={1}", a, b);
            u.SwapFake(a, b);
            Console.WriteLine("Sau khi hoan vi fake a={0},b={1}",a, b);
            u.SwapReally(ref a, ref b);
            Console.WriteLine("Sau khi hoan vi really a={0},b={1}", a, b);
            u.AreaCircle(100, out area);
            Console.WriteLine("Chu vi hinh tron ban kinh 100 la: {0}", area);
        }
    }
}
