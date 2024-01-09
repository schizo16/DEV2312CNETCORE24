using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabGuide04_4._2
{
    internal class NhanVienBanHang : NhanVien

    {
        public int Soluongbanduoc;

        public NhanVienBanHang(string Ten, string DiaChi, int Soluongbanduoc)
            : base(Ten, DiaChi)
        {
            this.Soluongbanduoc = Soluongbanduoc;
        }
        public override void HienThi()
        {
            Console.WriteLine("Ten: " + Ten);
            Console.WriteLine("Dia chi: "+  DiaChi);
            Console.WriteLine("So luong ban duoc la: " + Soluongbanduoc);
            
        }
        public override float TinhLuong()
        {
            throw new NotImplementedException();
        }

        }
    }
