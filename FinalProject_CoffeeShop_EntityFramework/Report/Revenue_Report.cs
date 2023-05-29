using FinalProject_CoffeeShop.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FinalProject_CoffeeShop.Query_Interface;
using FinalProject_CoffeeShop.Report;
using FinalProject_CoffeeShop.Ado_Net.BL;

namespace FinalProject_CoffeeShop.Interface
{
    public partial class Revenue_Report : Form
    {

        public Revenue_Report()
        {
            InitializeComponent();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            SupplyPurchase_Report supplyPurchase_report_obj = new SupplyPurchase_Report();
            float totalCostForSupplies = supplyPurchase_report_obj.getTotalPrice(dtp_StartDate.Text, dtp_EndDate.Text);
            money_cost_for_supplies_lb.Text = "Money cost for supplies: " + totalCostForSupplies.ToString();

            BL_Bill_Query bl = new BL_Bill_Query();
            float revenue = bl.getRevenue(dtp_StartDate.Text, dtp_EndDate.Text);
            revenue_from_order_lb.Text = "Revenue from orders: " + revenue.ToString();

            float balance = revenue - totalCostForSupplies;
            balance_lb.Text = "Balance: " + balance.ToString();
        }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            Database_Menu curForm = new Database_Menu();
            curForm.Show();
            this.Hide();
        }
    }
}
