using System.Collections;

namespace Labguide06_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo collection gồm 10 sách
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "Book1", Author = "Author1", Publisher = "Publisher1", Year = 2012, Price = 15.99 },
            new Book { Id = 2, Title = "Book2", Author = "Author2", Publisher = "Publisher2", Year = 2013, Price = 12.99 },
            new Book { Id = 3, Title = "Book3", Author = "Author3", Publisher = "Publisher3", Year = 2014, Price = 19.99 },
            new Book { Id = 4, Title = "Book4", Author = "Author1", Publisher = "Publisher1", Year = 2012, Price = 15.99 },
            new Book { Id = 5, Title = "Book5", Author = "Author2", Publisher = "Publisher2", Year = 2013, Price = 12.99 },
            new Book { Id = 6, Title = "Book6", Author = "Author3", Publisher = "Publisher3", Year = 2014, Price = 19.99 },
            new Book { Id = 7, Title = "Book7", Author = "Author1", Publisher = "Nhi Dong", Year = 2012, Price = 15.99 },
            new Book { Id = 8, Title = "Book8", Author = "Author2", Publisher = "Nhi Dong", Year = 2013, Price = 12.99 },
            new Book { Id = 9, Title = "Book9", Author = "Author3", Publisher = "Nhi Dong", Year = 2014, Price = 19.99 },
            new Book { Id = 10, Title = "Book10", Author = "Author1", Publisher = "Nhi Dong", Year = 2012, Price = 15.99 }

        };

            // Sắp xếp sách theo giá tăng dần
            books = books.OrderBy(book => book.Price).ToList();

            Console.WriteLine("Danh sách sách theo giá tăng dần:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }

            // Tìm sách theo giá trị nhập từ bàn phím
            Console.Write("\nNhập giá sách cần tìm: ");
            double inputPrice = Convert.ToDouble(Console.ReadLine());

            Book foundBook = books.Find(book => book.Price == inputPrice);
            if (foundBook != null)
            {
                Console.WriteLine($"\nSách có giá {inputPrice} là: {foundBook}");
            }
            else
            {
                Console.WriteLine($"\nKhông tìm thấy sách có giá {inputPrice}.");
            }

            // Lọc ra những quyển sách từ năm 2014
            List<Book> booksFrom2014 = books.Where(book => book.Year == 2014).ToList();

            Console.WriteLine("\nDanh sách sách từ năm 2014:");
            foreach (var book in booksFrom2014)
            {
                Console.WriteLine(book);
            }

            // Xoá quyển sách có nhà xuất bản "Nhi Dong"
            books.RemoveAll(book => book.Publisher == "Nhi Dong");

            Console.WriteLine("\nDanh sách sách sau khi xoá nhà xuất bản 'Nhi Dong':");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
