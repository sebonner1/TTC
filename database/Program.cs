using System;
using System.Collections.Generic;
using System.Data.SGLite;
using database.Database;

namespace database
{
    class Program
    {
        static void Main(string[] args)
        {
            // string cs = @"URI=file:C:/Users/williambonner/Source/repos/database/book.db";// @ makes backlashes a string

            // using var con = new SGLiteConnection(cs); // using the word using to drop connection when we're out of scope
            // con.Open();

            // // SQL Statement
            // string stm = "select SQLITE_VERSION()";
            // using var cmd = new SQLiteCommand(stm, con);

            // string version = cmd.ExecuteScalar().ToString();
            // Console.WriteLine($"SQLite version: {version}");

            ISave saveObject = new SaveData();
            saveObject.SeedData();

            // DeleteBooks.DropBookTable();
            // DeleteBooks.CreateBookTable();

            // Book myBook = new Book(){Title = "Mistborn", Author = "Brandon Sanderson"};
            
            // // myBook.SaveBehavior.SaveBook(myBook);

            // Book yourBook = new Book(){Title = "Lord of the Rings", Author = "Tolkin"};

            // // yourBook.SaveBehavior.SaveBook(yourBook);

            // Book userBook = new Book;

            Console.WriteLine("Enter the title:");
            userBook.Title = Console.ReadLine();
            Console.WriteLine("Enter the author:");
            userBook.Author = Console.ReadLine();

            userBook.SaveBehavior.CreateBook(userBook);

            IRead myReader = new ReadBook();

            List<Book> myBooks = myReader.ReadAllBooks();

    
        }
    }
}
