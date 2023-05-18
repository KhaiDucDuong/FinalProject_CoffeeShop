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
    public partial class Bill_Info : Form
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
        string err = "";
        BL_Bill_Info db_BillInfo = new BL_Bill_Info();
        public Bill_Info()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dgv_Bill_Info.DataSource = db_BillInfo.getData();

                dgv_Bill_Info.AutoResizeColumns();

                setInputOff();

                dgv_Bill_Info_CellClick(null, null);


            }
            catch { MessageBox.Show("Can not get the content in the Bill table. Error !!!"); }
        }
        private void txt_Bill_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_OpenBill_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.Show();
            this.Hide();

        }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            Database_Menu curForm = new Database_Menu();
            curForm.Show();
            this.Hide();
        }

        private void dgv_Bill_Info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Bill_Info.RowCount >= 2)
            {
                int r = dgv_Bill_Info.CurrentCell.RowIndex;


                this.Bill_Info_txt_Bill_Id.Text = dgv_Bill_Info.Rows[r].Cells[0].Value.ToString();
                this.Bill_Info_txt_ItemId.Text = dgv_Bill_Info.Rows[r].Cells[1].Value.ToString();
                this.Bill_Info_txt_Quantity.Text = dgv_Bill_Info.Rows[r].Cells[2].Value.ToString();

            }
        }

        private void Bill_Info_Load(object sender, EventArgs e)
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

            this.Bill_Info_txt_Bill_Id.Focus();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_Bill_Info.RowCount >= 2)
            {
                Add = false;

                setInputOn();
                dgv_Bill_Info_CellClick(null, null);
                Bill_Info_txt_Bill_Id.Enabled = false;
                Bill_Info_txt_ItemId.Enabled = false;

                this.Bill_Info_txt_ItemId.Focus();

            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            setInputOff();
            Bill_Info_txt_Bill_Id.Enabled = true;
            Bill_Info_txt_ItemId.Enabled = true;

            dgv_Bill_Info_CellClick(null, null);
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
                    BL_Bill_Info blBillInfo = new BL_Bill_Info();

                    blBillInfo.addNewRow(this.Bill_Info_txt_Bill_Id.Text, this.Bill_Info_txt_ItemId.Text, this.Bill_Info_txt_Quantity.Text, ref err);

                    LoadData();
                    if (!printError())
                    {
                        MessageBox.Show("Done added !");
                    }
                        
                }
                catch { MessageBox.Show("Can not add. Error !!!"); }
            }
            else
            {
                try
                {
                    BL_Bill_Info blBillInfo = new BL_Bill_Info();

                    blBillInfo.updateRow(this.Bill_Info_txt_Bill_Id.Text, this.Bill_Info_txt_ItemId.Text, this.Bill_Info_txt_Quantity.Text, ref err);

                    LoadData();
                    if (!printError())
                    {
                        MessageBox.Show("Done editted !");
                    }
                }
                catch { MessageBox.Show("Can not edit. Error !!!"); }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Bill_Info.RowCount >= 2)
                {
                    int r = dgv_Bill_Info.CurrentCell.RowIndex;

                    string Bill_id = dgv_Bill_Info.Rows[r].Cells[0].Value.ToString();
                    string Item_id = dgv_Bill_Info.Rows[r].Cells[1].Value.ToString();



                    DialogResult reply;

                    reply = MessageBox.Show("Are you sure you want to delete this post ?", "Reply",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (reply == DialogResult.Yes)
                    {

                        db_BillInfo.removeRow(Bill_id, Item_id, ref err);
                        LoadData();
                        if (!printError())
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
            Bill_Info_txt_Bill_Id.Enabled = true;
            Bill_Info_txt_ItemId.Enabled = true;

            this.Bill_Info_txt_Bill_Id.ResetText();
            this.Bill_Info_txt_ItemId.ResetText();
            this.Bill_Info_txt_Quantity.ResetText();

            this.btn_Save.Enabled = false;
            this.btn_Cancel.Enabled = false;
            this.Bill_Info_pl_Input.Enabled = false;

            this.btn_Add.Enabled = true;
            this.btn_Edit.Enabled = true;
            this.btn_Delete.Enabled = true;
        }
        private void setInputOn()
        {
            Bill_Info_txt_Bill_Id.Enabled = true;
            Bill_Info_txt_ItemId.Enabled = true;

            this.Bill_Info_txt_Bill_Id.ResetText();
            this.Bill_Info_txt_ItemId.ResetText();
            this.Bill_Info_txt_Quantity.ResetText();

            this.btn_Save.Enabled = true;
            this.btn_Cancel.Enabled = true;
            this.Bill_Info_pl_Input.Enabled = true;

            this.btn_Add.Enabled = false;
            this.btn_Edit.Enabled = false;
            this.btn_Delete.Enabled = false;
        }

        private bool printError()
        {
            if (err == "")
                return false;

            MessageBox.Show(err, "Error message");
            err = "";

            return true;
        }

        //return true if there's a special character in any of the text boxes
        private bool checkSpecialCharactersForTextBoxes()
        {
            if (checkSpecialCharactersForString(Bill_Info_txt_Bill_Id.Text) ||
                checkSpecialCharactersForString(Bill_Info_txt_ItemId.Text)  ||
                checkSpecialCharactersForString(Bill_Info_txt_Quantity.Text)
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
