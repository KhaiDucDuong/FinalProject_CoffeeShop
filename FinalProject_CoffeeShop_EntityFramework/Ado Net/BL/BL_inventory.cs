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
    internal class BL_inventory
    {
        string databaseName = "Inventory";
        string primaryKeyCol = "check_id";
        string secondCol = "date_check";
        string thirdCol = "checker_id";

        DB_Main db = null;
        public BL_inventory()
        {
            db = new DB_Main();
        }

        //get all the data (rows) in Item table
        public DataSet getData()
        {
            return db.ExecuteQueryDataSet("select * from " + databaseName, CommandType.Text);
        }

        //add a new row to Item table
        public bool addNewRow(string check_id, string date_check, string checker_id, ref string error)
        {
            string converted_date_check = convertInterfaceDateTimeFormatToSqlFormat(date_check);

            string sqlString = "INSERT INTO " + databaseName +
                " VALUES (" + check_id + ", '" + converted_date_check + "', " + checker_id + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        //remove a row in Item table that has a specified itemID
        public bool removeRow(string check_id, ref string error)
        {
            string sqlString = "DELETE FROM " + databaseName + " WHERE " + primaryKeyCol + " = " + check_id;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        //update a row in Item table that has a specified itemID
        public bool updateRow(string check_id, string date_check, string checker_id, ref string error)
        {
            string converted_date_check = convertInterfaceDateTimeFormatToSqlFormat(date_check);

            string sqlString = "UPDATE " + databaseName +
                " SET " + secondCol + " = '" + converted_date_check + "', " + thirdCol + " = " + checker_id +
                " WHERE " + primaryKeyCol + " = '" + check_id + "'";
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
