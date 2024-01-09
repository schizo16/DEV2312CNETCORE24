namespace Labguide04_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Document dc = new Document();
            dc.Write("Du lieu trong document");
            string documentData = dc.Read();
            dc.Encrypt();
            dc.Decrypt();
            Console.ReadLine();
        }
    }
}
