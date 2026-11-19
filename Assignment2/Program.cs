using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;
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
            #region  Question4
            /*Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot
            divide by zero", and then prints "Done" in a finally block.*/
            //int pages = 10;
            //int pages1 = 0;
            //try
            // {
            //  int average = pages / pages1;
            // }
            // catch (Exception error)
            //  {
            //       Console.WriteLine($"Error: {error.Message}");
            //   }
            //finally
            //  {                Console.WriteLine("Done");
            // }

            #endregion
            #region Question5
            //Declare an int pages = 300; then store it in a double variable without using a cast.
            // int pages = 300;
            ///double pagesDouble = pages;
            // Console.WriteLine($"Pages as double: {pagesDouble}");
            #endregion
            #region Question6
            //Declare a double price = 49.99; then convert it into an int using a cast.
            // double price =49.99;
            //int priceInt = (int)price;
            //Console.WriteLine($"Price as int: {priceInt}");
            #endregion
            #region Question7
            //Given string pagesText = "464";, convert it into an int using the Convert class.
            // string pagesText = "464";
            // int pagesInt = Convert.ToInt32(pagesText);
            //Console.WriteLine($"Pages as int: {pagesInt}");
            #endregion
            #region Question8
            //Given string yearText = "2023";, convert it using int.Parse(). Then given string badText =
            // "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            //string yearText = "2023";
            //int yearn = int.Parse(yearText);
            // Console.WriteLine(yearn);
            // string badText= "abc";
            //bool isparsed = int.TryParse(badText, out int kh);
            // Console.WriteLine(isparsed);
            // Console.WriteLine(kh);
            //  if(!isparsed)
            // {
            // Console.WriteLine("Invalid number");
            // }

            #endregion
            #region Question9
            //Given int pages = 464;, convert it into a string using ToString() and print its type using
            //   GetType() to prove it's now a string
            //int pages = 464;
            //string pag = pages.ToString();
            //Console.WriteLine(pag.GetType());
            #endregion
            #region Question10
            //Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int
            //variable, and print both.
            //int copies = 100;
            //object copiesObj = copies;
            //int copiesUnboxed = (int)copiesObj;
            //Console.WriteLine($"Copies: {copies}");
            //Console.WriteLine($"Copies (unboxed): {copiesUnboxed}");
            #endregion
            #region Question11
            //Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its
            //value.
            //int ? year = null;
            //if (year.HasValue)
            // {
            //Console.WriteLine($"Year has value: {year.Value}");
            //}
            //else
            //{
            //Console.WriteLine("Year is null.");
            //}
            //year = 2023;
            //Console.WriteLine($"Year has value: {year.Value}");


            #endregion
            #region Question12
            //Declare a string? reviewer = null;. Print whether it is null.
            /* string ? reviewer = null;
             if (reviewer == null)
             {
                 Console.WriteLine("Reviewer is null.");
             }
             else
             {
                 Console.WriteLine($"Reviewer: {reviewer}");
             }*/
            #endregion
            #region Question13
            //Declare a Book? book = null;. Use ?. to safely read book.Title without crashing the
            // program, and print the result.
            // string book = null;
            //book= Console.ReadLine();
            // Console.WriteLine($"Book Title: {book?.ToString() ?? "No title available"}");

            #endregion
            #region Question14
            //Using title from the previous question, use ?? to print "Untitled" if title is null. Then use ??=
            //to assign title the value "Untitled" only if it's still null.
            //string book = null;
            //if (book == null)
            //{
            //  Console.WriteLine("Untitled");
            //  book = "Untitled";
            //}
            // else
            //{
            //    Console.WriteLine($"Book Title: {book}");
            //}
            #endregion
            #region Question15
            //Given string? name = "Ahmed"; (you are sure it's not null here), assign it to a non-nullable
           //string confirmedName using the ! operator.
          // string name = "Ahmed";

            #endregion


        }
    }
}


