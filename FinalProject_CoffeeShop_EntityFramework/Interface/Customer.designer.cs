using System.Drawing;
using System.Windows.Forms;

namespace coffee_shop2
{
    partial class Customer
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
            this.Customer_dtp_Time = new System.Windows.Forms.DateTimePicker();
            this.TimeLB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.quantity_BT6 = new System.Windows.Forms.NumericUpDown();
            this.quantity_BT5 = new System.Windows.Forms.NumericUpDown();
            this.quantity_BT4 = new System.Windows.Forms.NumericUpDown();
            this.quantity_BT3 = new System.Windows.Forms.NumericUpDown();
            this.quantity_BT2 = new System.Windows.Forms.NumericUpDown();
            this.quantity_BT1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.confirm_paymentBT = new System.Windows.Forms.Button();
            this.go_backBT = new System.Windows.Forms.Button();
            this.Customor_reloadBT = new System.Windows.Forms.Button();
            this.customer_removeBT = new System.Windows.Forms.Button();
            this.customor_add = new System.Windows.Forms.Button();
            this.Customer_dgv_ = new System.Windows.Forms.DataGridView();
            this.previous_pageBT = new System.Windows.Forms.Button();
            this.next_pageBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_BT6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_BT5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_BT4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_BT3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_BT2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_BT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_dgv_)).BeginInit();
            this.SuspendLayout();
            // 
            // Customer_dtp_Time
            // 
            this.Customer_dtp_Time.CustomFormat = "hh:mm:ss  dd/MM/yyyy";
            this.Customer_dtp_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Customer_dtp_Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Customer_dtp_Time.Location = new System.Drawing.Point(148, 45);
            this.Customer_dtp_Time.Name = "Customer_dtp_Time";
            this.Customer_dtp_Time.Size = new System.Drawing.Size(231, 29);
            this.Customer_dtp_Time.TabIndex = 0;
            // 
            // TimeLB
            // 
            this.TimeLB.AutoSize = true;
            this.TimeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TimeLB.Location = new System.Drawing.Point(41, 48);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(56, 25);
            this.TimeLB.TabIndex = 1;
            this.TimeLB.Text = "Time";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.quantity_BT6);
            this.panel1.Controls.Add(this.quantity_BT5);
            this.panel1.Controls.Add(this.quantity_BT4);
            this.panel1.Controls.Add(this.quantity_BT3);
            this.panel1.Controls.Add(this.quantity_BT2);
            this.panel1.Controls.Add(this.quantity_BT1);
            this.panel1.Controls.Add(this.checkBox6);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 339);
            this.panel1.TabIndex = 2;
            // 
            // quantity_BT6
            // 
            this.quantity_BT6.Location = new System.Drawing.Point(521, 279);
            this.quantity_BT6.Name = "quantity_BT6";
            this.quantity_BT6.Size = new System.Drawing.Size(48, 22);
            this.quantity_BT6.TabIndex = 23;
            // 
            // quantity_BT5
            // 
            this.quantity_BT5.Location = new System.Drawing.Point(319, 277);
            this.quantity_BT5.Name = "quantity_BT5";
            this.quantity_BT5.Size = new System.Drawing.Size(48, 22);
            this.quantity_BT5.TabIndex = 22;
            // 
            // quantity_BT4
            // 
            this.quantity_BT4.Location = new System.Drawing.Point(118, 278);
            this.quantity_BT4.Name = "quantity_BT4";
            this.quantity_BT4.Size = new System.Drawing.Size(48, 22);
            this.quantity_BT4.TabIndex = 21;
            // 
            // quantity_BT3
            // 
            this.quantity_BT3.Location = new System.Drawing.Point(521, 127);
            this.quantity_BT3.Name = "quantity_BT3";
            this.quantity_BT3.Size = new System.Drawing.Size(48, 22);
            this.quantity_BT3.TabIndex = 20;
            // 
            // quantity_BT2
            // 
            this.quantity_BT2.Location = new System.Drawing.Point(319, 128);
            this.quantity_BT2.Name = "quantity_BT2";
            this.quantity_BT2.Size = new System.Drawing.Size(48, 22);
            this.quantity_BT2.TabIndex = 19;
            // 
            // quantity_BT1
            // 
            this.quantity_BT1.Location = new System.Drawing.Point(118, 128);
            this.quantity_BT1.Name = "quantity_BT1";
            this.quantity_BT1.Size = new System.Drawing.Size(48, 22);
            this.quantity_BT1.TabIndex = 18;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(425, 279);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(95, 20);
            this.checkBox6.TabIndex = 11;
            this.checkBox6.Text = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(223, 279);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(95, 20);
            this.checkBox5.TabIndex = 10;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(22, 279);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(95, 20);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(425, 128);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(95, 20);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(223, 128);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 20);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(22, 128);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(22, 175);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(144, 98);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(425, 175);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(144, 98);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(223, 175);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(144, 98);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(425, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(144, 98);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(223, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 98);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 98);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.confirm_paymentBT);
            this.panel2.Controls.Add(this.go_backBT);
            this.panel2.Controls.Add(this.Customor_reloadBT);
            this.panel2.Controls.Add(this.customer_removeBT);
            this.panel2.Controls.Add(this.customor_add);
            this.panel2.Controls.Add(this.Customer_dgv_);
            this.panel2.Location = new System.Drawing.Point(624, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 394);
            this.panel2.TabIndex = 3;
            // 
            // confirm_paymentBT
            // 
            this.confirm_paymentBT.Location = new System.Drawing.Point(330, 292);
            this.confirm_paymentBT.Name = "confirm_paymentBT";
            this.confirm_paymentBT.Size = new System.Drawing.Size(209, 42);
            this.confirm_paymentBT.TabIndex = 5;
            this.confirm_paymentBT.Text = "Confirm payment";
            this.confirm_paymentBT.UseVisualStyleBackColor = true;
            this.confirm_paymentBT.Click += new System.EventHandler(this.confirm_paymentBT_Click);
            // 
            // go_backBT
            // 
            this.go_backBT.Location = new System.Drawing.Point(330, 340);
            this.go_backBT.Name = "go_backBT";
            this.go_backBT.Size = new System.Drawing.Size(209, 42);
            this.go_backBT.TabIndex = 4;
            this.go_backBT.Text = "Go Back";
            this.go_backBT.UseVisualStyleBackColor = true;
            // 
            // Customor_reloadBT
            // 
            this.Customor_reloadBT.Location = new System.Drawing.Point(330, 113);
            this.Customor_reloadBT.Name = "Customor_reloadBT";
            this.Customor_reloadBT.Size = new System.Drawing.Size(209, 42);
            this.Customor_reloadBT.TabIndex = 3;
            this.Customor_reloadBT.Text = "Reload";
            this.Customor_reloadBT.UseVisualStyleBackColor = true;
            // 
            // customer_removeBT
            // 
            this.customer_removeBT.Location = new System.Drawing.Point(330, 65);
            this.customer_removeBT.Name = "customer_removeBT";
            this.customer_removeBT.Size = new System.Drawing.Size(209, 42);
            this.customer_removeBT.TabIndex = 2;
            this.customer_removeBT.Text = "Remove";
            this.customer_removeBT.UseVisualStyleBackColor = true;
            // 
            // customor_add
            // 
            this.customor_add.Location = new System.Drawing.Point(330, 17);
            this.customor_add.Name = "customor_add";
            this.customor_add.Size = new System.Drawing.Size(209, 42);
            this.customor_add.TabIndex = 1;
            this.customor_add.Text = "Add";
            this.customor_add.UseVisualStyleBackColor = true;
            // 
            // Customer_dgv_
            // 
            this.Customer_dgv_.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Customer_dgv_.Location = new System.Drawing.Point(0, 17);
            this.Customer_dgv_.Name = "Customer_dgv_";
            this.Customer_dgv_.RowHeadersWidth = 51;
            this.Customer_dgv_.RowTemplate.Height = 24;
            this.Customer_dgv_.Size = new System.Drawing.Size(291, 365);
            this.Customer_dgv_.TabIndex = 0;
            // 
            // previous_pageBT
            // 
            this.previous_pageBT.Location = new System.Drawing.Point(56, 432);
            this.previous_pageBT.Name = "previous_pageBT";
            this.previous_pageBT.Size = new System.Drawing.Size(194, 49);
            this.previous_pageBT.TabIndex = 4;
            this.previous_pageBT.Text = "Previous page";
            this.previous_pageBT.UseVisualStyleBackColor = true;
            // 
            // next_pageBT
            // 
            this.next_pageBT.Location = new System.Drawing.Point(387, 432);
            this.next_pageBT.Name = "next_pageBT";
            this.next_pageBT.Size = new System.Drawing.Size(194, 49);
            this.next_pageBT.TabIndex = 5;
            this.next_pageBT.Text = "Next page";
            this.next_pageBT.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(555, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 27);
            this.label1.TabIndex = 55;
            this.label1.Text = "CUSTOMER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.next_pageBT);
            this.Controls.Add(this.previous_pageBT);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TimeLB);
            this.Controls.Add(this.Customer_dtp_Time);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_BT6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_BT5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_BT4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_BT3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_BT2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_BT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Customer_dgv_)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Customer_dtp_Time;
        private System.Windows.Forms.Label TimeLB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Customer_dgv_;
        private System.Windows.Forms.NumericUpDown quantity_BT6;
        private System.Windows.Forms.NumericUpDown quantity_BT5;
        private System.Windows.Forms.NumericUpDown quantity_BT4;
        private System.Windows.Forms.NumericUpDown quantity_BT3;
        private System.Windows.Forms.NumericUpDown quantity_BT2;
        private System.Windows.Forms.NumericUpDown quantity_BT1;
        private System.Windows.Forms.Button previous_pageBT;
        private System.Windows.Forms.Button next_pageBT;
        private Button confirm_paymentBT;
        private Button go_backBT;
        private Button Customor_reloadBT;
        private Button customer_removeBT;
        private Button customor_add;
        private Label label1;
    }
}