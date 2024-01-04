using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_3
{
    internal class StudentModel
    {
        //khai báo các lớp chứa các sinh viên
        List<Student> liststudent;
        //phương thức khởi tạo
        public StudentModel()
        {
            this.liststudent = new List<Student>() {
                new Student() {Id=1, Name="Dung",Age=20},
                new Student() {Id=2,Name="Tuan",Age=25},
                new Student() {Id=3,Name="Ha",Age=18 },
                new Student() {Id=4,Name="Anh", Age=30},
                new Student() {Id=5,Name="Long",Age=24},
            };


        }

        #region các phương thức overloading
        //phương thức trả vể danh sách sinh viên
        public List<Student> GetStudent()
        {
            return liststudent;
        }

        //phương thức trả về sinh viên theo id
        public Student GetStudent(int id)
        {
            Student st = null;
            foreach (var item in liststudent)
            {
                if(item.Id == id)
                {
                    st = item;
                }
            }
            return st;
        }

        //phương thức trả về sinh viên có tuổi từ x to y
        public List<Student> GetStudent(int x, int y)
        {
            List<Student> result = new List<Student> ();
            foreach (var item in liststudent)
            {
                if (item.Age >= x && item.Age <= y)
                    result.Add(item);
            }
            return result;
        }
#endregion
    }
}

