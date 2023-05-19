using FinalProject_CoffeeShop.Ado_Net.BL;
using FinalProject_CoffeeShop_EntityFramework.Ado_Net.BL;
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
    public partial class Remaining_Items : Form
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
        BL_remainingItem db = new BL_remainingItem();

        public Remaining_Items()
        {
            InitializeComponent();
        }

        private void Remaining_Item_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            try
            {
                getDataFromTable();

                setInputButtonsOff();

                dgv_RemainingItem_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Failed to get data from the requested Table!", "Load Data error");
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_RemainingItem.RowCount >= 2)
            {
                add = false;

                setInputButtonsOn();

                dgv_RemainingItem_CellClick(null, null);

                this.RemainingItem_txt_Quantity.Focus();
            }
        }

        private void goBackBt_Click(object sender, EventArgs e)
        {
            Database_Menu curForm = new Database_Menu();
            curForm.Show();
            this.Hide();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            add = true;

            setInputButtonsOn();

            this.RemainingItem_txt_ItemId.Focus();
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

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_RemainingItem.RowCount >= 2)
            {
                int rowIndex = dgv_RemainingItem.CurrentCell.RowIndex;

                string selectedItemID = dgv_RemainingItem.Rows[rowIndex].Cells[0].Value.ToString();

                deleteRow(selectedItemID);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            setInputButtonsOff();

            dgv_RemainingItem_CellClick(null, null);
        }

        private void dgv_RemainingItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_RemainingItem.RowCount >= 2)
            {
                int rowIndex = dgv_RemainingItem.CurrentCell.RowIndex;

                this.RemainingItem_txt_ItemId.Text = dgv_RemainingItem.Rows[rowIndex].Cells[0].Value.ToString();
                this.RemainingItem_txt_Quantity.Text = dgv_RemainingItem.Rows[rowIndex].Cells[1].Value.ToString();
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
                db.addNewRow(this.RemainingItem_txt_ItemId.Text, this.RemainingItem_txt_Quantity.Text, ref error);

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
                db.updateRow(this.RemainingItem_txt_ItemId.Text, this.RemainingItem_txt_Quantity.Text, ref error);
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
            dgv_RemainingItem.DataSource = db.getData();
            dgv_RemainingItem.AutoResizeColumns();
        }
        private void setInputButtonsOff()
        {
            this.RemainingItem_txt_ItemId.ResetText();
            this.RemainingItem_txt_Quantity.ResetText();

            this.btn_Add.Enabled = false;
            this.btn_Cancel.Enabled = false;
            this.btn_Save.Enabled = false;
            this.pl_Input.Enabled = false;

            this.btn_Add.Enabled = true;
            this.btn_Edit.Enabled = true;
            this.btn_Delete.Enabled = true;
            this.goBackBt.Enabled = true;
        }

        private void setInputButtonsOn()
        {
            this.RemainingItem_txt_ItemId.ResetText();
            this.RemainingItem_txt_Quantity.ResetText();

            this.btn_Add.Enabled = true;
            this.btn_Cancel.Enabled = true;
            this.btn_Save.Enabled = true;
            this.pl_Input.Enabled = true;

            this.btn_Add.Enabled = false;
            this.btn_Edit.Enabled = false;
            this.btn_Delete.Enabled = false;
            this.goBackBt.Enabled = false;
        }

        private bool printError()
        {
            if (error == "")
                return false;

            MessageBox.Show(error, "Error message");
            error = "";

            return true;
        }

        //return true if there's a special character in any of the text boxes
        private bool checkSpecialCharactersForTextBoxes()
        {
            if (checkSpecialCharactersForString(RemainingItem_txt_ItemId.Text) ||
                checkSpecialCharactersForString(RemainingItem_txt_Quantity.Text)
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
