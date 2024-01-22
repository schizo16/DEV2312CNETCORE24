using System.Text;

namespace Labguide8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Books> ListBooks = new List<Books>()
            {
                new Books{Id="B01", Name="Lập trình Java", Author="Author 1", Price = 3200, Publisher="Giáo dục", Year= 2015},
                new Books{Id="B02", Name="Triết học Mác Lê-nin", Author="Author 2", Price = 9000, Publisher="Giáo dục", Year= 2016},
                new Books{Id="B03", Name="Lập trình C", Author="Author 3", Price = 7000, Publisher="Publisher 3", Year= 2017},
                new Books{Id="B04", Name="Mạng máy tính", Author="Author 4", Price = 6000, Publisher="Publisher 4", Year= 2012},
                new Books{Id="B05", Name="Lập trình hướng đối tượng", Author="Author 5", Price = 6000, Publisher="Publisher 1", Year= 2015},
                new Books{Id="B06", Name="Cơ sở dữ liệu", Author="Author 6", Price = 7000, Publisher="Giáo dục", Year= 2017},
                new Books{Id="B07", Name="Kỹ năng mềm", Author="Author 7", Price = 4000, Publisher="Publisher 3", Year= 2018},
                new Books{Id="B08", Name="Trí tuệ nhân tạo", Author="Author 8", Price = 5000, Publisher="Giáo dục", Year= 2014},
                new Books{Id="B09", Name="Tin học cơ sở", Author="Author 9", Price = 6500, Publisher="Publisher 1", Year= 2013},
                new Books{Id="B10", Name="Toán rời rạc", Author="Author 10", Price = 3500, Publisher="Publisher 2", Year= 2018},
            };
            Console.OutputEncoding = Encoding.UTF8;
            Print(ListBooks, "Hiển thị tất cả các sách: ");
            Console.WriteLine("================");

            var priceBooks = ListBooks.Where(b => b.Price >= 1000 && b.Price <= 5000);
            Print(priceBooks, "Các sách có giá từ 1000 đến 5000: ");
            Console.WriteLine("================");

            var yearBooks = ListBooks.Where(b => b.Year == 2015);
            Print(yearBooks, "Những cuốn sách xuất bản năm 2015: ");
            Console.WriteLine("================");

            var nameBooks = ListBooks.Where(b => b.Name.Contains("Lập trình"));
            Print(nameBooks, "Những cuốn sách có tên Lập trình: ");

            int demBooks = ListBooks.Count(b => b.Publisher == "Giáo dục");
            Console.WriteLine("Đếm sách có nhà xuất bản Giáo dục: " + demBooks);

        }
        static void Print<T>(IEnumerable<T> data, string message)
        {
            Console.WriteLine(message);
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
