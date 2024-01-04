namespace Lab3_1
{
    public class Program
    {
        /// <summary>
        /// Minh hoạ việc khởi tạo đối tượng, truy cập các trường và phương thức
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Tạo đối tượng car
            Car myCar = new Car();
            // gán giá trị cho các trường đói lập
            myCar.make = "Toyota";
            myCar.model = "MR2";
            myCar.year = 1995;
            myCar.color = "black";

            //hiển thị thông tin về đối tượng myCar
            System.Console.WriteLine("Thong tin chi tiet: ");
            System.Console.WriteLine("Make: " + myCar.make);
            System.Console.WriteLine("Model: "+ myCar.model);
            System.Console.WriteLine("Color: " + myCar.color);
            System.Console.WriteLine("Year: "+ + myCar.year);

            //gọi các pt
            myCar.Start();
            myCar.stop();

        }
    }
}
