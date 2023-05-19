namespace FinalProject_CoffeeShop.Interface
{
    partial class Bill
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
            this.dgv_Bill = new System.Windows.Forms.DataGridView();
            this.btn_OpenBillInfo = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.Bill_pl_Input = new System.Windows.Forms.Panel();
            this.Bill_dtp_CreatedAt = new System.Windows.Forms.DateTimePicker();
            this.Lb_Created_At = new System.Windows.Forms.Label();
            this.Bill_txt_Bill_Id = new System.Windows.Forms.TextBox();
            this.Lb_Bill_Id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill)).BeginInit();
            this.Bill_pl_Input.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Bill
            // 
            this.dgv_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Bill.Location = new System.Drawing.Point(14, 158);
            this.dgv_Bill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Bill.Name = "dgv_Bill";
            this.dgv_Bill.RowHeadersWidth = 51;
            this.dgv_Bill.RowTemplate.Height = 24;
            this.dgv_Bill.Size = new System.Drawing.Size(536, 190);
            this.dgv_Bill.TabIndex = 42;
            this.dgv_Bill.TabStop = false;
            // 
            // btn_OpenBillInfo
            // 
            this.btn_OpenBillInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenBillInfo.Location = new System.Drawing.Point(320, 375);
            this.btn_OpenBillInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_OpenBillInfo.Name = "btn_OpenBillInfo";
            this.btn_OpenBillInfo.Size = new System.Drawing.Size(104, 91);
            this.btn_OpenBillInfo.TabIndex = 41;
            this.btn_OpenBillInfo.TabStop = false;
            this.btn_OpenBillInfo.Text = "Open Bill Info";
            this.btn_OpenBillInfo.UseVisualStyleBackColor = true;
            this.btn_OpenBillInfo.Click += new System.EventHandler(this.btn_OpenBillInfo_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(120, 429);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(77, 37);
            this.btn_Delete.TabIndex = 40;
            this.btn_Delete.TabStop = false;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(223, 429);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(76, 37);
            this.btn_Cancel.TabIndex = 39;
            this.btn_Cancel.TabStop = false;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(120, 373);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(76, 37);
            this.btn_Save.TabIndex = 38;
            this.btn_Save.TabStop = false;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoBack.Location = new System.Drawing.Point(453, 373);
            this.btn_GoBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(97, 93);
            this.btn_GoBack.TabIndex = 37;
            this.btn_GoBack.TabStop = false;
            this.btn_GoBack.Text = "Go back";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(14, 429);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(77, 37);
            this.btn_Edit.TabIndex = 36;
            this.btn_Edit.TabStop = false;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(14, 375);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(80, 35);
            this.btn_Add.TabIndex = 35;
            this.btn_Add.TabStop = false;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Reload
            // 
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.Location = new System.Drawing.Point(223, 373);
            this.btn_Reload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(76, 37);
            this.btn_Reload.TabIndex = 34;
            this.btn_Reload.TabStop = false;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // Bill_pl_Input
            // 
            this.Bill_pl_Input.Controls.Add(this.Bill_dtp_CreatedAt);
            this.Bill_pl_Input.Controls.Add(this.Lb_Created_At);
            this.Bill_pl_Input.Controls.Add(this.Bill_txt_Bill_Id);
            this.Bill_pl_Input.Controls.Add(this.Lb_Bill_Id);
            this.Bill_pl_Input.Controls.Add(this.label2);
            this.Bill_pl_Input.Location = new System.Drawing.Point(13, 47);
            this.Bill_pl_Input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bill_pl_Input.Name = "Bill_pl_Input";
            this.Bill_pl_Input.Size = new System.Drawing.Size(537, 91);
            this.Bill_pl_Input.TabIndex = 33;
            // 
            // Bill_dtp_CreatedAt
            // 
            this.Bill_dtp_CreatedAt.CustomFormat = "hh:mm:ss  dd/MM/yyyy";
            this.Bill_dtp_CreatedAt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Bill_dtp_CreatedAt.Location = new System.Drawing.Point(144, 58);
            this.Bill_dtp_CreatedAt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bill_dtp_CreatedAt.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.Bill_dtp_CreatedAt.Name = "Bill_dtp_CreatedAt";
            this.Bill_dtp_CreatedAt.RightToLeftLayout = true;
            this.Bill_dtp_CreatedAt.ShowUpDown = true;
            this.Bill_dtp_CreatedAt.Size = new System.Drawing.Size(189, 20);
            this.Bill_dtp_CreatedAt.TabIndex = 2;
            // 
            // Lb_Created_At
            // 
            this.Lb_Created_At.AutoSize = true;
            this.Lb_Created_At.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Created_At.Location = new System.Drawing.Point(14, 56);
            this.Lb_Created_At.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_Created_At.Name = "Lb_Created_At";
            this.Lb_Created_At.Size = new System.Drawing.Size(96, 20);
            this.Lb_Created_At.TabIndex = 4;
            this.Lb_Created_At.Text = "Created At";
            // 
            // Bill_txt_Bill_Id
            // 
            this.Bill_txt_Bill_Id.Location = new System.Drawing.Point(144, 11);
            this.Bill_txt_Bill_Id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bill_txt_Bill_Id.Name = "Bill_txt_Bill_Id";
            this.Bill_txt_Bill_Id.Size = new System.Drawing.Size(256, 20);
            this.Bill_txt_Bill_Id.TabIndex = 1;
            // 
            // Lb_Bill_Id
            // 
            this.Lb_Bill_Id.AutoSize = true;
            this.Lb_Bill_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Bill_Id.Location = new System.Drawing.Point(14, 11);
            this.Lb_Bill_Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_Bill_Id.Name = "Lb_Bill_Id";
            this.Lb_Bill_Id.Size = new System.Drawing.Size(54, 20);
            this.Lb_Bill_Id.TabIndex = 1;
            this.Lb_Bill_Id.Text = "Bill Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "BILL";
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 482);
            this.Controls.Add(this.dgv_Bill);
            this.Controls.Add(this.btn_OpenBillInfo);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.Bill_pl_Input);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill)).EndInit();
            this.Bill_pl_Input.ResumeLayout(false);
            this.Bill_pl_Input.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Bill;
        private System.Windows.Forms.Button btn_OpenBillInfo;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Panel Bill_pl_Input;
        private System.Windows.Forms.DateTimePicker Bill_dtp_CreatedAt;
        private System.Windows.Forms.Label Lb_Created_At;
        private System.Windows.Forms.TextBox Bill_txt_Bill_Id;
        private System.Windows.Forms.Label Lb_Bill_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}