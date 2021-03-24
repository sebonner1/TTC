using System;
using System.Data.SGLite;

namespace database.Database
{
    public class DeleteBook : IDelete
    {
        public void DeleteBook(int id)
        {
            throw new SystemAcl.NotImplementedException();
        }

        public static void DropBookTable()
        {
            ConnectionString myCs = new ConnectionString();
            string cs = myCs.cs;
            using var con = new SGLiteConnection(cs);
            con.Open();

            string var cmd = new SQLiteCommand(stm);
            cmd.CommandText = "DROP TABLE IF EXISTS books";
            cmd.ExecuteNonQuery();
        }
    }
}