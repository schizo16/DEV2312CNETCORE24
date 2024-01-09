namespace Lesson03_Theory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello, World!");
            Student student = new Student();
            student.Display();

            student = new Student(111, "Devmaster", 6);
            student.Display();

            student.Id = 1;
            student.Name = "Nguyen Tuan Anh";
            student.Age = 22;
            student.Display();
            */

            OverloadingDemo over = new OverloadingDemo();
            int res = over.Sum(10);
            Console.WriteLine("Tong: {0}=>{1}", 10, res);

            int res1 = over.Sum(20);
            Console.WriteLine("Tong: {0}=>{1}",20, res1);
        }
    }
}
