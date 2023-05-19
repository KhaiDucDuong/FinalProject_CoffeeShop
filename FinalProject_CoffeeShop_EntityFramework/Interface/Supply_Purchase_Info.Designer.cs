namespace FinalProject_CoffeeShop.Interface
{
    partial class Supply_Purchase_Info
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
            this.dgv_Purchase_Info = new System.Windows.Forms.DataGridView();
            this.PurchaseInfo_txt_QuantityPerUnit = new System.Windows.Forms.TextBox();
            this.ingredient_label = new System.Windows.Forms.Label();
            this.PurchaseInfo_txt_PurchasePrice = new System.Windows.Forms.TextBox();
            this.pl_Input = new System.Windows.Forms.Panel();
            this.quantity_per_unitLb = new System.Windows.Forms.Label();
            this.purchase_price = new System.Windows.Forms.Label();
            this.PurchaseInfo_txt_IngredientId = new System.Windows.Forms.TextBox();
            this.purchase_label = new System.Windows.Forms.Label();
            this.PurchaseInfo_txt_PurchaseId = new System.Windows.Forms.TextBox();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_OpenSupplyPurchase = new System.Windows.Forms.Button();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Purchase_Info)).BeginInit();
            this.pl_Input.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Purchase_Info
            // 
            this.dgv_Purchase_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Purchase_Info.Location = new System.Drawing.Point(10, 184);
            this.dgv_Purchase_Info.Name = "dgv_Purchase_Info";
            this.dgv_Purchase_Info.RowHeadersWidth = 51;
            this.dgv_Purchase_Info.Size = new System.Drawing.Size(343, 182);
            this.dgv_Purchase_Info.TabIndex = 25;
            this.dgv_Purchase_Info.TabStop = false;
            this.dgv_Purchase_Info.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupplypurchaseDGV_CellClick);
            // 
            // PurchaseInfo_txt_QuantityPerUnit
            // 
            this.PurchaseInfo_txt_QuantityPerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseInfo_txt_QuantityPerUnit.Location = new System.Drawing.Point(172, 73);
            this.PurchaseInfo_txt_QuantityPerUnit.Name = "PurchaseInfo_txt_QuantityPerUnit";
            this.PurchaseInfo_txt_QuantityPerUnit.Size = new System.Drawing.Size(165, 24);
            this.PurchaseInfo_txt_QuantityPerUnit.TabIndex = 2;
            // 
            // ingredient_label
            // 
            this.ingredient_label.AutoSize = true;
            this.ingredient_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredient_label.Location = new System.Drawing.Point(14, 43);
            this.ingredient_label.Name = "ingredient_label";
            this.ingredient_label.Size = new System.Drawing.Size(106, 20);
            this.ingredient_label.TabIndex = 2;
            this.ingredient_label.Text = "Ingredient ID:";
            // 
            // PurchaseInfo_txt_PurchasePrice
            // 
            this.PurchaseInfo_txt_PurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseInfo_txt_PurchasePrice.Location = new System.Drawing.Point(172, 102);
            this.PurchaseInfo_txt_PurchasePrice.Name = "PurchaseInfo_txt_PurchasePrice";
            this.PurchaseInfo_txt_PurchasePrice.Size = new System.Drawing.Size(165, 24);
            this.PurchaseInfo_txt_PurchasePrice.TabIndex = 3;
            // 
            // pl_Input
            // 
            this.pl_Input.Controls.Add(this.PurchaseInfo_txt_QuantityPerUnit);
            this.pl_Input.Controls.Add(this.ingredient_label);
            this.pl_Input.Controls.Add(this.quantity_per_unitLb);
            this.pl_Input.Controls.Add(this.PurchaseInfo_txt_PurchasePrice);
            this.pl_Input.Controls.Add(this.purchase_price);
            this.pl_Input.Controls.Add(this.PurchaseInfo_txt_IngredientId);
            this.pl_Input.Controls.Add(this.purchase_label);
            this.pl_Input.Controls.Add(this.PurchaseInfo_txt_PurchaseId);
            this.pl_Input.Location = new System.Drawing.Point(10, 42);
            this.pl_Input.Name = "pl_Input";
            this.pl_Input.Size = new System.Drawing.Size(343, 136);
            this.pl_Input.TabIndex = 26;
            // 
            // quantity_per_unitLb
            // 
            this.quantity_per_unitLb.AutoSize = true;
            this.quantity_per_unitLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_per_unitLb.Location = new System.Drawing.Point(14, 73);
            this.quantity_per_unitLb.Name = "quantity_per_unitLb";
            this.quantity_per_unitLb.Size = new System.Drawing.Size(132, 20);
            this.quantity_per_unitLb.TabIndex = 1;
            this.quantity_per_unitLb.Text = "Quantity per Unit:";
            // 
            // purchase_price
            // 
            this.purchase_price.AutoSize = true;
            this.purchase_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_price.Location = new System.Drawing.Point(14, 102);
            this.purchase_price.Name = "purchase_price";
            this.purchase_price.Size = new System.Drawing.Size(114, 20);
            this.purchase_price.TabIndex = 1;
            this.purchase_price.Text = "Purchase price";
            // 
            // PurchaseInfo_txt_IngredientId
            // 
            this.PurchaseInfo_txt_IngredientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseInfo_txt_IngredientId.Location = new System.Drawing.Point(172, 43);
            this.PurchaseInfo_txt_IngredientId.Name = "PurchaseInfo_txt_IngredientId";
            this.PurchaseInfo_txt_IngredientId.Size = new System.Drawing.Size(165, 24);
            this.PurchaseInfo_txt_IngredientId.TabIndex = 1;
            // 
            // purchase_label
            // 
            this.purchase_label.AutoSize = true;
            this.purchase_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_label.Location = new System.Drawing.Point(14, 15);
            this.purchase_label.Name = "purchase_label";
            this.purchase_label.Size = new System.Drawing.Size(101, 20);
            this.purchase_label.TabIndex = 1;
            this.purchase_label.Text = "Purchase ID:";
            // 
            // PurchaseInfo_txt_PurchaseId
            // 
            this.PurchaseInfo_txt_PurchaseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseInfo_txt_PurchaseId.Location = new System.Drawing.Point(172, 10);
            this.PurchaseInfo_txt_PurchaseId.Name = "PurchaseInfo_txt_PurchaseId";
            this.PurchaseInfo_txt_PurchaseId.Size = new System.Drawing.Size(165, 24);
            this.PurchaseInfo_txt_PurchaseId.TabIndex = 0;
            // 
            // btn_Reload
            // 
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.Location = new System.Drawing.Point(544, 42);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(75, 48);
            this.btn_Reload.TabIndex = 34;
            this.btn_Reload.TabStop = false;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(452, 40);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 48);
            this.btn_Save.TabIndex = 28;
            this.btn_Save.TabStop = false;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_OpenSupplyPurchase
            // 
            this.btn_OpenSupplyPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenSupplyPurchase.Location = new System.Drawing.Point(364, 210);
            this.btn_OpenSupplyPurchase.Name = "btn_OpenSupplyPurchase";
            this.btn_OpenSupplyPurchase.Size = new System.Drawing.Size(255, 55);
            this.btn_OpenSupplyPurchase.TabIndex = 29;
            this.btn_OpenSupplyPurchase.TabStop = false;
            this.btn_OpenSupplyPurchase.Text = "Open Supply Purchase";
            this.btn_OpenSupplyPurchase.UseVisualStyleBackColor = true;
            this.btn_OpenSupplyPurchase.Click += new System.EventHandler(this.btn_OpenSupplyPurchase_Click);
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoBack.Location = new System.Drawing.Point(364, 312);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(255, 55);
            this.btn_GoBack.TabIndex = 30;
            this.btn_GoBack.TabStop = false;
            this.btn_GoBack.Text = "Go back";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(364, 40);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 48);
            this.btn_Add.TabIndex = 31;
            this.btn_Add.TabStop = false;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(544, 107);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 48);
            this.btn_Cancel.TabIndex = 32;
            this.btn_Cancel.TabStop = false;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(364, 107);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 48);
            this.btn_Edit.TabIndex = 33;
            this.btn_Edit.TabStop = false;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(452, 107);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 48);
            this.btn_Delete.TabIndex = 27;
            this.btn_Delete.TabStop = false;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
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
            this.label1.Size = new System.Drawing.Size(230, 22);
            this.label1.TabIndex = 67;
            this.label1.Text = "SUPPLY PURCHASE INFO";
            // 
            // Supply_Purchase_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Purchase_Info);
            this.Controls.Add(this.pl_Input);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_OpenSupplyPurchase);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Delete);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Supply_Purchase_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supply_Purchase_Info";
            this.Load += new System.EventHandler(this.Supply_Purchase_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Purchase_Info)).EndInit();
            this.pl_Input.ResumeLayout(false);
            this.pl_Input.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Purchase_Info;
        private System.Windows.Forms.TextBox PurchaseInfo_txt_QuantityPerUnit;
        private System.Windows.Forms.Label ingredient_label;
        private System.Windows.Forms.TextBox PurchaseInfo_txt_PurchasePrice;
        private System.Windows.Forms.Panel pl_Input;
        private System.Windows.Forms.Label quantity_per_unitLb;
        private System.Windows.Forms.Label purchase_price;
        private System.Windows.Forms.TextBox PurchaseInfo_txt_IngredientId;
        private System.Windows.Forms.Label purchase_label;
        private System.Windows.Forms.TextBox PurchaseInfo_txt_PurchaseId;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_OpenSupplyPurchase;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label1;
    }
}