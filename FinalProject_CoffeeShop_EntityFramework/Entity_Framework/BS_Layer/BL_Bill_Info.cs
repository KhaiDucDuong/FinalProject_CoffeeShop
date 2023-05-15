using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity.Migrations.Model;

namespace FinalProject_CoffeeShop.BS_Layer
{
     class BL_Bill_Info
    {
        public DataTable GetBill_Info ()
        {
            Coffee_ShopEntities csEntity = new Coffee_ShopEntities ();
            var bis =
                from i in csEntity.Bill_info
                select i;
            DataTable dt = new DataTable ();
            dt.Columns.Add("Bill Id");
            dt.Columns.Add("Item Id");
            dt.Columns.Add("Quantity");

            foreach (var b in bis)
            {
                dt.Rows.Add(b.bill_id,b.item_id,b.quantity);
            }
            return dt;
        }
        public bool AddBill_Info(int Bill_Id, int Item_Id, int Quantity, ref string err)
        {
            Coffee_ShopEntities csEntity = new Coffee_ShopEntities();
            Bill_info bi = new Bill_info ();
            bi.bill_id = Bill_Id;
            bi.item_id = Item_Id;
            bi.quantity = Quantity;

            csEntity.Bill_info.Add (bi);
            csEntity.SaveChanges();

            return true;
        }
        public bool DeleteBill_Info(int Bill_Id , ref string err)
        {
            Coffee_ShopEntities csEntity = new Coffee_ShopEntities();
            Bill_info bi = new Bill_info();
            bi.bill_id = Bill_Id;
            csEntity.Bill_info.Attach (bi);
            csEntity.Bill_info.Remove(bi);

            csEntity.SaveChanges();
            return true;
        }
        public bool UpdateBill_Info(int Bill_Id, int Item_Id, int Quantity, ref string err) 
        {
            Coffee_ShopEntities csEntity = new Coffee_ShopEntities ();
           
            var biQuery = (from bi in csEntity.Bill_info
                           where bi.bill_id == Bill_Id
                           select bi).SingleOrDefault();

            if (biQuery != null)
            {
                biQuery.bill_id = Bill_Id;
                biQuery.item_id = Item_Id;
                biQuery.quantity = Quantity;
                csEntity.SaveChanges();
            }
            return true;
        }
    }
}
