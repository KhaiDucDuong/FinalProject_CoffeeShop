using FinalProject_CoffeeShop.Query_Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject_CoffeeShop.Report;

namespace FinalProject_CoffeeShop.Interface
{
    public partial class Database_Menu : Form
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


        public Database_Menu()
        {
            InitializeComponent();
        }

        private void DatabaseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            if (DatabaseListBox.SelectedIndex != -1)
            {
                string selectedDatabase = DatabaseListBox.SelectedItem.ToString();
                switch (selectedDatabase)
                {
                    case "Bill":
                        {
                            Bill curForm = new Bill();
                            curForm.Show();
                            this.Hide();
                            break;
                        }
                    case "Inventory":
                        {
                            Inventory curForm = new Inventory();
                            curForm.Show();
                            this.Hide();
                            break;
                        }
                    case "Supply Purchase":
                        {
                            Supply_Purchase curForm = new Supply_Purchase();
                            curForm.Show();
                            this.Hide();
                            break;
                        }
                    case "Employee":
                        {
                            Employee curForm = new Employee();
                            curForm.Show();
                            this.Hide();
                            break;
                        }
                    case "Supplier":
                        {
                            Supplier curForm = new Supplier();
                            curForm.Show();
                            this.Hide();
                            break;
                        }
                    case "Ingredient":
                        {
                            Ingredient curForm = new Ingredient();
                            curForm.Show();
                            this.Hide();
                            break;
                        }
                    case "Item":
                        {
                            Item curForm = new Item();
                            curForm.Show();
                            this.Hide();
                            break;
                        }
                    case "Remaining Items":
                        {
                            Remaining_Items curForm = new Remaining_Items();
                            curForm.Show();  
                            this.Hide();
                            break;
                        }
                    case "Bill Query":
                        {
                            Bill_Query curForm = new Bill_Query();
                            curForm.Show();
                            this.Hide();
                            break;
                        }
                    case "SupplyPurchase Query":
                        {
                            SupplyPurchase_Report curForm = new SupplyPurchase_Report();
                            curForm.Show();
                            this.Hide();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            //inform user to select a database
            else
            {
                MessageBox.Show("Please select a database to open!", "No selected database");
            }
        }

        private void Database_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a Coffee shop management program developed by Duong Duc Khai, To Duc An, and Ngo Dinh Huy.\n\n" +
                "To make changes in the database, choose the name of a table you want to visit then click 'Open'\n" +
                "You can query Bill table by choosing 'Bill Query'\n" +
                "You can query and see reports of Supply Purchase table by choosing 'SupplyPurchase Query'", "Help menu");
        }
    }
}
