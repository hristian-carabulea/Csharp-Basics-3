using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics_3
// Create class Book in Visual Studio: 
// - Open Solution Explorer
// - Right-click on project name, and choose Add / New Item
// - Choose Class, tpye class name in "Name" field on the bottom of the window, and click on the "Add" button.
// - File Book.cs has been created. It can be seen in a separate window and in the Solution Explorer as well.

// Add the Book class. The class name should start with a capital letter.
// Give the Book class some attributes, e.g.:
/*class Book
    {
        public string title;
        public string author;
        public int numPages;
        public int publishingYear;
    }
*/

{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(); // an instance of the class Book
            //book1.title = "ВОЙНА и МИРЪ";
            //book1.author = "Лев Толстой";
            book1.title = "War and Peace";
            book1.author = "Leo Tolstoy";
            book1.numPages = 1225;
            book1.publishingYear = 1869;

            Console.WriteLine(); Console.WriteLine("The book " + "/" + book1.title + "/" + " was written by " + book1.author + ", and it was published in " + book1.publishingYear + ". The original print had " + book1.numPages + " pages.");

            Book book2 = new Book();
            book2.title = "Toate pânzele sus!";
            book2.author = "Radu Tudoran";
            book2.numPages = 524;
            book2.publishingYear = 1954;

            Console.WriteLine(); Console.WriteLine("The book " + book2.title + " was written by " + book2.author + ", and it was published in " + book2.publishingYear + ". The original print had " + book2.numPages + " pages.");

            Book book3 = new Book();
            book3.title = "Foundation";
            book3.author = "Isaac Asimov";
            book3.numPages = 255;
            book3.publishingYear = 1951;

            Console.WriteLine(); Console.WriteLine("The book " + book3.title + " was written by " + book3.author + ", and it was published in " + book3.publishingYear + ". The original print had " + book3.numPages + " pages.");

            // Declaration as below does not work for me
            // Book book4 = new Book("Harry Potter", "Joe", 1, 1);

            book3.numPages = 256; // one can change an object 

            Console.WriteLine();

            Reader reader1 = new Reader("Hristian", 25);
            Console.WriteLine("Reader 1 name: " + reader1.name + ". Reader 1 age: " + reader1.age + "\n");
            Reader reader2 = new Reader("Joe", 33);
            Console.WriteLine("Reader 2 name: " + reader2.name + ". Reader 2 age: " + reader2.age + "\n");

            Student student1 = new Student("Hari", "Computer Science", 3.41);
            Student student2 = new Student("Hristian", "MBA", 3.7);
            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());

            Console.WriteLine();

            Movie ooseven = new Movie("007", "Roger Moore", "*****");
            Console.WriteLine("The movie " + ooseven.title + " has a rating of " + ooseven.Rating + ".");
            Console.WriteLine("Movie count is " + Movie.movieCount);

            Movie simonTemple = new Movie("Simon Temple", "Roger Moore", "Shit");
            Console.WriteLine("The movie " + simonTemple.title + " has a rating of " + simonTemple.Rating + ".");
            Console.WriteLine("Movie count is " + Movie.movieCount);


            Console.ReadLine();

        }
    }
}
