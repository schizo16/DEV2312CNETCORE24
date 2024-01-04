namespace Lab3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tạo đối tượng contact với constructor không thamm số
            Contact ct1 = new Contact();
            //gán giá trị cho ct1
            ct1.Id = 6;
            ct1.Firstname = "Nguyen Tuan";
            ct1.Lastname = "Anh";
            ct1.Address = "Ha Noi";
            ct1.Phone = "0967869807";
            ct1.Email = "tuananhyas@gmail.com";
            //tạo đối tượng contact với constructor có tham số
            Contact ct2 = new Contact(5, "Tran Thi", "Tinh", "Tuyen Quang", "0987654232", "bupbecotinhyeu@yahoo.com");

            //hiển thị thông tin ct1 và ct2
            ct1.Display();
            ct2.Display();
        }
    }
}
