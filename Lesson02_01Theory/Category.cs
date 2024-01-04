using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02_01Theory
{
    // <sumary>
    //
    // <sumary>
    public class Category
    {
        // member: Field / properties( attribute)
        //Field: 
        private int id;
        private string name;

        // Prop
        public int Id { 
            get { return id; } 
            set { id = value; } 
        }

        public string Name { get; set; }
        /*
        private string _Name;
        public string Name{
            get { return _Name;}
            set { _Name = value;}
        }
         */
        // Method 
        public void Display()
        {
            Console.WriteLine("Id\t: " + Id);
            Console.WriteLine("Name\t: " +  Name);
        }
    }
}
