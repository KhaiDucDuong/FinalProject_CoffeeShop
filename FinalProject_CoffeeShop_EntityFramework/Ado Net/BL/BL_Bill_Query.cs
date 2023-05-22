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
    internal class BL_Bill_Query
    {
        string databaseName = "Bill";
        string searchCol = "created_at";

        DB_Main db = null;
        public BL_Bill_Query()
        {
            db = new DB_Main();
        }

        public DataTable getData(string start_date, string end_date)
        {
            string converted_start_date = convertInterfaceDateTimeFormatToSqlFormat(start_date);
            string converted_end_date = convertInterfaceDateTimeFormatToSqlFormat(end_date);

            DataTable dt = new DataTable();
            dt.Clear();
            DataSet ds = db.ExecuteQueryDataSet("select bill_id 'Bill id', created_at 'created time' from Bill where " + searchCol + " >= '" + converted_start_date + "' AND " + searchCol + " <= '" + converted_end_date + "'", CommandType.Text);
            dt = ds.Tables[0];

            return dt;
        }

        public DataTable getData()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            DataSet ds = db.ExecuteQueryDataSet("select bill_id 'Bill id', created_at 'created time' from Bill", CommandType.Text);
            dt = ds.Tables[0];

            return dt;
        }

        private string convertInterfaceDateTimeFormatToSqlFormat(string interface_format)
        {
            DateTime convertedFormat;
            DateTime.TryParseExact(interface_format, "HH:mm:ss  dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out convertedFormat);
            return convertedFormat.ToString();
        }
    }
}
