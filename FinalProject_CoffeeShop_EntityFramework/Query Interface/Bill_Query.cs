using FinalProject_CoffeeShop.Ado_Net.BL;
using FinalProject_CoffeeShop.Interface;
using FinalProject_CoffeeShop.Query_Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_CoffeeShop.Query_Interface
{
    public partial class Bill_Query : Form
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

        public Bill_Query()
        {
            InitializeComponent();
        }

        BL_Bill_Query db = new BL_Bill_Query();

        private void Bill_Query_Load(object sender, EventArgs e)
        {
            generateData();
            dgv_Bill_Query.Columns[1].DefaultCellStyle.Format = "HH:mm:ss dd/MM/yyyy";
        }

        private void btn_Open_Bill_Info_Query_Click(object sender, EventArgs e)
        {
            Bill_info_Query curForm = new Bill_info_Query();
            curForm.Show();
            this.Hide();
        }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            Database_Menu curForm = new Database_Menu();
            curForm.Show();
            this.Hide();
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            getAllData();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            generateData();
        }

        private void generateData()
        {
            try
            {
                dgv_Bill_Query.DataSource = db.getData(dtp_StartDate.Text, dtp_EndDate.Text);
                lb_revenue.Text = "Revenue: " + db.getRevenue(dtp_StartDate.Text, dtp_EndDate.Text).ToString();
            }
            catch { MessageBox.Show("Can not get the content in the Bill table. Error !!!");
                    }
        }

        private void getAllData()
        {
            try
            {
                dgv_Bill_Query.DataSource = db.getData();
                lb_revenue.Text = "Revenue: " + db.getRevenue().ToString();
            }
            catch { MessageBox.Show("Can not get the content in the Bill table. Error !!!"); }
        }
    }
}
