namespace FinalProject_CoffeeShop.Interface
{
    partial class Ingredient
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
            this.btn_Reload = new System.Windows.Forms.Button();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.pl_Input = new System.Windows.Forms.Panel();
            this.Ingredient_txt_Unit = new System.Windows.Forms.TextBox();
            this.unitBT = new System.Windows.Forms.Label();
            this.Ingredient_txt_IngredientName = new System.Windows.Forms.TextBox();
            this.IngredientID_label = new System.Windows.Forms.Label();
            this.Ingredient_txt_IngredientId = new System.Windows.Forms.TextBox();
            this.Ingredient_NameLB = new System.Windows.Forms.Label();
            this.dgv_Ingredient = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pl_Input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ingredient)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Reload
            // 
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.Location = new System.Drawing.Point(388, 215);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(75, 48);
            this.btn_Reload.TabIndex = 62;
            this.btn_Reload.TabStop = false;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoBack.Location = new System.Drawing.Point(385, 295);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(185, 61);
            this.btn_GoBack.TabIndex = 58;
            this.btn_GoBack.TabStop = false;
            this.btn_GoBack.Text = "Go back";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(388, 37);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 48);
            this.btn_Add.TabIndex = 59;
            this.btn_Add.TabStop = false;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(495, 215);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 48);
            this.btn_Cancel.TabIndex = 60;
            this.btn_Cancel.TabStop = false;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(495, 128);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 48);
            this.btn_Delete.TabIndex = 56;
            this.btn_Delete.TabStop = false;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(388, 128);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 48);
            this.btn_Save.TabIndex = 57;
            this.btn_Save.TabStop = false;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(495, 37);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 48);
            this.btn_Edit.TabIndex = 61;
            this.btn_Edit.TabStop = false;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // pl_Input
            // 
            this.pl_Input.Controls.Add(this.Ingredient_txt_Unit);
            this.pl_Input.Controls.Add(this.unitBT);
            this.pl_Input.Controls.Add(this.Ingredient_txt_IngredientName);
            this.pl_Input.Controls.Add(this.IngredientID_label);
            this.pl_Input.Controls.Add(this.Ingredient_txt_IngredientId);
            this.pl_Input.Controls.Add(this.Ingredient_NameLB);
            this.pl_Input.Location = new System.Drawing.Point(9, 41);
            this.pl_Input.Name = "pl_Input";
            this.pl_Input.Size = new System.Drawing.Size(355, 117);
            this.pl_Input.TabIndex = 55;
            // 
            // Ingredient_txt_Unit
            // 
            this.Ingredient_txt_Unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingredient_txt_Unit.Location = new System.Drawing.Point(160, 77);
            this.Ingredient_txt_Unit.Name = "Ingredient_txt_Unit";
            this.Ingredient_txt_Unit.Size = new System.Drawing.Size(177, 24);
            this.Ingredient_txt_Unit.TabIndex = 3;
            // 
            // unitBT
            // 
            this.unitBT.AutoSize = true;
            this.unitBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitBT.Location = new System.Drawing.Point(3, 77);
            this.unitBT.Name = "unitBT";
            this.unitBT.Size = new System.Drawing.Size(46, 20);
            this.unitBT.TabIndex = 1;
            this.unitBT.Text = "Unit :";
            // 
            // Ingredient_txt_IngredientName
            // 
            this.Ingredient_txt_IngredientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingredient_txt_IngredientName.Location = new System.Drawing.Point(160, 42);
            this.Ingredient_txt_IngredientName.Name = "Ingredient_txt_IngredientName";
            this.Ingredient_txt_IngredientName.Size = new System.Drawing.Size(177, 24);
            this.Ingredient_txt_IngredientName.TabIndex = 1;
            // 
            // IngredientID_label
            // 
            this.IngredientID_label.AutoSize = true;
            this.IngredientID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientID_label.Location = new System.Drawing.Point(3, 14);
            this.IngredientID_label.Name = "IngredientID_label";
            this.IngredientID_label.Size = new System.Drawing.Size(106, 20);
            this.IngredientID_label.TabIndex = 1;
            this.IngredientID_label.Text = "Ingredient ID:";
            // 
            // Ingredient_txt_IngredientId
            // 
            this.Ingredient_txt_IngredientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingredient_txt_IngredientId.Location = new System.Drawing.Point(160, 9);
            this.Ingredient_txt_IngredientId.Name = "Ingredient_txt_IngredientId";
            this.Ingredient_txt_IngredientId.Size = new System.Drawing.Size(177, 24);
            this.Ingredient_txt_IngredientId.TabIndex = 0;
            // 
            // Ingredient_NameLB
            // 
            this.Ingredient_NameLB.AutoSize = true;
            this.Ingredient_NameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingredient_NameLB.Location = new System.Drawing.Point(3, 46);
            this.Ingredient_NameLB.Name = "Ingredient_NameLB";
            this.Ingredient_NameLB.Size = new System.Drawing.Size(131, 20);
            this.Ingredient_NameLB.TabIndex = 1;
            this.Ingredient_NameLB.Text = "Ingredient Name:";
            // 
            // dgv_Ingredient
            // 
            this.dgv_Ingredient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ingredient.Location = new System.Drawing.Point(9, 164);
            this.dgv_Ingredient.Name = "dgv_Ingredient";
            this.dgv_Ingredient.RowHeadersWidth = 51;
            this.dgv_Ingredient.Size = new System.Drawing.Size(355, 192);
            this.dgv_Ingredient.TabIndex = 54;
            this.dgv_Ingredient.TabStop = false;
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
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 63;
            this.label1.Text = "INGREDIENT";
            // 
            // Ingredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.pl_Input);
            this.Controls.Add(this.dgv_Ingredient);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ingredient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingredient";
            this.Load += new System.EventHandler(this.Ingredient_Load);
            this.pl_Input.ResumeLayout(false);
            this.pl_Input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ingredient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Panel pl_Input;
        private System.Windows.Forms.TextBox Ingredient_txt_Unit;
        private System.Windows.Forms.Label unitBT;
        private System.Windows.Forms.TextBox Ingredient_txt_IngredientName;
        private System.Windows.Forms.Label IngredientID_label;
        private System.Windows.Forms.TextBox Ingredient_txt_IngredientId;
        private System.Windows.Forms.Label Ingredient_NameLB;
        private System.Windows.Forms.DataGridView dgv_Ingredient;
        private System.Windows.Forms.Label label1;
    }
}