namespace FinalProject_CoffeeShop.Interface
{
    partial class Supplier
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
            this.dgv_Supplier = new System.Windows.Forms.DataGridView();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.Supplier_pl_Input = new System.Windows.Forms.Panel();
            this.Supplier_txt_Email = new System.Windows.Forms.TextBox();
            this.Supplier_txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.Supplier_txt_Address = new System.Windows.Forms.TextBox();
            this.Supplier_txt_Name = new System.Windows.Forms.TextBox();
            this.LbEmail = new System.Windows.Forms.Label();
            this.LbPhoneNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LbAddress = new System.Windows.Forms.Label();
            this.LbName = new System.Windows.Forms.Label();
            this.Supplier_txt_SupplierId = new System.Windows.Forms.TextBox();
            this.LbSupplierID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Supplier)).BeginInit();
            this.Supplier_pl_Input.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Supplier
            // 
            this.dgv_Supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Supplier.Location = new System.Drawing.Point(9, 236);
            this.dgv_Supplier.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Supplier.Name = "dgv_Supplier";
            this.dgv_Supplier.RowHeadersWidth = 51;
            this.dgv_Supplier.RowTemplate.Height = 24;
            this.dgv_Supplier.Size = new System.Drawing.Size(492, 226);
            this.dgv_Supplier.TabIndex = 63;
            this.dgv_Supplier.TabStop = false;
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoBack.Location = new System.Drawing.Point(394, 488);
            this.btn_GoBack.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(107, 82);
            this.btn_GoBack.TabIndex = 62;
            this.btn_GoBack.TabStop = false;
            this.btn_GoBack.Text = "Go back";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(127, 534);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(77, 35);
            this.btn_Delete.TabIndex = 61;
            this.btn_Delete.TabStop = false;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(251, 535);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(80, 35);
            this.btn_Cancel.TabIndex = 60;
            this.btn_Cancel.TabStop = false;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(128, 488);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(76, 35);
            this.btn_Save.TabIndex = 59;
            this.btn_Save.TabStop = false;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(8, 534);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(77, 35);
            this.btn_Edit.TabIndex = 58;
            this.btn_Edit.TabStop = false;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(5, 488);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(80, 35);
            this.btn_Add.TabIndex = 57;
            this.btn_Add.TabStop = false;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Reload
            // 
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.Location = new System.Drawing.Point(251, 488);
            this.btn_Reload.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(80, 37);
            this.btn_Reload.TabIndex = 56;
            this.btn_Reload.TabStop = false;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // Supplier_pl_Input
            // 
            this.Supplier_pl_Input.Controls.Add(this.Supplier_txt_Email);
            this.Supplier_pl_Input.Controls.Add(this.Supplier_txt_PhoneNumber);
            this.Supplier_pl_Input.Controls.Add(this.Supplier_txt_Address);
            this.Supplier_pl_Input.Controls.Add(this.Supplier_txt_Name);
            this.Supplier_pl_Input.Controls.Add(this.LbEmail);
            this.Supplier_pl_Input.Controls.Add(this.LbPhoneNumber);
            this.Supplier_pl_Input.Controls.Add(this.label6);
            this.Supplier_pl_Input.Controls.Add(this.LbAddress);
            this.Supplier_pl_Input.Controls.Add(this.LbName);
            this.Supplier_pl_Input.Controls.Add(this.Supplier_txt_SupplierId);
            this.Supplier_pl_Input.Controls.Add(this.LbSupplierID);
            this.Supplier_pl_Input.Controls.Add(this.label2);
            this.Supplier_pl_Input.Location = new System.Drawing.Point(9, 37);
            this.Supplier_pl_Input.Margin = new System.Windows.Forms.Padding(2);
            this.Supplier_pl_Input.Name = "Supplier_pl_Input";
            this.Supplier_pl_Input.Size = new System.Drawing.Size(492, 194);
            this.Supplier_pl_Input.TabIndex = 55;
            // 
            // Supplier_txt_Email
            // 
            this.Supplier_txt_Email.Location = new System.Drawing.Point(144, 167);
            this.Supplier_txt_Email.Margin = new System.Windows.Forms.Padding(2);
            this.Supplier_txt_Email.Name = "Supplier_txt_Email";
            this.Supplier_txt_Email.Size = new System.Drawing.Size(335, 20);
            this.Supplier_txt_Email.TabIndex = 11;
            // 
            // Supplier_txt_PhoneNumber
            // 
            this.Supplier_txt_PhoneNumber.Location = new System.Drawing.Point(144, 126);
            this.Supplier_txt_PhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.Supplier_txt_PhoneNumber.Name = "Supplier_txt_PhoneNumber";
            this.Supplier_txt_PhoneNumber.Size = new System.Drawing.Size(335, 20);
            this.Supplier_txt_PhoneNumber.TabIndex = 10;
            // 
            // Supplier_txt_Address
            // 
            this.Supplier_txt_Address.Location = new System.Drawing.Point(144, 87);
            this.Supplier_txt_Address.Margin = new System.Windows.Forms.Padding(2);
            this.Supplier_txt_Address.Name = "Supplier_txt_Address";
            this.Supplier_txt_Address.Size = new System.Drawing.Size(335, 20);
            this.Supplier_txt_Address.TabIndex = 9;
            // 
            // Supplier_txt_Name
            // 
            this.Supplier_txt_Name.Location = new System.Drawing.Point(144, 49);
            this.Supplier_txt_Name.Margin = new System.Windows.Forms.Padding(2);
            this.Supplier_txt_Name.Name = "Supplier_txt_Name";
            this.Supplier_txt_Name.Size = new System.Drawing.Size(335, 20);
            this.Supplier_txt_Name.TabIndex = 8;
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmail.Location = new System.Drawing.Point(7, 165);
            this.LbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(53, 20);
            this.LbEmail.TabIndex = 7;
            this.LbEmail.Text = "Email";
            // 
            // LbPhoneNumber
            // 
            this.LbPhoneNumber.AutoSize = true;
            this.LbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPhoneNumber.Location = new System.Drawing.Point(7, 126);
            this.LbPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbPhoneNumber.Name = "LbPhoneNumber";
            this.LbPhoneNumber.Size = new System.Drawing.Size(127, 20);
            this.LbPhoneNumber.TabIndex = 6;
            this.LbPhoneNumber.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // LbAddress
            // 
            this.LbAddress.AutoSize = true;
            this.LbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAddress.Location = new System.Drawing.Point(7, 84);
            this.LbAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbAddress.Name = "LbAddress";
            this.LbAddress.Size = new System.Drawing.Size(75, 20);
            this.LbAddress.TabIndex = 4;
            this.LbAddress.Text = "Address";
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbName.Location = new System.Drawing.Point(3, 49);
            this.LbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(65, 20);
            this.LbName.TabIndex = 3;
            this.LbName.Text = " Name ";
            // 
            // Supplier_txt_SupplierId
            // 
            this.Supplier_txt_SupplierId.Location = new System.Drawing.Point(144, 7);
            this.Supplier_txt_SupplierId.Margin = new System.Windows.Forms.Padding(2);
            this.Supplier_txt_SupplierId.Name = "Supplier_txt_SupplierId";
            this.Supplier_txt_SupplierId.Size = new System.Drawing.Size(335, 20);
            this.Supplier_txt_SupplierId.TabIndex = 2;
            // 
            // LbSupplierID
            // 
            this.LbSupplierID.AutoSize = true;
            this.LbSupplierID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSupplierID.Location = new System.Drawing.Point(3, 7);
            this.LbSupplierID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbSupplierID.Name = "LbSupplierID";
            this.LbSupplierID.Size = new System.Drawing.Size(96, 20);
            this.LbSupplierID.TabIndex = 1;
            this.LbSupplierID.Text = "Supplier Id";
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
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 54;
            this.label1.Text = "SUPPLIER";
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 584);
            this.Controls.Add(this.dgv_Supplier);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.Supplier_pl_Input);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Supplier)).EndInit();
            this.Supplier_pl_Input.ResumeLayout(false);
            this.Supplier_pl_Input.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Supplier;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Panel Supplier_pl_Input;
        private System.Windows.Forms.TextBox Supplier_txt_Email;
        private System.Windows.Forms.TextBox Supplier_txt_PhoneNumber;
        private System.Windows.Forms.TextBox Supplier_txt_Address;
        private System.Windows.Forms.TextBox Supplier_txt_Name;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.Label LbPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LbAddress;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.TextBox Supplier_txt_SupplierId;
        private System.Windows.Forms.Label LbSupplierID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}