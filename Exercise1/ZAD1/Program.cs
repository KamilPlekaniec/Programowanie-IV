using System;
using System.Data.SqlClient;

namespace ZAD1
{
    class Program
    {
        //Zadanie z ADONET

        static void Main(string[] args)
        {
            var db = new DB();
            var connectionString = "";
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            db.Select(connection);
            db.Insert(connection, 10,"Bielsko");
            db.Update(connection, 10, "Bielsko-Biała");
            db.Delete(connection, 10, "Bielsko");
            
            connection.Close();
        }
    }
}
