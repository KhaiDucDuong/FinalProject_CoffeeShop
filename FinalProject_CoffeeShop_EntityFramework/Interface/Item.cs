using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_CoffeeShop.Interface
{
    public partial class Item : Form
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

        public Item()
        {
            InitializeComponent();
        }

        private void addBT_Click(object sender, EventArgs e)
        {

        }

        private void Item_Load(object sender, EventArgs e)
        {

        }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            Database_Menu curForm = new Database_Menu();
            curForm.Show();
            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
