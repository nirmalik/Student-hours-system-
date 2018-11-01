using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PROJECT_19
{
    class conncection
    {
        private static SqlConnectionStringBuilder builder;
        private static SqlConnection connection;
        static public void connect()
        {
            //This function to creat initial connection it should be called first
            builder = new SqlConnectionStringBuilder();
            builder.DataSource = "scedata.database.windows.net";
            builder.UserID = "scedata";
            builder.Password = "Shadi1234";
            builder.InitialCatalog = "Branch_B";
            connection = new SqlConnection(builder.ConnectionString);
            connection.Open();
        }
        static public Dictionary<String, String> select(String dbName, String coulm, String value)
        {
            //This function will return a dictionary of the raw values 'rawName' : 'value'
            String sql = queryString(dbName, coulm, value);
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            Dictionary<String, String> dic = new Dictionary<String, String>();
            if (reader != null)
            {

                if (reader.Read())
                {
                    if (dbName == "Users")
                    {
                        dic.Add("id", reader[0].ToString());
                        dic.Add("firstName", reader[1].ToString());
                        dic.Add("lastName", reader[2].ToString());
                        dic.Add("userName", reader[3].ToString());
                        dic.Add("password", reader[4].ToString());
                        dic.Add("mail", reader[5].ToString());
                        dic.Add("address", reader[6].ToString());
                        dic.Add("phone", reader[7].ToString());
                        dic.Add("job", reader[8].ToString());
                    }
                }
            }
            
            return dic;
        }

        private static String queryString(String table, String coulm, String value)
        {
            //This function will return the current query
            if (table == "Users")
                return "SELECT * FROM Users WHERE " + coulm + " = '" + value + "'";
            return "Table not found";
            
        }

    }
}
