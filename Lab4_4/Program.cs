namespace Lab4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPerson staff = new Staff();
            object data = "Back Khoa Aptech";

            staff.Insert(data);
            staff.Delete(data);
            staff.Update(data);
            
            staff.Display(data);

            IPerson student = new Student() { Id = "S10", Name = "Test", Age = 20 };
            student.Display(student);
        }
    }
}
