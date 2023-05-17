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

namespace FinalProject_CoffeeShop.Interface
{

    public partial class Bill : Form
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


        bool Add;
        string err;
        //BL_Bill db_Bill = new BL_Bill();



        public Bill()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                //dgv_Bill.DataSource = db_Bill.GetBill();

                dgv_Bill.AutoResizeColumns();

                setInputOff();

                dgv_Bill_CellClick(null, null);
            }
            catch { MessageBox.Show("Can not get the content in the Bill table. Error !!!"); }
        }

        private void btn_OpenBillInfo_Click(object sender, EventArgs e)
        {
            Bill_Info bill_info = new Bill_Info();
            bill_info.Show();
            this.Hide();
        }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            Database_Menu curForm = new Database_Menu();
            curForm.Show();
            this.Hide();
        }

        private void dgv_Bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Bill.RowCount >= 2)
            {
                int r = dgv_Bill.CurrentCell.RowIndex;

                //int billid = int.Parse(this.Bill_txt_Bill_Id.Text);
                this.Bill_txt_Bill_Id.Text = dgv_Bill.Rows[r].Cells[0].Value.ToString();


                //DateTime createdat = DateTime.Parse(this.Bill_dtp_CreatedAt.Text);
                this.Bill_dtp_CreatedAt.Text = (dgv_Bill.Rows[r].Cells[1].Value.ToString());
            }
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Add = true;

            setInputOn();

            this.Bill_txt_Bill_Id.Focus();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if(dgv_Bill.RowCount >= 2)
            {
                Add = false;

                setInputOn();
                dgv_Bill_CellClick(null, null);

                //this.Bill_txt_Bill_Id.Enabled = false;
                this.Bill_dtp_CreatedAt.Focus();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            setInputOff();

            dgv_Bill_CellClick(null, null);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (checkSpecialCharactersForTextBoxes())
            {
                MessageBox.Show("Cannot use special characters!", "String error");
                return;
            }

            if (Add)
            {
                try
                {
                    //BL_Bill blBill = new BL_Bill();
                    //blBill.AddBill(this.Bill_txt_Bill_Id.Text, this.Bill_dtp_CreatedAt.Text, ref err);

                    LoadData();
                    MessageBox.Show("Done added !");
                }
                catch { MessageBox.Show("Can not add. Error !!!"); }
            }
            else
            {
                //BL_Bill blBill = new BL_Bill();
                //blBill.UpdateBill(this.Bill_txt_Bill_Id.Text, this.Bill_dtp_CreatedAt.Text, ref err);

                LoadData();

                MessageBox.Show("Done editted !");
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgv_Bill.RowCount >= 2)
                {
                    int r = dgv_Bill.CurrentCell.RowIndex;

                    string strBill =
                    dgv_Bill.Rows[r].Cells[0].Value.ToString();


                    DialogResult reply;

                    reply = MessageBox.Show("Are you sure you want to delete this post ?", "Reply",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (reply == DialogResult.Yes)
                    {
                        //db_Bill.DeleteBill(strBill, ref err);
                        LoadData();
                        MessageBox.Show("Done deleted !");
                    }
                    else
                    {
                        MessageBox.Show("Unable to delete records !");
                    }
                }
            }
            catch { MessageBox.Show("Can not delete. Error !!!"); }
        }

        private void setInputOff()
        {
            this.Bill_txt_Bill_Id.ResetText();
            this.Bill_dtp_CreatedAt.ResetText();

            this.btn_Save.Enabled = false;
            this.btn_Cancel.Enabled = false;
            this.btn_Save.Enabled = false;
            this.Bill_pl_Input.Enabled = false;

            this.btn_Add.Enabled = true;
            this.btn_Edit.Enabled = true;
            this.btn_Delete.Enabled = true;
        }
        private void setInputOn()
        {
            this.Bill_txt_Bill_Id.ResetText();
            this.Bill_dtp_CreatedAt.ResetText();

            this.btn_Save.Enabled = true;
            this.btn_Cancel.Enabled = true;
            this.btn_Save.Enabled = true;
            this.Bill_pl_Input.Enabled = true;

            this.btn_Add.Enabled = false;
            this.btn_Edit.Enabled = false;
            this.btn_Delete.Enabled = false;
        }

        //return true if there's a special character in any of the text boxes
        private bool checkSpecialCharactersForTextBoxes()
        {
            if (checkSpecialCharactersForString(Bill_txt_Bill_Id.Text)
                )
                return true;

            return false;
        }

        //check if there's a special character in the string, return true if yes
        private bool checkSpecialCharactersForString(string str)
        {
            if (str.Contains("!") ||
               str.Contains("\"") ||
               str.Contains("#") ||
               str.Contains("$") ||
               str.Contains("%") ||
               str.Contains("&") ||
               str.Contains("’") ||
               str.Contains("(") ||
               str.Contains(")") ||
               str.Contains("*") ||
               str.Contains("+") ||
               str.Contains(",") ||
               str.Contains("-") ||
               str.Contains("/") ||
               str.Contains(":") ||
               str.Contains(";") ||
               str.Contains("<") ||
               str.Contains("=") ||
               str.Contains(">") ||
               str.Contains("?") ||
               str.Contains("@") ||
               str.Contains("[") ||
               str.Contains("\\") ||
               str.Contains("]") ||
               str.Contains("^") ||
               str.Contains("_") ||
               str.Contains("`") ||
               str.Contains("{") ||
               str.Contains("|") ||
               str.Contains(">") ||
               str.Contains("~")
                )
                return true;

            return false;
        }
    }
}
