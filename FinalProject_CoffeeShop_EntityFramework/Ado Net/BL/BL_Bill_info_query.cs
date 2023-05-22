using FinalProject_CoffeeShop.Ado_Net.DB;
using FinalProject_CoffeeShop.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_CoffeeShop.Ado_Net.BL
{
    internal class BL_Bill_info_query
    {
        static string databaseName = "Bill_info";
        static string searchCol = "bill_id";

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


        public static DataSet getDataSet(string bill_id) 
        {
            DB_Main db = new DB_Main();
            DataSet ds = db.ExecuteQueryDataSet("select bill_id, item_name, item_price, quantity from Bill_info join Item on Bill_info.item_id = Item.item_id where " + searchCol + " = '" + bill_id + "'", CommandType.Text);
            return ds;
        }

        public static float getRevenue()
        {
            DB_Main db = new DB_Main();
            float revenue = 0;
            //Get the joint table of Bill_Info and Item
            DataSet ds_Bill_Info_Join_Item = db.ExecuteQueryDataSet("select bill_id, item_name, item_price, quantity from Bill_info join Item on Bill_info.item_id = Item.item_id", CommandType.Text);
            if (ds_Bill_Info_Join_Item.Tables[0].Rows.Count <= 0)
            {
                return 0;
            }
            else
            {
                int i = 0;
                //get the moneyed earned for a bill_id; for every item revenue += (item price * quantity)
                foreach (DataRow dRow in ds_Bill_Info_Join_Item.Tables[0].Rows)
                {
                    float itemPrice;
                    int quantity;
                    if (float.TryParse(ds_Bill_Info_Join_Item.Tables[0].Rows[i][2].ToString(), out itemPrice) &&
                        int.TryParse(ds_Bill_Info_Join_Item.Tables[0].Rows[i][3].ToString(), out quantity))
                    {
                        revenue += itemPrice * quantity;
                        i++;
                    }
                    else
                    {
                        MessageBox.Show("Conversion failed!");
                    }
                }
            }

            return revenue;
        }

        public static float getRevenue(string bill_id)
        {
            DB_Main db = new DB_Main();
            float revenue = 0;
            //Get the joint table of Bill_Info and Item with the given Bill_ID
            DataSet ds_Bill_Info_Join_Item = db.ExecuteQueryDataSet("select bill_id, item_name, item_price, quantity from Bill_info join Item on Bill_info.item_id = Item.item_id where bill_id = '" + bill_id + "'", CommandType.Text);
            if (ds_Bill_Info_Join_Item.Tables[0].Rows.Count <= 0)
            {
                return 0;
            }
            else
            {
                int i = 0;
                //get the moneyed earned for a bill_id; for every item revenue += (item price * quantity)
                foreach (DataRow dRow in ds_Bill_Info_Join_Item.Tables[0].Rows)
                {
                    float itemPrice;
                    int quantity;
                    if (float.TryParse(ds_Bill_Info_Join_Item.Tables[0].Rows[i][2].ToString(), out itemPrice) &&
                        int.TryParse(ds_Bill_Info_Join_Item.Tables[0].Rows[i][3].ToString(), out quantity))
                    {
                        revenue += itemPrice * quantity;
                        i++;
                    }
                    else
                    {
                        MessageBox.Show("Conversion failed!");
                    }
                }
            }

            return revenue;
        }
    }
}
