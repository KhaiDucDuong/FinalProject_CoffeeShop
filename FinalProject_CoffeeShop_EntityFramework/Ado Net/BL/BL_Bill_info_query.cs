using FinalProject_CoffeeShop.Ado_Net.DB;
using FinalProject_CoffeeShop.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_CoffeeShop.Ado_Net.BL
{
    internal class BL_Bill_info_query
    {
        string databaseName = "Bill_info";
        string searchCol = "bill_id";

        DB_Main db = null;
        public BL_Bill_info_query()
        {
            db = new DB_Main();
        }

        public DataTable getData(string bill_id)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            DataSet ds = db.ExecuteQueryDataSet("select bill_id 'Bill id', item_name 'Item name', item_price 'Item price', quantity from Bill_info join Item on Bill_info.item_id = Item.item_id where " + searchCol + " = '" + bill_id + "'", CommandType.Text);
            dt = ds.Tables[0];

            return dt;
        }

        public DataTable getData()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            DataSet ds = db.ExecuteQueryDataSet("select bill_id 'Bill id', item_name 'Item name', item_price 'Item price', quantity from Bill_info join Item on Bill_info.item_id = Item.item_id ", CommandType.Text);
            dt = ds.Tables[0];

            return dt;
        }
    }
}
