using System.Collections;

namespace Lesson05_ArrayListObj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array List Object");
            ArrayList arr = new ArrayList();

            //add
            arr.Add(new Student(111, "Chung", 45));
            Student[] st =
            {
                new Student(222, "Tuan Anh", 22),
                new Student(){Id = 333, Name = "Trinh",Age=40 },
                new Student(444, "Huong", 20),
                new Student(555, "Alo", 21)
            };
            arr.AddRange(st);
            printObj(arr);

            //SX
            //SX tang theo tuoi
            arr.Sort(new SortAgeASC());
            printObj(arr);

            arr.Sort(new SortNameASC());
            printObj(arr);


            //Hashtable
            Hashtable ht = new Hashtable();
            Student st1 = new Student(123, "Chung Trinh", 100);
            ht.Add(st1.Id, st1);
            st1 = new Student(124, "Chung Trinh 1", 50);
            ht.Add(st1.Id, st1);
            Console.WriteLine("List key");
            foreach(var key in ht.Keys)
            {
                Console.WriteLine(key + "====" + ht[key].ToString());
            }
            Console.WriteLine("List value");
            foreach(var item in ht.Values)
            {
                Console.WriteLine(item.ToString());
            }
           
        }
        static void printObj(ArrayList al)
        {
            Console.WriteLine("=========Danh sach");
            foreach(var item in al)
            {
                Console.WriteLine(item.ToString());
            }
        }
        
    }
    class SortAgeASC : IComparer
    {
        public int Compare(object x, object y)
        {
            Student a = x as Student;
            Student b = y as Student;
            return a.Age - b.Age;
        }
    }
    class SortNameASC : IComparer
    {
        public int Compare (object x, object y)
        {
            Student a = x as Student;
            Student b = y as Student;
            return string.Compare(a.Name, b.Name);
        }
    }
}
