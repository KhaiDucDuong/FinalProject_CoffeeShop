﻿namespace FinalProject_CoffeeShop.Interface
{
    partial class Remaining_Items
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
            this.goBackBt = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.pl_Input = new System.Windows.Forms.Panel();
            this.RemainingItem_txt_Quantity = new System.Windows.Forms.TextBox();
            this.quantityLB = new System.Windows.Forms.Label();
            this.ItemIDLB = new System.Windows.Forms.Label();
            this.RemainingItem_txt_ItemId = new System.Windows.Forms.TextBox();
            this.dgv_RemainingItem = new System.Windows.Forms.DataGridView();
            this.pl_Input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RemainingItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Reload
            // 
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.Location = new System.Drawing.Point(544, 21);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(75, 48);
            this.btn_Reload.TabIndex = 62;
            this.btn_Reload.TabStop = false;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // goBackBt
            // 
            this.goBackBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackBt.Location = new System.Drawing.Point(358, 277);
            this.goBackBt.Name = "goBackBt";
            this.goBackBt.Size = new System.Drawing.Size(255, 55);
            this.goBackBt.TabIndex = 58;
            this.goBackBt.TabStop = false;
            this.goBackBt.Text = "Go back";
            this.goBackBt.UseVisualStyleBackColor = true;
            this.goBackBt.Click += new System.EventHandler(this.goBackBt_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(358, 24);
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
            this.btn_Cancel.Location = new System.Drawing.Point(544, 141);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 48);
            this.btn_Cancel.TabIndex = 60;
            this.btn_Cancel.TabStop = false;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(449, 141);
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
            this.btn_Save.Location = new System.Drawing.Point(449, 24);
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
            this.btn_Edit.Location = new System.Drawing.Point(358, 141);
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
            this.pl_Input.Controls.Add(this.RemainingItem_txt_Quantity);
            this.pl_Input.Controls.Add(this.quantityLB);
            this.pl_Input.Controls.Add(this.ItemIDLB);
            this.pl_Input.Controls.Add(this.RemainingItem_txt_ItemId);
            this.pl_Input.Location = new System.Drawing.Point(4, 24);
            this.pl_Input.Name = "pl_Input";
            this.pl_Input.Size = new System.Drawing.Size(343, 106);
            this.pl_Input.TabIndex = 55;
            // 
            // RemainingItem_txt_Quantity
            // 
            this.RemainingItem_txt_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingItem_txt_Quantity.Location = new System.Drawing.Point(160, 65);
            this.RemainingItem_txt_Quantity.Name = "RemainingItem_txt_Quantity";
            this.RemainingItem_txt_Quantity.Size = new System.Drawing.Size(165, 24);
            this.RemainingItem_txt_Quantity.TabIndex = 1;
            // 
            // quantityLB
            // 
            this.quantityLB.AutoSize = true;
            this.quantityLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLB.Location = new System.Drawing.Point(3, 67);
            this.quantityLB.Name = "quantityLB";
            this.quantityLB.Size = new System.Drawing.Size(68, 20);
            this.quantityLB.TabIndex = 1;
            this.quantityLB.Text = "Quantity";
            // 
            // ItemIDLB
            // 
            this.ItemIDLB.AutoSize = true;
            this.ItemIDLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemIDLB.Location = new System.Drawing.Point(3, 14);
            this.ItemIDLB.Name = "ItemIDLB";
            this.ItemIDLB.Size = new System.Drawing.Size(66, 20);
            this.ItemIDLB.TabIndex = 1;
            this.ItemIDLB.Text = "Item ID:";
            // 
            // RemainingItem_txt_ItemId
            // 
            this.RemainingItem_txt_ItemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingItem_txt_ItemId.Location = new System.Drawing.Point(160, 9);
            this.RemainingItem_txt_ItemId.Name = "RemainingItem_txt_ItemId";
            this.RemainingItem_txt_ItemId.Size = new System.Drawing.Size(165, 24);
            this.RemainingItem_txt_ItemId.TabIndex = 0;
            // 
            // dgv_RemainingItem
            // 
            this.dgv_RemainingItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RemainingItem.Location = new System.Drawing.Point(4, 150);
            this.dgv_RemainingItem.Name = "dgv_RemainingItem";
            this.dgv_RemainingItem.RowHeadersWidth = 51;
            this.dgv_RemainingItem.Size = new System.Drawing.Size(343, 182);
            this.dgv_RemainingItem.TabIndex = 54;
            this.dgv_RemainingItem.TabStop = false;
            this.dgv_RemainingItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RemainingItem_CellClick);
            // 
            // Remaining_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 343);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.goBackBt);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.pl_Input);
            this.Controls.Add(this.dgv_RemainingItem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Remaining_Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remaining_Item";
            this.Load += new System.EventHandler(this.Remaining_Item_Load);
            this.pl_Input.ResumeLayout(false);
            this.pl_Input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RemainingItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button goBackBt;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Panel pl_Input;
        private System.Windows.Forms.TextBox RemainingItem_txt_Quantity;
        private System.Windows.Forms.Label quantityLB;
        private System.Windows.Forms.Label ItemIDLB;
        private System.Windows.Forms.TextBox RemainingItem_txt_ItemId;
        private System.Windows.Forms.DataGridView dgv_RemainingItem;
    }
}