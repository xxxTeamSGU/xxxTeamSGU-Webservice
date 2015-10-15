namespace Admin_QuanLyShop
{
    partial class Form_DanhSachKhachHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableKhachHang = new System.Windows.Forms.DataGridView();
            this.btNap = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.btTim = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableKhachHang)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btNap);
            this.panel1.Controls.Add(this.tableKhachHang);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 382);
            this.panel1.TabIndex = 0;
            // 
            // tableKhachHang
            // 
            this.tableKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableKhachHang.Location = new System.Drawing.Point(3, 162);
            this.tableKhachHang.Name = "tableKhachHang";
            this.tableKhachHang.Size = new System.Drawing.Size(487, 217);
            this.tableKhachHang.TabIndex = 0;
            // 
            // btNap
            // 
            this.btNap.Location = new System.Drawing.Point(6, 133);
            this.btNap.Name = "btNap";
            this.btNap.Size = new System.Drawing.Size(91, 23);
            this.btNap.TabIndex = 2;
            this.btNap.Text = "Nạp danh sách";
            this.btNap.UseVisualStyleBackColor = true;
            this.btNap.Click += new System.EventHandler(this.btNap_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btTim);
            this.panel2.Controls.Add(this.cbGioiTinh);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtSoDT);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtHoTen);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(9, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 109);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên : ";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(65, 14);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(132, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(65, 47);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(132, 20);
            this.txtSoDT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số ĐT : ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(300, 14);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới Tính : ";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(300, 46);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(75, 21);
            this.cbGioiTinh.TabIndex = 7;
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(355, 86);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(113, 23);
            this.btTim.TabIndex = 4;
            this.btTim.Text = "Tìm khách hàng";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // Form_DanhSachKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 405);
            this.Controls.Add(this.panel1);
            this.Name = "Form_DanhSachKhachHang";
            this.Text = "Form_DanhSachKhachHang";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableKhachHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tableKhachHang;
        private System.Windows.Forms.Button btNap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
    }
}