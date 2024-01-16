using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labguide06_1
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Title: {Title}, Author: {Author}, Publisher: {Publisher}, Year: {Year}, Price: {Price}";
        }
    }
}
