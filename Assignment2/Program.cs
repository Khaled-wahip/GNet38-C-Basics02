using System.Runtime.InteropServices;
class Book
{
    public string Title;
    public int Pages;
}
namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question1
            /*Create a Book class with a Title(string) and Pages(int). Create a Book object and store it
            in a variable of type object.Print it.*/
            /* Book book = new Book();
             book.Title = "The Great Gatsby";// Assigning a title to the book
             book.Pages = 180; // Assigning the number of pages to the book


             Console.WriteLine($"Book Title: {book.Title}, Pages: {book.Pages}"); */// Printing




            #endregion
            #region Question2
            /*Using the Book class above, print the result of calling ToString(), Equals() (compare book
            with itself), GetHashCode(), and GetType() on book.*/
            //  Book book = new Book();
            //    book.Title = "The Great Gatsby";
            //  book.Pages = 180;
            // Console.WriteLine($"ToString(): {book.ToString()}");
            // Console.WriteLine($"Equals(): {book.Equals(book)}");
            //  Console.WriteLine($"GetHashCode(): {book.GetHashCode()}");
            //  Console.WriteLine($"GetType(): {book.GetType()}");


            #endregion
            #region  Question3
            /*
             * Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            int pages = "464";*/
            //   a compile-time error
            #endregion
        }
    }
}


