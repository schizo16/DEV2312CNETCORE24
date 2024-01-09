using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabGuide04_4._2
{
    internal class CongNhan : NhanVien
    {
        public int Soluongsanpham;
        
        public CongNhan(string Ten, string DiaChi, int Soluongsanpham)
            :base(Ten, DiaChi)
        {
            this.Soluongsanpham = Soluongsanpham;
        }
        public override void HienThi()
        {
            Console.WriteLine("Ten: "+Ten);
            Console.WriteLine("Dia chi: "+DiaChi);
            Console.WriteLine("So luong san pham: " + Soluongsanpham);
        }
        public override float TinhLuong()
        {
            throw new NotImplementedException();
        }
    }
}
