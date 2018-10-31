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
        public static List<CoffeeMenuModel> GetMenuFromDB()
        {
            List<CoffeeMenuModel> returnObjs = new List<CoffeeMenuModel>();
            
            SqlConnection cnn;
            string sql = null;
            SqlCommand command;
            SqlDataReader dataReader;

            DataTable dt = new DataTable();
            DataSet dsCoffeeMenu = new DataSet();

            var cs = ConfigurationManager.ConnectionStrings["CoffeeShopConnection"].ConnectionString;
            cnn = new SqlConnection(cs);
            sql = "select * from coffeeshop;";

            //Open the connection
            cnn.Open();
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader(CommandBehavior.SequentialAccess);

            while(dataReader.Read())
            {
                CoffeeMenuModel returnObj = new CoffeeMenuModel();

                returnObj.CategoryID = dataReader["CategoryID"].ToString();
                returnObj.ItemName = dataReader["ItemName"].ToString();
                returnObj.ItemDescription = dataReader["Description"].ToString();
                returnObj.Price =  dataReader["Price"].ToString();

                returnObjs.Add(returnObj);
            }

            //dt.Load(dataReader);
            //dsCoffeeMenu.Tables.Add(dt);
            //var rows = dsCoffeeMenu.Tables[0].Rows;
            //var test = rows[0]["CategoryId"];
            dataReader.Close();
            command.Dispose();
            cnn.Close();

            //return dsCoffeeMenu;
            return returnObjs;
        }
    }
}
