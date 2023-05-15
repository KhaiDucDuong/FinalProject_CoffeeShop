namespace FinalProject_CoffeeShop.Interface
{
    partial class Inventory_Info
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
            this.btn_CheckInventory = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.pl_Input = new System.Windows.Forms.Panel();
            this.quantity_per_unitLb = new System.Windows.Forms.Label();
            this.InventoryInfo_txt_QuantityPerUnit = new System.Windows.Forms.TextBox();
            this.ingredient_idLb = new System.Windows.Forms.Label();
            this.InventoryInfo_IngredientId = new System.Windows.Forms.TextBox();
            this.check_idLb = new System.Windows.Forms.Label();
            this.InventoryInfo_txt_CheckId = new System.Windows.Forms.TextBox();
            this.dgv_InventoryInfo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pl_Input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InventoryInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(613, 187);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(100, 59);
            this.btn_Delete.TabIndex = 16;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(613, 73);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(100, 59);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoBack.Location = new System.Drawing.Point(495, 405);
            this.btn_GoBack.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(340, 68);
            this.btn_GoBack.TabIndex = 18;
            this.btn_GoBack.Text = "Go back";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // btn_CheckInventory
            // 
            this.btn_CheckInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckInventory.Location = new System.Drawing.Point(495, 313);
            this.btn_CheckInventory.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CheckInventory.Name = "btn_CheckInventory";
            this.btn_CheckInventory.Size = new System.Drawing.Size(340, 68);
            this.btn_CheckInventory.TabIndex = 19;
            this.btn_CheckInventory.Text = "Check Inventory";
            this.btn_CheckInventory.UseVisualStyleBackColor = true;
            this.btn_CheckInventory.Click += new System.EventHandler(this.btn_CheckInventory_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(495, 73);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 59);
            this.btn_Add.TabIndex = 20;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(735, 187);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 59);
            this.btn_Cancel.TabIndex = 21;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(495, 187);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(100, 59);
            this.btn_Edit.TabIndex = 22;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Reload
            // 
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.Location = new System.Drawing.Point(735, 73);
            this.btn_Reload.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(100, 59);
            this.btn_Reload.TabIndex = 23;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.reloadBt_Click);
            // 
            // pl_Input
            // 
            this.pl_Input.Controls.Add(this.quantity_per_unitLb);
            this.pl_Input.Controls.Add(this.InventoryInfo_txt_QuantityPerUnit);
            this.pl_Input.Controls.Add(this.ingredient_idLb);
            this.pl_Input.Controls.Add(this.InventoryInfo_IngredientId);
            this.pl_Input.Controls.Add(this.check_idLb);
            this.pl_Input.Controls.Add(this.InventoryInfo_txt_CheckId);
            this.pl_Input.Location = new System.Drawing.Point(22, 73);
            this.pl_Input.Margin = new System.Windows.Forms.Padding(4);
            this.pl_Input.Name = "pl_Input";
            this.pl_Input.Size = new System.Drawing.Size(457, 153);
            this.pl_Input.TabIndex = 15;
            // 
            // quantity_per_unitLb
            // 
            this.quantity_per_unitLb.AutoSize = true;
            this.quantity_per_unitLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_per_unitLb.Location = new System.Drawing.Point(4, 114);
            this.quantity_per_unitLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantity_per_unitLb.Name = "quantity_per_unitLb";
            this.quantity_per_unitLb.Size = new System.Drawing.Size(163, 25);
            this.quantity_per_unitLb.TabIndex = 1;
            this.quantity_per_unitLb.Text = "Quantity per Unit:";
            // 
            // InventoryInfo_txt_QuantityPerUnit
            // 
            this.InventoryInfo_txt_QuantityPerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryInfo_txt_QuantityPerUnit.Location = new System.Drawing.Point(188, 114);
            this.InventoryInfo_txt_QuantityPerUnit.Margin = new System.Windows.Forms.Padding(4);
            this.InventoryInfo_txt_QuantityPerUnit.Name = "InventoryInfo_txt_QuantityPerUnit";
            this.InventoryInfo_txt_QuantityPerUnit.Size = new System.Drawing.Size(245, 29);
            this.InventoryInfo_txt_QuantityPerUnit.TabIndex = 0;
            // 
            // ingredient_idLb
            // 
            this.ingredient_idLb.AutoSize = true;
            this.ingredient_idLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredient_idLb.Location = new System.Drawing.Point(4, 66);
            this.ingredient_idLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ingredient_idLb.Name = "ingredient_idLb";
            this.ingredient_idLb.Size = new System.Drawing.Size(128, 25);
            this.ingredient_idLb.TabIndex = 1;
            this.ingredient_idLb.Text = "Ingredient ID:";
            // 
            // InventoryInfo_IngredientId
            // 
            this.InventoryInfo_IngredientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryInfo_IngredientId.Location = new System.Drawing.Point(188, 66);
            this.InventoryInfo_IngredientId.Margin = new System.Windows.Forms.Padding(4);
            this.InventoryInfo_IngredientId.Name = "InventoryInfo_IngredientId";
            this.InventoryInfo_IngredientId.Size = new System.Drawing.Size(245, 29);
            this.InventoryInfo_IngredientId.TabIndex = 0;
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
            // InventoryInfo_txt_CheckId
            // 
            this.InventoryInfo_txt_CheckId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryInfo_txt_CheckId.Location = new System.Drawing.Point(188, 11);
            this.InventoryInfo_txt_CheckId.Margin = new System.Windows.Forms.Padding(4);
            this.InventoryInfo_txt_CheckId.Name = "InventoryInfo_txt_CheckId";
            this.InventoryInfo_txt_CheckId.Size = new System.Drawing.Size(245, 29);
            this.InventoryInfo_txt_CheckId.TabIndex = 0;
            // 
            // dgv_InventoryInfo
            // 
            this.dgv_InventoryInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_InventoryInfo.Location = new System.Drawing.Point(22, 233);
            this.dgv_InventoryInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_InventoryInfo.Name = "dgv_InventoryInfo";
            this.dgv_InventoryInfo.RowHeadersWidth = 51;
            this.dgv_InventoryInfo.Size = new System.Drawing.Size(457, 239);
            this.dgv_InventoryInfo.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 27);
            this.label1.TabIndex = 64;
            this.label1.Text = "INVENTORY INFO";
            // 
            // Inventory_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.btn_CheckInventory);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.pl_Input);
            this.Controls.Add(this.dgv_InventoryInfo);
            this.Name = "Inventory_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory_Info";
            this.Load += new System.EventHandler(this.Inventory_Info_Load);
            this.pl_Input.ResumeLayout(false);
            this.pl_Input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InventoryInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Button btn_CheckInventory;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Panel pl_Input;
        private System.Windows.Forms.Label quantity_per_unitLb;
        private System.Windows.Forms.TextBox InventoryInfo_txt_QuantityPerUnit;
        private System.Windows.Forms.Label ingredient_idLb;
        private System.Windows.Forms.TextBox InventoryInfo_IngredientId;
        private System.Windows.Forms.Label check_idLb;
        private System.Windows.Forms.TextBox InventoryInfo_txt_CheckId;
        private System.Windows.Forms.DataGridView dgv_InventoryInfo;
        private System.Windows.Forms.Label label1;
    }
}