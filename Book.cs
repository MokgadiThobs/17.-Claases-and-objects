using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Claases_and_objects
{
    internal class Classes_and_objects
    {
        static void Main(string[] args)
        {
            Book Book1 = new Book();// create a new book bject
            Book1.title = "Harry Potter";
            Book1.author = "JK Rowling";
            Book1.pages = 400;

            Book Book2 = new Book();
            Book2.title = "Lord of the rings";
            Book2.author = "Tolkein";
            Book2.pages = 900;

            Console.WriteLine(Book1.pages);
            Console.WriteLine(Book2.title);
            //freeze
            Console.ReadLine();
        }
    }
}
