using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;
using FinalProject_CoffeeShop_EntityFramework;

namespace FinalProject_CoffeeShop.BS_Layer
{
    class BL_Bill
    {
        public DataTable GetBill()
        {
            CoffeeShopEntities csEntity = new CoffeeShopEntities();
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

        public bool AddBill (string Bill_Id, string Created_At, ref string err)
        {
            int bill_id;
            DateTime created_at;
            if(!int.TryParse(Bill_Id, out bill_id) ||
            !DateTime.TryParseExact(Created_At, "hh:mm:ss  dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out created_at))
            {
                return false;
            }

            CoffeeShopEntities csEntity = new CoffeeShopEntities ();
            
            Bill b = new Bill();
            b.bill_id = bill_id; 
            b.created_at = created_at;

            csEntity.Bills.Add(b);
            csEntity.SaveChanges();

            return true;
        }

        public bool DeleteBill(string Bill_Id, ref string err) 
        {
            int bill_id;
            if (!int.TryParse(Bill_Id, out bill_id))
            {
                return false;
            }

            CoffeeShopEntities csEntity = new CoffeeShopEntities();
            
            Bill b = new Bill();
            b.bill_id = bill_id; 
            csEntity.Bills.Attach(b);
            csEntity.Bills.Remove(b);

            csEntity.SaveChanges ();


            return true;

        }
        public bool UpdateBill(string Bill_Id, string Created_At, ref string err) 
        {
            int bill_id;
            DateTime created_at;
            if (!int.TryParse(Bill_Id, out bill_id) ||
            !DateTime.TryParseExact(Created_At, "hh:mm:ss  dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out created_at))
            {
                return false;
            }

            CoffeeShopEntities csEntity = new CoffeeShopEntities();
            var bQuery = (from b in csEntity.Bills
                          where b.bill_id == bill_id
                          select b).SingleOrDefault();
            if(bQuery != null) 
            {
                bQuery.created_at = created_at;
                csEntity.SaveChanges();
            }
            return true;
        }
    }
}
