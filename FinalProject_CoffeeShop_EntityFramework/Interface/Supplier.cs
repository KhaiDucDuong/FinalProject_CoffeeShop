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
    public partial class Supplier : Form
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
        BL_Supplier db_Supplier = new BL_Supplier();
        public Supplier()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dgv_Supplier.DataSource = db_Supplier.getData();

                dgv_Supplier.AutoResizeColumns();

                setInputOff();

                dgv_Supplier_CellClick(null, null);


            }
            catch { MessageBox.Show("Can not get the content in the Bill table. Error !!!"); }
        }
        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            Database_Menu curForm = new Database_Menu();
            curForm.Show();
            this.Hide();
        }

        private void dgv_Supplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Supplier.RowCount >= 2)
            {
                int r = dgv_Supplier.CurrentCell.RowIndex;


                this.Supplier_txt_SupplierId.Text = dgv_Supplier.Rows[r].Cells[0].Value.ToString();
                this.Supplier_txt_Name.Text = dgv_Supplier.Rows[r].Cells[1].Value.ToString();
                this.Supplier_txt_Address.Text = dgv_Supplier.Rows[r].Cells[2].Value.ToString();
                this.Supplier_txt_PhoneNumber.Text = dgv_Supplier.Rows[r].Cells[3].Value.ToString();
                this.Supplier_txt_Email.Text = dgv_Supplier.Rows[r].Cells[4].Value.ToString();
            }
        }

        private void Supplier_Load(object sender, EventArgs e)
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

            this.Supplier_txt_SupplierId.Focus();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_Supplier.RowCount >= 2)
            {
                Add = false;

                setInputOn();
                dgv_Supplier_CellClick(null, null);
                this.Supplier_txt_SupplierId.Enabled = false;

                this.Supplier_txt_Name.Focus();
                this.Supplier_txt_Address.Focus();
                this.Supplier_txt_PhoneNumber.Focus();
                this.Supplier_txt_Email.Focus();

            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            setInputOff();

            dgv_Supplier_CellClick(null, null);
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
                    BL_Supplier blSupplier = new BL_Supplier();

                    blSupplier.addNewRow(this.Supplier_txt_SupplierId.Text, this.Supplier_txt_Name.Text, this.Supplier_txt_Address.Text, this.Supplier_txt_PhoneNumber.Text, this.Supplier_txt_Email.Text, ref err);

                    LoadData();
                    if(!printError())
                        MessageBox.Show("Done added !");
                }
                catch { MessageBox.Show("Can not add. Error !!!"); }
            }
            else
            {
                BL_Supplier blSupplier = new BL_Supplier();

                blSupplier.updateRow(this.Supplier_txt_SupplierId.Text, this.Supplier_txt_Name.Text, this.Supplier_txt_Address.Text, this.Supplier_txt_PhoneNumber.Text, this.Supplier_txt_Email.Text, ref err);

                LoadData();
                if(!printError())
                    MessageBox.Show("Done editted !");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Supplier.RowCount >= 2)
                {
                    int r = dgv_Supplier.CurrentCell.RowIndex;

                    string strSupplier =
                    dgv_Supplier.Rows[r].Cells[0].Value.ToString();


                    DialogResult reply;

                    reply = MessageBox.Show("Are you sure you want to delete this post ?", "Reply",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (reply == DialogResult.Yes)
                    {
                        db_Supplier.removeRow(strSupplier, ref err);
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
            this.Supplier_txt_SupplierId.ResetText();
            this.Supplier_txt_Name.ResetText();
            this.Supplier_txt_Address.ResetText();
            this.Supplier_txt_PhoneNumber.ResetText();
            this.Supplier_txt_Email.ResetText();

            this.btn_Save.Enabled = false;
            this.btn_Cancel.Enabled = false;
            this.Supplier_pl_Input.Enabled = false;

            this.btn_Add.Enabled = true;
            this.btn_Edit.Enabled = true;
            this.btn_Delete.Enabled = true;
        }
        private void setInputOn()
        {
            this.Supplier_txt_SupplierId.Enabled = true;

            this.Supplier_txt_SupplierId.ResetText();
            this.Supplier_txt_Name.ResetText();
            this.Supplier_txt_Address.ResetText();
            this.Supplier_txt_PhoneNumber.ResetText();
            this.Supplier_txt_Email.ResetText();

            this.btn_Save.Enabled = true;
            this.btn_Cancel.Enabled = true;
            this.Supplier_pl_Input.Enabled = true;

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
            if (checkSpecialCharactersForString(Supplier_txt_SupplierId.Text) ||
                checkSpecialCharactersForString(Supplier_txt_Name.Text) ||
                checkSpecialCharactersForString(Supplier_txt_Address.Text) ||
                checkSpecialCharactersForString(Supplier_txt_PhoneNumber.Text) ||
                checkSpecialCharactersForString(Supplier_txt_Email.Text)
                )
                return true;

            return false;
        }

        //check if there's a special character in the string, return true if yes
        private bool checkSpecialCharactersForString(string str)
        {
            if (str.Contains("!") ||
               str.Contains("\"") ||
               str.Contains("&") ||
               str.Contains("’") ||
               str.Contains(":") ||
               str.Contains(";") ||
               str.Contains("<") ||
               str.Contains(">") ||
               str.Contains("[") ||
               str.Contains("\\") ||
               str.Contains("]") ||
               str.Contains("`") ||
               str.Contains("|") ||
               str.Contains(">")
                )
                return true;

            return false;
        }
    }
}
