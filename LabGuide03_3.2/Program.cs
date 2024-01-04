namespace LabGuide03_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book("AuthorName", "500", "123456789", "Sample Book", 1);

            
            myBook.flipPageForward();
            
            myBook.flipPageBackward();
            myBook.Display();

        }
    }
}
