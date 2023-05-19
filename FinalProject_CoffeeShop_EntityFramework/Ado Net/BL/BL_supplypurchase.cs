using FinalProject_CoffeeShop.Ado_Net.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_CoffeeShop.Ado_Net.BL
{
    internal class BL_supplypurchase
    {
        string databaseName = "SupplyPurchase";
        string primaryKeyCol = "purchase_id";
        string secondCol = "employee_in_charge";
        string thirdCol = "supplier_id";
        string fourthCol = "purchase_date";

        DB_Main db = null;
        public BL_supplypurchase()
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
        public bool addNewRow(string purchase_id, string employee_in_charge, string supplier_id, string purchase_date, ref string error)
        {
            string sqlString;
            string converted_purchase_date = convertInterfaceDateTimeFormatToSqlFormat(purchase_date);

            sqlString = "INSERT INTO " + databaseName +
                " VALUES (" + purchase_id + ", " + employee_in_charge + ", " + supplier_id + ", '" + converted_purchase_date + "')";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        //remove a row in Item table that has a specified itemID
        public bool removeRow(string purchase_id, ref string error)
        {
            string sqlString = "DELETE FROM " + databaseName + " WHERE " + primaryKeyCol + " = " + purchase_id;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        //update a row in Item table that has a specified itemID
        public bool updateRow(string purchase_id, string employee_in_charge, string supplier_id, string purchase_date, ref string error)
        {
            string sqlString;

            string converted_purchase_date = convertInterfaceDateTimeFormatToSqlFormat(purchase_date);

            sqlString = "UPDATE " + databaseName +
                " SET " + secondCol + " = " + employee_in_charge + ", " + thirdCol + " = " + supplier_id + ", " + fourthCol + " = '" + converted_purchase_date + "' " +
                "WHERE " + primaryKeyCol + " = '" + purchase_id + "'";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        private string convertInterfaceDateTimeFormatToSqlFormat(string interface_format)
        {
            DateTime convertedFormat;
            DateTime.TryParseExact(interface_format, "HH:mm:ss  dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out convertedFormat);
            return convertedFormat.ToString();
        }
    }
}
