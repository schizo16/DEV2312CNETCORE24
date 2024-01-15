namespace Lesson05_ListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List Generic......");
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(15);
            list.Add(12);
            list.Add(14);
            

            //Tang
            list.Sort();
            Console.WriteLine("\n==================Ds");
            foreach (var item in list)
            {
                Console.WriteLine("{0,5}", item);
            }
            //Giam
            list.Sort((x, y) => { return y - x; });
            Console.WriteLine("\n==================Ds");
            foreach (var item in list)
            {
                Console.WriteLine("{0,5}", item);
            }

            //Obj
            List<Student> students = new List<Student>() {
                new Student(222, "Tuan Anh", 22),
                new Student(){Id = 333, Name = "Trinh",Age=40 },
                new Student(444, "Huong", 20),
                new Student(555, "Alo", 21)
            };
            students.Sort((a, b) => { return a.Age - b.Age; }) ;
            Console.WriteLine("\n==================Ds");
            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
