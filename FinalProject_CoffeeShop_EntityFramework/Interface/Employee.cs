
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

using FinalProject_CoffeeShop.Ado_Net.BL;

namespace FinalProject_CoffeeShop.Interface
{
    public partial class Employee : Form
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
        BL_Employee db_Employee = new BL_Employee();

        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgv_Employee.DataSource = db_Employee.getData();
                dgv_Employee.AutoResizeColumns();

                setInputOff();

                dgv_Employee_CellClick(null, null);
            }
            catch { MessageBox.Show("Can not get the content in the Employee table. Error !!!"); }
        }




        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            Database_Menu curForm = new Database_Menu();
            curForm.Show();
            this.Hide();
        }


        private void dgv_Employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Employee.RowCount >= 2)
            {
                this.workStatusComboBox.SelectedIndex = 0;

                int r = dgv_Employee.CurrentCell.RowIndex;

                this.Employee_txt_EmployeeId.Text = dgv_Employee.Rows[r].Cells[0].Value.ToString();
                this.Employee_txt_FirstName.Text = dgv_Employee.Rows[r].Cells[1].Value.ToString();
                this.Employee_txt_LastName.Text = dgv_Employee.Rows[r].Cells[2].Value.ToString();
                this.Employee_dtp_DateJoin.Text = dgv_Employee.Rows[r].Cells[3].Value.ToString();
                if(dgv_Employee.Rows[r].Cells[4].Value != DBNull.Value)
                {
                    this.Employee_dtp_DateLeft.Text = dgv_Employee.Rows[r].Cells[4].Value.ToString();
                    this.workStatusComboBox.SelectedIndex = 1;
                }

            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Add = true;

            setInputOn();

            this.Employee_txt_EmployeeId.Focus();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_Employee.RowCount >= 2)
            {
                Add = false;

                setInputOn();
                dgv_Employee_CellClick(null, null);
                this.Employee_txt_EmployeeId.Enabled = false;

                this.Employee_txt_FirstName.Focus();
                
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            setInputOff();

            dgv_Employee_CellClick(null, null);
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
                    BL_Employee blEmployee = new BL_Employee();

                    if(workStatusComboBox.SelectedIndex == 1)
                        blEmployee.addNewRow(this.Employee_txt_EmployeeId.Text, this.Employee_txt_FirstName.Text, this.Employee_txt_LastName.Text, this.Employee_dtp_DateJoin.Text, this.Employee_dtp_DateLeft.Text, ref err);
                    else
                        blEmployee.addNewRow(this.Employee_txt_EmployeeId.Text, this.Employee_txt_FirstName.Text, this.Employee_txt_LastName.Text, this.Employee_dtp_DateJoin.Text, "NULL", ref err);

                    LoadData();
                    if(!printError())
                        MessageBox.Show("Done added !");
                }
                catch { MessageBox.Show("Can not add. Error !!!"); }
            }
            else
            {
                BL_Employee blEmployee = new BL_Employee();

                if (workStatusComboBox.SelectedIndex == 1)
                    blEmployee.updateRow(this.Employee_txt_EmployeeId.Text, this.Employee_txt_FirstName.Text, this.Employee_txt_LastName.Text, this.Employee_dtp_DateJoin.Text, this.Employee_dtp_DateLeft.Text, ref err);
                else
                    blEmployee.updateRow(this.Employee_txt_EmployeeId.Text, this.Employee_txt_FirstName.Text, this.Employee_txt_LastName.Text, this.Employee_dtp_DateJoin.Text, "NULL", ref err);

                LoadData();
                if (!printError())
                    MessageBox.Show("Done editted!");
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Employee.RowCount >= 2)
                {
                    int r = dgv_Employee.CurrentCell.RowIndex;

                    string strBill =
                    dgv_Employee.Rows[r].Cells[0].Value.ToString();


                    DialogResult reply;

                    reply = MessageBox.Show("Are you sure you want to delete this post ?", "Reply",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (reply == DialogResult.Yes)
                    {

                        db_Employee.removeRow(strBill, ref err);
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
            this.Employee_txt_EmployeeId.Enabled= true;

            this.Employee_txt_EmployeeId.ResetText();
            this.Employee_txt_FirstName.ResetText();
            this.Employee_txt_LastName.ResetText();
            this.Employee_dtp_DateJoin.Value = DateTime.Today;
            this.Employee_dtp_DateLeft.Value = DateTime.Today;

            this.btn_Save.Enabled = false;
            this.btn_Cancel.Enabled = false;
            this.Employee_pl_Input.Enabled = false;

            this.btn_Add.Enabled = true;
            this.btn_Edit.Enabled = true;
            this.btn_Delete.Enabled = true;
        }
        private void setInputOn()
        {
            this.Employee_txt_EmployeeId.Enabled = true;

            this.Employee_txt_EmployeeId.ResetText();
            this.Employee_txt_FirstName.ResetText();
            this.Employee_txt_LastName.ResetText();
            this.Employee_dtp_DateJoin.Value = DateTime.Today;
            this.Employee_dtp_DateLeft.Value = DateTime.Today;

            this.btn_Save.Enabled = true;
            this.btn_Cancel.Enabled = true;
            this.Employee_pl_Input.Enabled = true;

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
            if (checkSpecialCharactersForString(Employee_txt_EmployeeId.Text) ||
                checkSpecialCharactersForString(Employee_txt_FirstName.Text) ||
                checkSpecialCharactersForString(Employee_txt_LastName.Text))
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

        private void workStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(workStatusComboBox.SelectedIndex == 0)
            {
                Employee_dtp_DateLeft.Enabled = false;
            }
            else if(workStatusComboBox.SelectedIndex == 1)
            {
                Employee_dtp_DateLeft.Enabled = true;
            }
        }
    }
}
