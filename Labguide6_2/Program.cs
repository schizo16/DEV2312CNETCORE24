using System.Collections;

namespace Labguide6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo một Hashtable
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Hashtable weekDaysHashtable = new Hashtable();

            // Thêm các ngày trong tuần vào Hashtable với key từ 1 đến 8
            weekDaysHashtable.Add(1, "Monday");
            weekDaysHashtable.Add(2, "Tuesday");
            weekDaysHashtable.Add(3, "Wednesday");
            weekDaysHashtable.Add(4, "Thursday");
            weekDaysHashtable.Add(5, "Friday");
            weekDaysHashtable.Add(6, "Saturday");
            weekDaysHashtable.Add(7, "Sunday");
            weekDaysHashtable.Add(8, "Another Monday"); // Ví dụ thêm một phần tử khác với key 8

            // In ra tất cả các ngày trong tuần với key và value
            Console.WriteLine("Danh sách các ngày trong tuần:");
            foreach (DictionaryEntry entry in weekDaysHashtable)
            {
                int key = (int)entry.Key;
                string value = (string)entry.Value;

                Console.WriteLine($"Key: {key}, Value: {value}");
            }

            // Kiểm tra xem Tuesday có tồn tại trong Hashtable không
            int keyForTuesday = 2;
            if (weekDaysHashtable.ContainsKey(keyForTuesday))
            {
                string tuesdayValue = (string)weekDaysHashtable[keyForTuesday];
                Console.WriteLine($"\nNgày Tuesday tồn tại trong Hashtable và giá trị là: {tuesdayValue}");
            }
            else
            {
                Console.WriteLine("\nNgày Tuesday không tồn tại trong Hashtable");
            }
        }
    }
}
