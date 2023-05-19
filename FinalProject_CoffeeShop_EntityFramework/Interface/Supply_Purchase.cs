using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FinalProject_CoffeeShop.Ado_Net.BL;

namespace FinalProject_CoffeeShop.Interface
{
    public partial class Supply_Purchase : Form
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

        public Supply_Purchase()
        {
            InitializeComponent();
        }
        DataTable dt;
        bool add;
        string error = "";
        BL_supplypurchase db = new BL_supplypurchase();

        private void Supply_Purchase_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void btn_OpenSupplyPurchaseInfo_Click(object sender, EventArgs e)
        {
            Supply_Purchase_Info supplyPurchaseInfo = new Supply_Purchase_Info();
            supplyPurchaseInfo.Show();
            this.Hide();
        }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            Database_Menu curForm = new Database_Menu();
            curForm.Show();
            this.Hide();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            add = true;

            setInputButtonsOn();

            this.SupplyPurchase_txt_PurchaseId.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (checkSpecialCharactersForTextBoxes())
            {
                MessageBox.Show("Cannot use special characters!", "String error");
                return;
            }

            if (add)
            {
                addRow();
            }
            else
            {
                updateRow();
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_SupplyPurchase.RowCount >= 2)
            {
                add = false;

                setInputButtonsOn();

                SupplypurchaseDGV_CellClick(null, null);
                this.SupplyPurchase_txt_PurchaseId.Enabled = false;

                this.SupplyPurchase_txt_PurchaseId.Focus();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_SupplyPurchase.RowCount >= 2)
            {
                int rowIndex = dgv_SupplyPurchase.CurrentCell.RowIndex;

                string selectedItemID = dgv_SupplyPurchase.Rows[rowIndex].Cells[0].Value.ToString();

                deleteRow(selectedItemID);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            setInputButtonsOff();

            SupplypurchaseDGV_CellClick(null, null);
        }


        private void setInputButtonsOff()
        {
            this.SupplyPurchase_txt_PurchaseDate.Value = DateTime.Today;
            this.SupplyPurchase_txt_EmployeeInCharge.ResetText();
            this.SupplyPurchase_txt_PurchaseId.ResetText();
            this.SupplyPurchase_txt_SupplierId.ResetText();

            this.btn_Save.Enabled = false;
            this.btn_Cancel.Enabled = false;
            this.pl_Input.Enabled = false;

            this.btn_Add.Enabled = true;
            this.btn_Edit.Enabled = true;
            this.btn_Delete.Enabled = true;
            this.btn_GoBack.Enabled = true;
        }
        private void setInputButtonsOn()
        {
            this.SupplyPurchase_txt_PurchaseId.Enabled = true;

            this.SupplyPurchase_txt_EmployeeInCharge.ResetText();
            this.SupplyPurchase_txt_PurchaseId.ResetText();
            this.SupplyPurchase_txt_SupplierId.ResetText();
            this.SupplyPurchase_txt_PurchaseDate.Value = DateTime.Today;

            this.btn_Save.Enabled = true;
            this.btn_Cancel.Enabled = true;
            this.pl_Input.Enabled = true;

            this.btn_Add.Enabled = false;
            this.btn_Edit.Enabled = false;
            this.btn_Delete.Enabled = false;
            this.btn_GoBack.Enabled = false;
        }
        private void addRow()
        {
            try
            {
                db.addNewRow(this.SupplyPurchase_txt_PurchaseId.Text, this.SupplyPurchase_txt_EmployeeInCharge.Text, this.SupplyPurchase_txt_SupplierId.Text, this.SupplyPurchase_txt_PurchaseDate.Text, ref error);

                loadData();

                if (!printError())
                    MessageBox.Show("Add a new row successfully!", "Non Query execution status");
            }
            catch (SqlException)
            {
                MessageBox.Show("Failed to add a new row!", "Non Query execution status");
            }
        }
        private void updateRow()
        {
            try
            {
                db.updateRow(this.SupplyPurchase_txt_PurchaseId.Text, this.SupplyPurchase_txt_EmployeeInCharge.Text, this.SupplyPurchase_txt_SupplierId.Text, this.SupplyPurchase_txt_PurchaseDate.Text, ref error);
                loadData();
                if (!printError())
                    MessageBox.Show("Update a new row successfully!", "Non Query execution status");
            }
            catch (SqlException)
            {
                MessageBox.Show("Failed to update a new row!", "Non Query execution status");
            }
        }
        private void deleteRow(string selectedItemID)
        {
            DialogResult answer;

            answer = MessageBox.Show("Do you want to delete this row?", "Deleting row", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                db.removeRow(selectedItemID, ref error);
                loadData();
                if (!printError())
                    MessageBox.Show("Delete selected row successfully!", "Deletion status");

            }
        }

        private void getDataFromTable()
        {
            dgv_SupplyPurchase.DataSource = db.getData();
            dgv_SupplyPurchase.AutoResizeColumns();
        }

        //get data from Item table
        private void loadData()
        {
            try
            {
                getDataFromTable();

                setInputButtonsOff();

                SupplypurchaseDGV_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Failed to get data from the requested Table!", "Load Data error");
            }
        }
        private void SupplypurchaseDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_SupplyPurchase.RowCount >= 2)
            {
                int rowIndex = dgv_SupplyPurchase.CurrentCell.RowIndex;

                this.SupplyPurchase_txt_PurchaseId.Text = dgv_SupplyPurchase.Rows[rowIndex].Cells[0].Value.ToString();
                this.SupplyPurchase_txt_EmployeeInCharge.Text = dgv_SupplyPurchase.Rows[rowIndex].Cells[1].Value.ToString();
                this.SupplyPurchase_txt_SupplierId.Text = dgv_SupplyPurchase.Rows[rowIndex].Cells[2].Value.ToString();
                this.SupplyPurchase_txt_PurchaseDate.Text = dgv_SupplyPurchase.Rows[rowIndex].Cells[3].Value.ToString();
            }
        }
        private bool printError()
        {
            if (error == "")
                return false;

            MessageBox.Show(error, "Error message");
            error = "";

            return true;
        }

        private bool checkSpecialCharactersForTextBoxes()
        {
            if (checkSpecialCharactersForString(SupplyPurchase_txt_PurchaseId.Text) ||
                checkSpecialCharactersForString(SupplyPurchase_txt_EmployeeInCharge.Text) ||
                checkSpecialCharactersForString(SupplyPurchase_txt_SupplierId.Text)
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
               str.Contains("(") ||
               str.Contains(")") ||
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
