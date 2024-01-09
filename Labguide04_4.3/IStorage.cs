using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labguide04_4._3
{
    internal interface IStorage
    {
        public string Data { get; set; }
        void Write(string data);
        string Read();
    }
}
