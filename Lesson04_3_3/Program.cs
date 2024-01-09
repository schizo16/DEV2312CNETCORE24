namespace Lesson04_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //====inheristance:
            Staff staff = new Staff();
            staff.Print();
            staff = new Staff(123, "Chung chung", "25 Vu Ngoc Phan", "09392828329", 123.123f, 12321);
            staff.Print();
            staff.ToString();
        }
    }
}
