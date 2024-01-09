using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabGuide04_4._2
{
    abstract class NhanVien
    {
        protected string Ten;
        protected string DiaChi;

        protected NhanVien(string ten, string diaChi)
        {
            Ten = ten;
            DiaChi = diaChi;
        }

        public abstract float TinhLuong();
        public abstract void HienThi();
    }
}
