using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.IO;

namespace MysqlGyak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "",
                Database = "ingatlan"
            };
            MySqlConnection con = new MySqlConnection(builder.ConnectionString);
            con.Open();
            con.CreateCommand();

            var a = con.CreateCommand();

            a.CommandText = "SELECT * FROM sellers";
            //a.ExecuteQuery(); módosításhoz
            var reader = a.ExecuteReader();
            /*while (reader.Read())
            {
                Console.WriteLine(reader.GetInt32(0));
            }*/
            reader.Close(); 
            Console.ReadKey();

        }
    }
}
