using FinalProject_CoffeeShop.ADO_NET.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_CoffeeShop.Ado_Net.BL
{
    internal class BL_Bill
    {
        string databaseName = "Bill";
        string primaryKeyCol = "bill_id";
        string secondCol = "created_at";

        DB_Main db = null;
        public BL_Bill()
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
        public bool addNewRow(string bill_id, string created_at, ref string error)
        {
            string converted_created_at = convertInterfaceDateTimeFormatToSqlFormat(created_at);

            string sqlString = "INSERT INTO " + databaseName +
                " VALUES (" + bill_id + ", '" + converted_created_at + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        //remove a row in Item table that has a specified itemID
        public bool removeRow(string bill_id, ref string error)
        {
            string sqlString = "DELETE FROM " + databaseName + " WHERE " + primaryKeyCol + " = " + bill_id;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        //update a row in Item table that has a specified itemID
        public bool updateRow(string bill_id, string created_at, ref string error)
        {
            string converted_created_at = convertInterfaceDateTimeFormatToSqlFormat(created_at);

            string sqlString = "UPDATE " + databaseName +
                " SET " + secondCol + " = '" + converted_created_at + "' " +
                "WHERE " + primaryKeyCol + " = '" + bill_id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        private string convertInterfaceDateTimeFormatToSqlFormat(string interface_format)
        {
            DateTime convertedFormat;
            DateTime.TryParseExact(interface_format, "hh:mm:ss  dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out convertedFormat);
            return convertedFormat.ToString();
        }
    }
}
