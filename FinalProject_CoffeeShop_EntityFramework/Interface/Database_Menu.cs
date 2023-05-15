using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_CoffeeShop.Interface
{
    public partial class Database_Menu : Form
    {
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
                            Bill bill = new Bill();
                            bill.Show();
                            this.Hide();
                            break;
                        }
                    case "Inventory":
                        {
                            Inventory inventory = new Inventory();
                            inventory.Show();
                            this.Hide();
                            break;
                        }
                    case "Supply Purchase":
                        {
                            Supply_Purchase supply_Purchase = new Supply_Purchase();
                            supply_Purchase.Show();
                            this.Hide();
                            break;
                        }
                    case "Employee":
                        {
                            Employee em = new Employee();
                            em.Show();
                            this.Hide();
                            break;
                        }
                    case "Supplier":
                        {
                            Supplier supplier = new Supplier();
                            supplier.Show();
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
                            Remaining_Items remaining_Item = new Remaining_Items();   
                            remaining_Item.Show();  
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
    }
}
