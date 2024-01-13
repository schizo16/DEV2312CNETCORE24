namespace Labguide05_5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo một danh sách nhân viên
            Employee[] employees = new Employee[]
            {
            new Employee(1, "John Doe", 30),
            new Employee(2, "Jane Doe", 25),
                // Thêm nhân viên khác nếu cần
            };

            // Tạo một đối tượng Department với danh sách nhân viên
            Department department1 = new Department("Human Resources", employees);

            // Truy cập thông tin của nhân viên và phòng ban thông qua indexer
            Console.WriteLine("Employee 1 Information:");
            department1[0].DisplayInfo();

            Console.WriteLine("Department Name:");
            Console.WriteLine(department1["name"]);

            Console.WriteLine("\nEmployee 2 Information:");
            department1[1].DisplayInfo();

            Console.WriteLine("Department Name:");
            Console.WriteLine(department1["name"]);

            // Đợi người dùng nhấn Enter để đóng cửa sổ console
            Console.ReadLine();
        }
    }
}
