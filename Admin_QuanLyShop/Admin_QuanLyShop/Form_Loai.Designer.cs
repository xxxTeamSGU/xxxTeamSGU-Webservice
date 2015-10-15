namespace Admin_QuanLyShop
{
    partial class Form_Loai
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
            this.tableLoai = new System.Windows.Forms.DataGridView();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btNap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLoai
            // 
            this.tableLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLoai.Location = new System.Drawing.Point(1, 130);
            this.tableLoai.Name = "tableLoai";
            this.tableLoai.Size = new System.Drawing.Size(242, 202);
            this.tableLoai.TabIndex = 0;
            this.tableLoai.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableLoai_CellDoubleClick);
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(70, 22);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.ReadOnly = true;
            this.txtMaLoai.Size = new System.Drawing.Size(132, 20);
            this.txtMaLoai.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Loại";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(70, 53);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(132, 20);
            this.txtTenLoai.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên Loại";
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(1, 101);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(56, 23);
            this.btThem.TabIndex = 8;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(91, 101);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(56, 23);
            this.btXoa.TabIndex = 10;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btNap
            // 
            this.btNap.Location = new System.Drawing.Point(187, 101);
            this.btNap.Name = "btNap";
            this.btNap.Size = new System.Drawing.Size(56, 23);
            this.btNap.TabIndex = 11;
            this.btNap.Text = "Nạp loại";
            this.btNap.UseVisualStyleBackColor = true;
            this.btNap.Click += new System.EventHandler(this.btNap_Click);
            // 
            // Form_Loai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 335);
            this.Controls.Add(this.btNap);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txtTenLoai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaLoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLoai);
            this.Name = "Form_Loai";
            this.Text = "Form_Loai";
            ((System.ComponentModel.ISupportInitialize)(this.tableLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableLoai;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btNap;
    }
}