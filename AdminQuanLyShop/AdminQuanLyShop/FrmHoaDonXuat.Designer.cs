namespace AdminQuanLyShop
{
    partial class FrmHoaDonXuat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgChitiet = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btTaiDonHang = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgHoaDonXuat = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.btDuyet = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timeNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChitiet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoaDonXuat)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(675, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 27);
            this.label6.TabIndex = 44;
            this.label6.Text = "Danh sách hóa đơn xuất: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(3, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 27);
            this.label5.TabIndex = 38;
            this.label5.Text = "Chi tiết đơn hàng : ";
            // 
            // dtgChitiet
            // 
            this.dtgChitiet.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgChitiet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgChitiet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgChitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgChitiet.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgChitiet.Location = new System.Drawing.Point(3, 168);
            this.dtgChitiet.Name = "dtgChitiet";
            this.dtgChitiet.Size = new System.Drawing.Size(666, 335);
            this.dtgChitiet.TabIndex = 43;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtTim);
            this.panel3.Controls.Add(this.btTimKiem);
            this.panel3.Controls.Add(this.btTaiDonHang);
            this.panel3.Location = new System.Drawing.Point(675, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 44);
            this.panel3.TabIndex = 40;
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(130, 10);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(236, 26);
            this.txtTim.TabIndex = 28;
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
            this.label4.Location = new System.Drawing.Point(-153, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 22);
            this.label4.TabIndex = 42;
            // 
            // dtgHoaDonXuat
            // 
            this.dtgHoaDonXuat.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgHoaDonXuat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgHoaDonXuat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgHoaDonXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgHoaDonXuat.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgHoaDonXuat.Location = new System.Drawing.Point(675, 88);
            this.dtgHoaDonXuat.Name = "dtgHoaDonXuat";
            this.dtgHoaDonXuat.Size = new System.Drawing.Size(500, 415);
            this.dtgHoaDonXuat.TabIndex = 41;
            this.dtgHoaDonXuat.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgHoaDonXuat_CellMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtKhachHang);
            this.panel1.Controls.Add(this.btDuyet);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.timeNgayNhap);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaHD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 125);
            this.panel1.TabIndex = 37;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhachHang.Location = new System.Drawing.Point(123, 47);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.ReadOnly = true;
            this.txtKhachHang.Size = new System.Drawing.Size(147, 26);
            this.txtKhachHang.TabIndex = 37;
            // 
            // btDuyet
            // 
            this.btDuyet.BackColor = System.Drawing.Color.Red;
            this.btDuyet.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDuyet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDuyet.Location = new System.Drawing.Point(469, 50);
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
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Khách Hàng : ";
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
            // FrmHoaDonXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 537);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtgChitiet);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgHoaDonXuat);
            this.Controls.Add(this.panel1);
            this.Name = "FrmHoaDonXuat";
            this.Text = "FrmHoaDonXuat";
            this.Load += new System.EventHandler(this.FrmHoaDonXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgChitiet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoaDonXuat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgChitiet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btTaiDonHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgHoaDonXuat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btDuyet;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker timeNgayNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKhachHang;

    }
}