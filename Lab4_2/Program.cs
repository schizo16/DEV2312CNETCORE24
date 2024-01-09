namespace Lab4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student of College: ");
            StudentCollege sv1 = new StudentCollege("Tuan Anh", 2002, 9.5, 8, 7);
            sv1.Display();
            Console.WriteLine("Average of score: {0}", sv1.Average());

            Console.WriteLine("Student of University: ");
            StudentUniversity sv2 = new StudentUniversity("Thanh", 1998, 8, 8.5, 9, 9.5);
            sv2.Display();
            Console.WriteLine("Average of score: {0}", sv2.Average());
        }
    }
}
