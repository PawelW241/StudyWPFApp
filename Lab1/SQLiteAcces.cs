using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab1
{
    internal class SQLiteAcces
    {
        public static string DbFile = Path.Combine(Environment.CurrentDirectory, "database.db");
        private static string Connection = string.Format("Data Source= {0}", DbFile);
        public static bool CreateTable()
        {
            bool IsCreated = false;
            SQLiteConnection DatabaseConnection = new SQLiteConnection(Connection);
            DatabaseConnection.Open();

            if (DatabaseConnection.State == ConnectionState.Open)
            {
                string Query = string.Format("CREATE TABLE IF NOT EXISTS Instrumenty(Id INTEGER PRIMARY KEY AUTOINCREMENT, Nazwa TEXT, Stroj TEXT, Podgrupa TEXT, Skala TEXT, Opis TEXT, Zdjecie TEXT)");
                SQLiteCommand DatabaseCommand = new SQLiteCommand(Query,DatabaseConnection);
                int result = DatabaseCommand.ExecuteNonQuery();
                if (result == 0)
                {
                    IsCreated = true;
                }
            }
            DatabaseConnection.Close();
            return IsCreated;
        }
        public static bool Create(TablePattern DefaultItem)
        {
            bool IsCreated = false;
            SQLiteConnection DatabaseConnection = new SQLiteConnection(Connection);
            DatabaseConnection.Open();
            if (DatabaseConnection.State == ConnectionState.Open)
            {
                string Query = string.Format("SELECT COUNT(Id) FROM Instrumenty Where Nazwa = '{0}'", DefaultItem.Nazwa);
                SQLiteCommand DatabaseCommand = new SQLiteCommand(Query, DatabaseConnection);
                int result = Convert.ToInt32(DatabaseCommand.ExecuteScalar());
                if (result == 0)
                {
                    Query = String.Format("INSERT INTO Instrumenty(Nazwa, Stroj, Podgrupa, Skala, Opis, Zdjecie) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", DefaultItem.Nazwa, DefaultItem.Stroj, DefaultItem.Podgrupa, DefaultItem.Skala, DefaultItem.Opis, DefaultItem.Zdjecie );
                    DatabaseCommand.CommandText = Query;
                    if (DatabaseCommand.ExecuteNonQuery() == 1)
                    {
                        IsCreated = true;
                    }
                }
            }
            DatabaseConnection.Close();
            return IsCreated;
        }
        public static bool Delete(TablePattern DefaultItem)
        {
            bool IsDeleted = false;
            SQLiteConnection DatabaseConnection = new SQLiteConnection(Connection);
            DatabaseConnection.Open();
            if (DatabaseConnection.State == ConnectionState.Open)
            {
                string Query = string.Format("SELECT COUNT(Id) FROM Instrumenty Where Nazwa = '{0}'", DefaultItem.Nazwa);
                SQLiteCommand DatabaseCommand = new SQLiteCommand(Query, DatabaseConnection);
                int result = Convert.ToInt32(DatabaseCommand.ExecuteScalar());
                if (result == 1)
                {
                    Query = String.Format("DELETE FROM Instrumenty WHERE Id = {0}", DefaultItem.Id);
                    DatabaseCommand.CommandText = Query;
                    if (DatabaseCommand.ExecuteNonQuery() == 1)
                    {
                        IsDeleted = true;
                    }
                }
            }
            DatabaseConnection.Close();
            return IsDeleted;
        }
        public static List<TablePattern> Read()
        {
            List<TablePattern> DefaultList = new List<TablePattern>();
            SQLiteConnection DatabaseConnection = new SQLiteConnection(Connection);
            DatabaseConnection.Open();
            if (DatabaseConnection.State == ConnectionState.Open)
            {
                string Query = string.Format("SELECT * FROM Instrumenty");
                SQLiteCommand DatabaseCommand = new SQLiteCommand(Query, DatabaseConnection); 
                SQLiteDataReader DatabaseReader = DatabaseCommand.ExecuteReader();
                while (DatabaseReader.Read())
                {
                    TablePattern TablePattern = new TablePattern()
                    {
                        Id = Convert.ToInt32(DatabaseReader["Id"]),
                        Nazwa = DatabaseReader["Nazwa"].ToString(),
                        Stroj = DatabaseReader["Stroj"].ToString(),
                        Podgrupa = DatabaseReader["Podgrupa"].ToString(),
                        Skala = DatabaseReader["Skala"].ToString(),
                        Opis = DatabaseReader["Opis"].ToString(),
                        Zdjecie = DatabaseReader["Zdjecie"].ToString(),
                    };
                    DefaultList.Add(TablePattern);
                }
            }
            DatabaseConnection.Close();
            return DefaultList;
        }
        public static List<TablePattern2> Read2()
        {
            List<TablePattern2> DefaultList = new List<TablePattern2>();
            SQLiteConnection DatabaseConnection = new SQLiteConnection(Connection);
            DatabaseConnection.Open();
            if (DatabaseConnection.State == ConnectionState.Open)
            {
                string Query = string.Format("SELECT * FROM Instrumenty");
                SQLiteCommand DatabaseCommand = new SQLiteCommand(Query, DatabaseConnection);
                SQLiteDataReader DatabaseReader = DatabaseCommand.ExecuteReader();
                while (DatabaseReader.Read())
                {
                    TablePattern2 TablePattern = new TablePattern2()
                    {
                        Nazwa = DatabaseReader["Nazwa"].ToString(),
                        Stroj = DatabaseReader["Stroj"].ToString(),
                        Podgrupa = DatabaseReader["Podgrupa"].ToString(),
                        Skala = DatabaseReader["Skala"].ToString(),
                    };
                    DefaultList.Add(TablePattern);
                }
            }
            DatabaseConnection.Close();
            return DefaultList;
        }
        public static bool Update(TablePattern DefaultItem)
        {
            bool IsUpdate = false;
            SQLiteConnection DatabaseConnection = new SQLiteConnection(Connection);
            DatabaseConnection.Open();
            if (DatabaseConnection.State == ConnectionState.Open)
            {
                string Query = string.Format("SELECT COUNT(Id) FROM Instrumenty Where Nazwa = '{0}'", DefaultItem.Nazwa);
                SQLiteCommand DatabaseCommand = new SQLiteCommand(Query, DatabaseConnection);
                int result = Convert.ToInt32(DatabaseCommand.ExecuteScalar());
                if (result == 1)
                {
                    Query = String.Format("UPDATE Instrumenty SET Stroj = '{0}', Skala = '{1}', Opis = '{2}', Zdjecie = '{3}' WHERE Id = {4}", DefaultItem.Stroj, DefaultItem.Skala, DefaultItem.Opis, DefaultItem.Zdjecie, DefaultItem.Id);
                    DatabaseCommand.CommandText = Query;
                    if (DatabaseCommand.ExecuteNonQuery() == 1)
                    {
                        IsUpdate = true;
                    }
                }
            }
            DatabaseConnection.Close();
            return IsUpdate;
        }
    }
}
