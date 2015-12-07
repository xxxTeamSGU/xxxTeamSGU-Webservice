namespace AdminQuanLyShop
{
    partial class FrmKhuyenMai
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btLoad = new System.Windows.Forms.Button();
            this.dtgKhuyenMai = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtBatDau = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenKM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhuyenMai)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btLoad);
            this.panel3.Location = new System.Drawing.Point(12, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 44);
            this.panel3.TabIndex = 14;
            // 
            // btLoad
            // 
            this.btLoad.BackColor = System.Drawing.Color.Purple;
            this.btLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLoad.Location = new System.Drawing.Point(3, 7);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(115, 30);
            this.btLoad.TabIndex = 10;
            this.btLoad.Text = "Tải ";
            this.btLoad.UseVisualStyleBackColor = false;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // dtgKhuyenMai
            // 
            this.dtgKhuyenMai.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgKhuyenMai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgKhuyenMai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgKhuyenMai.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgKhuyenMai.Location = new System.Drawing.Point(12, 199);
            this.dtgKhuyenMai.Name = "dtgKhuyenMai";
            this.dtgKhuyenMai.Size = new System.Drawing.Size(560, 253);
            this.dtgKhuyenMai.TabIndex = 13;
            this.dtgKhuyenMai.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKhuyenMai_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btXoa);
            this.panel2.Controls.Add(this.btSua);
            this.panel2.Controls.Add(this.btThem);
            this.panel2.Location = new System.Drawing.Point(12, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 44);
            this.panel2.TabIndex = 12;
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Purple;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btXoa.Location = new System.Drawing.Point(245, 3);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(115, 30);
            this.btXoa.TabIndex = 9;
            this.btXoa.Text = "Xóa ";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.Purple;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSua.Location = new System.Drawing.Point(124, 3);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(115, 30);
            this.btSua.TabIndex = 8;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.Purple;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThem.Location = new System.Drawing.Point(3, 3);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(115, 30);
            this.btThem.TabIndex = 7;
            this.btThem.Text = "Thêm ";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dtKetThuc);
            this.panel1.Controls.Add(this.dtBatDau);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTenKM);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaKM);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 89);
            this.panel1.TabIndex = 11;
            // 
            // dtKetThuc
            // 
            this.dtKetThuc.Location = new System.Drawing.Point(336, 50);
            this.dtKetThuc.Name = "dtKetThuc";
            this.dtKetThuc.Size = new System.Drawing.Size(200, 20);
            this.dtKetThuc.TabIndex = 8;
            // 
            // dtBatDau
            // 
            this.dtBatDau.Location = new System.Drawing.Point(336, 15);
            this.dtBatDau.Name = "dtBatDau";
            this.dtBatDau.Size = new System.Drawing.Size(200, 20);
            this.dtBatDau.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày KT : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(252, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày BĐ : ";
            // 
            // txtTenKM
            // 
            this.txtTenKM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKM.Location = new System.Drawing.Point(87, 47);
            this.txtTenKM.Name = "txtTenKM";
            this.txtTenKM.Size = new System.Drawing.Size(147, 26);
            this.txtTenKM.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại KM";
            // 
            // txtMaKM
            // 
            this.txtMaKM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKM.Location = new System.Drawing.Point(87, 9);
            this.txtMaKM.Name = "txtMaKM";
            this.txtMaKM.ReadOnly = true;
            this.txtMaKM.Size = new System.Drawing.Size(147, 26);
            this.txtMaKM.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã KM : ";
            // 
            // FrmKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(584, 465);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dtgKhuyenMai);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmKhuyenMai";
            this.Text = "FrmKhuyenMai";
            this.Load += new System.EventHandler(this.FrmKhuyenMai_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhuyenMai)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.DataGridView dtgKhuyenMai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtKetThuc;
        private System.Windows.Forms.DateTimePicker dtBatDau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenKM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKM;
        private System.Windows.Forms.Label label1;
    }
}