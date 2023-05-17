using FinalProject_CoffeeShop.Ado_Net.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_CoffeeShop.Ado_Net.BL
{
    internal class BL_InventoryInfo
    {
        string databaseName = "Inventory_info";
        string primaryKeyCol = "check_id";
        string secondCol = "ingredient_id";
        string thirdCol = "quantity_per_unit";

        DB_Main db = null;
        public BL_InventoryInfo()
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
        public bool addNewRow(string check_id, string ingredient_id, string quantity_per_unit, ref string error)
        {
            string sqlString = "INSERT INTO " + databaseName +
                " VALUES (" + check_id + ", " + ingredient_id + ", " + quantity_per_unit + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        //remove a row in Item table that has a specified itemID
        public bool removeRow(string check_id, ref string error)
        {
            string sqlString = "DELETE FROM " + databaseName + " WHERE " + primaryKeyCol + " = " + check_id;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        //update a row in Item table that has a specified itemID
        public bool updateRow(string check_id, string ingredient_id, string quantity_per_unit, ref string error)
        {
            string sqlString = "UPDATE " + databaseName +
                " SET " + secondCol + " = " + ingredient_id + ", " + thirdCol + " = " + quantity_per_unit +
                "WHERE " + primaryKeyCol + " = " + check_id;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
    }
}
