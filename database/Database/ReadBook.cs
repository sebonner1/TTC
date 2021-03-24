using System;
using System.Collections.Generic;

namespace database.Database
{
    public class ReadBook
    {
        public List<Book> ReadAllBooks()
        {
            ConnectionString myCs = new ConnectionString();
            string cs = myCs.cs;
            using var con = new SGLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM books";
            using var cmd = new SQLiteCommand(stm, con);

            using SQLiteDataReader rdr = cmd.ExecuteReader();

            List<Book> myBooks = new List<Book>();

            while(rdr.Read()){
                myBooks.Add(new ReadBook(){Id = rdr.GetInt32(0), Title = rdr.GetString(1), Author = rdr.GetString(2)});
            }

            return myBooks;
        }
    }
}