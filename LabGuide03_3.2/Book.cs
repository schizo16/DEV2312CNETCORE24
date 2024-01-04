using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabGuide03_3._2
{
    internal class Book
    {
        private string Author {  get; set; }
        private string Page { get; set; }
        private string Isbn { get; set; }
        private string Title { get; set; }
        private int Curentpage { get; set; }

        //Constructor mac dinh va thiet lap currentpage cho 1
        public Book()
        {
            Curentpage = 1;
        }
        //constructor voi cac tham so de khoi tao cac truong tuong ung

        public Book(string author, string page, string isbn, string title, int curentpage)
        {
            Author = author;
            Page = page;
            Isbn = isbn;
            Title = title;
            Curentpage = curentpage;
        }


        //Pt flipPageForward

        public void flipPageForward()
        {
            Curentpage++;
            Console.WriteLine("Lat trang sau " + Curentpage);
        }

        //Pt plipPageBackward
        public void flipPageBackward()
        {
            if (Curentpage > 1)
            {
                Curentpage--;
                Console.WriteLine("Lat trang truoc " + Curentpage);
            }
            else
            {
                Console.WriteLine("Khong the lat trang dau.");
            }

        }

        public void Display()
        {
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Pages: "+ Page);
            Console.WriteLine("Isbn: " + Isbn);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Current Page: " + Curentpage);
        }


    }
}
