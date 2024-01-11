namespace Lab05_1
{
    internal class Program
    {
        /// <summary>
        /// một số thao tác mảng 1 chiều
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] m = {5, 2, 3, 4, 6, 8, 10, 7, 9, 1};


            //duyet mang va in du lieu
            Console.WriteLine("Cac phan tu cua mang: ");
            for (int i = 0; i < m.Length; i++)
            {
                Console.WriteLine(" {0} ",m[i]);
            }

            //tim phan tu lon nhat
            Array.Sort(m);
            Array.Reverse(m);
            int maxElement = m[0];
            Console.WriteLine("Phan tu lon nhat la: {0}", maxElement);

            //Kiểm tra mảng đôi xứng
            bool kt = true;
            for (int i =1; i < m.Length / 2 ;i++)
            {
                if (m[i] != m[m.Length - 1 - i])
                {
                    kt = false;
                    break;
                }
            }
            if(kt)
            {
                Console.WriteLine("Mang doi xung");
            }else { Console.WriteLine("Mang khong dx"); }
        }
    }
}
