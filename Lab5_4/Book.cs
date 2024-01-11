using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_4
{
    internal class Book
    {
        private string name;
        private Chapter[] chapters;
        public Book() { }
        public Book(string name, int n)
        {
            this.name = name;
            chapters = new Chapter[n];
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                name = value;
            }

        }
        // indexer thứ nhất có một tham chiếu kiểu int
        public Chapter this[int index]
        {
            get
            {
                if (index < 0 || index > chapters.Length - 1)
                    return null;
                return chapters[index];
            }
            set
            {
                if ((index < 0) || (index > chapters.Length - 1))
                    throw new ArgumentOutOfRangeException();
                chapters[index] = value;
            }
        }

        // indexer thứ 2 có 1 tham số kiểu string overload indexer
        public Chapter this[string chapterName]
        {
            get
            {
                foreach (Chapter ch in chapters)
                {
                    if (ch != null && ch.Name == chapterName)
                    {
                        return ch;
                    }
                }
                return null;
            }
        }
    }
}
