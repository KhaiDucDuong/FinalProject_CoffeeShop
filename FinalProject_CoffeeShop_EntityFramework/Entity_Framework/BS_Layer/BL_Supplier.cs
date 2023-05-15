using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity.Infrastructure;

namespace FinalProject_CoffeeShop.BS_Layer
{
     class BL_Supplier
    {
        public DataTable GetSupplier ()
        {
            Coffee_ShopEntities csEntity = new Coffee_ShopEntities();
            var sps =
                from p in csEntity.Suppliers
                select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Supplier Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Address");
            dt.Columns.Add("Phone Number");
            dt.Columns.Add("Email");

            foreach (var p in sps)
            {
                dt.Rows.Add(p.supplier_id, p.name , p.address, p .phone_num, p.email);

            }
            return dt;
        }
        public bool AddSupplier(int Supplier_Id, string Name, string Address, int Phone_Num , string Email, ref string err)
        {
            Coffee_ShopEntities csEntity = new Coffee_ShopEntities();
            Supplier sp = new Supplier();
            sp.supplier_id = Supplier_Id;
            sp.name = Name; 
            sp.address = Address;
            sp.phone_num = Phone_Num;
            sp.email = Email;

            csEntity.Suppliers.Add(sp);
            csEntity.SaveChanges();
            return true;
        }
        public bool DeleteSupplier(int Supplier_Id, ref string err) 
        {
            Coffee_ShopEntities csEntity = new Coffee_ShopEntities();
            Supplier sp = new Supplier();
            sp.supplier_id = Supplier_Id;

            csEntity.Suppliers.Attach(sp);
            csEntity.Suppliers.Remove(sp);

            csEntity.SaveChanges();
            return true;

        }
        public bool UpdateSupplier(int Supplier_Id, string Name, string Address, int Phone_Num, string Email, ref string err) 
        {
            Coffee_ShopEntities csEntity = new Coffee_ShopEntities();
            var spQuery = (from sp in csEntity.Suppliers
                           where sp.supplier_id == Supplier_Id
                           select sp).SingleOrDefault();
            if (spQuery != null)
            {
                spQuery.name = Name;
                spQuery.address = Address; 
                spQuery.phone_num = Phone_Num; 
                spQuery.email = Email;
                csEntity.SaveChanges();
            }
            return true;
        }
    }
}
