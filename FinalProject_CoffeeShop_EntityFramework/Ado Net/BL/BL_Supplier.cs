using FinalProject_CoffeeShop.Ado_Net.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_CoffeeShop.Ado_Net.BL
{
    internal class BL_Supplier
    {
        string databaseName = "Supplier";
        string primaryKeyCol = "supplier_id";
        string secondCol = "name";
        string thirdCol = "address";
        string fourthCol = "phone_num";
        string fifthCol = "email";

        DB_Main db = null;
        public BL_Supplier()
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
        public bool addNewRow(string supplier_id, string name, string address, string phone_num, string email, ref string error)
        {
            string sqlString = "INSERT INTO " + databaseName +
                " VALUES (" + supplier_id + ", N'" + name + "', N'" + address + "', '" + phone_num + "', N'" + email + "'" + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        //remove a row in Item table that has a specified itemID
        public bool removeRow(string supplier_id, ref string error)
        {
            string sqlString = "DELETE FROM " + databaseName + " WHERE " + primaryKeyCol + " = " + supplier_id;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        //update a row in Item table that has a specified itemID
        public bool updateRow(string supplier_id, string name, string address, string phone_num, string email, ref string error)
        {
            string sqlString = "UPDATE " + databaseName +
                " SET " + secondCol + " = N'" + name + "', " + thirdCol + " = N'" + address + "', " + fourthCol + " = '" + phone_num + "', " + fifthCol + " = '" + email + "' " + 
                "WHERE " + primaryKeyCol + " = '" + supplier_id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
    }
}
