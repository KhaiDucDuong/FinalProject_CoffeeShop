using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FinalProject_CoffeeShop.Ado_Net.BL;
using FinalProject_CoffeeShop.Interface;

namespace FinalProject_CoffeeShop.Query_Interface
{
    public partial class Bill_info_Query : Form
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

        BL_Bill_info_query db = new BL_Bill_info_query();

        public Bill_info_Query()
        {
            InitializeComponent();
        }

        private void Bill_info_Query_Load(object sender, EventArgs e)
        {
            generateData();
        }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            Database_Menu curForm = new Database_Menu();
            curForm.Show();
            this.Hide();
        }

        private void btn_Open_Bill_Query_Click(object sender, EventArgs e)
        {
            Bill_Query curForm = new Bill_Query();
            curForm.Show();
            this.Hide();
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            getAllData();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            generateData();
        }

        private void generateData()
        {
            try
            {
                dgv_Bill_info_Query.DataSource = db.getData(Bill_Info_txt_Bill_Id.Text);
            }
            catch { MessageBox.Show("Can not get the content in the Bill table. Error !!!"); }
        }

        private void getAllData()
        {
            try
            {
                dgv_Bill_info_Query.DataSource = db.getData();
            }
            catch { MessageBox.Show("Can not get the content in the Bill table. Error !!!"); }
        }
    }
}
