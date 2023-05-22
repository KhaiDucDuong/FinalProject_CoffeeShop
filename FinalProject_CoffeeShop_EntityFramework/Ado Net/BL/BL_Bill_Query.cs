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

        public float getRevenue()
        {
            float revenue = 0;
            DataSet ds_Bill = db.ExecuteQueryDataSet("select bill_id from Bill", CommandType.Text);
            if (ds_Bill.Tables[0].Rows.Count <= 0)
            {
                return 0;
            }
            else
            {
                int i = 0;
                //calculate money earned for each bill_id
                foreach (DataRow dRow in ds_Bill.Tables[0].Rows)
                {
                    string bill_id = ds_Bill.Tables[0].Rows[i][0].ToString();

                    revenue += BL_Bill_info_query.getRevenue(bill_id);
                    i++;
                }
            }
            return revenue;
        }

        public float getRevenue(string startDate, string endDate)
        {
            float revenue = 0;

            string converted_start_date = convertInterfaceDateTimeFormatToSqlFormat(startDate);
            string converted_end_date = convertInterfaceDateTimeFormatToSqlFormat(endDate);
            DataSet ds_Bill = db.ExecuteQueryDataSet("select bill_id 'Bill id', created_at 'created time' from Bill where " + searchCol + " >= '" + converted_start_date + "' AND " + searchCol + " <= '" + converted_end_date + "'", CommandType.Text);

            if (ds_Bill.Tables[0].Rows.Count <= 0)
            {
                return 0;
            }
            else
            {
                int i = 0;
                //calculate money earned for each bill_id
                foreach (DataRow dRow in ds_Bill.Tables[0].Rows)
                {
                    string bill_id = ds_Bill.Tables[0].Rows[i][0].ToString();

                    revenue += BL_Bill_info_query.getRevenue(bill_id);
                    i++;
                }
            }

            return revenue;
        }
    }
}
