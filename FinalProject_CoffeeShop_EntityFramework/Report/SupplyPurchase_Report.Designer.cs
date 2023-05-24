namespace FinalProject_CoffeeShop.Report
{
    partial class SupplyPurchase_Report
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.supplyPurchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffee_ShopDataSet = new FinalProject_CoffeeShop.Coffee_ShopDataSet();
            this.reportViewer_SupplyPurchase = new Microsoft.Reporting.WinForms.ReportViewer();
            this.supplyPurchaseTableAdapter = new FinalProject_CoffeeShop.Coffee_ShopDataSetTableAdapters.SupplyPurchaseTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_totalCost = new System.Windows.Forms.Label();
            this.btn_Open_SupplyPurchaseInfo_Querry = new System.Windows.Forms.Button();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.btn_ShowAll = new System.Windows.Forms.Button();
            this.btn_Find = new System.Windows.Forms.Button();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supplyPurchaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffee_ShopDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // supplyPurchaseBindingSource
            // 
            this.supplyPurchaseBindingSource.DataMember = "SupplyPurchase";
            this.supplyPurchaseBindingSource.DataSource = this.coffee_ShopDataSet;
            // 
            // coffee_ShopDataSet
            // 
            this.coffee_ShopDataSet.DataSetName = "Coffee_ShopDataSet";
            this.coffee_ShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer_SupplyPurchase
            // 
            this.reportViewer_SupplyPurchase.AutoSize = true;
            reportDataSource6.Name = "SupplyPurchase";
            reportDataSource6.Value = this.supplyPurchaseBindingSource;
            this.reportViewer_SupplyPurchase.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer_SupplyPurchase.LocalReport.ReportEmbeddedResource = "FinalProject_CoffeeShop.Report.SupplyPurchase_reportWizard.rdlc";
            this.reportViewer_SupplyPurchase.Location = new System.Drawing.Point(13, 179);
            this.reportViewer_SupplyPurchase.Name = "reportViewer_SupplyPurchase";
            this.reportViewer_SupplyPurchase.ServerReport.BearerToken = null;
            this.reportViewer_SupplyPurchase.Size = new System.Drawing.Size(517, 259);
            this.reportViewer_SupplyPurchase.TabIndex = 0;
            // 
            // supplyPurchaseTableAdapter
            // 
            this.supplyPurchaseTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_totalCost);
            this.panel1.Controls.Add(this.btn_Open_SupplyPurchaseInfo_Querry);
            this.panel1.Controls.Add(this.btn_GoBack);
            this.panel1.Controls.Add(this.btn_ShowAll);
            this.panel1.Controls.Add(this.btn_Find);
            this.panel1.Controls.Add(this.dtp_EndDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtp_StartDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 160);
            this.panel1.TabIndex = 1;
            // 
            // lb_totalCost
            // 
            this.lb_totalCost.AutoSize = true;
            this.lb_totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalCost.Location = new System.Drawing.Point(7, 91);
            this.lb_totalCost.Name = "lb_totalCost";
            this.lb_totalCost.Size = new System.Drawing.Size(95, 24);
            this.lb_totalCost.TabIndex = 20;
            this.lb_totalCost.Text = "Total cost:";
            // 
            // btn_Open_SupplyPurchaseInfo_Querry
            // 
            this.btn_Open_SupplyPurchaseInfo_Querry.AutoSize = true;
            this.btn_Open_SupplyPurchaseInfo_Querry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Open_SupplyPurchaseInfo_Querry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_Open_SupplyPurchaseInfo_Querry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Open_SupplyPurchaseInfo_Querry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Open_SupplyPurchaseInfo_Querry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Open_SupplyPurchaseInfo_Querry.ForeColor = System.Drawing.Color.Black;
            this.btn_Open_SupplyPurchaseInfo_Querry.Location = new System.Drawing.Point(307, 88);
            this.btn_Open_SupplyPurchaseInfo_Querry.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Open_SupplyPurchaseInfo_Querry.Name = "btn_Open_SupplyPurchaseInfo_Querry";
            this.btn_Open_SupplyPurchaseInfo_Querry.Size = new System.Drawing.Size(197, 27);
            this.btn_Open_SupplyPurchaseInfo_Querry.TabIndex = 19;
            this.btn_Open_SupplyPurchaseInfo_Querry.Text = "Open SupplyPurchase info query";
            this.btn_Open_SupplyPurchaseInfo_Querry.UseVisualStyleBackColor = false;
            this.btn_Open_SupplyPurchaseInfo_Querry.Click += new System.EventHandler(this.btn_Open_SupplyPurchaseInfo_Querry_Click);
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
            this.btn_GoBack.Location = new System.Drawing.Point(306, 123);
            this.btn_GoBack.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(198, 27);
            this.btn_GoBack.TabIndex = 18;
            this.btn_GoBack.Text = "Go back";
            this.btn_GoBack.UseVisualStyleBackColor = false;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // btn_ShowAll
            // 
            this.btn_ShowAll.AutoSize = true;
            this.btn_ShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_ShowAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_ShowAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_ShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowAll.ForeColor = System.Drawing.Color.Black;
            this.btn_ShowAll.Location = new System.Drawing.Point(11, 123);
            this.btn_ShowAll.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ShowAll.Name = "btn_ShowAll";
            this.btn_ShowAll.Size = new System.Drawing.Size(76, 27);
            this.btn_ShowAll.TabIndex = 17;
            this.btn_ShowAll.Text = "Show All";
            this.btn_ShowAll.UseVisualStyleBackColor = false;
            this.btn_ShowAll.Click += new System.EventHandler(this.btn_ShowAll_Click);
            // 
            // btn_Find
            // 
            this.btn_Find.AutoSize = true;
            this.btn_Find.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Find.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Find.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btn_Find.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Find.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Find.Location = new System.Drawing.Point(204, 88);
            this.btn_Find.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(76, 32);
            this.btn_Find.TabIndex = 16;
            this.btn_Find.Text = "FIND";
            this.btn_Find.UseVisualStyleBackColor = false;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.CustomFormat = "dd/MM/yyyy";
            this.dtp_EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_EndDate.Location = new System.Drawing.Point(306, 52);
            this.dtp_EndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.RightToLeftLayout = true;
            this.dtp_EndDate.ShowUpDown = true;
            this.dtp_EndDate.Size = new System.Drawing.Size(103, 26);
            this.dtp_EndDate.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 52);
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
            this.dtp_StartDate.Location = new System.Drawing.Point(77, 52);
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
            this.label2.Location = new System.Drawing.Point(7, 54);
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
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(105, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "SUPPLY PURCHASE SEARCH";
            // 
            // SupplyPurchase_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer_SupplyPurchase);
            this.Name = "SupplyPurchase_Report";
            this.Text = "SupplyPurchase Report";
            this.Load += new System.EventHandler(this.SupplyPurchase_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplyPurchaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffee_ShopDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_SupplyPurchase;
        private Coffee_ShopDataSet coffee_ShopDataSet;
        private System.Windows.Forms.BindingSource supplyPurchaseBindingSource;
        private Coffee_ShopDataSetTableAdapters.SupplyPurchaseTableAdapter supplyPurchaseTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_totalCost;
        private System.Windows.Forms.Button btn_Open_SupplyPurchaseInfo_Querry;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Button btn_ShowAll;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}