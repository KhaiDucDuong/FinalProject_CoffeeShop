using FinalProject_CoffeeShop.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_CoffeeShop.Report
{
    public partial class SupplyPurchase_Report : Form
    {
        //disable exit button on top right
        private const int CP_DISABLE_CLOSE_BUTTON = 0x200;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CP_DISABLE_CLOSE_BUTTON;
                return cp;
            }
        }

        public SupplyPurchase_Report()
        {
            InitializeComponent();
        }

        private void SupplyPurchase_Report_Load(object sender, EventArgs e)
        {
            getAllData();
        }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            Database_Menu curForm = new Database_Menu();
            curForm.Show();
            this.Hide();
        }

        private void btn_Show_Details_report_Click(object sender, EventArgs e)
        {
            SupplyPurchaseInfo_Report popUpForm = new SupplyPurchaseInfo_Report();
            SupplyPurchaseInfo_Report.pur_ID = Pur_ID_txtb.Text;
            popUpForm.Show();
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            getAllData();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            string converted_start_date = convertInterfaceDateTimeFormatToSqlFormat(dtp_StartDate.Text);
            string converted_end_date = convertInterfaceDateTimeFormatToSqlFormat(dtp_EndDate.Text);

            this.supplyPurchaseTableAdapter.Fill(this.coffee_ShopDataSet.SupplyPurchase, converted_start_date, converted_end_date);
            
            if(this.coffee_ShopDataSet.SupplyPurchase.Rows.Count > 0)
            {
                updateTotalPrice();
            }

            this.reportViewer_SupplyPurchase.RefreshReport();
        }

        private string convertInterfaceDateTimeFormatToSqlFormat(string interface_format)
        {
            DateTime convertedFormat;
            DateTime.TryParseExact(interface_format, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out convertedFormat);
            return convertedFormat.ToString();
        }

        private void updateTotalPrice()
        {
            SupplyPurchaseInfo_Report SupplyPurchase_Info_obj = new SupplyPurchaseInfo_Report();
            float totalPrice = 0;
            try
            {
                //get all purchase id currently in current table and add the price for each of them into totalPrice
                for (int i = 0; i < this.coffee_ShopDataSet.SupplyPurchase.Rows.Count; i++)
                {
                    totalPrice += SupplyPurchase_Info_obj.getPriceForPurchase(int.Parse(this.coffee_ShopDataSet.SupplyPurchase.Rows[i][0].ToString()));
                }
                lb_totalCost.Text = "Total cost: " + totalPrice.ToString();
            }
            catch { MessageBox.Show("Failed to calculate total price for all supply purchases!"); }

            SupplyPurchase_Info_obj.Close();
        }

        private void getAllData()
        {
            this.supplyPurchaseTableAdapter.FillAll(this.coffee_ShopDataSet.SupplyPurchase);

            if (this.coffee_ShopDataSet.SupplyPurchase.Rows.Count > 0)
            {
                updateTotalPrice();
            }

            this.reportViewer_SupplyPurchase.RefreshReport();
        }
    }
}
