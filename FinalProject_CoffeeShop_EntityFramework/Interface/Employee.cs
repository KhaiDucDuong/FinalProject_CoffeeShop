﻿
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
        string err;
        //BL_Employee db_Employee = new BL_Employee();

        public Employee()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                //dgv_Employee.DataSource = db_Employee.GetEmployee();

                dgv_Employee.AutoResizeColumns();

                setInputOff();

                dgv_Employee_CellClick(null, null);


            }
            catch { MessageBox.Show("Can not get the content in the Bill table. Error !!!"); }
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
                int r = dgv_Employee.CurrentCell.RowIndex;

                this.Employee_txt_EmployeeId.Text = dgv_Employee.Rows[r].Cells[0].Value.ToString();
                this.Employee_txt_FirstName.Text = dgv_Employee.Rows[r].Cells[1].Value.ToString();
                this.Employee_txt_LastName.Text = dgv_Employee.Rows[r].Cells[2].Value.ToString();
                this.Employee_dtp_DateJoin.Text = dgv_Employee.Rows[r].Cells[3].Value.ToString();
                this.Employee_dtp_DateLeft.Text = dgv_Employee.Rows[r].Cells[4].Value.ToString();
            }
        }

        private void Employee_Load(object sender, EventArgs e)
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
                this.Employee_txt_LastName.Focus();
                this.Employee_dtp_DateJoin.Focus();
                this.Employee_dtp_DateLeft.Focus();

            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            setInputOff();

            dgv_Employee_CellClick(null, null);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (Add)
            {
                try
                {
                    //BL_Employee blEmployee = new BL_Employee();

                    //blEmployee.AddEmployee(this.Employee_txt_EmployeeId.Text, this.Employee_txt_FirstName.Text, this.Employee_txt_LastName.Text, this.Employee_dtp_DateJoin.Text, this.Employee_dtp_DateLeft.Text, ref err);

                    LoadData();
                    MessageBox.Show("Done added !");
                }
                catch { MessageBox.Show("Can not add. Error !!!"); }
            }
            else
            {
                //BL_Employee blEmployee = new BL_Employee();

                //blEmployee.UpdateEmployee(this.Employee_txt_EmployeeId.Text, this.Employee_txt_FirstName.Text, this.Employee_txt_LastName.Text, this.Employee_dtp_DateJoin.Text, this.Employee_dtp_DateLeft.Text, ref err);

                LoadData();

                MessageBox.Show("Done editted !");
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

                        //db_Employee.DeleteEmployee(strBill, ref err);
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
            this.Employee_txt_EmployeeId.ResetText();
            this.Employee_txt_FirstName.ResetText();
            this.Employee_txt_LastName.ResetText();
            this.Employee_dtp_DateJoin.ResetText();
            this.Employee_dtp_DateLeft.ResetText();

            this.btn_Save.Enabled = false;
            this.btn_Cancel.Enabled = false;
            this.Employee_pl_Input.Enabled = false;

            this.btn_Add.Enabled = true;
            this.btn_Edit.Enabled = true;
            this.btn_Delete.Enabled = true;
        }
        private void setInputOn()
        {
            this.Employee_txt_EmployeeId.ResetText();
            this.Employee_txt_FirstName.ResetText();
            this.Employee_txt_LastName.ResetText();
            this.Employee_dtp_DateJoin.ResetText();
            this.Employee_dtp_DateLeft.ResetText();

            this.btn_Save.Enabled = true;
            this.btn_Cancel.Enabled = true;
            this.Employee_pl_Input.Enabled = true;

            this.btn_Add.Enabled = false;
            this.btn_Edit.Enabled = false;
            this.btn_Delete.Enabled = false;
        }
    }
}
