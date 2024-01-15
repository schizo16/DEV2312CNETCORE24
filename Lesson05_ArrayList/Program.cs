using System.Collections;

namespace Lesson05_ArrayList
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Array List Demo");
            //Khởi tạo collection ArrayList
            ArrayList arr   = new ArrayList();
            //properties
            Console.WriteLine("Count: "+arr.Count);
            Console.WriteLine("Capacity: " + arr.Capacity);
            Console.WriteLine("===================");
            //Method(add, addrange, insert,...)
            arr.Add("Xin chao");
            arr.Add(100);
            printArrayList(arr);
            Console.WriteLine("Count: " + arr.Count);
            Console.WriteLine("Capacity: " + arr.Capacity);
            Console.WriteLine("===================");
            //insert
            arr.Insert(1, "Devmaster");
            printArrayList(arr);

            // AddRange | InsertRange
            string[] names = { "Tung", "Cuc", "Truc", "Mai" };
            arr.AddRange(names); 
            printArrayList(arr);
            Console.WriteLine("Count: " + arr.Count);
            Console.WriteLine("Capacity: " + arr.Capacity);
            Console.WriteLine("===================");
            arr.InsertRange(0, names);
            printArrayList(arr);
            Console.WriteLine("Count: " + arr.Count);
            Console.WriteLine("Capacity: " + arr.Capacity);
            Console.WriteLine("===================");

            //xoá: Remove; RemoveAt; Clear;
            arr.Remove("Tung");
            printArrayList(arr);
            arr.RemoveAt(1); printArrayList(arr);


            //Sort | Search
            arr.Remove(100);
            arr.Sort(); printArrayList(arr);

            //Sắp giảm
            arr.Sort(new SortDesc());
            printArrayList(arr);

            // search
            if (arr.Contains("Cuc"))
            {
                int index = arr.IndexOf("Cuc");
                Console.WriteLine("Tim thay tai: " + index);
            }
            Console.WriteLine("Khong tim thay");
        }
        static void printArrayList(ArrayList al)
        {
            Console.WriteLine("==Danh sach phan tu trong mang");
            foreach (var  item in al)
            {
                Console.WriteLine(item);
            }
        }
    }
    class SortDesc : IComparer
    {
        public int Compare(object x, object y)
        {
            string a = x as string;
            string b = y as string;
            return b.CompareTo(a);
        }
    }
}
