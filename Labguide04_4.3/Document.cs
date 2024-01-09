using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labguide04_4._3
{
    internal class Document: IStorage, IEncrytable
    {
        public string Data { get; set; }
        public void Write(string data)
        {
            Data = data;
            Console.WriteLine("Du lieu duoc luu tru.");
        }
        public string Read()
        {
            Console.WriteLine("Doc du lieu cua tai lieu: " + Data);
            return Data;
        }
        public void Encrypt()
        {
            Console.WriteLine("Du lieu da duoc ma hoa.");
        }
        public void Decrypt()
        {
            Console.WriteLine("Du lieu da duoc giai ma.");
        }
    }
}
