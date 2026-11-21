using System.Threading.Channels;

namespace c_basics_session02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question(1)
            // 1-Create a Book class with a Title (string) and Pages (int).
            // 1-Create a Book object and store it in a variable of type object. Print it.
            //object obj = new Book { Title = "Clean Code", Pages = 464 };
            //Console.WriteLine(obj);
            #endregion
            #region Question(2)
            // 2-Using the Book class above, print the result of calling ToString(),
            // Equals() (compare book with itself), GetHashCode(), and GetType() on book.
            //Book book = new Book { Title = "Clean Code", Pages = 464 };
            //Console.WriteLine(book.ToString());
            //Console.WriteLine(book.Equals(book));  
            //Console.WriteLine(book.GetHashCode());
            //Console.WriteLine(book.GetType());
            #endregion
            #region Question(3)
            // 3-Look at the line below. Is it a compile-time error, a runtime error,
            // or a logical error? Fix it.
            // int pages = "464";
            //int Pages = 464; //Compile-time error
            //Console.WriteLine(Pages); 
            #endregion
            #region Question(4)
            // 4-Write code that divides 10 by 0 inside a try block, catches the exception,
            // prints "Cannot divide by zero", and then prints "Done" in a finally block.
            //try
            //{
            //    int zero = 0;
            //    int result = 10 / zero;
            //    Console.WriteLine(result);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}
            #endregion
            #region Question(5)
            // 5-Declare an int pages = 300; then store it in a double variable without using a cast.
            //int pages = 300;
            //double Double = pages;   // implicit casting
            //Console.WriteLine(Double);
            #endregion
            #region Question(6)
            // Declare a double price = 49.99; then convert it into an int using a cast.
            //double price = 49.99;
            //int intprice = (int)price;// Explicit casting 
            //Console.WriteLine(intprice);
            #endregion
            #region Question(7)
            // Given string pagesText = "464";, convert it into an int using the Convert class.
            //string pagesText = "464";
            //int convInt = Convert.ToInt32(pagesText);
            //Console.WriteLine(convInt);
            //int karim;
            //karim = convInt + 5;
            //Console.WriteLine(karim); // The convert process was successful because the addition process was successful.
            // This step is an extra one I’ve added for confirmation.
            #endregion
            #region Question(8)
            // Given string yearText = "2023";, convert it using int.Parse().
            // Then given string badText = "abc";, use int.TryParse() to safely try
            // converting it, and print "Invalid number" if it fails.
            //string yearText = "2023";
            //int yearInt = int.Parse(yearText);
            //Console.WriteLine(yearInt);
            //string badText = "abc";
            //if (int.TryParse(badText, out int badInt))
            //          Console.WriteLine(badInt);
            //else
            //    Console.WriteLine("Invalid number");
            #endregion
            #region Question(9)
            // Given int pages = 464;, convert it into a string using ToString()
            // and print its type using GetType() to prove it's now a string.
            //int pages = 464;
            //string pagesString = pages.ToString();
            //Console.WriteLine(pagesString.GetType());
            //string total;
            //total = pagesString + 55;
            //Console.WriteLine(total); // proved it
            #endregion
            #region Question(10)
            // Declare int copies = 100;. Box it into an object variable,
            // then unbox it back into a new int variable, and print both.
            //int copies = 100;
            //object BoxingCopies = copies;
            //int UnBoxingCopies = (int)BoxingCopies;
            //Console.WriteLine(BoxingCopies);
            //Console.WriteLine(UnBoxingCopies);
            #endregion
            #region Question(11)
            // Declare an int? year = null;. Print whether it has a value,
            // then assign it 2023 and print its value.
            //int? year = null;
            //Console.WriteLine(year.HasValue);
            //year = 2023;
            //Console.WriteLine(year.Value);
            #endregion

            #region Question(12)
            // Declare a string? reviewer = null;. Print whether it is null.
            string ? reviewer = null;
            Console.WriteLine(reviewer==null);
            #endregion



        }

    }
    }
