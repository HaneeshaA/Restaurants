using CoffeeShop_Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CoffeeShop_Data
{
    public class CoffeeMenuData
    {
        public static DataSet GetData()
        {
            SqlConnection cnn;
            string sql = null;
            SqlCommand command;
            SqlDataReader dataReader;

            DataTable dt = new DataTable();
            DataSet dsCoffeeMenu = new DataSet();

            var cs = ConfigurationManager.ConnectionStrings["CoffeeShopConnection"].ConnectionString;
            cnn = new SqlConnection(cs);
            sql = "Select * from coffeeshop";

            //Open the connection
            cnn.Open();
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            dt.Load(dataReader);
            dsCoffeeMenu.Tables.Add(dt);
            dataReader.Close();
            command.Dispose();
            cnn.Close();

            return dsCoffeeMenu;
        }
    }
}
