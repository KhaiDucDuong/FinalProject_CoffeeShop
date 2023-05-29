namespace FinalProject_CoffeeShop.Interface
{
    partial class Revenue_Report
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inputted_date_from_lb = new System.Windows.Forms.Label();
            this.inputted_date_to_lb = new System.Windows.Forms.Label();
            this.revenue_from_order_lb = new System.Windows.Forms.Label();
            this.money_cost_for_supplies_lb = new System.Windows.Forms.Label();
            this.balance_lb = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.search_btn);
            this.panel1.Controls.Add(this.btn_GoBack);
            this.panel1.Controls.Add(this.dtp_EndDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtp_StartDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 85);
            this.panel1.TabIndex = 2;
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.AutoSize = true;
            this.btn_GoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GoBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_GoBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoBack.ForeColor = System.Drawing.Color.Black;
            this.btn_GoBack.Location = new System.Drawing.Point(445, 31);
            this.btn_GoBack.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(104, 39);
            this.btn_GoBack.TabIndex = 18;
            this.btn_GoBack.Text = "Go back";
            this.btn_GoBack.UseVisualStyleBackColor = false;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.CustomFormat = "dd/MM/yyyy";
            this.dtp_EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_EndDate.Location = new System.Drawing.Point(264, 38);
            this.dtp_EndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.RightToLeftLayout = true;
            this.dtp_EndDate.ShowUpDown = true;
            this.dtp_EndDate.Size = new System.Drawing.Size(104, 26);
            this.dtp_EndDate.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "TO";
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.CustomFormat = "dd/MM/yyyy";
            this.dtp_StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_StartDate.Location = new System.Drawing.Point(99, 38);
            this.dtp_StartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.RightToLeftLayout = true;
            this.dtp_StartDate.ShowUpDown = true;
            this.dtp_StartDate.Size = new System.Drawing.Size(102, 26);
            this.dtp_StartDate.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "FROM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(163, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "REVENUE CALCULATOR";
            // 
            // search_btn
            // 
            this.search_btn.BackgroundImage = global::FinalProject_CoffeeShop.Properties.Resources.query_icon_4;
            this.search_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_btn.Location = new System.Drawing.Point(385, 31);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(39, 39);
            this.search_btn.TabIndex = 3;
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.inputted_date_to_lb);
            this.panel2.Controls.Add(this.balance_lb);
            this.panel2.Controls.Add(this.money_cost_for_supplies_lb);
            this.panel2.Controls.Add(this.revenue_from_order_lb);
            this.panel2.Controls.Add(this.inputted_date_from_lb);
            this.panel2.Location = new System.Drawing.Point(13, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 228);
            this.panel2.TabIndex = 3;
            // 
            // inputted_date_from_lb
            // 
            this.inputted_date_from_lb.AutoSize = true;
            this.inputted_date_from_lb.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputted_date_from_lb.Location = new System.Drawing.Point(13, 11);
            this.inputted_date_from_lb.Name = "inputted_date_from_lb";
            this.inputted_date_from_lb.Size = new System.Drawing.Size(78, 33);
            this.inputted_date_from_lb.TabIndex = 0;
            this.inputted_date_from_lb.Text = "From";
            // 
            // inputted_date_to_lb
            // 
            this.inputted_date_to_lb.AutoSize = true;
            this.inputted_date_to_lb.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputted_date_to_lb.Location = new System.Drawing.Point(211, 11);
            this.inputted_date_to_lb.Name = "inputted_date_to_lb";
            this.inputted_date_to_lb.Size = new System.Drawing.Size(50, 33);
            this.inputted_date_to_lb.TabIndex = 0;
            this.inputted_date_to_lb.Text = "To ";
            // 
            // revenue_from_order_lb
            // 
            this.revenue_from_order_lb.AutoSize = true;
            this.revenue_from_order_lb.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenue_from_order_lb.Location = new System.Drawing.Point(13, 70);
            this.revenue_from_order_lb.Name = "revenue_from_order_lb";
            this.revenue_from_order_lb.Size = new System.Drawing.Size(275, 33);
            this.revenue_from_order_lb.TabIndex = 0;
            this.revenue_from_order_lb.Text = "Revenue from orders:";
            // 
            // money_cost_for_supplies_lb
            // 
            this.money_cost_for_supplies_lb.AutoSize = true;
            this.money_cost_for_supplies_lb.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money_cost_for_supplies_lb.Location = new System.Drawing.Point(11, 128);
            this.money_cost_for_supplies_lb.Name = "money_cost_for_supplies_lb";
            this.money_cost_for_supplies_lb.Size = new System.Drawing.Size(304, 33);
            this.money_cost_for_supplies_lb.TabIndex = 0;
            this.money_cost_for_supplies_lb.Text = "Money cost for supplies:";
            // 
            // balance_lb
            // 
            this.balance_lb.AutoSize = true;
            this.balance_lb.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance_lb.Location = new System.Drawing.Point(11, 182);
            this.balance_lb.Name = "balance_lb";
            this.balance_lb.Size = new System.Drawing.Size(115, 33);
            this.balance_lb.TabIndex = 0;
            this.balance_lb.Text = "Balance:";
            // 
            // Revenue_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 343);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Revenue_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Revenue Report";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label inputted_date_to_lb;
        private System.Windows.Forms.Label balance_lb;
        private System.Windows.Forms.Label money_cost_for_supplies_lb;
        private System.Windows.Forms.Label revenue_from_order_lb;
        private System.Windows.Forms.Label inputted_date_from_lb;
    }
}