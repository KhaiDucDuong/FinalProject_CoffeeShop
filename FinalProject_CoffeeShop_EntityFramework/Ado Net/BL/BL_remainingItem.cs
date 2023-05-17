using FinalProject_CoffeeShop.ADO_NET.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_CoffeeShop_EntityFramework.Ado_Net.BL
{
    internal class BL_remainingItem
    {
        string databaseName = "remainingItems";
        string primaryKeyCol = "item_id";
        string secondCol = "quanity";

        DB_Main db = null;

        public BL_remainingItem() 
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
        public bool addNewRow(string itemID, string quantity, ref string error)
        {
            string sqlString = "INSERT INTO " + databaseName +
                " VALUES (" + itemID + ", " + quantity + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        //remove a row in Item table that has a specified itemID
        public bool removeRow(string itemID, ref string error)
        {
            string sqlString = "DELETE FROM " + databaseName + " WHERE " + primaryKeyCol + " = " + itemID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        //update a row in Item table that has a specified itemID
        public bool updateRow(string itemID, string quantity, ref string error)
        {
            string sqlString = "UPDATE " + databaseName +
                " SET " + secondCol + " = " + quantity +
                "WHERE " + primaryKeyCol + " = '" + itemID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

    }
}
