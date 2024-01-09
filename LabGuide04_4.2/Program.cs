namespace LabGuide04_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            NhanVienBanHang nvbh = new NhanVienBanHang("Tuan", "Hanoi", 20);
            nvbh.HienThi();

            CongNhan cn = new CongNhan("Anh","Hanoi",15);
            cn.HienThi();
        }
    }
}
