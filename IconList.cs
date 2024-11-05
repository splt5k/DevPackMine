// Decompiled with JetBrains decompiler
// Type: DevPackMine.IconList
// Assembly: DevPackMine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\DevPackMine\DevPackMine\DevPackMine.exe

using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace DevPackMine
{
  public class IconList
  {
    public static System.Collections.Generic.List<ticon> List = new System.Collections.Generic.List<ticon>();
        public static string LoadFromDatabaseSQL = "SELECT a_index, a_name_ger, a_name_usa, a_name_frc, a_name_pld, a_name_brz, a_name_rus, a_name_mex, a_name_spn, a_name_thai, a_name_ita, a_texture_id, a_texture_row, a_texture_col, a_descr  FROM t_item ORDER BY a_index";
        public static Connection connection = new Connection();
    public static string Host = IconList.connection.ReadSettings("Host");
    public static string User = IconList.connection.ReadSettings("User");
    public static string Password = IconList.connection.ReadSettings("Password");
    public static string Database = IconList.connection.ReadSettings("Database");
    public static string language = IconList.connection.ReadSettings("Language");//dethunter12 language selection
    public static MySqlConnection mysqlCon;
    public static string ConnectionString;
    public static string namee; //dethunter12 stringfrom lang modify

    public static string StringFromLanguage() //dethunter12 5/10/2018
        {

            if (language == "GER")
            {
                namee = "a_name_ger";
                return namee;

            }
            else if (language == "POL")
            {
                namee = "a_name_pld";
                return namee;

            }
            else if (language == "BRA")
            {
                namee = "a_name_brz";
                return namee;
            }
            else if (language == "RUS")
            {
                namee = "a_name_rus";
                return namee;
            }
            else if (language == "FRA")
            {
                namee = "a_name_frc";
                return namee;
            }
            else if (language == "ESP")
            {
                namee = "a_name_spn";
                return namee;
            }
            else if (language == "MEX")
            {
                namee = "a_name_mex";
                return namee;
            }
            else if (language == "THA")
            {
                namee = "a_name_thai";
                return namee;
            }
            else if (language == "ITA")
            {
                namee = "a_name_ita";
                return namee;
            }
            else if (language == "USA")
            {
                namee = "a_name_usa";
                return namee;
            }
            else
            {
                namee = "a_name";
                return namee;
            }
        }
     public static bool SetConnection()
    {
      IconList.ConnectionString = string.Format("Data Source={0};Database={1};User ID={2};Password={3};",  IconList.Host,  IconList.Database,  IconList.User,  IconList.Password);
      return true;
    }

    public static DataTable GetFromQuery(string query)
    {
      DataTable dataTable = new DataTable();
      using (IconList.mysqlCon = new MySqlConnection(IconList.ConnectionString))
      {
        IconList.mysqlCon.Open();
        MySqlDataReader mySqlDataReader = MySqlHelper.ExecuteReader(IconList.mysqlCon, query);
        dataTable.Load((IDataReader) mySqlDataReader);
        IconList.mysqlCon.Close();
      }
      return dataTable;
    }

    public static void Import()
    {
            namee = StringFromLanguage(); //dethunter12 test
            foreach (DataRow row in (InternalDataCollectionBase)IconList.GetFromQuery(IconList.LoadFromDatabaseSQL).Rows)

                IconList.List.Add(new ticon()
                {
                  
          ItemID = Convert.ToInt32(row["a_index"]),
          FileID = Convert.ToInt32(row["a_texture_id"]),
          Row = Convert.ToInt32(row["a_texture_row"]),
          Col = Convert.ToInt32(row["a_texture_col"]),
          Name = Convert.ToString(row[namee]), //dethunter12 test
          Desc = Convert.ToString(row["a_descr"])
        });
    }
  }
}
