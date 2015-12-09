namespace AdminQuanLyShop
{
    partial class FrmKho
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
            this.dtKho = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btload = new System.Windows.Forms.Button();
            this.btTim = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMau = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.btCapNhatGia = new System.Windows.Forms.Button();
            this.txtGiaSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtKho)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtKho
            // 
            this.dtKho.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtKho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtKho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtKho.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtKho.Location = new System.Drawing.Point(12, 165);
            this.dtKho.Name = "dtKho";
            this.dtKho.Size = new System.Drawing.Size(722, 380);
            this.dtKho.TabIndex = 33;
            this.dtKho.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtKho_MouseDoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtTim);
            this.panel3.Controls.Add(this.btload);
            this.panel3.Controls.Add(this.btTim);
            this.panel3.Location = new System.Drawing.Point(12, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(719, 44);
            this.panel3.TabIndex = 34;
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(130, 10);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(236, 26);
            this.txtTim.TabIndex = 28;
            // 
            // btload
            // 
            this.btload.BackColor = System.Drawing.Color.Purple;
            this.btload.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btload.Location = new System.Drawing.Point(597, 6);
            this.btload.Name = "btload";
            this.btload.Size = new System.Drawing.Size(115, 30);
            this.btload.TabIndex = 29;
            this.btload.Text = "Tải kho";
            this.btload.UseVisualStyleBackColor = false;
            this.btload.Click += new System.EventHandler(this.btload_Click);
            // 
            // btTim
            // 
            this.btTim.BackColor = System.Drawing.Color.Purple;
            this.btTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTim.Location = new System.Drawing.Point(9, 7);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(115, 30);
            this.btTim.TabIndex = 12;
            this.btTim.Text = "Tìm kiếm";
            this.btTim.UseVisualStyleBackColor = false;
            this.btTim.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtMau);
            this.panel1.Controls.Add(this.txtTenSP);
            this.panel1.Controls.Add(this.btCapNhatGia);
            this.panel1.Controls.Add(this.txtGiaSP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 102);
            this.panel1.TabIndex = 35;
            // 
            // txtMau
            // 
            this.txtMau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMau.ForeColor = System.Drawing.Color.Maroon;
            this.txtMau.Location = new System.Drawing.Point(115, 55);
            this.txtMau.Name = "txtMau";
            this.txtMau.ReadOnly = true;
            this.txtMau.Size = new System.Drawing.Size(175, 26);
            this.txtMau.TabIndex = 32;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.ForeColor = System.Drawing.Color.Maroon;
            this.txtTenSP.Location = new System.Drawing.Point(115, 12);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.ReadOnly = true;
            this.txtTenSP.Size = new System.Drawing.Size(251, 26);
            this.txtTenSP.TabIndex = 31;
            // 
            // btCapNhatGia
            // 
            this.btCapNhatGia.BackColor = System.Drawing.Color.Purple;
            this.btCapNhatGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhatGia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCapNhatGia.Location = new System.Drawing.Point(395, 55);
            this.btCapNhatGia.Name = "btCapNhatGia";
            this.btCapNhatGia.Size = new System.Drawing.Size(115, 30);
            this.btCapNhatGia.TabIndex = 30;
            this.btCapNhatGia.Text = "Lưu ";
            this.btCapNhatGia.UseVisualStyleBackColor = false;
            this.btCapNhatGia.Click += new System.EventHandler(this.btCapNhatGia_Click);
            // 
            // txtGiaSP
            // 
            this.txtGiaSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaSP.Location = new System.Drawing.Point(490, 12);
            this.txtGiaSP.Name = "txtGiaSP";
            this.txtGiaSP.Size = new System.Drawing.Size(191, 26);
            this.txtGiaSP.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(391, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Giá sản phẩm  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Màu sắc  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tên sản phẩm  :";
            // 
            // FrmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(743, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dtKho);
            this.Name = "FrmKho";
            this.Text = "FrmKho";
            this.Load += new System.EventHandler(this.FrmKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtKho)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtKho;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Button btload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCapNhatGia;
        private System.Windows.Forms.TextBox txtGiaSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMau;
        private System.Windows.Forms.TextBox txtTenSP;
    }
}