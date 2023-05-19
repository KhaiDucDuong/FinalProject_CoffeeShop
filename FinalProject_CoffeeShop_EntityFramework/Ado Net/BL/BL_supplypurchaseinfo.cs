using FinalProject_CoffeeShop.Ado_Net.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_CoffeeShop.Ado_Net.BL
{
    internal class BL_supplypurchaseinfo
    {
        string databaseName = "SupplyPurchaseInfo";
        string firstCol = "purchase_id";
        string secondCol = "ingredient_id";
        string thirdCol = "quantity_per_unit";
        string fourthCol = "purchase_price";

        DB_Main db = null;
        public BL_supplypurchaseinfo()
        {
            db = new DB_Main();
        }

        //get all the data (rows) in Item table
        public DataTable getData()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            DataSet ds = db.ExecuteQueryDataSet("select * from " + databaseName, CommandType.Text);
            dt = ds.Tables[0];

            return dt;
        }

        //add a new row to Item table
        public bool addNewRow(string purchase_id, string ingredient_id, string quantity_per_unit, string purchase_price, ref string error)
        {
            string sqlString = "INSERT INTO " + databaseName +
                " VALUES (" + purchase_id + ", " + ingredient_id + ", " + quantity_per_unit + ", " + purchase_price + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        //remove a row in Item table that has a specified itemID
        public bool removeRow(string purchase_id, string ingredient_id, ref string error)
        {
            string sqlString = "DELETE FROM " + databaseName + " WHERE " + firstCol + " = " + purchase_id + " AND " + secondCol + " = " + ingredient_id;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        //update a row in Item table that has a specified itemID
        public bool updateRow(string purchase_id, string ingredient_id, string quantity_per_unit, string purchase_price, ref string error)
        {
            string sqlString = "UPDATE " + databaseName +
                " SET " + thirdCol + " = " + quantity_per_unit + ", " + fourthCol + " = " + purchase_price +
                "WHERE " + firstCol + " = " + purchase_id + " AND " + secondCol + " = " + ingredient_id;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
    }
}
