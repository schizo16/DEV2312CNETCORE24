using System.Text;

namespace Labguide05_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập một năm bất kỳ: ");
            int namDuongLich = int.Parse(Console.ReadLine());

            // Số dư khi chia năm cho 10 sẽ là vị trí của Can trong mảng Can
            int viTriCan = (namDuongLich - 4) % 10;
            if (viTriCan < 0)
            {
                viTriCan += 10; // Đảm bảo viTriCan luôn dương
            }

            // Số dư khi chia năm cho 12 sẽ là vị trí của Chi trong mảng Chi
            int viTriChi = (namDuongLich - 4) % 12;
            if (viTriChi < 0)
            {
                viTriChi += 12; // Đảm bảo viTriChi luôn dương
            }

            // Lấy Can và Chi tương ứng từ mảng
            string can = GetCan(viTriCan);
            string chi = GetChi(viTriChi);

            Console.WriteLine($"Năm {namDuongLich} là năm {can} {chi}");
        }

        static string GetCan(int viTri)
        {
            string[] canArray = { "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ", "Canh", "Tân", "Nhâm", "Quý" };
            return canArray[viTri];
        }

        static string GetChi(int viTri)
        {
            string[] chiArray = { "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi", "Thân", "Dậu", "Tuất", "Hợi" };
            return chiArray[viTri];
        }



    }
    }

