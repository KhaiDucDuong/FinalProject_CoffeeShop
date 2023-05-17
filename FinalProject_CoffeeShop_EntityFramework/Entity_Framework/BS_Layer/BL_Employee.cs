using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.Entity.Infrastructure;
using System.Globalization;
using FinalProject_CoffeeShop_EntityFramework;

namespace FinalProject_CoffeeShop.BS_Layer
{
     class BL_Employee
    {
        public DataTable GetEmployee()
        {
            CoffeeShopEntities csEntity = new CoffeeShopEntities();
            var es =
                from p in csEntity.Employees
                select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Employee Id");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Date Join");
            dt.Columns.Add("Date Left");

            foreach (var p in es)
            {
                dt.Rows.Add(p.employee_id, p.first_name, p.last_name, p.date_join, p.date_left);
            }
            return dt;
        }
        public bool AddEmployee(int Employee_Id , string First_Name , string Last_Name, string Date_Join, string Date_Left, ref string err)
        {
            CoffeeShopEntities csEntity = new CoffeeShopEntities();

            Employee em = new Employee();

            em.employee_id = Employee_Id;
            em.first_name = First_Name;
            em.last_name = Last_Name;
            
            DateTime temp;
            if (DateTime.TryParseExact(Date_Join, "hh:mm:ss  dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out temp))
                em.date_join = temp;
            else
                return false;
            if (DateTime.TryParseExact(Date_Left, "hh:mm:ss  dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out temp))
                em.date_left = temp;
            else
                return false;

            csEntity.Employees.Add(em);
            csEntity.SaveChanges();

            return true;
        }
        public bool DeleteEmployee (int  Employee_Id, ref string err) 
        {
            CoffeeShopEntities csEntity = new CoffeeShopEntities ();
            Employee em = new Employee();
            em.employee_id = Employee_Id;
            csEntity.Employees.Attach (em);
            csEntity.Employees.Remove(em);

            csEntity.SaveChanges();
            return true;
        }
        public bool UpdateEmployee(int Employee_Id, string First_Name, string Last_Name, string Date_Join, string Date_Left, ref string err)
        {
            CoffeeShopEntities csEntity = new CoffeeShopEntities();
            var emQuery = (from em in csEntity.Employees
                           where em.employee_id == Employee_Id
                           select em).SingleOrDefault();

            if (emQuery != null)
            {
                emQuery.first_name = First_Name;
                emQuery.last_name = Last_Name;

                DateTime temp;
                if (DateTime.TryParseExact(Date_Join, "hh:mm:ss  dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out temp))
                    emQuery.date_join = temp;
                else
                    return false;
                if (DateTime.TryParseExact(Date_Left, "hh:mm:ss  dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out temp))
                    emQuery.date_left = temp;
                else
                    return false;

                csEntity.SaveChanges();
            }
            return true;
        }
    }
}
