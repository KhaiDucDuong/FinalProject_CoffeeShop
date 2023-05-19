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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

using FinalProject_CoffeeShop.Ado_Net.BL;
using System.Runtime.Remoting.Messaging;

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

        DataTable dt;
        bool add;
        string error = "";
        BL_item db = new BL_item();

        public Item()
        {
            InitializeComponent();
        }

        private void Item_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            try
            {
                getDataFromTable();

                setInputButtonsOff();

                dgv_Item_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Failed to get data from the requested Table!", "Load Data error");
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            add = true;

            setInputButtonsOn();

            this.Item_txt_ItemId.Focus();
        }

        

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            Database_Menu curForm = new Database_Menu();
            curForm.Show();
            this.Hide();
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

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_Item.RowCount >= 2)
            {
                add = false;

                setInputButtonsOn();

                dgv_Item_CellClick(null, null);

                this.Item_txt_ItemName.Focus();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Item.RowCount >= 2)
            {
                int rowIndex = dgv_Item.CurrentCell.RowIndex;

                string selectedItemID = dgv_Item.Rows[rowIndex].Cells[0].Value.ToString();

                deleteRow(selectedItemID);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            setInputButtonsOff();

            dgv_Item_CellClick(null, null);
        }

        private void dgv_Item_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Item.RowCount >= 2)
            {
                int rowIndex = dgv_Item.CurrentCell.RowIndex;

                this.Item_txt_ItemId.Text = dgv_Item.Rows[rowIndex].Cells[0].Value.ToString();
                this.Item_txt_ItemName.Text = dgv_Item.Rows[rowIndex].Cells[1].Value.ToString();
                this.Item_txt_ItemPrice.Text = dgv_Item.Rows[rowIndex].Cells[2].Value.ToString();
            }
        }
        private void addRow()
        {
            if(checkSpecialCharactersForTextBoxes())
            {
                MessageBox.Show("Cannot use special characters!", "String error");
                return;
            }

            try
            {
                db.addNewRow(this.Item_txt_ItemId.Text, this.Item_txt_ItemName.Text, this.Item_txt_ItemPrice.Text, ref error);

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
                db.updateRow(this.Item_txt_ItemId.Text, this.Item_txt_ItemName.Text, this.Item_txt_ItemPrice.Text, ref error);
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
            dgv_Item.DataSource = db.getData();
            dgv_Item.AutoResizeColumns();
        }
        private void setInputButtonsOff()
        {
            this.Item_txt_ItemId.ResetText();
            this.Item_txt_ItemName.ResetText();
            this.Item_txt_ItemPrice.ResetText();

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
            this.Item_txt_ItemId.ResetText();
            this.Item_txt_ItemName.ResetText();
            this.Item_txt_ItemPrice.ResetText();

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
            if (checkSpecialCharactersForString(Item_txt_ItemId.Text)   ||
                checkSpecialCharactersForString(Item_txt_ItemName.Text) ||
                checkSpecialCharactersForString(Item_txt_ItemPrice.Text))
                return true;

            return false;
        }

        //check if there's a special character in the string, return true if yes
        private bool checkSpecialCharactersForString(string str )
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
