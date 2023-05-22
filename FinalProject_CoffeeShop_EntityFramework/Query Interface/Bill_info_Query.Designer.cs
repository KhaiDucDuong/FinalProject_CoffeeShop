namespace FinalProject_CoffeeShop.Query_Interface
{
    partial class Bill_info_Query
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.Bill_Info_pl_Input = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Open_Bill_Query = new System.Windows.Forms.Button();
            this.btn_ShowAll = new System.Windows.Forms.Button();
            this.Bill_Info_txt_Bill_Id = new System.Windows.Forms.TextBox();
            this.Lb_Bill_Id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Bill_info_Query = new System.Windows.Forms.DataGridView();
            this.Bill_Info_pl_Input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill_info_Query)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 44;
            this.label1.Text = "BILL INFO QUERY";
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoBack.Location = new System.Drawing.Point(261, 89);
            this.btn_GoBack.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(104, 57);
            this.btn_GoBack.TabIndex = 49;
            this.btn_GoBack.TabStop = false;
            this.btn_GoBack.Text = "Go back";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // Bill_Info_pl_Input
            // 
            this.Bill_Info_pl_Input.Controls.Add(this.btn_Search);
            this.Bill_Info_pl_Input.Controls.Add(this.btn_Open_Bill_Query);
            this.Bill_Info_pl_Input.Controls.Add(this.btn_ShowAll);
            this.Bill_Info_pl_Input.Controls.Add(this.btn_GoBack);
            this.Bill_Info_pl_Input.Controls.Add(this.Bill_Info_txt_Bill_Id);
            this.Bill_Info_pl_Input.Controls.Add(this.Lb_Bill_Id);
            this.Bill_Info_pl_Input.Controls.Add(this.label2);
            this.Bill_Info_pl_Input.Location = new System.Drawing.Point(11, 33);
            this.Bill_Info_pl_Input.Margin = new System.Windows.Forms.Padding(2);
            this.Bill_Info_pl_Input.Name = "Bill_Info_pl_Input";
            this.Bill_Info_pl_Input.Size = new System.Drawing.Size(377, 158);
            this.Bill_Info_pl_Input.TabIndex = 50;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Search.Location = new System.Drawing.Point(261, 18);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(104, 46);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // btn_Open_Bill_Query
            // 
            this.btn_Open_Bill_Query.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Open_Bill_Query.Location = new System.Drawing.Point(110, 89);
            this.btn_Open_Bill_Query.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Open_Bill_Query.Name = "btn_Open_Bill_Query";
            this.btn_Open_Bill_Query.Size = new System.Drawing.Size(127, 57);
            this.btn_Open_Bill_Query.TabIndex = 49;
            this.btn_Open_Bill_Query.TabStop = false;
            this.btn_Open_Bill_Query.Text = "Open Bill query";
            this.btn_Open_Bill_Query.UseVisualStyleBackColor = true;
            this.btn_Open_Bill_Query.Click += new System.EventHandler(this.btn_Open_Bill_Query_Click);
            // 
            // btn_ShowAll
            // 
            this.btn_ShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowAll.Location = new System.Drawing.Point(11, 89);
            this.btn_ShowAll.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ShowAll.Name = "btn_ShowAll";
            this.btn_ShowAll.Size = new System.Drawing.Size(86, 57);
            this.btn_ShowAll.TabIndex = 49;
            this.btn_ShowAll.TabStop = false;
            this.btn_ShowAll.Text = "Show all";
            this.btn_ShowAll.UseVisualStyleBackColor = true;
            this.btn_ShowAll.Click += new System.EventHandler(this.btn_ShowAll_Click);
            // 
            // Bill_Info_txt_Bill_Id
            // 
            this.Bill_Info_txt_Bill_Id.Location = new System.Drawing.Point(81, 30);
            this.Bill_Info_txt_Bill_Id.Margin = new System.Windows.Forms.Padding(2);
            this.Bill_Info_txt_Bill_Id.Name = "Bill_Info_txt_Bill_Id";
            this.Bill_Info_txt_Bill_Id.Size = new System.Drawing.Size(156, 20);
            this.Bill_Info_txt_Bill_Id.TabIndex = 1;
            // 
            // Lb_Bill_Id
            // 
            this.Lb_Bill_Id.AutoSize = true;
            this.Lb_Bill_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Bill_Id.Location = new System.Drawing.Point(20, 28);
            this.Lb_Bill_Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_Bill_Id.Name = "Lb_Bill_Id";
            this.Lb_Bill_Id.Size = new System.Drawing.Size(54, 20);
            this.Lb_Bill_Id.TabIndex = 1;
            this.Lb_Bill_Id.Text = "Bill Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // dgv_Bill_info_Query
            // 
            this.dgv_Bill_info_Query.AllowUserToAddRows = false;
            this.dgv_Bill_info_Query.AllowUserToDeleteRows = false;
            this.dgv_Bill_info_Query.AllowUserToOrderColumns = true;
            this.dgv_Bill_info_Query.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Bill_info_Query.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Bill_info_Query.Location = new System.Drawing.Point(13, 196);
            this.dgv_Bill_info_Query.Name = "dgv_Bill_info_Query";
            this.dgv_Bill_info_Query.ReadOnly = true;
            this.dgv_Bill_info_Query.Size = new System.Drawing.Size(375, 445);
            this.dgv_Bill_info_Query.TabIndex = 51;
            // 
            // Bill_info_Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 653);
            this.Controls.Add(this.dgv_Bill_info_Query);
            this.Controls.Add(this.Bill_Info_pl_Input);
            this.Controls.Add(this.label1);
            this.Name = "Bill_info_Query";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill Info Query";
            this.Load += new System.EventHandler(this.Bill_info_Query_Load);
            this.Bill_Info_pl_Input.ResumeLayout(false);
            this.Bill_Info_pl_Input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill_info_Query)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Panel Bill_Info_pl_Input;
        private System.Windows.Forms.TextBox Bill_Info_txt_Bill_Id;
        private System.Windows.Forms.Label Lb_Bill_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_Bill_info_Query;
        private System.Windows.Forms.Button btn_Open_Bill_Query;
        private System.Windows.Forms.Button btn_ShowAll;
    }
}