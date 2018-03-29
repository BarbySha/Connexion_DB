using MySql.Data.MySqlClient;
using System.Data.OleDb;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Connexion_DB
{
    class Program
    {
        static IDbConnection BarbySha;
        static void Main(string[] args)
        {
            Connect();
            Connexion();
        }
        public static void Connexion()
        {
            BarbySha = new MySqlConnection();
            BarbySha.ConnectionString = "Database=db_mysql;datasource=localhost;user id=root;password=;port=3306;";
            BarbySha.Open();
               Console.WriteLine("Connexion réussie");
               Console.ReadLine();
        }
        public static void Connect()
        {
            BarbySha = new OleDbConnection();
            BarbySha.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/koug/Documents/DB_Access.mdb;";
            BarbySha.Open();
            Console.WriteLine("bravooooooooooo");
            Console.ReadLine();
 
        }

    }
}
