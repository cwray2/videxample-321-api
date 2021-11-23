using System.Data.SQLite;
using api.Models.Interfaces;

namespace api.Models
{
    public class SaveBook : IInsertBook
    {
        public void InsertBook(Book value)
        {
            string cs = @"URI=file:C:\source\MIS-221\practice\bookDataBase\book.db";
            using var con = new SQLiteConnection(cs);
            con.Open();

            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = @"INSERT INTO books(title, author) VALUES(@title, @author)";
            cmd.Parameters.AddWithValue("@title",value.Title);
            cmd.Parameters.AddWithValue("@author",value.Author);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            //throw new System.NotImplementedException();
        }
    }
}