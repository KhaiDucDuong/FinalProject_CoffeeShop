using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinalProject_CoffeeShop.ADO_NET.DB;

namespace FinalProject_CoffeeShop.ADO_NET.BL
{
    internal class BL_item
    {
        string databaseName = "item";
        string primaryKeyCol = "item_id";
        string secondCol = "item_name";
        string thirdCol = "item_price";

        DB_Main db = null;
        public BL_item() 
        {
            db = new DB_Main();
        }

        //get all the data (rows) in Item table
        public DataSet getData()
        {
            return db.ExecuteQueryDataSet("select * from " + databaseName, CommandType.Text);
        }

        //add a new row to Item table
        public bool addNewRow(string itemID, string itemName, string itemPrice, ref string error)
        {
            string sqlString = "INSERT INTO " + databaseName +
                " VALUES (" + itemID + ", N'" + itemName + "', " + itemPrice + ")"; 
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        //remove a row in Item table that has a specified itemID
        public bool removeRow(string itemID, ref string error) 
        {
            string sqlString = "DELETE FROM " + databaseName + " WHERE " + primaryKeyCol + " = " + itemID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        //update a row in Item table that has a specified itemID
        public bool updateRow(string itemID, string itemName, string itemPrice, ref string error)
        {
            string sqlString = "UPDATE " + databaseName + 
                " SET " + secondCol + " = N'" + itemName + "', " + thirdCol + " = " + itemPrice +
                "WHERE " + primaryKeyCol + " = '" + itemID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
    }
}
