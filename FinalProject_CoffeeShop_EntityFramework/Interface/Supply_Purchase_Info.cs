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
    public partial class Supply_Purchase_Info : Form
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
        bool add;
        string error = "";
        BL_supplypurchaseinfo db_supplypurchaseinfo = new BL_supplypurchaseinfo();


        public Supply_Purchase_Info()
        {
            InitializeComponent();
        }
        private void Supply_Purchase_Info_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void btn_OpenSupplyPurchase_Click(object sender, EventArgs e)
        {
            Supply_Purchase supply_Purchase = new Supply_Purchase();
            supply_Purchase.Show();
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

            this.PurchaseInfo_txt_PurchaseId.Focus();
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

        //get data from Item table again
        private void btn_Reload_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_Purchase_Info.RowCount >= 2)
            {
                add = false;

                setInputButtonsOn();

                SupplypurchaseDGV_CellClick(null, null);
                this.PurchaseInfo_txt_PurchaseId.Enabled = false;
                this.PurchaseInfo_txt_IngredientId.Enabled = false;

                this.PurchaseInfo_txt_PurchasePrice.Focus();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Purchase_Info.RowCount >= 2)
            {
                int rowIndex = dgv_Purchase_Info.CurrentCell.RowIndex;

                string selectedPurchaseID = dgv_Purchase_Info.Rows[rowIndex].Cells[0].Value.ToString();
                string selectedIngredientID = dgv_Purchase_Info.Rows[rowIndex].Cells[1].Value.ToString();


                deleteRow(selectedPurchaseID, selectedIngredientID);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            setInputButtonsOff();

            SupplypurchaseDGV_CellClick(null, null);
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
        private void setInputButtonsOff()
        {
            this.PurchaseInfo_txt_PurchaseId.ResetText();
            this.PurchaseInfo_txt_IngredientId.ResetText();
            this.PurchaseInfo_txt_QuantityPerUnit.ResetText();
            this.PurchaseInfo_txt_PurchasePrice.ResetText();

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
            this.PurchaseInfo_txt_PurchaseId.Enabled = true;
            this.PurchaseInfo_txt_IngredientId.Enabled = true;

            this.PurchaseInfo_txt_PurchaseId.ResetText();
            this.PurchaseInfo_txt_IngredientId.ResetText();
            this.PurchaseInfo_txt_QuantityPerUnit.ResetText();
            this.PurchaseInfo_txt_PurchasePrice.ResetText();

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
                db_supplypurchaseinfo.addNewRow(this.PurchaseInfo_txt_PurchaseId.Text, this.PurchaseInfo_txt_IngredientId.Text, this.PurchaseInfo_txt_QuantityPerUnit.Text, this.PurchaseInfo_txt_PurchasePrice.Text, ref error);

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
                db_supplypurchaseinfo.updateRow(this.PurchaseInfo_txt_PurchaseId.Text, this.PurchaseInfo_txt_IngredientId.Text, this.PurchaseInfo_txt_QuantityPerUnit.Text, this.PurchaseInfo_txt_PurchasePrice.Text, ref error);
                loadData();
                if (!printError())
                    MessageBox.Show("Update a new row successfully!", "Non Query execution status");
            }
            catch (SqlException)
            {
                MessageBox.Show("Failed to update a new row!", "Non Query execution status");
            }
        }
        private void deleteRow(string selectedPurchaseID, string selectedIngredientID)
        {
            DialogResult answer;

            answer = MessageBox.Show("Do you want to delete this row?", "Deleting row", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                db_supplypurchaseinfo.removeRow(selectedPurchaseID, selectedIngredientID, ref error);
                loadData();
                if (!printError())
                    MessageBox.Show("Delete selected row successfully!", "Deletion status");

            }
        }

        private void getDataFromTable()
        {

            dgv_Purchase_Info.DataSource = db_supplypurchaseinfo.getData();
            dgv_Purchase_Info.AutoResizeColumns();

        }

        //get data from Item table
        private void SupplypurchaseDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Purchase_Info.RowCount >= 2)
            {
                int rowIndex = dgv_Purchase_Info.CurrentCell.RowIndex;

                this.PurchaseInfo_txt_PurchaseId.Text = dgv_Purchase_Info.Rows[rowIndex].Cells[0].Value.ToString();
                this.PurchaseInfo_txt_IngredientId.Text = dgv_Purchase_Info.Rows[rowIndex].Cells[1].Value.ToString();
                this.PurchaseInfo_txt_QuantityPerUnit.Text = dgv_Purchase_Info.Rows[rowIndex].Cells[2].Value.ToString();
                this.PurchaseInfo_txt_PurchasePrice.Text = dgv_Purchase_Info.Rows[rowIndex].Cells[3].Value.ToString();
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
            if (checkSpecialCharactersForString(PurchaseInfo_txt_PurchaseId.Text) ||
                checkSpecialCharactersForString(PurchaseInfo_txt_IngredientId.Text) ||
                checkSpecialCharactersForString(PurchaseInfo_txt_QuantityPerUnit.Text) ||
                checkSpecialCharactersForString(PurchaseInfo_txt_PurchasePrice.Text)
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
