namespace Lesson01_02Theory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập xuất với C#");

            //Xuất ra màn hình write// writeline

            int a = 100, b = 200, c;
            c = a + b;
            Console.WriteLine(a + "+" + b + "=" + c);
            Console.WriteLine("{0} + {1} = {2}",a,b,c);
            Console.WriteLine("{2} = {0} + {1}",a,b,c);


            //Nhập: Read / ReadLine

            String name;
            int age;
            Console.Write("Nhập tên: ");
            name= Console.ReadLine();
            Console.Write("Nhập tuổi: ");
            age = int.Parse(Console.ReadLine());

            //In
            Console.WriteLine(name);
            Console.WriteLine(age);


            //Chuyển đổi kiểu ép
            double x = 10.59;
            Console.WriteLine("Kiểu số thực {0} ", x);
            int y = (int) x;
            Console.WriteLine("Ép kiểu double -> int " + y);

            /*
            //Các cấu trúc điều khiển
            // if
            // __________if đơn

            Console.WriteLine("Nhập vào một số: ");
            int n = int.Parse(Console.ReadLine());
            if(n > 10)
            {
                Console.WriteLine("{0} > 10 ", n);
            }


            // if - else
            //Kiểm tra các số n là số chẵn hay lẻ
            if(n % 2 == 0)
            {
                Console.WriteLine("{0} là số chẵn", n);

            }
            else
            {
                Console.WriteLine("{0} là số lẻ", n);
            }

            //cấu trúc switch
            //nhập một số (1 chữ số) -> đọc thành lời việt
            int num;
            Console.Write("Num = ");
            num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 0:
                    Console.WriteLine("Không");
                    break;
                case 1:
                    Console.WriteLine("Một");
                    break;
                    case 2:
                    Console.WriteLine("Hai");
                    break;
                    case 3: Console.WriteLine("Ba");
                    break;
                    case 4: Console.WriteLine("Bốn");
                    break;
                    case 5: Console.WriteLine("Năm");
                    break;
                    case 6: Console.WriteLine("Sáu");
                    break;
                    case 7: Console.WriteLine("Bảy");
                    break;
                    case 8: Console.WriteLine("Tám");
                    break;
                    case 9: Console.WriteLine("Chín");
                        break;
                    case 10: Console.WriteLine("Mười");
                    break;
                    default: Console.WriteLine("Nhập sai");
                    break;
            }
            */
            
            //lặp : for
            for (byte  i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("=========khuyết");
            for (byte i = 0; ; i++)
            {
                Console.WriteLine(i);
                if (i == 9) break;
            }
            Console.WriteLine("=========khuyết");
            for(byte i = 0; ;)
            {
                Console.WriteLine(i);
                i++;
                if (i == 9) break;
            }
            Console.WriteLine("=======khuyết");
            int j =0;
            for(; ; )
            {
                Console.WriteLine(j);
                j++;
                if (j == 9) break;
            }
            Console.WriteLine("======nobody");
            for (int i = 0; i < 10; Console.WriteLine(i), i++) ;

            // white
            x = 0;
            while (x < 10)
            {
                Console.WriteLine(x);
                x++;
            }

            bool flag = true;
            while (flag = !flag)
            {
                Console.WriteLine(flag);
            }

            //true
            flag = true;
            while (flag = !flag)
            {
                Console.WriteLine(flag);
            }
            //không thực hiện
            flag = true;
            while (!flag)
            {
                Console.WriteLine(flag);
            }
            flag = false;
            while (!flag)
            {
                Console.WriteLine(flag);
            }

            //do...while; foreach

        }
    }
}
