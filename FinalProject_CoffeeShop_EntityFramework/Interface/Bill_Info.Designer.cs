namespace FinalProject_CoffeeShop.Interface
{
    partial class Bill_Info
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
            this.dgv_Bill_Info = new System.Windows.Forms.DataGridView();
            this.btn_OpenBill = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.Bill_Info_pl_Input = new System.Windows.Forms.Panel();
            this.Bill_Info_txt_Quantity = new System.Windows.Forms.TextBox();
            this.Bill_Info_txt_ItemId = new System.Windows.Forms.TextBox();
            this.LB_Quantity = new System.Windows.Forms.Label();
            this.LB_Item_ID = new System.Windows.Forms.Label();
            this.Bill_Info_txt_Bill_Id = new System.Windows.Forms.TextBox();
            this.Lb_Bill_Id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill_Info)).BeginInit();
            this.Bill_Info_pl_Input.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Bill_Info
            // 
            this.dgv_Bill_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Bill_Info.Location = new System.Drawing.Point(15, 206);
            this.dgv_Bill_Info.Name = "dgv_Bill_Info";
            this.dgv_Bill_Info.RowHeadersWidth = 51;
            this.dgv_Bill_Info.RowTemplate.Height = 24;
            this.dgv_Bill_Info.Size = new System.Drawing.Size(715, 234);
            this.dgv_Bill_Info.TabIndex = 53;
            // 
            // btn_OpenBill
            // 
            this.btn_OpenBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenBill.Location = new System.Drawing.Point(424, 465);
            this.btn_OpenBill.Name = "btn_OpenBill";
            this.btn_OpenBill.Size = new System.Drawing.Size(134, 114);
            this.btn_OpenBill.TabIndex = 52;
            this.btn_OpenBill.Text = "Open Bill";
            this.btn_OpenBill.UseVisualStyleBackColor = true;
            this.btn_OpenBill.Click += new System.EventHandler(this.btn_OpenBill_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(154, 528);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(103, 45);
            this.btn_Delete.TabIndex = 51;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(285, 530);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(106, 45);
            this.btn_Cancel.TabIndex = 50;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(154, 465);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(102, 45);
            this.btn_Save.TabIndex = 49;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoBack.Location = new System.Drawing.Point(603, 465);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(127, 114);
            this.btn_GoBack.TabIndex = 48;
            this.btn_GoBack.Text = "Go back";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(14, 530);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(103, 43);
            this.btn_Edit.TabIndex = 47;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(15, 465);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(106, 43);
            this.btn_Add.TabIndex = 46;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Reload
            // 
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.Location = new System.Drawing.Point(285, 465);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(106, 45);
            this.btn_Reload.TabIndex = 45;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // Bill_Info_pl_Input
            // 
            this.Bill_Info_pl_Input.Controls.Add(this.Bill_Info_txt_Quantity);
            this.Bill_Info_pl_Input.Controls.Add(this.Bill_Info_txt_ItemId);
            this.Bill_Info_pl_Input.Controls.Add(this.LB_Quantity);
            this.Bill_Info_pl_Input.Controls.Add(this.LB_Item_ID);
            this.Bill_Info_pl_Input.Controls.Add(this.Bill_Info_txt_Bill_Id);
            this.Bill_Info_pl_Input.Controls.Add(this.Lb_Bill_Id);
            this.Bill_Info_pl_Input.Controls.Add(this.label2);
            this.Bill_Info_pl_Input.Location = new System.Drawing.Point(14, 36);
            this.Bill_Info_pl_Input.Name = "Bill_Info_pl_Input";
            this.Bill_Info_pl_Input.Size = new System.Drawing.Size(716, 154);
            this.Bill_Info_pl_Input.TabIndex = 44;
            // 
            // Bill_Info_txt_Quantity
            // 
            this.Bill_Info_txt_Quantity.Location = new System.Drawing.Point(204, 109);
            this.Bill_Info_txt_Quantity.Name = "Bill_Info_txt_Quantity";
            this.Bill_Info_txt_Quantity.Size = new System.Drawing.Size(158, 22);
            this.Bill_Info_txt_Quantity.TabIndex = 8;
            // 
            // Bill_Info_txt_ItemId
            // 
            this.Bill_Info_txt_ItemId.Location = new System.Drawing.Point(204, 65);
            this.Bill_Info_txt_ItemId.Name = "Bill_Info_txt_ItemId";
            this.Bill_Info_txt_ItemId.Size = new System.Drawing.Size(340, 22);
            this.Bill_Info_txt_ItemId.TabIndex = 7;
            // 
            // LB_Quantity
            // 
            this.LB_Quantity.AutoSize = true;
            this.LB_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Quantity.Location = new System.Drawing.Point(14, 109);
            this.LB_Quantity.Name = "LB_Quantity";
            this.LB_Quantity.Size = new System.Drawing.Size(93, 25);
            this.LB_Quantity.TabIndex = 6;
            this.LB_Quantity.Text = "Quantity";
            // 
            // LB_Item_ID
            // 
            this.LB_Item_ID.AutoSize = true;
            this.LB_Item_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Item_ID.Location = new System.Drawing.Point(14, 63);
            this.LB_Item_ID.Name = "LB_Item_ID";
            this.LB_Item_ID.Size = new System.Drawing.Size(77, 25);
            this.LB_Item_ID.TabIndex = 4;
            this.LB_Item_ID.Text = "Item Id";
            // 
            // Bill_Info_txt_Bill_Id
            // 
            this.Bill_Info_txt_Bill_Id.Location = new System.Drawing.Point(204, 16);
            this.Bill_Info_txt_Bill_Id.Name = "Bill_Info_txt_Bill_Id";
            this.Bill_Info_txt_Bill_Id.Size = new System.Drawing.Size(340, 22);
            this.Bill_Info_txt_Bill_Id.TabIndex = 2;
            this.Bill_Info_txt_Bill_Id.TextChanged += new System.EventHandler(this.txt_Bill_Id_TextChanged);
            // 
            // Lb_Bill_Id
            // 
            this.Lb_Bill_Id.AutoSize = true;
            this.Lb_Bill_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Bill_Id.Location = new System.Drawing.Point(14, 16);
            this.Lb_Bill_Id.Name = "Lb_Bill_Id";
            this.Lb_Bill_Id.Size = new System.Drawing.Size(65, 25);
            this.Lb_Bill_Id.TabIndex = 1;
            this.Lb_Bill_Id.Text = "Bill Id";
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
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 27);
            this.label1.TabIndex = 43;
            this.label1.Text = "BILL INFO";
            // 
            // Bill_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 585);
            this.Controls.Add(this.dgv_Bill_Info);
            this.Controls.Add(this.btn_OpenBill);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.Bill_Info_pl_Input);
            this.Controls.Add(this.label1);
            this.Name = "Bill_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill_Info";
            this.Load += new System.EventHandler(this.Bill_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill_Info)).EndInit();
            this.Bill_Info_pl_Input.ResumeLayout(false);
            this.Bill_Info_pl_Input.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Bill_Info;
        private System.Windows.Forms.Button btn_OpenBill;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Panel Bill_Info_pl_Input;
        private System.Windows.Forms.TextBox Bill_Info_txt_Quantity;
        private System.Windows.Forms.TextBox Bill_Info_txt_ItemId;
        private System.Windows.Forms.Label LB_Quantity;
        private System.Windows.Forms.Label LB_Item_ID;
        private System.Windows.Forms.TextBox Bill_Info_txt_Bill_Id;
        private System.Windows.Forms.Label Lb_Bill_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}