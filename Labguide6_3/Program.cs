namespace Labguide6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Tạo danh sách chứa 10 đối tượng Car
            List<Car> carList = new List<Car>
        {
            new Car("Toyota", "Blue"),
            new Car("Honda", "Red"),
            new Car("Ford", "Green"),
            new Car("Chevrolet", "Silver"),
            new Car("BMW", "Black"),
            new Car("Mercedes", "White"),
            new Car("Audi", "Gray"),
            new Car("Nissan", "Yellow"),
            new Car("Hyundai", "Purple"),
            new Car("Kia", "Orange")
        };

            // In danh sách trước khi xóa
            Console.WriteLine("Danh sách trước khi xóa:");
            foreach (Car car in carList)
            {
                car.DisplayInfo();
            }

            // Xóa các xe có màu đỏ
            carList.RemoveAll(car => car.Color.ToLower() == "red");

            // In danh sách sau khi xóa
            Console.WriteLine("Danh sách sau khi xóa:");
            foreach (Car car in carList)
            {
                car.DisplayInfo();
            }

            // Đợi người dùng nhấn phím Enter trước khi đóng chương trình
            Console.ReadLine();
        }
    }
}
