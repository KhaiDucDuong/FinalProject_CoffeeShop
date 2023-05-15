namespace FinalProject_CoffeeShop.Interface
{
    partial class Employee
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
            this.dgv_Employee = new System.Windows.Forms.DataGridView();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.pl_Input = new System.Windows.Forms.Panel();
            this.Employee_dtp_DateLeft = new System.Windows.Forms.DateTimePicker();
            this.Employee_dtp_DateJoin = new System.Windows.Forms.DateTimePicker();
            this.Employee_txt_LastName = new System.Windows.Forms.TextBox();
            this.Employee_txt_FirstName = new System.Windows.Forms.TextBox();
            this.LbDateLeft = new System.Windows.Forms.Label();
            this.LbDateJoin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LbLastName = new System.Windows.Forms.Label();
            this.LbFirstName = new System.Windows.Forms.Label();
            this.Employee_txt_EmployeeId = new System.Windows.Forms.TextBox();
            this.Lb_EmployeeID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).BeginInit();
            this.pl_Input.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Employee
            // 
            this.dgv_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee.Location = new System.Drawing.Point(12, 297);
            this.dgv_Employee.Name = "dgv_Employee";
            this.dgv_Employee.RowHeadersWidth = 51;
            this.dgv_Employee.RowTemplate.Height = 24;
            this.dgv_Employee.Size = new System.Drawing.Size(714, 266);
            this.dgv_Employee.TabIndex = 52;
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoBack.Location = new System.Drawing.Point(784, 481);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(99, 80);
            this.btn_GoBack.TabIndex = 51;
            this.btn_GoBack.Text = "Go back";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(784, 261);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(99, 45);
            this.btn_Delete.TabIndex = 50;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(784, 412);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(99, 45);
            this.btn_Cancel.TabIndex = 49;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(784, 187);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(99, 45);
            this.btn_Save.TabIndex = 48;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(784, 111);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(99, 43);
            this.btn_Edit.TabIndex = 47;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(784, 31);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(99, 43);
            this.btn_Add.TabIndex = 46;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Reload
            // 
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.Location = new System.Drawing.Point(784, 343);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(99, 45);
            this.btn_Reload.TabIndex = 45;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // pl_Input
            // 
            this.pl_Input.Controls.Add(this.Employee_dtp_DateLeft);
            this.pl_Input.Controls.Add(this.Employee_dtp_DateJoin);
            this.pl_Input.Controls.Add(this.Employee_txt_LastName);
            this.pl_Input.Controls.Add(this.Employee_txt_FirstName);
            this.pl_Input.Controls.Add(this.LbDateLeft);
            this.pl_Input.Controls.Add(this.LbDateJoin);
            this.pl_Input.Controls.Add(this.label6);
            this.pl_Input.Controls.Add(this.LbLastName);
            this.pl_Input.Controls.Add(this.LbFirstName);
            this.pl_Input.Controls.Add(this.Employee_txt_EmployeeId);
            this.pl_Input.Controls.Add(this.Lb_EmployeeID);
            this.pl_Input.Controls.Add(this.label2);
            this.pl_Input.Location = new System.Drawing.Point(12, 40);
            this.pl_Input.Name = "pl_Input";
            this.pl_Input.Size = new System.Drawing.Size(714, 239);
            this.pl_Input.TabIndex = 44;
            // 
            // Employee_dtp_DateLeft
            // 
            this.Employee_dtp_DateLeft.CustomFormat = "hh:mm:ss  dd/MM/yyyy";
            this.Employee_dtp_DateLeft.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Employee_dtp_DateLeft.Location = new System.Drawing.Point(192, 207);
            this.Employee_dtp_DateLeft.Name = "Employee_dtp_DateLeft";
            this.Employee_dtp_DateLeft.ShowUpDown = true;
            this.Employee_dtp_DateLeft.Size = new System.Drawing.Size(200, 22);
            this.Employee_dtp_DateLeft.TabIndex = 11;
            // 
            // Employee_dtp_DateJoin
            // 
            this.Employee_dtp_DateJoin.CustomFormat = "hh:mm:ss  dd/MM/yyyy";
            this.Employee_dtp_DateJoin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Employee_dtp_DateJoin.Location = new System.Drawing.Point(192, 157);
            this.Employee_dtp_DateJoin.Name = "Employee_dtp_DateJoin";
            this.Employee_dtp_DateJoin.ShowUpDown = true;
            this.Employee_dtp_DateJoin.Size = new System.Drawing.Size(200, 22);
            this.Employee_dtp_DateJoin.TabIndex = 10;
            // 
            // Employee_txt_LastName
            // 
            this.Employee_txt_LastName.Location = new System.Drawing.Point(192, 107);
            this.Employee_txt_LastName.Name = "Employee_txt_LastName";
            this.Employee_txt_LastName.Size = new System.Drawing.Size(484, 22);
            this.Employee_txt_LastName.TabIndex = 9;
            // 
            // Employee_txt_FirstName
            // 
            this.Employee_txt_FirstName.Location = new System.Drawing.Point(192, 60);
            this.Employee_txt_FirstName.Name = "Employee_txt_FirstName";
            this.Employee_txt_FirstName.Size = new System.Drawing.Size(484, 22);
            this.Employee_txt_FirstName.TabIndex = 8;
            // 
            // LbDateLeft
            // 
            this.LbDateLeft.AutoSize = true;
            this.LbDateLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDateLeft.Location = new System.Drawing.Point(9, 204);
            this.LbDateLeft.Name = "LbDateLeft";
            this.LbDateLeft.Size = new System.Drawing.Size(99, 25);
            this.LbDateLeft.TabIndex = 7;
            this.LbDateLeft.Text = "Date Left";
            // 
            // LbDateJoin
            // 
            this.LbDateJoin.AutoSize = true;
            this.LbDateJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDateJoin.Location = new System.Drawing.Point(4, 155);
            this.LbDateJoin.Name = "LbDateJoin";
            this.LbDateJoin.Size = new System.Drawing.Size(104, 25);
            this.LbDateJoin.TabIndex = 6;
            this.LbDateJoin.Text = "Date Join";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 5;
            // 
            // LbLastName
            // 
            this.LbLastName.AutoSize = true;
            this.LbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLastName.Location = new System.Drawing.Point(4, 105);
            this.LbLastName.Name = "LbLastName";
            this.LbLastName.Size = new System.Drawing.Size(115, 25);
            this.LbLastName.TabIndex = 4;
            this.LbLastName.Text = "Last Name";
            // 
            // LbFirstName
            // 
            this.LbFirstName.AutoSize = true;
            this.LbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFirstName.Location = new System.Drawing.Point(4, 58);
            this.LbFirstName.Name = "LbFirstName";
            this.LbFirstName.Size = new System.Drawing.Size(122, 25);
            this.LbFirstName.TabIndex = 3;
            this.LbFirstName.Text = "First Name ";
            // 
            // Employee_txt_EmployeeId
            // 
            this.Employee_txt_EmployeeId.Location = new System.Drawing.Point(192, 9);
            this.Employee_txt_EmployeeId.Name = "Employee_txt_EmployeeId";
            this.Employee_txt_EmployeeId.Size = new System.Drawing.Size(484, 22);
            this.Employee_txt_EmployeeId.TabIndex = 2;
            // 
            // Lb_EmployeeID
            // 
            this.Lb_EmployeeID.AutoSize = true;
            this.Lb_EmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_EmployeeID.Location = new System.Drawing.Point(4, 9);
            this.Lb_EmployeeID.Name = "Lb_EmployeeID";
            this.Lb_EmployeeID.Size = new System.Drawing.Size(131, 25);
            this.Lb_EmployeeID.TabIndex = 1;
            this.Lb_EmployeeID.Text = "Employee Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 27);
            this.label1.TabIndex = 43;
            this.label1.Text = "EMPLOYEE";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(924, 573);
            this.Controls.Add(this.dgv_Employee);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.pl_Input);
            this.Controls.Add(this.label1);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).EndInit();
            this.pl_Input.ResumeLayout(false);
            this.pl_Input.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Employee;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Panel pl_Input;
        private System.Windows.Forms.DateTimePicker Employee_dtp_DateLeft;
        private System.Windows.Forms.DateTimePicker Employee_dtp_DateJoin;
        private System.Windows.Forms.TextBox Employee_txt_LastName;
        private System.Windows.Forms.TextBox Employee_txt_FirstName;
        private System.Windows.Forms.Label LbDateLeft;
        private System.Windows.Forms.Label LbDateJoin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LbLastName;
        private System.Windows.Forms.Label LbFirstName;
        private System.Windows.Forms.TextBox Employee_txt_EmployeeId;
        private System.Windows.Forms.Label Lb_EmployeeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}