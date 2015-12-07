namespace AdminQuanLyShop
{
    partial class FrmKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btLoad = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.dtgKhachHang = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btTim = new System.Windows.Forms.Button();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtNgayDK = new System.Windows.Forms.DateTimePicker();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhachHang)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btLoad);
            this.panel2.Controls.Add(this.btXoa);
            this.panel2.Location = new System.Drawing.Point(12, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 44);
            this.panel2.TabIndex = 17;
            // 
            // btLoad
            // 
            this.btLoad.BackColor = System.Drawing.Color.Purple;
            this.btLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLoad.Location = new System.Drawing.Point(124, 3);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(115, 30);
            this.btLoad.TabIndex = 12;
            this.btLoad.Text = "Tải danh sách";
            this.btLoad.UseVisualStyleBackColor = false;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Purple;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btXoa.Location = new System.Drawing.Point(3, 3);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(115, 30);
            this.btXoa.TabIndex = 9;
            this.btXoa.Text = "Xóa ";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // dtgKhachHang
            // 
            this.dtgKhachHang.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgKhachHang.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgKhachHang.Location = new System.Drawing.Point(12, 285);
            this.dtgKhachHang.Name = "dtgKhachHang";
            this.dtgKhachHang.Size = new System.Drawing.Size(749, 332);
            this.dtgKhachHang.TabIndex = 16;
            this.dtgKhachHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKhachHang_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btTim);
            this.panel3.Controls.Add(this.txtLoc);
            this.panel3.Location = new System.Drawing.Point(12, 235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(463, 44);
            this.panel3.TabIndex = 15;
            // 
            // btTim
            // 
            this.btTim.BackColor = System.Drawing.Color.Purple;
            this.btTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTim.Location = new System.Drawing.Point(3, 3);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(115, 30);
            this.btTim.TabIndex = 9;
            this.btTim.Text = "Tìm kiếm";
            this.btTim.UseVisualStyleBackColor = false;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // txtLoc
            // 
            this.txtLoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoc.Location = new System.Drawing.Point(123, 6);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(333, 26);
            this.txtLoc.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dtNgayDK);
            this.panel1.Controls.Add(this.dtNgaySinh);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtGioiTinh);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtSoDT);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtHoten);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaKH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 167);
            this.panel1.TabIndex = 14;
            // 
            // dtNgayDK
            // 
            this.dtNgayDK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayDK.Location = new System.Drawing.Point(502, 118);
            this.dtNgayDK.Name = "dtNgayDK";
            this.dtNgayDK.Size = new System.Drawing.Size(232, 26);
            this.dtNgayDK.TabIndex = 24;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaySinh.Location = new System.Drawing.Point(138, 84);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(230, 26);
            this.dtNgaySinh.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(394, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ngày đăng ký : ";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioiTinh.Location = new System.Drawing.Point(502, 84);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(147, 26);
            this.txtGioiTinh.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(394, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Giới tính : ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(138, 119);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(147, 26);
            this.txtEmail.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Email : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ngày sinh : ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(502, 47);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(147, 26);
            this.txtDiaChi.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(394, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Địa chỉ : ";
            // 
            // txtSoDT
            // 
            this.txtSoDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.Location = new System.Drawing.Point(502, 9);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(147, 26);
            this.txtSoDT.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(394, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Số điện thoại : ";
            // 
            // txtHoten
            // 
            this.txtHoten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.Location = new System.Drawing.Point(138, 47);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(147, 26);
            this.txtHoten.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ tên : ";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(138, 9);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(147, 26);
            this.txtMaKH.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã khách hàng  : ";
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(765, 624);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtgKhachHang);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmKhachHang";
            this.Text = "FrmKhachHang";
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhachHang)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.DataGridView dtgKhachHang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtNgayDK;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label1;
    }
}