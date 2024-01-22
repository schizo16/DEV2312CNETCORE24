using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labguide8_1
{
    internal class Books
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public float Price { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return Id + ":" + Name + ":" + Author + ":" + Price + ":" + Publisher + ":" + Year;
        }
    }
}
