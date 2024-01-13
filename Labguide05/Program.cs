using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Labguide05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Tạo mảng 1 chiềucos số nguyên gồm 10 phần tử
            int[] a = { 1, 3, 9, -12, 29, -4, 7, -14, 10, -11 };
           
            //Tìm phần tử nhỏ nhất của mảng
            
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
                
            }
            Console.WriteLine("Phan tu nho nhat la: " + min);


            //Đảo ngược mảng
            Console.WriteLine("Mang ban dau: ");
            Display(a);
            Array.Reverse(a);
            Console.WriteLine("Mang sau khi dao nguoc: ");
            Display(a);


            static void Display(int[] a)
            {
                foreach (var item in a)
                {
                    Console.WriteLine(item + " ");
                }
            }
            //Sắp xếp mảng tăng
            Array.Sort(a);
            Console.WriteLine("Sap xep mang tang: ");
            Display(a);
            Console.WriteLine("Sap xep mang giam: ");
            Array.Reverse(a);
            Display(a);

            // Tìm phần tử số nguyên
            int phanTuCanTim = 7;

            if (KiemTraPhanTuLaSoNguyen(a, phanTuCanTim))
            {
                Console.WriteLine($"{phanTuCanTim} là một số nguyên trong mảng.");
            }
            else
            {
                Console.WriteLine($"{phanTuCanTim} không là số nguyên hoặc không có trong mảng.");
            }
        

            static bool KiemTraPhanTuLaSoNguyen(int[] a, int phanTuCanTim)
            {
                foreach (var phanTu in a)
                {
                    if (phanTu == phanTuCanTim && phanTu is int)
                    {
                        return true;
                    }
                }
                return false;
            }
            // In ra số lượng các số dương liên tiếp nhiều nhất
            int doDai = a.Length;
            int dem = 0;
            int maxDem = 0;
            int startIndex = -1;
            for (int i = 0; i < doDai; i++)
            {
                if (a[i] > 0)
                {
                    dem++;
                    if (dem == 1)
                    {
                        startIndex = i;
                    }
                    if (dem > maxDem)
                    {
                        maxDem = dem;
                    }
                }
                else
                {
                    dem = 0;
                }
                
            }if (maxDem > 0)
            {
                Console.Write("Các số dương liên tiếp nhiều nhất là: \n");
                for (int i = startIndex; i < startIndex + maxDem; i++)
                {
                    Console.Write(a[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("Không có số dương nào trong mảng.");
            }
            //Tính trung bình cộng
            double average = TinhTrungBinhCong(a);

            Console.WriteLine($"Trung bình cộng của mảng là: {average}");

            static double TinhTrungBinhCong(int[] a)
            {
                if (a == null || a.Length == 0)
                {
                    throw new ArgumentException("Mảng không hợp lệ.");
                }

                int tong = 0;

                foreach (var phanTu in a)
                {
                    tong += phanTu;
                }

                double trungBinhCong = (double)tong / a.Length;

                return trungBinhCong;
            }
            //Kiểm tra xem mảng có phải chứa các phần tử âm dương, đan xen nhau không
            int[] b = { -1, -3, -9, 12, -29, 4, -7, 14, -10, 11 };
            if (KiemTraDanXenAmDuong(a))
            {
                Console.WriteLine("Mảng 1 chứa các phần tử âm và dương đan xen nhau.");
            }
            else
            {
                Console.WriteLine("Mảng 1 không chứa các phần tử âm và dương đan xen nhau.");
            }

            if (KiemTraDanXenAmDuong(b))
            {
                Console.WriteLine("Mảng 2 chứa các phần tử âm và dương đan xen nhau.");
            }
            else
            {
                Console.WriteLine("Mảng 2 không chứa các phần tử âm và dương đan xen nhau.");
            }
            static bool KiemTraDanXenAmDuong(int[] a)
            {
                if(a == null || a.Length < 2)
                {
                    return false;
                }
                int hienTai = Math.Sign(a[0]);
                for(int i = 1; i < a.Length; i++)
                {
                    int hienTaiDau = Math.Sign(a[i]);
                    if(hienTaiDau < 0)
                    {
                        return false;
                    }
                    if(hienTaiDau == hienTai)
                    {
                        return false;
                    }
                    hienTai = hienTaiDau;
                }
                return true;
            }
        }
    }
}
