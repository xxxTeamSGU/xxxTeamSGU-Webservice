namespace AdminQuanLyShop
{
    partial class FrmCTHDN
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgChitiethoadon = new System.Windows.Forms.DataGridView();
            this.dtgTenSP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dtgMau = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dtgSize = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dtgSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btThemDH = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.cbDuyetHD = new System.Windows.Forms.CheckBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timeNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChitiethoadon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Chi tiết đơn hàng : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 22);
            this.label4.TabIndex = 38;
            // 
            // dtgChitiethoadon
            // 
            this.dtgChitiethoadon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgChitiethoadon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgChitiethoadon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgChitiethoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChitiethoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgTenSP,
            this.dtgMau,
            this.dtgSize,
            this.dtgSoLuong,
            this.dtgGiaNhap});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgChitiethoadon.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgChitiethoadon.Location = new System.Drawing.Point(12, 222);
            this.dtgChitiethoadon.Name = "dtgChitiethoadon";
            this.dtgChitiethoadon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgChitiethoadon.Size = new System.Drawing.Size(731, 285);
            this.dtgChitiethoadon.TabIndex = 37;
            this.dtgChitiethoadon.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgChitiethoadon_RowEnter);
            // 
            // dtgTenSP
            // 
            this.dtgTenSP.HeaderText = "Tên sản phẩm";
            this.dtgTenSP.Name = "dtgTenSP";
            this.dtgTenSP.Width = 170;
            // 
            // dtgMau
            // 
            this.dtgMau.HeaderText = "Màu Sắc";
            this.dtgMau.Name = "dtgMau";
            this.dtgMau.Width = 130;
            // 
            // dtgSize
            // 
            this.dtgSize.HeaderText = "Size";
            this.dtgSize.Name = "dtgSize";
            this.dtgSize.Width = 130;
            // 
            // dtgSoLuong
            // 
            this.dtgSoLuong.HeaderText = "Số Lượng";
            this.dtgSoLuong.Name = "dtgSoLuong";
            this.dtgSoLuong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSoLuong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dtgSoLuong.Width = 130;
            // 
            // dtgGiaNhap
            // 
            this.dtgGiaNhap.HeaderText = "Giá Nhập";
            this.dtgGiaNhap.Name = "dtgGiaNhap";
            this.dtgGiaNhap.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgGiaNhap.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dtgGiaNhap.Width = 130;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btThemDH);
            this.panel2.Controls.Add(this.btXoa);
            this.panel2.Controls.Add(this.btCapNhat);
            this.panel2.Location = new System.Drawing.Point(12, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 44);
            this.panel2.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(243, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Nhập nhanh";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btThemDH
            // 
            this.btThemDH.BackColor = System.Drawing.Color.Purple;
            this.btThemDH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemDH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThemDH.Location = new System.Drawing.Point(3, 7);
            this.btThemDH.Name = "btThemDH";
            this.btThemDH.Size = new System.Drawing.Size(115, 30);
            this.btThemDH.TabIndex = 15;
            this.btThemDH.Text = "Thêm DH";
            this.btThemDH.UseVisualStyleBackColor = false;
            this.btThemDH.Click += new System.EventHandler(this.btThemDH_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Purple;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btXoa.Location = new System.Drawing.Point(364, 7);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(115, 30);
            this.btXoa.TabIndex = 14;
            this.btXoa.Text = "Thoát";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.BackColor = System.Drawing.Color.Purple;
            this.btCapNhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCapNhat.Location = new System.Drawing.Point(122, 7);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(115, 30);
            this.btCapNhat.TabIndex = 13;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.UseVisualStyleBackColor = false;
            this.btCapNhat.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbNCC);
            this.panel1.Controls.Add(this.cbDuyetHD);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.timeNgaynhap);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaHD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 125);
            this.panel1.TabIndex = 35;
            // 
            // cbNCC
            // 
            this.cbNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.Location = new System.Drawing.Point(145, 46);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(147, 24);
            this.cbNCC.TabIndex = 28;
            // 
            // cbDuyetHD
            // 
            this.cbDuyetHD.AutoSize = true;
            this.cbDuyetHD.Location = new System.Drawing.Point(511, 56);
            this.cbDuyetHD.Name = "cbDuyetHD";
            this.cbDuyetHD.Size = new System.Drawing.Size(73, 17);
            this.cbDuyetHD.TabIndex = 27;
            this.cbDuyetHD.Text = "Duyệt DH";
            this.cbDuyetHD.UseVisualStyleBackColor = true;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(511, 12);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(195, 35);
            this.txtTongTien.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tổng tiền : ";
            // 
            // timeNgaynhap
            // 
            this.timeNgaynhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeNgaynhap.Location = new System.Drawing.Point(145, 83);
            this.timeNgaynhap.Name = "timeNgaynhap";
            this.timeNgaynhap.Size = new System.Drawing.Size(248, 26);
            this.timeNgaynhap.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ngày nhập : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã nhà cung cấp : ";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(145, 9);
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
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hóa đơn  : ";
            // 
            // FrmCTHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(749, 515);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgChitiethoadon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCTHDN";
            this.Text = "FrmCTHDN";
            this.Load += new System.EventHandler(this.FrmCTHDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgChitiethoadon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgChitiethoadon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker timeNgaynhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThemDH;
        private System.Windows.Forms.DataGridViewComboBoxColumn dtgTenSP;
        private System.Windows.Forms.DataGridViewComboBoxColumn dtgMau;
        private System.Windows.Forms.DataGridViewComboBoxColumn dtgSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgGiaNhap;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbDuyetHD;
    }
}