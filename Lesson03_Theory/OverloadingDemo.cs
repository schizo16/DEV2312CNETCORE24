using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Theory
{
    /// <summary>
    /// Cài đặt tính chất đa hình trong OOP
    /// - Có cùng tên
    /// - danh sách tham số giống thì phải khác nhau
    /// - 
    /// </summary>
    internal class OverloadingDemo
    {
        public int Sum(int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += i;
            }
            return tong;
        }

        public int Sum(int a, int b)
        {
            int tong = 0;
            for (int i = a; i<=b; i++)
            {
                tong += i;
            }
            return tong;
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static double Add(double a, double b)
        {
            return a + b;
        }
    }
}
