namespace Lab6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>()
            {
                new Student{Id= "S10", FirstName= "Nguyen Thu", LastName= "Phuong",Avg = 9.5},
                new Student{Id= "S12", FirstName= "Tran Thi", LastName= "Thuy",Avg = 9.0},
                new Student{Id= "S13", FirstName= "Le Hoang", LastName= "Nhat",Avg = 8.0},
                new Student{Id= "S14", FirstName= "Nguyen Van", LastName= "Phong",Avg = 6.5},
                new Student{Id= "S15", FirstName= "Hoang Thi", LastName= "Hue",Avg = 9.7},
                new Student{Id= "S16", FirstName= "Nguyen Tien", LastName= "Tung",Avg = 5.0},
                new Student{Id= "S17", FirstName= "Nguyen Thien", LastName= "Nhan",Avg = 4.8}
            };
            Console.WriteLine("Danh sach sinh vien: ");
            foreach(var st in list)
            {
                Console.WriteLine(st);
            }
            //tim sv co diem tb cao nhat
            double max = list[6].Avg;
            Student stmax= list[6];
            foreach (var st in list)
            {
                if (max > st.Avg) ;
                stmax = st;
            }
            Console.WriteLine("Sinh vien co diem cao nhat la: ");
            Console.Write(stmax);
        }
    }
}
