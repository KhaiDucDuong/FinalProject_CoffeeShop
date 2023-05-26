namespace FinalProject_CoffeeShop.Report
{
    partial class SupplyPurchaseInfo_Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.coffee_ShopDataSet = new FinalProject_CoffeeShop.Coffee_ShopDataSet();
            this.SupplyPurchaseDetail_report = new Microsoft.Reporting.WinForms.ReportViewer();
            this.supplyPurchaseDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplyPurchaseDetailsTableAdapter = new FinalProject_CoffeeShop.Coffee_ShopDataSetTableAdapters.SupplyPurchaseDetailsTableAdapter();
            this.purchase_ID_txtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.supplyPurchaseDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.coffee_ShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyPurchaseDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyPurchaseDetailsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // coffee_ShopDataSet
            // 
            this.coffee_ShopDataSet.DataSetName = "Coffee_ShopDataSet";
            this.coffee_ShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SupplyPurchaseDetail_report
            // 
            reportDataSource1.Name = "SupplyPurchaseDetails";
            reportDataSource1.Value = this.supplyPurchaseDetailsBindingSource1;
            this.SupplyPurchaseDetail_report.LocalReport.DataSources.Add(reportDataSource1);
            this.SupplyPurchaseDetail_report.LocalReport.ReportEmbeddedResource = "FinalProject_CoffeeShop.Report.SupplyPurchaseInfo_report.rdlc";
            this.SupplyPurchaseDetail_report.Location = new System.Drawing.Point(13, 64);
            this.SupplyPurchaseDetail_report.Name = "SupplyPurchaseDetail_report";
            this.SupplyPurchaseDetail_report.ServerReport.BearerToken = null;
            this.SupplyPurchaseDetail_report.Size = new System.Drawing.Size(775, 374);
            this.SupplyPurchaseDetail_report.TabIndex = 0;
            // 
            // supplyPurchaseDetailsBindingSource
            // 
            this.supplyPurchaseDetailsBindingSource.DataMember = "SupplyPurchaseDetails";
            this.supplyPurchaseDetailsBindingSource.DataSource = this.coffee_ShopDataSet;
            // 
            // supplyPurchaseDetailsTableAdapter
            // 
            this.supplyPurchaseDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // purchase_ID_txtb
            // 
            this.purchase_ID_txtb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_ID_txtb.Location = new System.Drawing.Point(124, 32);
            this.purchase_ID_txtb.Name = "purchase_ID_txtb";
            this.purchase_ID_txtb.Size = new System.Drawing.Size(100, 26);
            this.purchase_ID_txtb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Purchase ID:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(257, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Find_Bttn_Click);
            // 
            // supplyPurchaseDetailsBindingSource1
            // 
            this.supplyPurchaseDetailsBindingSource1.DataMember = "SupplyPurchaseDetails";
            this.supplyPurchaseDetailsBindingSource1.DataSource = this.coffee_ShopDataSet;
            // 
            // SupplyPurchaseInfo_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.purchase_ID_txtb);
            this.Controls.Add(this.SupplyPurchaseDetail_report);
            this.Name = "SupplyPurchaseInfo_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplyPurchase details Report";
            this.Load += new System.EventHandler(this.SupplyPurchaseInfo_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coffee_ShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyPurchaseDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyPurchaseDetailsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer SupplyPurchaseDetail_report;
        private Coffee_ShopDataSet coffee_ShopDataSet;
        private System.Windows.Forms.BindingSource supplyPurchaseDetailsBindingSource;
        private Coffee_ShopDataSetTableAdapters.SupplyPurchaseDetailsTableAdapter supplyPurchaseDetailsTableAdapter;
        private System.Windows.Forms.TextBox purchase_ID_txtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource supplyPurchaseDetailsBindingSource1;
    }
}