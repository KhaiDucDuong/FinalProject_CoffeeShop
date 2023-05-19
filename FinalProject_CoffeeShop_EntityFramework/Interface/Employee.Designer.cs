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
            this.Employee_pl_Input = new System.Windows.Forms.Panel();
            this.workStatusComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.Employee_pl_Input.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Employee
            // 
            this.dgv_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee.Location = new System.Drawing.Point(10, 238);
            this.dgv_Employee.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Employee.Name = "dgv_Employee";
            this.dgv_Employee.RowHeadersWidth = 51;
            this.dgv_Employee.RowTemplate.Height = 24;
            this.dgv_Employee.Size = new System.Drawing.Size(571, 213);
            this.dgv_Employee.TabIndex = 52;
            this.dgv_Employee.TabStop = false;
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoBack.Location = new System.Drawing.Point(627, 385);
            this.btn_GoBack.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(79, 64);
            this.btn_GoBack.TabIndex = 51;
            this.btn_GoBack.TabStop = false;
            this.btn_GoBack.Text = "Go back";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(627, 209);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(79, 36);
            this.btn_Delete.TabIndex = 50;
            this.btn_Delete.TabStop = false;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(627, 330);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(79, 36);
            this.btn_Cancel.TabIndex = 49;
            this.btn_Cancel.TabStop = false;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(627, 150);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(79, 36);
            this.btn_Save.TabIndex = 48;
            this.btn_Save.TabStop = false;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(627, 89);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(79, 34);
            this.btn_Edit.TabIndex = 47;
            this.btn_Edit.TabStop = false;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(627, 25);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(79, 34);
            this.btn_Add.TabIndex = 46;
            this.btn_Add.TabStop = false;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Reload
            // 
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.Location = new System.Drawing.Point(627, 274);
            this.btn_Reload.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(79, 36);
            this.btn_Reload.TabIndex = 45;
            this.btn_Reload.TabStop = false;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // Employee_pl_Input
            // 
            this.Employee_pl_Input.Controls.Add(this.workStatusComboBox);
            this.Employee_pl_Input.Controls.Add(this.label3);
            this.Employee_pl_Input.Controls.Add(this.Employee_dtp_DateLeft);
            this.Employee_pl_Input.Controls.Add(this.Employee_dtp_DateJoin);
            this.Employee_pl_Input.Controls.Add(this.Employee_txt_LastName);
            this.Employee_pl_Input.Controls.Add(this.Employee_txt_FirstName);
            this.Employee_pl_Input.Controls.Add(this.LbDateLeft);
            this.Employee_pl_Input.Controls.Add(this.LbDateJoin);
            this.Employee_pl_Input.Controls.Add(this.label6);
            this.Employee_pl_Input.Controls.Add(this.LbLastName);
            this.Employee_pl_Input.Controls.Add(this.LbFirstName);
            this.Employee_pl_Input.Controls.Add(this.Employee_txt_EmployeeId);
            this.Employee_pl_Input.Controls.Add(this.Lb_EmployeeID);
            this.Employee_pl_Input.Controls.Add(this.label2);
            this.Employee_pl_Input.Location = new System.Drawing.Point(10, 32);
            this.Employee_pl_Input.Margin = new System.Windows.Forms.Padding(2);
            this.Employee_pl_Input.Name = "Employee_pl_Input";
            this.Employee_pl_Input.Size = new System.Drawing.Size(571, 191);
            this.Employee_pl_Input.TabIndex = 44;
            // 
            // workStatusComboBox
            // 
            this.workStatusComboBox.FormattingEnabled = true;
            this.workStatusComboBox.Items.AddRange(new object[] {
            "Working",
            "Has left"});
            this.workStatusComboBox.Location = new System.Drawing.Point(445, 131);
            this.workStatusComboBox.Name = "workStatusComboBox";
            this.workStatusComboBox.Size = new System.Drawing.Size(97, 21);
            this.workStatusComboBox.TabIndex = 5;
            this.workStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.workStatusComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(329, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Work status:";
            // 
            // Employee_dtp_DateLeft
            // 
            this.Employee_dtp_DateLeft.CustomFormat = "hh:mm:ss  dd/MM/yyyy";
            this.Employee_dtp_DateLeft.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Employee_dtp_DateLeft.Location = new System.Drawing.Point(154, 166);
            this.Employee_dtp_DateLeft.Margin = new System.Windows.Forms.Padding(2);
            this.Employee_dtp_DateLeft.Name = "Employee_dtp_DateLeft";
            this.Employee_dtp_DateLeft.ShowUpDown = true;
            this.Employee_dtp_DateLeft.Size = new System.Drawing.Size(161, 20);
            this.Employee_dtp_DateLeft.TabIndex = 6;
            // 
            // Employee_dtp_DateJoin
            // 
            this.Employee_dtp_DateJoin.CustomFormat = "hh:mm:ss  dd/MM/yyyy";
            this.Employee_dtp_DateJoin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Employee_dtp_DateJoin.Location = new System.Drawing.Point(154, 126);
            this.Employee_dtp_DateJoin.Margin = new System.Windows.Forms.Padding(2);
            this.Employee_dtp_DateJoin.Name = "Employee_dtp_DateJoin";
            this.Employee_dtp_DateJoin.ShowUpDown = true;
            this.Employee_dtp_DateJoin.Size = new System.Drawing.Size(161, 20);
            this.Employee_dtp_DateJoin.TabIndex = 4;
            // 
            // Employee_txt_LastName
            // 
            this.Employee_txt_LastName.Location = new System.Drawing.Point(154, 86);
            this.Employee_txt_LastName.Margin = new System.Windows.Forms.Padding(2);
            this.Employee_txt_LastName.Name = "Employee_txt_LastName";
            this.Employee_txt_LastName.Size = new System.Drawing.Size(388, 20);
            this.Employee_txt_LastName.TabIndex = 3;
            // 
            // Employee_txt_FirstName
            // 
            this.Employee_txt_FirstName.Location = new System.Drawing.Point(154, 48);
            this.Employee_txt_FirstName.Margin = new System.Windows.Forms.Padding(2);
            this.Employee_txt_FirstName.Name = "Employee_txt_FirstName";
            this.Employee_txt_FirstName.Size = new System.Drawing.Size(388, 20);
            this.Employee_txt_FirstName.TabIndex = 2;
            // 
            // LbDateLeft
            // 
            this.LbDateLeft.AutoSize = true;
            this.LbDateLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDateLeft.Location = new System.Drawing.Point(7, 163);
            this.LbDateLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbDateLeft.Name = "LbDateLeft";
            this.LbDateLeft.Size = new System.Drawing.Size(85, 20);
            this.LbDateLeft.TabIndex = 7;
            this.LbDateLeft.Text = "Date Left";
            // 
            // LbDateJoin
            // 
            this.LbDateJoin.AutoSize = true;
            this.LbDateJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDateJoin.Location = new System.Drawing.Point(3, 124);
            this.LbDateJoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbDateJoin.Name = "LbDateJoin";
            this.LbDateJoin.Size = new System.Drawing.Size(86, 20);
            this.LbDateJoin.TabIndex = 6;
            this.LbDateJoin.Text = "Date Join";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // LbLastName
            // 
            this.LbLastName.AutoSize = true;
            this.LbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLastName.Location = new System.Drawing.Point(3, 84);
            this.LbLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbLastName.Name = "LbLastName";
            this.LbLastName.Size = new System.Drawing.Size(95, 20);
            this.LbLastName.TabIndex = 4;
            this.LbLastName.Text = "Last Name";
            // 
            // LbFirstName
            // 
            this.LbFirstName.AutoSize = true;
            this.LbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFirstName.Location = new System.Drawing.Point(3, 46);
            this.LbFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbFirstName.Name = "LbFirstName";
            this.LbFirstName.Size = new System.Drawing.Size(101, 20);
            this.LbFirstName.TabIndex = 3;
            this.LbFirstName.Text = "First Name ";
            // 
            // Employee_txt_EmployeeId
            // 
            this.Employee_txt_EmployeeId.Location = new System.Drawing.Point(154, 7);
            this.Employee_txt_EmployeeId.Margin = new System.Windows.Forms.Padding(2);
            this.Employee_txt_EmployeeId.Name = "Employee_txt_EmployeeId";
            this.Employee_txt_EmployeeId.Size = new System.Drawing.Size(388, 20);
            this.Employee_txt_EmployeeId.TabIndex = 1;
            // 
            // Lb_EmployeeID
            // 
            this.Lb_EmployeeID.AutoSize = true;
            this.Lb_EmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_EmployeeID.Location = new System.Drawing.Point(3, 7);
            this.Lb_EmployeeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_EmployeeID.Name = "Lb_EmployeeID";
            this.Lb_EmployeeID.Size = new System.Drawing.Size(108, 20);
            this.Lb_EmployeeID.TabIndex = 1;
            this.Lb_EmployeeID.Text = "Employee Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 13);
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
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 43;
            this.label1.Text = "EMPLOYEE";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(739, 458);
            this.Controls.Add(this.dgv_Employee);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.Employee_pl_Input);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).EndInit();
            this.Employee_pl_Input.ResumeLayout(false);
            this.Employee_pl_Input.PerformLayout();
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
        private System.Windows.Forms.Panel Employee_pl_Input;
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
        private System.Windows.Forms.ComboBox workStatusComboBox;
        private System.Windows.Forms.Label label3;
    }
}