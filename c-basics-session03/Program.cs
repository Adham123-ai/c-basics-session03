using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace c_basics_session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            ///Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle.Print
            ///both title and upperTitle to show that title did not change.
            ///string title = "clean code";
            ///string upperTitle = title.ToUpper();
            ///Console.WriteLine(title);
            ///Console.WriteLine(upperTitle);


            #endregion
            #region Q2
            /// Declare two separate string variables, both set to the literal "Clean Code".Use ReferenceEquals()
            ///to check if they point to the same object in memory.
            /// string title1 = "Clean Code";
            ///string title2 = "Clean Code";
            ///Console.WriteLine(Object.ReferenceEquals(title1,title2));

            #endregion
            #region Q3
            ///Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
            ///object.Print the final result.

            /// StringBuilder book = new StringBuilder();

            ///book.Append("Book List");

            ///book.Append(" - Updated");

            ///Console.WriteLine(book);


            #endregion
            #region Q4
            //  Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
            //Print the result.
            ///book.Replace("Book List","Library");
            ///Console.WriteLine(book);
            #endregion
            #region Q5
            /// Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
            ///Pages: 464" using the + operator.
            ///string title = "Clean Code";
            ///int pages = 464;
            ///Console.WriteLine("Book:" + title +"Pages"+pages);


            #endregion
            #region Q6
            //  Build the same sentence as above, but using string interpolation ($"...").
            ///Console.WriteLine($"Book:{title} pages:{pages}");

            #endregion
            #region Q7
            /// Console.WriteLine("Book:{0}pages{1}",title,pages);
            #endregion
            #region Q8
            ///Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than
            ///300, otherwise prints "Short Book".
            int pages = 464;
            if (pages >= 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }


            #endregion


        }
    }
}
