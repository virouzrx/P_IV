using System;
using System.Data.SqlClient;
namespace lab1netcore
{
    class Program
    {
        static void Main()
        {
            var connectionStrig = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; 
            using var connection = new SqlConnection(connectionStrig);

            var db = new klasa_db();
            connection.Open();


            //db.Select(connection);
            db.Update(connection, 1488, "Bielsko");
            db.Select(connection);
            connection.Close();
        }


    }
}