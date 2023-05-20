using FinalProject_CoffeeShop.Ado_Net.BL;
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
    public partial class Inventory_Info : Form
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

        DataTable dt;
        bool add;
        string error = "";
        BL_InventoryInfo db = new BL_InventoryInfo();

        public Inventory_Info()
        {
            InitializeComponent();
        }

        private void Inventory_Info_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            try
            {
                getDataFromTable();

                setInputButtonsOff();

                dgv_InventoryInfo_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Failed to get data from the requested Table!", "Load Data error");
            }
        }

        private void reloadBt_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_CheckInventory_Click(object sender, EventArgs e)
        {
            Inventory invent = new Inventory();
            invent.Show();
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

            this.InventoryInfo_txt_CheckId.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (add)
            {
                addRow();
            }
            else
            {
                updateRow();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_InventoryInfo.RowCount >= 2)
            {
                add = false;

                setInputButtonsOn();

                dgv_InventoryInfo_CellClick(null, null);

                this.InventoryInfo_txt_CheckId.Enabled = false;
                this.InventoryInfo_IngredientId.Enabled = false;

                this.InventoryInfo_txt_QuantityPerUnit.Focus();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_InventoryInfo.RowCount >= 2)
            {
                int rowIndex = dgv_InventoryInfo.CurrentCell.RowIndex;

                string selectedItemID = dgv_InventoryInfo.Rows[rowIndex].Cells[0].Value.ToString();
                string ingredient_id = dgv_InventoryInfo.Rows[rowIndex].Cells[1].Value.ToString();


                deleteRow(selectedItemID, ingredient_id);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            setInputButtonsOff();

            dgv_InventoryInfo_CellClick(null, null);
        }

        private void dgv_InventoryInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_InventoryInfo.RowCount >= 2)
            {
                int rowIndex = dgv_InventoryInfo.CurrentCell.RowIndex;

                this.InventoryInfo_txt_CheckId.Text = dgv_InventoryInfo.Rows[rowIndex].Cells[0].Value.ToString();
                this.InventoryInfo_IngredientId.Text = dgv_InventoryInfo.Rows[rowIndex].Cells[1].Value.ToString();
                this.InventoryInfo_txt_QuantityPerUnit.Text = dgv_InventoryInfo.Rows[rowIndex].Cells[2].Value.ToString();
            }
        }

        private void addRow()
        {
            if (checkSpecialCharactersForTextBoxes())
            {
                MessageBox.Show("Cannot use special characters!", "String error");
                return;
            }

            try
            {
                db.addNewRow(this.InventoryInfo_txt_CheckId.Text, this.InventoryInfo_IngredientId.Text, this.InventoryInfo_txt_QuantityPerUnit.Text, ref error);

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
            if (checkSpecialCharactersForTextBoxes())
            {
                MessageBox.Show("Cannot use special characters!", "String error");
                return;
            }

            try
            {
                db.updateRow(this.InventoryInfo_txt_CheckId.Text, this.InventoryInfo_IngredientId.Text, this.InventoryInfo_txt_QuantityPerUnit.Text, ref error);
                loadData();
                if (!printError())
                    MessageBox.Show("Update a new row successfully!", "Non Query execution status");
            }
            catch (SqlException)
            {
                MessageBox.Show("Failed to update a new row!", "Non Query execution status");
            }
        }
        private void deleteRow(string selectedItemID, string ingredient_id)
        {
            DialogResult answer;

            answer = MessageBox.Show("Do you want to delete this row?", "Deleting row", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                db.removeRow(selectedItemID, ingredient_id, ref error);
                loadData();
                if (!printError())
                    MessageBox.Show("Delete selected row successfully!", "Deletion status");

            }
        }

        private void getDataFromTable()
        {
            dgv_InventoryInfo.DataSource = db.getData();
            dgv_InventoryInfo.AutoResizeColumns();
        }
        private void setInputButtonsOff()
        {
            this.InventoryInfo_txt_CheckId.ResetText();
            this.InventoryInfo_IngredientId.ResetText();
            this.InventoryInfo_txt_QuantityPerUnit.ResetText();

            this.btn_Add.Enabled = false;
            this.btn_Cancel.Enabled = false;
            this.btn_Save.Enabled = false;
            this.pl_Input.Enabled = false;

            this.btn_Add.Enabled = true;
            this.btn_Edit.Enabled = true;
            this.btn_Delete.Enabled = true;
            this.btn_GoBack.Enabled = true;
        }

        private void setInputButtonsOn()
        {
            this.InventoryInfo_txt_CheckId.Enabled = true;
            this.InventoryInfo_IngredientId.Enabled = true;

            this.InventoryInfo_txt_CheckId.ResetText();
            this.InventoryInfo_IngredientId.ResetText();
            this.InventoryInfo_txt_QuantityPerUnit.ResetText();

            this.btn_Add.Enabled = true;
            this.btn_Cancel.Enabled = true;
            this.btn_Save.Enabled = true;
            this.pl_Input.Enabled = true;

            this.btn_Add.Enabled = false;
            this.btn_Edit.Enabled = false;
            this.btn_Delete.Enabled = false;
            this.btn_GoBack.Enabled = false;
        }

        private bool printError()
        {
            if (error == "")
                return false;

            MessageBox.Show(error, "Error message");
            error = "";

            return true;
        }

        //display the selected row data on the input panel text boxes


        //return true if there's a special character in any of the text boxes
        private bool checkSpecialCharactersForTextBoxes()
        {
            if (checkSpecialCharactersForString(InventoryInfo_txt_CheckId.Text) ||
                checkSpecialCharactersForString(InventoryInfo_IngredientId.Text) ||
                checkSpecialCharactersForString(InventoryInfo_txt_QuantityPerUnit.Text))
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
