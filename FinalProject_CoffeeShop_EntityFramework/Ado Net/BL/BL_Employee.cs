using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinalProject_CoffeeShop.Ado_Net.DB;

namespace FinalProject_CoffeeShop.Ado_Net.BL
{
    internal class BL_Employee
    {
        string databaseName = "Employee";
        string primaryKeyCol = "employee_id";
        string secondCol = "first_name";
        string thirdCol = "last_name";
        string fourthCol = "date_join";
        string fifthCol = "date_left";

        DB_Main db = null;
        public BL_Employee() 
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
        public bool addNewRow(string employee_id, string first_name, string last_name, string date_join, string date_left, ref string error)
        {
            string converted_date_join = convertInterfaceDateTimeFormatToSqlFormat(date_join);
            string converted_date_left = convertInterfaceDateTimeFormatToSqlFormat(date_left);

            string sqlString = "INSERT INTO " + databaseName +
                " VALUES (" + employee_id + ", N'" + first_name + "', N'" + last_name + "', '" + converted_date_join + "', '" + converted_date_left + "')"; 
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        //remove a row in Item table that has a specified itemID
        public bool removeRow(string itemID, ref string error) 
        {
            string sqlString = "DELETE FROM " + databaseName + " WHERE " + primaryKeyCol + " = " + itemID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        //update a row in Item table that has a specified itemID
        public bool updateRow(string employee_id, string first_name, string last_name, string date_join, string date_left, ref string error)
        {
            string converted_date_join = convertInterfaceDateTimeFormatToSqlFormat(date_join);
            string converted_date_left = convertInterfaceDateTimeFormatToSqlFormat(date_left);

            string sqlString = "UPDATE " + databaseName + 
                " SET " + secondCol + " = N'" + first_name + "', " + thirdCol + " = N'" + last_name + "', " + fourthCol + " = '" + converted_date_join + "', " + fifthCol + " = '" + converted_date_left + "' " +
                "WHERE " + primaryKeyCol + " = '" + employee_id + "'";
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
