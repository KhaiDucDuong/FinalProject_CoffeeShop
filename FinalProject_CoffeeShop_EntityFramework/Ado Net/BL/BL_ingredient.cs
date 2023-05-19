using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinalProject_CoffeeShop.Ado_Net.DB;

namespace FinalProject_CoffeeShop.Ado_Net.BL
{
    internal class BL_ingredient
    {
        string databaseName = "Ingredient";
        string primaryKeyCol = "ingredient_id";
        string secondCol = "name";
        string thirdCol = "unit";

        DB_Main db = null;
        public BL_ingredient()
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
        public bool addNewRow(string ingredient_id, string name, string unit, ref string error)
        {
            string sqlString = "INSERT INTO " + databaseName +
                " VALUES (" + ingredient_id + ", N'" + name + "', N'" + unit + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        //remove a row in Item table that has a specified itemID
        public bool removeRow(string ingredient_id, ref string error)
        {
            string sqlString = "DELETE FROM " + databaseName + " WHERE " + primaryKeyCol + " = " + ingredient_id;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        //update a row in Item table that has a specified itemID
        public bool updateRow(string ingredient_id, string name, string unit, ref string error)
        {
            string sqlString = "UPDATE " + databaseName +
                " SET " + secondCol + " = N'" + name + "', " + thirdCol + " = N'" + unit + "' " +
                "WHERE " + primaryKeyCol + " = '" + ingredient_id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
    }
}
