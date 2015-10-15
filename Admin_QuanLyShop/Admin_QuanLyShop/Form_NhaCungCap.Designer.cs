namespace Admin_QuanLyShop
{
    partial class Form_NhaCungCap
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
            this.tableNhaCungCap = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.btNhapmoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSoTK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableNhaCungCap)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableNhaCungCap
            // 
            this.tableNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableNhaCungCap.Location = new System.Drawing.Point(12, 243);
            this.tableNhaCungCap.Name = "tableNhaCungCap";
            this.tableNhaCungCap.Size = new System.Drawing.Size(487, 217);
            this.tableNhaCungCap.TabIndex = 1;
            this.tableNhaCungCap.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableNhaCungCap_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.btNhapmoi);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btLoad);
            this.panel2.Controls.Add(this.btThem);
            this.panel2.Controls.Add(this.btSua);
            this.panel2.Location = new System.Drawing.Point(12, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 50);
            this.panel2.TabIndex = 8;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(343, 11);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "In danh sách";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btNhapmoi
            // 
            this.btNhapmoi.Location = new System.Drawing.Point(250, 11);
            this.btNhapmoi.Name = "btNhapmoi";
            this.btNhapmoi.Size = new System.Drawing.Size(87, 23);
            this.btNhapmoi.TabIndex = 5;
            this.btNhapmoi.Text = "Nhập mới";
            this.btNhapmoi.UseVisualStyleBackColor = true;
            this.btNhapmoi.Click += new System.EventHandler(this.btNhapmoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(133, 11);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(42, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(181, 11);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(63, 23);
            this.btLoad.TabIndex = 3;
            this.btLoad.Text = "Nạp lại";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(9, 11);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(63, 23);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm mới";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(78, 11);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(49, 23);
            this.btSua.TabIndex = 1;
            this.btSua.Text = "Sửa sản phẩm";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSoTK);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSoDT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNCC);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaNCC);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 109);
            this.panel1.TabIndex = 9;
            // 
            // txtSoTK
            // 
            this.txtSoTK.Location = new System.Drawing.Point(300, 43);
            this.txtSoTK.Name = "txtSoTK";
            this.txtSoTK.Size = new System.Drawing.Size(132, 20);
            this.txtSoTK.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số TK";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(65, 78);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(132, 20);
            this.txtDiaChi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa Chỉ";
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(300, 14);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(132, 20);
            this.txtSoDT.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số DT";
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(65, 47);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(132, 20);
            this.txtNCC.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên NCC";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(65, 14);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.ReadOnly = true;
            this.txtMaNCC.Size = new System.Drawing.Size(132, 20);
            this.txtMaNCC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NCC";
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(436, 214);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(63, 23);
            this.btTim.TabIndex = 7;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(298, 216);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(132, 20);
            this.txtTim.TabIndex = 10;
            // 
            // Form_NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 472);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableNhaCungCap);
            this.Name = "Form_NhaCungCap";
            this.Text = "Form_NhaCungCap";
            ((System.ComponentModel.ISupportInitialize)(this.tableNhaCungCap)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableNhaCungCap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btNhapmoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoTK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.TextBox txtTim;
    }
}