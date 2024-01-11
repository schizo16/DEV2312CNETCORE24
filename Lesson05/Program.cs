using System.Text;

namespace Lesson05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            /*
            int[] a;
            int[] b = new int[10];
            float[] c = new float[] {1.2f, 1.3f, 1.4f, 1.5f};
            string[] names = {"Hung", "Dung", "Sang", "Trong" };
            //truy cap phan tu
            b[0] = 100;
            b[5] = 500;
            b[9] = 900;
            Console.WriteLine("b[5]={0}", b[5]);

            //duyệt mảng
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine("{0,5}", b[i]);
                
            }
            Console.WriteLine();

            foreach(var item in b)
            {
                Console.WriteLine("{0,5}", item);
            }
            Console.WriteLine();
            */

            // Khởi tạo mảng đối tượng sinh viên (Student) 5 đối tượng
            // Gán giá trị và in ra màn hình
            Student[] students = new Student[5];
            students[0] = new Student(01, "Tuan Anh", 20);
            students[1] = new Student(02, "Dung", 22);
            students[2] = new Student(03, "Hung", 21);
            students[3] = new Student(04, "Ha", 21);
            students[4] = new Student(05, "Trung", 22);

            foreach(var item in students)
            {
             
                Console.WriteLine("ID: {0,5} Name: {1,10} Age: {2,5}",item.Id,item.Name, item.Age);
                
            }

            //Sắp xếp theo tuổi giảm dần

            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (students[i].Age > students[j].Age)
                    {
                        // Hoán đổi vị trí của hai sinh viên
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }

            int[] arr = [1, 2, 4, 3, 6, 8, 3, 5, 7];
            Array.Sort(arr);
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
            Array.Reverse(arr);
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }

            Array.Sort(arr, (x, y) => { return y - x; });
            Console.WriteLine();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            //Sắp xếp mảng tuổi giảm dần
            Array.Sort(students, (x, y) => { return y.Age - x.Age; });
            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
