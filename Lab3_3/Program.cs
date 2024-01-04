namespace Lab3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tạo đối tượng
            StudentModel action = new StudentModel();
            //gọi phương thức lấy tất cả các sinh viên
            List<Student> listall = action.GetStudent();
            //hiển thị
            foreach (var item in listall)
            {
                item.Display();
            }
            //gọi phương thức lấy sinh viên theo id
            Student st = action.GetStudent(2);
            //hiển thị
            st.Display();
            //gọi phương thức lấy sinh viên có tuổi từ 25 -> 30
            List<Student> listage = action.GetStudent(25, 30);
            foreach (var item in listage)
            {
                item.Display();
            }
        }
    }
}
