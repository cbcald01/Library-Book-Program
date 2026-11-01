//Channel Caldwell
//Program 4
//Due Date: 04/17/2025
//CIS 199:50
//This program uses a reusable class and then a seperate class that gathers the information about the books in an object list.
//It then displays the given book information and then displays the changes that are made to each of the books information 
/*Answers to questions: 
1)You would use a protected access level for the feed() method.
2)A class property is a member of a class that provides access to a field of a class. Properties have get and set accessors. 
We use class properties because we can store private data and not let anyone touch/manipulate it, example is a private backing field. 
The prperty is able to talk to the baking field, the data directly. We use property instead of backing field because we don't want to 
give access to anyone so it basically protects the backing field data.
3)If we do not provide a constructor C# automatically provides a public constructor, which is paramerterless (takes no argument).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program4Spring2025
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //information for each book using the LibraryBook class
            LibraryBook book1 = new LibraryBook("Verity", 6.99, 281, 5, true);
            LibraryBook book2 = new LibraryBook("Dune", 11.99, 794, 1, true);
            LibraryBook book3 = new LibraryBook("It Ends with Us", 8.50, 321, 6, false);
            LibraryBook book4 = new LibraryBook("Pride and Prejudice", 18.99, 180, 7, true);
            LibraryBook book5 = new LibraryBook("1984", 6.99, 328, 3, true);

            LibraryBook[] libraryBooks = new LibraryBook[] { book1, book2, book3, book4, book5 };//adds books to array

            WriteLine(" ");//adds space
            WriteLine("**********Before Change**********");//shows before the change
            WriteLine(" ");//adds space
            DisplayBooks(libraryBooks);

            //changes to each book
            book1.RetailPrice = 10.99;//price increase
            book2.TimesBorrowed = 2;//book borrowed went up by 1
            book3.MakeAvailable();//book is available now
            book4.RetailPrice = 11.99;//pice decrease
            book5.MakeUnavailable();//book has been checked out and is now unavailable

            WriteLine(" ");//adds space
            WriteLine("**********After Change**********");//shows after the changes have been made
            WriteLine(" ");//adds space
            DisplayBooks(libraryBooks);
        }


            public static void DisplayBooks(LibraryBook[] books)//method to print each books data by accepting the LibraryBook array 
            {
            foreach (LibraryBook book in books)
                {
                    WriteLine(book.ToString());
                    WriteLine("----------------------------------------------------------------------------");//adds line between each book info
                }


            }

        }

    }

