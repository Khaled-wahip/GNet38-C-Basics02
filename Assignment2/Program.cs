using System.Runtime.InteropServices;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            /*Create a Book class with a Title(string) and Pages(int). Create a Book object and store it
            in a variable of type object.Print it.*/
         
            Book book= new Book();
            book.Title = "The Great Gatsby";// Assigning a title to the book
            book.Pages = 180; // Assigning the number of pages to the book
            Console.WriteLine($"Book Title: {book.Title}, Pages: {book.Pages}"); // Printing
            #endregion
        }
    }
}
    

