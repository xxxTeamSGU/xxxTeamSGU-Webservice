namespace AdminQuanLyShop
{
    partial class FrmQuanLySanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLySanPham));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btThemKM = new System.Windows.Forms.Button();
            this.btThemLoai = new System.Windows.Forms.Button();
            this.cbThuongHieu = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btPre = new System.Windows.Forms.Button();
            this.btThemAnh = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.datetimeNgayDang = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbKM = new System.Windows.Forms.ComboBox();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtxbChiTiet = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbMoTa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTenSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMasp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btTaiSP = new System.Windows.Forms.Button();
            this.btNhapMoi = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSuaSP = new System.Windows.Forms.Button();
            this.btThemSP = new System.Windows.Forms.Button();
            this.dtgSanPham = new System.Windows.Forms.DataGridView();
            this.btTim = new System.Windows.Forms.Button();
            this.txbLoc = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSanPham)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btThemKM);
            this.panel1.Controls.Add(this.btThemLoai);
            this.panel1.Controls.Add(this.cbThuongHieu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.datetimeNgayDang);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbKM);
            this.panel1.Controls.Add(this.cbLoai);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.rtxbChiTiet);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txbMoTa);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbTenSP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbMasp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 255);
            this.panel1.TabIndex = 0;
            // 
            // btThemKM
            // 
            this.btThemKM.BackColor = System.Drawing.Color.Purple;
            this.btThemKM.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemKM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThemKM.Location = new System.Drawing.Point(270, 163);
            this.btThemKM.Name = "btThemKM";
            this.btThemKM.Size = new System.Drawing.Size(34, 30);
            this.btThemKM.TabIndex = 20;
            this.btThemKM.Text = "+";
            this.btThemKM.UseVisualStyleBackColor = false;
            this.btThemKM.Click += new System.EventHandler(this.btThemKM_Click);
            // 
            // btThemLoai
            // 
            this.btThemLoai.BackColor = System.Drawing.Color.Purple;
            this.btThemLoai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemLoai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThemLoai.Location = new System.Drawing.Point(270, 88);
            this.btThemLoai.Name = "btThemLoai";
            this.btThemLoai.Size = new System.Drawing.Size(34, 30);
            this.btThemLoai.TabIndex = 10;
            this.btThemLoai.Text = "+";
            this.btThemLoai.UseVisualStyleBackColor = false;
            this.btThemLoai.Click += new System.EventHandler(this.btThemLoai_Click);
            // 
            // cbThuongHieu
            // 
            this.cbThuongHieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThuongHieu.FormattingEnabled = true;
            this.cbThuongHieu.Location = new System.Drawing.Point(122, 127);
            this.cbThuongHieu.Name = "cbThuongHieu";
            this.cbThuongHieu.Size = new System.Drawing.Size(147, 27);
            this.cbThuongHieu.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btNext);
            this.panel2.Controls.Add(this.btPre);
            this.panel2.Controls.Add(this.btThemAnh);
            this.panel2.Controls.Add(this.picBox);
            this.panel2.Location = new System.Drawing.Point(694, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 234);
            this.panel2.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(115, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Xóa ảnh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.Color.GhostWhite;
            this.btNext.Location = new System.Drawing.Point(286, 95);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(25, 23);
            this.btNext.TabIndex = 4;
            this.btNext.Text = ">>";
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btPre
            // 
            this.btPre.BackColor = System.Drawing.Color.GhostWhite;
            this.btPre.Location = new System.Drawing.Point(3, 95);
            this.btPre.Name = "btPre";
            this.btPre.Size = new System.Drawing.Size(25, 23);
            this.btPre.TabIndex = 3;
            this.btPre.Text = "<<";
            this.btPre.UseVisualStyleBackColor = false;
            this.btPre.Click += new System.EventHandler(this.btPre_Click);
            // 
            // btThemAnh
            // 
            this.btThemAnh.BackColor = System.Drawing.Color.Purple;
            this.btThemAnh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThemAnh.Location = new System.Drawing.Point(34, 206);
            this.btThemAnh.Name = "btThemAnh";
            this.btThemAnh.Size = new System.Drawing.Size(75, 23);
            this.btThemAnh.TabIndex = 1;
            this.btThemAnh.Text = "Thêm ảnh";
            this.btThemAnh.UseVisualStyleBackColor = false;
            this.btThemAnh.Click += new System.EventHandler(this.btThemAnh_Click);
            // 
            // picBox
            // 
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(34, 3);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(250, 200);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // datetimeNgayDang
            // 
            this.datetimeNgayDang.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeNgayDang.Location = new System.Drawing.Point(122, 205);
            this.datetimeNgayDang.Name = "datetimeNgayDang";
            this.datetimeNgayDang.Size = new System.Drawing.Size(218, 20);
            this.datetimeNgayDang.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ngày đăng :";
            // 
            // cbKM
            // 
            this.cbKM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKM.FormattingEnabled = true;
            this.cbKM.Location = new System.Drawing.Point(122, 165);
            this.cbKM.Name = "cbKM";
            this.cbKM.Size = new System.Drawing.Size(147, 27);
            this.cbKM.TabIndex = 15;
            // 
            // cbLoai
            // 
            this.cbLoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(122, 89);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(147, 27);
            this.cbLoai.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Khuyến Mãi:";
            // 
            // rtxbChiTiet
            // 
            this.rtxbChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbChiTiet.Location = new System.Drawing.Point(460, 55);
            this.rtxbChiTiet.Name = "rtxbChiTiet";
            this.rtxbChiTiet.Size = new System.Drawing.Size(218, 175);
            this.rtxbChiTiet.TabIndex = 11;
            this.rtxbChiTiet.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(374, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Chi Tiết SP : ";
            // 
            // txbMoTa
            // 
            this.txbMoTa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMoTa.Location = new System.Drawing.Point(460, 14);
            this.txbMoTa.Name = "txbMoTa";
            this.txbMoTa.Size = new System.Drawing.Size(218, 26);
            this.txbMoTa.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(374, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mô tả : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thương hiệu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loại SP  :";
            // 
            // txbTenSP
            // 
            this.txbTenSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTenSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenSP.Location = new System.Drawing.Point(122, 52);
            this.txbTenSP.Name = "txbTenSP";
            this.txbTenSP.Size = new System.Drawing.Size(218, 26);
            this.txbTenSP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sản phẩm : ";
            // 
            // txbMasp
            // 
            this.txbMasp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMasp.ForeColor = System.Drawing.Color.Red;
            this.txbMasp.Location = new System.Drawing.Point(122, 14);
            this.txbMasp.Name = "txbMasp";
            this.txbMasp.ReadOnly = true;
            this.txbMasp.Size = new System.Drawing.Size(147, 26);
            this.txbMasp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm : ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btTaiSP);
            this.panel3.Controls.Add(this.btNhapMoi);
            this.panel3.Controls.Add(this.btXoa);
            this.panel3.Controls.Add(this.btSuaSP);
            this.panel3.Controls.Add(this.btThemSP);
            this.panel3.Location = new System.Drawing.Point(12, 273);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1018, 52);
            this.panel3.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(788, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btTaiSP
            // 
            this.btTaiSP.BackColor = System.Drawing.Color.Purple;
            this.btTaiSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaiSP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTaiSP.Location = new System.Drawing.Point(655, 10);
            this.btTaiSP.Name = "btTaiSP";
            this.btTaiSP.Size = new System.Drawing.Size(115, 30);
            this.btTaiSP.TabIndex = 9;
            this.btTaiSP.Text = "Tải SP";
            this.btTaiSP.UseVisualStyleBackColor = false;
            this.btTaiSP.Click += new System.EventHandler(this.btTaiSP_Click);
            // 
            // btNhapMoi
            // 
            this.btNhapMoi.BackColor = System.Drawing.Color.Purple;
            this.btNhapMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhapMoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNhapMoi.Location = new System.Drawing.Point(522, 10);
            this.btNhapMoi.Name = "btNhapMoi";
            this.btNhapMoi.Size = new System.Drawing.Size(115, 30);
            this.btNhapMoi.TabIndex = 8;
            this.btNhapMoi.Text = "Nhập mới";
            this.btNhapMoi.UseVisualStyleBackColor = false;
            this.btNhapMoi.Click += new System.EventHandler(this.btNhapMoi_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Purple;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btXoa.Location = new System.Drawing.Point(389, 10);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(115, 30);
            this.btXoa.TabIndex = 7;
            this.btXoa.Text = "Xóa SP";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSuaSP
            // 
            this.btSuaSP.BackColor = System.Drawing.Color.Purple;
            this.btSuaSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaSP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSuaSP.Location = new System.Drawing.Point(257, 10);
            this.btSuaSP.Name = "btSuaSP";
            this.btSuaSP.Size = new System.Drawing.Size(115, 30);
            this.btSuaSP.TabIndex = 6;
            this.btSuaSP.Text = "Sửa SP";
            this.btSuaSP.UseVisualStyleBackColor = false;
            this.btSuaSP.Click += new System.EventHandler(this.btSuaSP_Click);
            // 
            // btThemSP
            // 
            this.btThemSP.BackColor = System.Drawing.Color.Purple;
            this.btThemSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemSP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThemSP.Location = new System.Drawing.Point(124, 10);
            this.btThemSP.Name = "btThemSP";
            this.btThemSP.Size = new System.Drawing.Size(115, 30);
            this.btThemSP.TabIndex = 5;
            this.btThemSP.Text = "Thêm SP";
            this.btThemSP.UseVisualStyleBackColor = false;
            this.btThemSP.Click += new System.EventHandler(this.btThemSP_Click);
            // 
            // dtgSanPham
            // 
            this.dtgSanPham.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgSanPham.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgSanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgSanPham.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgSanPham.Location = new System.Drawing.Point(12, 364);
            this.dtgSanPham.Name = "dtgSanPham";
            this.dtgSanPham.Size = new System.Drawing.Size(1018, 336);
            this.dtgSanPham.TabIndex = 2;
            this.dtgSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSanPham_CellContentClick);
            this.dtgSanPham.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSanPham_CellDoubleClick);
            // 
            // btTim
            // 
            this.btTim.BackColor = System.Drawing.Color.Purple;
            this.btTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTim.Location = new System.Drawing.Point(3, 2);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(115, 30);
            this.btTim.TabIndex = 11;
            this.btTim.Text = "Tìm kiếm SP";
            this.btTim.UseVisualStyleBackColor = false;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // txbLoc
            // 
            this.txbLoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLoc.Location = new System.Drawing.Point(116, 5);
            this.txbLoc.Name = "txbLoc";
            this.txbLoc.Size = new System.Drawing.Size(251, 26);
            this.txbLoc.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Lavender;
            this.panel4.Controls.Add(this.txbLoc);
            this.panel4.Controls.Add(this.btTim);
            this.panel4.Location = new System.Drawing.Point(12, 327);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(379, 36);
            this.panel4.TabIndex = 10;
            // 
            // FrmQuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1034, 702);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dtgSanPham);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.HelpButton = true;
            this.Name = "FrmQuanLySanPham";
            this.Text = "FrmQuanLySanPham";
            this.Load += new System.EventHandler(this.FrmQuanLySanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSanPham)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbMasp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTenSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datetimeNgayDang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbKM;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtxbChiTiet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbMoTa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btThemAnh;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btPre;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btTaiSP;
        private System.Windows.Forms.Button btNhapMoi;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSuaSP;
        private System.Windows.Forms.Button btThemSP;
        private System.Windows.Forms.DataGridView dtgSanPham;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.TextBox txbLoc;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbThuongHieu;
        private System.Windows.Forms.Button btThemKM;
        private System.Windows.Forms.Button btThemLoai;
        private System.Windows.Forms.Button button2;
    }
}