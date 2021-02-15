using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelektika_1A
{
    public class Database
    {
        SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=Sport.db; Version = 3; New = True; Compress = True; ");
        public List<Sport> GetData()
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "Select Height, Weight, Sport, Position From Sport";
            SQLiteDataReader sQLiteDataReader = sqlite_cmd.ExecuteReader();
            List<Sport> list = new List<Sport>();
            while (sQLiteDataReader.Read())
            {
                string X = sQLiteDataReader.GetString(0);
                string Y = sQLiteDataReader.GetString(1);
                string Z = sQLiteDataReader.GetString(2);
                string klass = sQLiteDataReader.GetString(3);
                list.Add(new Sport { height = X, weight = Y, sport = Z, position = klass });
            }
            sqlite_conn.Close();
            return list;
        }
        public List<Sport> GetSportData()
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "Select Height, Weight From Sports";
            SQLiteDataReader sQLiteDataReader = sqlite_cmd.ExecuteReader();
            List<Sport> list = new List<Sport>();
            while (sQLiteDataReader.Read())
            {
                string X = sQLiteDataReader.GetString(0);
                string Y = sQLiteDataReader.GetString(1);
                list.Add(new Sport { height = X, weight = Y });
            }
            sqlite_conn.Close();
            return list;
        }
        public List<Sport> GetSpecificData(string sport)
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "Select Height, Weight, Sport, Position From Sport WHERE Sport = '"+ sport +"' ";
            SQLiteDataReader sQLiteDataReader = sqlite_cmd.ExecuteReader();
            List<Sport> list = new List<Sport>();
            while (sQLiteDataReader.Read())
            {
                string X = sQLiteDataReader.GetString(0);
                string Y = sQLiteDataReader.GetString(1);
                string Z = sQLiteDataReader.GetString(2);
                string klass = sQLiteDataReader.GetString(3);
                list.Add(new Sport { height = X, weight = Y, sport = Z, position = klass }); ;
            }
            sqlite_conn.Close();
            return list;
        }

        public void AddPerson(string height, string weight, string sport, string position)
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO Sport (Height, Weight, Sport,Position) VALUES('" + height + "' ,'" + weight + "','" + sport + "','" + position + "'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }
        public void DeletePerson(string height, string weight)
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "DELETE FROM Sports WHERE Height = '" + height + "' AND Weight = '" + weight + "'";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }

    }
}
