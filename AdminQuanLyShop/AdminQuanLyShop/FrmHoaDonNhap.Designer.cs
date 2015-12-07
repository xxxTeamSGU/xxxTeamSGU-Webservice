namespace AdminQuanLyShop
{
    partial class FrmHoaDonNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btTaiDonHang = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btXoa = new System.Windows.Forms.Button();
            this.btNhapDH = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNhaCungCap = new System.Windows.Forms.TextBox();
            this.btDuyet = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timeNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgChitiet = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoaDonNhap)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.btTimKiem);
            this.panel3.Controls.Add(this.btTaiDonHang);
            this.panel3.Location = new System.Drawing.Point(684, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 44);
            this.panel3.TabIndex = 31;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(130, 10);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(236, 26);
            this.textBox4.TabIndex = 28;
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.Color.Purple;
            this.btTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTimKiem.Location = new System.Drawing.Point(9, 7);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(115, 30);
            this.btTimKiem.TabIndex = 12;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = false;
            // 
            // btTaiDonHang
            // 
            this.btTaiDonHang.BackColor = System.Drawing.Color.Purple;
            this.btTaiDonHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaiDonHang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTaiDonHang.Location = new System.Drawing.Point(372, 7);
            this.btTaiDonHang.Name = "btTaiDonHang";
            this.btTaiDonHang.Size = new System.Drawing.Size(115, 30);
            this.btTaiDonHang.TabIndex = 12;
            this.btTaiDonHang.Text = "Tải đơn hàng";
            this.btTaiDonHang.UseVisualStyleBackColor = false;
            this.btTaiDonHang.Click += new System.EventHandler(this.btTaiDonHang_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 22);
            this.label4.TabIndex = 33;
            // 
            // dtgHoaDonNhap
            // 
            this.dtgHoaDonNhap.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgHoaDonNhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgHoaDonNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgHoaDonNhap.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgHoaDonNhap.Location = new System.Drawing.Point(684, 140);
            this.dtgHoaDonNhap.Name = "dtgHoaDonNhap";
            this.dtgHoaDonNhap.Size = new System.Drawing.Size(500, 365);
            this.dtgHoaDonNhap.TabIndex = 32;
            this.dtgHoaDonNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHoaDonNhap_CellContentClick);
            this.dtgHoaDonNhap.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHoaDonNhap_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btXoa);
            this.panel2.Controls.Add(this.btNhapDH);
            this.panel2.Location = new System.Drawing.Point(684, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 44);
            this.panel2.TabIndex = 30;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Purple;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btXoa.Location = new System.Drawing.Point(130, 7);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(115, 30);
            this.btXoa.TabIndex = 16;
            this.btXoa.Text = "Xóa ĐH";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btNhapDH
            // 
            this.btNhapDH.BackColor = System.Drawing.Color.Purple;
            this.btNhapDH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhapDH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNhapDH.Location = new System.Drawing.Point(9, 7);
            this.btNhapDH.Name = "btNhapDH";
            this.btNhapDH.Size = new System.Drawing.Size(115, 30);
            this.btNhapDH.TabIndex = 15;
            this.btNhapDH.Text = "Nhập ĐH";
            this.btNhapDH.UseVisualStyleBackColor = false;
            this.btNhapDH.Click += new System.EventHandler(this.btNhapDH_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtNhanVien);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtNhaCungCap);
            this.panel1.Controls.Add(this.btDuyet);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.timeNgayNhap);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaHD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 125);
            this.panel1.TabIndex = 29;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanVien.Location = new System.Drawing.Point(469, 47);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.ReadOnly = true;
            this.txtNhanVien.Size = new System.Drawing.Size(190, 26);
            this.txtNhanVien.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(387, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 38;
            this.label7.Text = "NV lập : ";
            // 
            // txtNhaCungCap
            // 
            this.txtNhaCungCap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaCungCap.Location = new System.Drawing.Point(123, 47);
            this.txtNhaCungCap.Name = "txtNhaCungCap";
            this.txtNhaCungCap.ReadOnly = true;
            this.txtNhaCungCap.Size = new System.Drawing.Size(147, 26);
            this.txtNhaCungCap.TabIndex = 37;
            // 
            // btDuyet
            // 
            this.btDuyet.BackColor = System.Drawing.Color.Red;
            this.btDuyet.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDuyet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDuyet.Location = new System.Drawing.Point(544, 79);
            this.btDuyet.Name = "btDuyet";
            this.btDuyet.Size = new System.Drawing.Size(115, 30);
            this.btDuyet.TabIndex = 36;
            this.btDuyet.Text = "Duyệt đơn hàng";
            this.btDuyet.UseVisualStyleBackColor = false;
            this.btDuyet.Click += new System.EventHandler(this.btDuyet_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(469, 8);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(190, 35);
            this.txtTongTien.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tổng tiền : ";
            // 
            // timeNgayNhap
            // 
            this.timeNgayNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeNgayNhap.Location = new System.Drawing.Point(123, 83);
            this.timeNgayNhap.Name = "timeNgayNhap";
            this.timeNgayNhap.Size = new System.Drawing.Size(248, 26);
            this.timeNgayNhap.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ngày Nhập : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhà Cung Cấp : ";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(123, 9);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(147, 26);
            this.txtMaHD.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Hóa Đơn : ";
            // 
            // dtgChitiet
            // 
            this.dtgChitiet.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgChitiet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgChitiet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgChitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgChitiet.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgChitiet.Location = new System.Drawing.Point(12, 170);
            this.dtgChitiet.Name = "dtgChitiet";
            this.dtgChitiet.Size = new System.Drawing.Size(666, 335);
            this.dtgChitiet.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 27);
            this.label5.TabIndex = 30;
            this.label5.Text = "Chi tiết đơn hàng : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(684, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 27);
            this.label6.TabIndex = 35;
            this.label6.Text = "Danh sách hóa đơn nhập: ";
            // 
            // FrmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1194, 517);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtgChitiet);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgHoaDonNhap);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmHoaDonNhap";
            this.Text = "FrmHoaDonNhap";
            this.Load += new System.EventHandler(this.FrmHoaDonNhap_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoaDonNhap)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChitiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgHoaDonNhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btTaiDonHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker timeNgayNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btNhapDH;
        private System.Windows.Forms.DataGridView dtgChitiet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btDuyet;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNhaCungCap;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Label label7;
    }
}