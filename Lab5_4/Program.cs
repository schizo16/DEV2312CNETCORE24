namespace Lab5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book("Programing with C#", 4);

            b[0] = new Chapter("Chapter 1", "Introducation");
            b[1] = new Chapter("Chapter 2", "Datatype nad variables");
            b[2] = new Chapter("Chapter 3", "Input and Output in Console App");
            b[3] = new Chapter("Chapter 4", " Statements Conditions and Loops");

            Console.WriteLine("List of book: ");
            Console.WriteLine(b.Name);

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(b[i]);
            }
            Console.WriteLine("Detail of Chapter 3");
            Console.WriteLine(b["Chapter 3"]);
            Console.Read();
        }
    }
}
