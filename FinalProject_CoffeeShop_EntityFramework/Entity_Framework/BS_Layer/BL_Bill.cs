using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FinalProject_CoffeeShop.BS_Layer
{
    class BL_Bill
    {
        public DataTable GetBill()
        {
            Coffee_ShopEntities csEntity = new Coffee_ShopEntities();
            var bs =
                from s in csEntity.Bills
                select s; 
            DataTable dt = new DataTable();
            dt.Columns.Add("Bill Id ");
            dt.Columns.Add("Created At ");

            foreach (var s in bs)
            {
                dt.Rows.Add(s.bill_id, s.created_at);
            }
            return dt;
        }
        public bool AddBill (int Bill_Id, DateTime Created_At, ref string err)
        {
            Coffee_ShopEntities csEntity = new Coffee_ShopEntities ();
            
            Bill b = new Bill();
            b.bill_id = Bill_Id; 
            b.created_at = Created_At;

            csEntity.Bills.Add(b);
            csEntity.SaveChanges();

            return true;
        }

        public bool DeleteBill(int Bill_Id, ref string err) 
        {
            Coffee_ShopEntities csEntity = new Coffee_ShopEntities();
            
            Bill b = new Bill();
            b.bill_id = Bill_Id; 
            csEntity.Bills.Attach(b);
            csEntity.Bills.Remove(b);

            csEntity.SaveChanges ();


            return true;

        }
        public bool UpdateBill(int Bill_Id, DateTime Created_At, ref string err) 
        {
            Coffee_ShopEntities csEntity = new Coffee_ShopEntities();
            var bQuery = (from b in csEntity.Bills
                          where b.bill_id == Bill_Id
                          select b).SingleOrDefault();
            if(bQuery != null) 
            {
                bQuery.created_at = Created_At;
                csEntity.SaveChanges();
            }
            return true;
        }
    }
}
