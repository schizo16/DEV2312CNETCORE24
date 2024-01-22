using System.Text;

namespace Lab8_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] Numbers = { 7, 9, 3, 5, 2, 1, 0, 6, 4, 3, 1 };
            string[] Words =
            {
                "Chỉ",
                "trích",
                "phê",
                "phán",
                "người",
                "khác",
                "giống",
                "như",
                "con",
                "chim",
                "bồ",
                "câu",
                "đưa",
                "thư",
                "bao",
                "giờ",
                "cũng",
                "quay",
                "về",
                "nơi",
                "xuất",
                "phát"
            };
            List<Film> ListFilm = new List<Film>()
            {
                new Film{FilmId = "F01", FilmName="Điệp viên 007",Price=120000},
                new Film{FilmId = "F02", FilmName="Tam quốc diễn nghĩa",Price=130000},
                new Film{FilmId = "F03", FilmName="Thiếu lâm truyền kỳ",Price=16000},
                new Film{FilmId = "F04", FilmName="Người nhện 3",Price=100000},
                new Film{FilmId = "F05", FilmName="Ngân hàng tình yêu",Price=340000},
                new Film{FilmId = "F06", FilmName="Người đẹp và súc vật",Price=230000},
                new Film{FilmId = "F07", FilmName="Biệp động Sài Gòn",Price=190000}
            };
            IEnumerable<int> querynumber = Numbers.Where(n => n % 2 == 0);
            Show<int>(querynumber, "Loc cac so chan: ");

            IEnumerable<string> queryword = Words.Where(w => w.Length > 4);
            Show<string>(queryword, "Loc cac tu co do dai > 4");

            IEnumerable<string> queryT = Words.Where(w => w.StartsWith("t"));
            Show<string>(queryT, "Loc cac tu bat dau bang chu t");

            var uniqueNumber = Numbers.Distinct();
            Show<int>(uniqueNumber, "Loc cac so duy nhat trong tap cac so: ");

            var countDistinct = Words.Distinct().Count();
            Console.WriteLine("Dem xem co nhieu tu khong trung nhau: " + countDistinct);

            var fourNumber = Numbers.Take(4);
            Show<int>(fourNumber, "Lay 4 so dau tien trong day: ");

            var twoword = Words.Take(2);
            Show<string>(twoword, "Lay 2 tu dau tien trong cau: ");

            var search = Words.TakeWhile(w => w.Contains("t"));
            Show<string>(search, "Lay nhung tu dau tien co chua chu t: ");

            var queryfilm = ListFilm.OrderBy(f => f.Price).Select(x => new { x.FilmId, x.FilmName, x.Price }).ToList().TakeWhile(t => t.Price < 200000);

            var skipNumber = Numbers.Skip(3);
            Show<int>(skipNumber, "Bo qua 3 phan tu dau tien, lay tat ca cac phan tu con lai: ");

            var skipTakeNumber = Numbers.Skip(4).Take(3);
            Show<int>(skipTakeNumber, "Bo qua 4 phan tu dau tien, lay 3 phan tu ke tiep: ");

            var skipTakeFilm = ListFilm.Skip(3).Take(3);
            Show<Film>(skipTakeFilm, "Bo qua 3 phim dau tien, lay 3 phim ke tiep: ");

            var sortNumber = Numbers.OrderByDescending(x => x).SkipWhile(x => x > 5);
            Show<int>(sortNumber, "Sap xep giam dan, sau do lay cac phan tu < 5: ");


        }
        static void Show<T>(IEnumerable<T> data, string message)
        {
            Console.WriteLine(message);
            foreach (var item  in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
