using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_4
{
    internal class Chapter
    {
        private string name;
        private string content;
        public Chapter()
        {
            name = "";
            content = "";
        }

        public Chapter(string name, string content)
        {
            this.name = name;
            this.content = content;
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public string Name { get; internal set; }

        public override string ToString()
        {
            return name + "\n" + content;
        }
    }
}
