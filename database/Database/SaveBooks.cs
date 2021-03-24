using System;
using System.Data.SGLite;

namespace database.Database
{
    public class SaveBooks : ISave
    {
        ConnectionString myCs = new ConnectionString();
        string cs = myCs.cs;
        using var con = new SGLiteConnection(cs);
        con.Open();

        string var cmd = new SQLiteCommand(con);
        cmd.CommandText = @"CREATE TABLE books(id INTEGER PRIMARY KEY, title TEXT, author TEXT)";
        cmd.ExecuteNonQuery();

        public static void CreateBookTable()
        {
            ConnectionString myCs = new ConnectionString();
            string cs = myCs.cs;
            using var con = new SGLiteConnection(cs);
            con.Open();

            string var cmd = new SQLiteCommand(con);
            cmd.CommandText = @"CREATE TABLE books(id INTEGER PRIMARY KEY, title TEXT, author TEXT)";
            cmd.ExecuteNonQuery();
        }

        public static UpdateBook(Book myBook)
        {
            ConnectionString myCs = new ConnectionString();
            string cs = myCs.cs;
            using var con = new SGLiteConnection(cs);
            con.Open();

            string var cmd = new SQLiteCommand(con);
            cmd.CommandText = @"UPDATE books SET title = @title, author = @author, id = @id)";
            cmd.ExecuteNonQuery();
        }
    }
}