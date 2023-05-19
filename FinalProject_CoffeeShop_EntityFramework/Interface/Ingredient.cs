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
    public partial class Ingredient : Form
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
        BL_ingredient db = new BL_ingredient();
        public Ingredient()
        {
            InitializeComponent();
        }

        private void Ingredient_Load(object sender, EventArgs e)
        {
            loadData();
        }

        //get data from Item table
        private void loadData()
        {
            try
            {
                getDataFromTable();

                setInputButtonsOff();

                DGV_Ingredient_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Failed to get data from the requested Table!", "Load Data error");
            }
        }
        private void getDataFromTable()
        {
            dgv_Ingredient.DataSource = db.getData();
            dgv_Ingredient.AutoResizeColumns();
        }
        private void setInputButtonsOff()
        {
            this.Ingredient_txt_IngredientId.ResetText();
            this.Ingredient_txt_IngredientName.ResetText();
            this.Ingredient_txt_Unit.ResetText();

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
            this.Ingredient_txt_IngredientId.Enabled = true;

            this.Ingredient_txt_IngredientId.ResetText();
            this.Ingredient_txt_IngredientName.ResetText();
            this.Ingredient_txt_Unit.ResetText();

            this.btn_Save.Enabled = true;
            this.btn_Cancel.Enabled = true;
            this.pl_Input.Enabled = true;

            this.btn_Add.Enabled = false;
            this.btn_Edit.Enabled = false;
            this.btn_Delete.Enabled = false;
            this.btn_GoBack.Enabled = false;
        }
        //display the selected row data on the input panel text boxes            i

        private void DGV_Ingredient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Ingredient.RowCount >= 2)
            {
                int rowIndex = dgv_Ingredient.CurrentCell.RowIndex;

                this.Ingredient_txt_IngredientId.Text = dgv_Ingredient.Rows[rowIndex].Cells[0].Value.ToString();
                this.Ingredient_txt_IngredientName.Text = dgv_Ingredient.Rows[rowIndex].Cells[1].Value.ToString();
                this.Ingredient_txt_Unit.Text = dgv_Ingredient.Rows[rowIndex].Cells[2].Value.ToString();
            }
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

            this.Ingredient_txt_IngredientId.Focus();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_Ingredient.RowCount >= 2)
            {
                add = false;

                setInputButtonsOn();

                DGV_Ingredient_CellClick(null, null);

                this.Ingredient_txt_IngredientId.Enabled = false;

                this.Ingredient_txt_IngredientName.Focus();
            }
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
        private void addRow()
        {

            try
            {
                db.addNewRow(this.Ingredient_txt_IngredientId.Text, this.Ingredient_txt_IngredientName.Text, this.Ingredient_txt_Unit.Text, ref error);

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
            DialogResult answer;

            answer = MessageBox.Show("Do you want to update this row?", "Updating row", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                try
                {
                    db.updateRow(this.Ingredient_txt_IngredientId.Text, this.Ingredient_txt_IngredientName.Text, this.Ingredient_txt_Unit.Text, ref error);
                    loadData();
                    if (!printError())
                        MessageBox.Show("Update a new row successfully!", "Non Query execution status");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Failed to update a new row!", "Non Query execution status");
                }
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
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Ingredient.RowCount >= 2)
            {
                int rowIndex = dgv_Ingredient.CurrentCell.RowIndex;

                string selectedItemID = dgv_Ingredient.Rows[rowIndex].Cells[0].Value.ToString();

                deleteRow(selectedItemID);
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            setInputButtonsOff();

            DGV_Ingredient_CellClick(null, null);
        }

        private void deleteRow(string selectedIngredientID)
        {
            DialogResult answer;

            answer = MessageBox.Show("Do you want to delete this row?", "Deleting row", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                db.removeRow(selectedIngredientID, ref error);
                loadData();

                if (!printError())
                    MessageBox.Show("Delete selected row successfully!", "Deletion status");
            }
        }

        private bool checkSpecialCharactersForTextBoxes()
        {
            if (checkSpecialCharactersForString(Ingredient_txt_IngredientId.Text) ||
                checkSpecialCharactersForString(Ingredient_txt_IngredientName.Text) ||
                checkSpecialCharactersForString(Ingredient_txt_Unit.Text)
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
