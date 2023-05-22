using FinalProject_CoffeeShop.Ado_Net.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_CoffeeShop.Ado_Net.BL
{
    internal class BL_Bill_Info
    {
        string databaseName = "Bill_info";
        string primaryKeyCol = "bill_id";
        string secondCol = "item_id";
        string thirdCol = "quantity";

        DB_Main db = null;
        public BL_Bill_Info()
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
        public bool addNewRow(string bill_id, string item_id, string quantity, ref string error)
        {

            string sqlString = "INSERT INTO " + databaseName +
                " VALUES (" + bill_id + ", " + item_id + ", " + quantity + " )";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        //remove a row in Item table that has a specified itemID
        public bool removeRow(string bill_id, string item_id, ref string error)
        {
            string sqlString = "DELETE FROM " + databaseName + " WHERE " + primaryKeyCol + " = " + bill_id + " AND " + secondCol + " = " + item_id;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        //update a row in Item table that has a specified itemID
        public bool updateRow(string bill_id, string item_id, string quantity, ref string error)
        {
            string sqlString = "UPDATE " + databaseName +
                " SET " + secondCol + " = " + item_id + ", " + thirdCol + " = " + quantity +
                "WHERE " + primaryKeyCol + " = " + bill_id + " AND " + secondCol + " = " + item_id;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        
    }
}
