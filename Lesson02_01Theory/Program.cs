namespace Lesson02_01Theory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo");

            //Khởi tạo đối tượng
            Category category = new Category();
            //Truy cập đến thuộc tính
            category.Id = 111;
            category.Name = "Devmaster";
            //Truy cập đến display
            category.Display();


            Employees employees = new Employees();
            employees.Id = 1;
            employees.Fullname = "Nguyễn Tuấn Anh";
            employees.Salary = 923.238;

            employees.PrintInfor();

            //Tạo trong employees -> hàm khởi tạo 3 tham số
            // 3 tham số

            // Sử dụng
            employees = new Employees(1, "Tuấn Anh", 82372);
            employees.PrintInfor();


            //Test calculator 
            //sử dụng phương thức tĩnh
            int kq = Calculator.Add(10, 20);
            Console.WriteLine(kq);
            kq = Calculator.Sub(10, 20);
            Console.WriteLine(kq);
            Calculator calculator = new Calculator();

            //kq = Calculator.Mul(10, 20); // error
            kq = calculator.Mul(10, 20);
            Console.WriteLine(kq);

            //ref / out
            int cong, tru;
            calculator.Calc(10, 20, out cong, out tru);
            Console.WriteLine("Cong: " + cong);
            Console.WriteLine("Tru: " + tru);
            Console.WriteLine("============");

            int num1 = 100; int num2 = 200;
            Console.WriteLine("Num1:{0} / num2:{2}", num1, num2);
            calculator.Swap(num1, num2);
            Console.WriteLine("Swap => Numb1:{0} / num2:{2}");
        }
    }
}
