namespace FinalProject_CoffeeShop.Interface
{
    partial class Inventory
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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.btn_CheckInventoryInfo = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Inventory_txt_DateCheck = new System.Windows.Forms.DateTimePicker();
            this.check_idLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Inventory_txt_CheckId = new System.Windows.Forms.TextBox();
            this.date_checkLb = new System.Windows.Forms.Label();
            this.Inventory_txt_CheckerId = new System.Windows.Forms.TextBox();
            this.dgv_Inventory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventory)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(605, 144);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(100, 59);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(605, 64);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(100, 59);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoBack.Location = new System.Drawing.Point(487, 396);
            this.btn_GoBack.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(340, 68);
            this.btn_GoBack.TabIndex = 7;
            this.btn_GoBack.Text = "Go back";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // btn_CheckInventoryInfo
            // 
            this.btn_CheckInventoryInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckInventoryInfo.Location = new System.Drawing.Point(487, 285);
            this.btn_CheckInventoryInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CheckInventoryInfo.Name = "btn_CheckInventoryInfo";
            this.btn_CheckInventoryInfo.Size = new System.Drawing.Size(340, 68);
            this.btn_CheckInventoryInfo.TabIndex = 8;
            this.btn_CheckInventoryInfo.Text = "Check Inventory Info";
            this.btn_CheckInventoryInfo.UseVisualStyleBackColor = true;
            this.btn_CheckInventoryInfo.Click += new System.EventHandler(this.btn_CheckInventoryInfo_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(487, 64);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 59);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(720, 144);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 59);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(487, 148);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(100, 59);
            this.btn_Edit.TabIndex = 11;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Reload
            // 
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.Location = new System.Drawing.Point(720, 64);
            this.btn_Reload.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(100, 59);
            this.btn_Reload.TabIndex = 12;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Inventory_txt_DateCheck);
            this.panel1.Controls.Add(this.check_idLb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Inventory_txt_CheckId);
            this.panel1.Controls.Add(this.date_checkLb);
            this.panel1.Controls.Add(this.Inventory_txt_CheckerId);
            this.panel1.Location = new System.Drawing.Point(13, 53);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 153);
            this.panel1.TabIndex = 4;
            // 
            // Inventory_txt_DateCheck
            // 
            this.Inventory_txt_DateCheck.CustomFormat = "hh:mm:ss  dd/MM/yyyy";
            this.Inventory_txt_DateCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory_txt_DateCheck.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Inventory_txt_DateCheck.Location = new System.Drawing.Point(221, 60);
            this.Inventory_txt_DateCheck.Margin = new System.Windows.Forms.Padding(4);
            this.Inventory_txt_DateCheck.Name = "Inventory_txt_DateCheck";
            this.Inventory_txt_DateCheck.ShowUpDown = true;
            this.Inventory_txt_DateCheck.Size = new System.Drawing.Size(212, 29);
            this.Inventory_txt_DateCheck.TabIndex = 2;
            // 
            // check_idLb
            // 
            this.check_idLb.AutoSize = true;
            this.check_idLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_idLb.Location = new System.Drawing.Point(4, 11);
            this.check_idLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.check_idLb.Name = "check_idLb";
            this.check_idLb.Size = new System.Drawing.Size(99, 25);
            this.check_idLb.TabIndex = 1;
            this.check_idLb.Text = "Check ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Checker ID (employee\'s):";
            // 
            // Inventory_txt_CheckId
            // 
            this.Inventory_txt_CheckId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory_txt_CheckId.Location = new System.Drawing.Point(221, 11);
            this.Inventory_txt_CheckId.Margin = new System.Windows.Forms.Padding(4);
            this.Inventory_txt_CheckId.Name = "Inventory_txt_CheckId";
            this.Inventory_txt_CheckId.Size = new System.Drawing.Size(212, 29);
            this.Inventory_txt_CheckId.TabIndex = 0;
            // 
            // date_checkLb
            // 
            this.date_checkLb.AutoSize = true;
            this.date_checkLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_checkLb.Location = new System.Drawing.Point(4, 60);
            this.date_checkLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date_checkLb.Name = "date_checkLb";
            this.date_checkLb.Size = new System.Drawing.Size(116, 25);
            this.date_checkLb.TabIndex = 1;
            this.date_checkLb.Text = "Date check:";
            // 
            // Inventory_txt_CheckerId
            // 
            this.Inventory_txt_CheckerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory_txt_CheckerId.Location = new System.Drawing.Point(260, 110);
            this.Inventory_txt_CheckerId.Margin = new System.Windows.Forms.Padding(4);
            this.Inventory_txt_CheckerId.Name = "Inventory_txt_CheckerId";
            this.Inventory_txt_CheckerId.Size = new System.Drawing.Size(173, 29);
            this.Inventory_txt_CheckerId.TabIndex = 0;
            // 
            // dgv_Inventory
            // 
            this.dgv_Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Inventory.Location = new System.Drawing.Point(13, 224);
            this.dgv_Inventory.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Inventory.Name = "dgv_Inventory";
            this.dgv_Inventory.RowHeadersWidth = 51;
            this.dgv_Inventory.Size = new System.Drawing.Size(457, 239);
            this.dgv_Inventory.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 27);
            this.label1.TabIndex = 64;
            this.label1.Text = "INVENTORY";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 479);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.btn_CheckInventoryInfo);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_Inventory);
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Button btn_CheckInventoryInfo;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker Inventory_txt_DateCheck;
        private System.Windows.Forms.Label check_idLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Inventory_txt_CheckId;
        private System.Windows.Forms.Label date_checkLb;
        private System.Windows.Forms.TextBox Inventory_txt_CheckerId;
        private System.Windows.Forms.DataGridView dgv_Inventory;
        private System.Windows.Forms.Label label1;
    }
}