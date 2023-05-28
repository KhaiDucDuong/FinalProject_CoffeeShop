using FinalProject_CoffeeShop.Coffee_ShopDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_CoffeeShop.Report
{
    public partial class SupplyPurchaseInfo_Report : Form
    {
        public static string pur_ID;
        public SupplyPurchaseInfo_Report()
        {
            InitializeComponent();
        }

        private void SupplyPurchaseInfo_Report_Load(object sender, EventArgs e)
        {
            purchase_ID_txtb.Text = pur_ID;
            getData();
        }


        private void Find_Bttn_Click(object sender, EventArgs e)
        {
            pur_ID = purchase_ID_txtb.Text;
            getData();
        }

        //using the id in pur_ID to get data
        private void getData()
        {
            try
            {
                int query_purchase_ID;
                if(int.TryParse(pur_ID, out query_purchase_ID))
                {
                    pur_ID = purchase_ID_txtb.Text;
                    this.supplyPurchaseDetailsTableAdapter.Fill(this.coffee_ShopDataSet.SupplyPurchaseDetails, int.Parse(pur_ID));
                }
                else
                {
                    this.supplyPurchaseDetailsTableAdapter.FillAll(this.coffee_ShopDataSet.SupplyPurchaseDetails);
                }
                SupplyPurchaseDetail_report.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public float getPriceForPurchase(int pur_ID)
        {
            double temp_price = 0;
            float price = 0;
            try
            {
                if(supplyPurchaseDetailsTableAdapter.GetTotalPrice(pur_ID) != null)
                {
                    temp_price = (double)(supplyPurchaseDetailsTableAdapter.GetTotalPrice(pur_ID));
                    price = float.Parse(temp_price.ToString());
                }
            }
            catch { MessageBox.Show("Cannot get total price for this purchase ID!"); }

            return price;
        }
    }
}
