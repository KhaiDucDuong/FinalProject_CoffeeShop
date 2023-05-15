namespace FinalProject_CoffeeShop.Interface
{
    partial class Database_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Help = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Lb_Menu = new System.Windows.Forms.Label();
            this.DatabaseListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Help
            // 
            this.btn_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Help.Location = new System.Drawing.Point(281, 238);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(98, 44);
            this.btn_Help.TabIndex = 12;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = true;
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.Location = new System.Drawing.Point(281, 171);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(98, 44);
            this.btn_LogOut.TabIndex = 11;
            this.btn_LogOut.Text = "Log out";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            // 
            // btn_Open
            // 
            this.btn_Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Open.Location = new System.Drawing.Point(281, 102);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(98, 44);
            this.btn_Open.TabIndex = 10;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Database list:";
            // 
            // Lb_Menu
            // 
            this.Lb_Menu.AutoSize = true;
            this.Lb_Menu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Lb_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lb_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Menu.Location = new System.Drawing.Point(120, 23);
            this.Lb_Menu.Name = "Lb_Menu";
            this.Lb_Menu.Size = new System.Drawing.Size(169, 34);
            this.Lb_Menu.TabIndex = 8;
            this.Lb_Menu.Text = "Coffee shop";
            // 
            // DatabaseListBox
            // 
            this.DatabaseListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseListBox.FormattingEnabled = true;
            this.DatabaseListBox.ItemHeight = 22;
            this.DatabaseListBox.Items.AddRange(new object[] {
            "Bill",
            "Remaining Items",
            "Inventory",
            "Supply Purchase",
            "Employee",
            "Supplier",
            "Ingredient",
            "Item"});
            this.DatabaseListBox.Location = new System.Drawing.Point(21, 102);
            this.DatabaseListBox.Name = "DatabaseListBox";
            this.DatabaseListBox.Size = new System.Drawing.Size(200, 180);
            this.DatabaseListBox.TabIndex = 7;
            this.DatabaseListBox.SelectedIndexChanged += new System.EventHandler(this.DatabaseListBox_SelectedIndexChanged);
            // 
            // Database_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 312);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lb_Menu);
            this.Controls.Add(this.DatabaseListBox);
            this.Name = "Database_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database_Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Database_Menu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lb_Menu;
        private System.Windows.Forms.ListBox DatabaseListBox;
    }
}