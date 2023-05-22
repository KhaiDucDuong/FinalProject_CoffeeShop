namespace FinalProject_CoffeeShop.Query_Interface
{
    partial class Bill_Query
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_Bill_Query = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_ShowAll = new System.Windows.Forms.Button();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.btn_Open_Bill_Info_Query = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill_Query)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Bill_Query
            // 
            this.dgv_Bill_Query.AllowUserToAddRows = false;
            this.dgv_Bill_Query.AllowUserToDeleteRows = false;
            this.dgv_Bill_Query.AllowUserToResizeColumns = false;
            this.dgv_Bill_Query.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Bill_Query.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Bill_Query.Location = new System.Drawing.Point(9, 157);
            this.dgv_Bill_Query.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Bill_Query.Name = "dgv_Bill_Query";
            this.dgv_Bill_Query.RowHeadersWidth = 51;
            this.dgv_Bill_Query.RowTemplate.Height = 24;
            this.dgv_Bill_Query.Size = new System.Drawing.Size(428, 262);
            this.dgv_Bill_Query.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(158, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "BILL SEARCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "FROM";
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.CustomFormat = "HH:mm:ss  dd/MM/yyyy";
            this.dtp_StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_StartDate.Location = new System.Drawing.Point(61, 54);
            this.dtp_StartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.RightToLeftLayout = true;
            this.dtp_StartDate.ShowUpDown = true;
            this.dtp_StartDate.Size = new System.Drawing.Size(140, 21);
            this.dtp_StartDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "TO";
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.CustomFormat = "HH:mm:ss  dd/MM/yyyy";
            this.dtp_EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_EndDate.Location = new System.Drawing.Point(290, 54);
            this.dtp_EndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.RightToLeftLayout = true;
            this.dtp_EndDate.ShowUpDown = true;
            this.dtp_EndDate.Size = new System.Drawing.Size(140, 21);
            this.dtp_EndDate.TabIndex = 5;
            // 
            // btn_Find
            // 
            this.btn_Find.AutoSize = true;
            this.btn_Find.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Find.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Find.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btn_Find.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Find.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Find.Location = new System.Drawing.Point(188, 90);
            this.btn_Find.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(76, 31);
            this.btn_Find.TabIndex = 6;
            this.btn_Find.Text = "FIND";
            this.btn_Find.UseVisualStyleBackColor = false;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // btn_ShowAll
            // 
            this.btn_ShowAll.AutoSize = true;
            this.btn_ShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_ShowAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_ShowAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_ShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowAll.ForeColor = System.Drawing.Color.Black;
            this.btn_ShowAll.Location = new System.Drawing.Point(9, 125);
            this.btn_ShowAll.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ShowAll.Name = "btn_ShowAll";
            this.btn_ShowAll.Size = new System.Drawing.Size(76, 27);
            this.btn_ShowAll.TabIndex = 7;
            this.btn_ShowAll.Text = "Show All";
            this.btn_ShowAll.UseVisualStyleBackColor = false;
            this.btn_ShowAll.Click += new System.EventHandler(this.btn_ShowAll_Click);
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.AutoSize = true;
            this.btn_GoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GoBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_GoBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoBack.ForeColor = System.Drawing.Color.Black;
            this.btn_GoBack.Location = new System.Drawing.Point(291, 125);
            this.btn_GoBack.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(139, 27);
            this.btn_GoBack.TabIndex = 8;
            this.btn_GoBack.Text = "Go back";
            this.btn_GoBack.UseVisualStyleBackColor = false;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // btn_Open_Bill_Info_Query
            // 
            this.btn_Open_Bill_Info_Query.AutoSize = true;
            this.btn_Open_Bill_Info_Query.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Open_Bill_Info_Query.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_Open_Bill_Info_Query.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Open_Bill_Info_Query.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Open_Bill_Info_Query.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Open_Bill_Info_Query.ForeColor = System.Drawing.Color.Black;
            this.btn_Open_Bill_Info_Query.Location = new System.Drawing.Point(291, 90);
            this.btn_Open_Bill_Info_Query.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Open_Bill_Info_Query.Name = "btn_Open_Bill_Info_Query";
            this.btn_Open_Bill_Info_Query.Size = new System.Drawing.Size(139, 27);
            this.btn_Open_Bill_Info_Query.TabIndex = 9;
            this.btn_Open_Bill_Info_Query.Text = "Open Bill info query";
            this.btn_Open_Bill_Info_Query.UseVisualStyleBackColor = false;
            this.btn_Open_Bill_Info_Query.Click += new System.EventHandler(this.btn_Open_Bill_Info_Query_Click);
            // 
            // Bill_Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 430);
            this.Controls.Add(this.btn_Open_Bill_Info_Query);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.btn_ShowAll);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.dtp_EndDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_StartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Bill_Query);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bill_Query";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill Query";
            this.Load += new System.EventHandler(this.Bill_Query_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill_Query)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dgv_Bill_Query;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Button btn_ShowAll;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Button btn_Open_Bill_Info_Query;
    }
}