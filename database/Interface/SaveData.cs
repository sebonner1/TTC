using System;
using System.Data.SQLite;

namespace database
{
    public class SaveData
    {
        public void SaveBook()
        {
            string cs = @"URI=file:C:/Users/williambonner/Source/repos/database/book.db";// @ makes backlashes a string
            using var con = new SQLiteConnection(cs);
            con.Open();

            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = "DROP TABLE IF EXISTS books";
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"CREATE TABLE books(id INTERGER PRIMARY KEY, title TEXT, author TEXT");
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"INSERT INTO books(title, author) VALUES(@title,@author)";
            cmd.Parameters.AddWithValue("@title", "Oathbringer");
            cmd.Parameters.AddWithValue("@author", "Brandon Sanderson");
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}