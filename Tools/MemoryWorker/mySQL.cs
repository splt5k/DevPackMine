// Decompiled with JetBrains decompiler
// Type: DevPackMine.Tools.MemoryWorker.mySQL
// Assembly: DevPackMine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\DevPackMine\DevPackMine\DevPackMine.exe

using MySql.Data.MySqlClient;
using System.Data;

namespace DevPackMine.Tools.MemoryWorker
{
  public class mySQL
  {
    public static MySqlConnection mysqlCon;
    public static string ConnectionString;

    public static bool SetConnection()
    {
      config.ReadConfig();
      mySQL.ConnectionString = config.ConfigString;
      return true;
    }

    public static DataTable GetFromQuery(string query)
    {
      DataTable dataTable = new DataTable();
      using (mySQL.mysqlCon = new MySqlConnection(mySQL.ConnectionString))
      {
        mySQL.mysqlCon.Open();
        MySqlDataReader mySqlDataReader = MySqlHelper.ExecuteReader(mySQL.mysqlCon, query);
        dataTable.Load(mySqlDataReader);
        mySQL.mysqlCon.Close();
      }
      return dataTable;
    }

        public static DataTable GetFromQueryIcon(string query)
        {
            DataTable dataTable = new DataTable();
            using (mySQL.mysqlCon = new MySqlConnection(mySQL.ConnectionString))
            {
                mySQL.mysqlCon.Open();
                MySqlDataReader mySqlDataReader = MySqlHelper.ExecuteReader(mySQL.mysqlCon, query);
                dataTable.Load(mySqlDataReader);
                mySQL.mysqlCon.Close();
            }
            return dataTable;
        }

        public static object SingleQuery(string query)
    {
      object obj;
      using (mySQL.mysqlCon = new MySqlConnection(mySQL.ConnectionString))
      {
        mySQL.mysqlCon.Open();
        obj = MySqlHelper.ExecuteScalar(mySQL.mysqlCon, query);
      }
      return obj;
    }

    public static void UpdateQuery(string query)
    {
      using (mySQL.mysqlCon = new MySqlConnection(mySQL.ConnectionString))
      {
        mySQL.mysqlCon.Open();
        MySqlHelper.ExecuteNonQuery(mySQL.mysqlCon, query);
      }
    }
  }
}
