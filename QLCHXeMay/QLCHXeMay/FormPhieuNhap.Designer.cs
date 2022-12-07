
namespace QLCHXeMay
{
    partial class FormPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhieuNhap));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbMaPN = new System.Windows.Forms.ComboBox();
            this.btnInPN = new System.Windows.Forms.Button();
            this.btnThemPN = new System.Windows.Forms.Button();
            this.dtGrdVwHienThi = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cbbMaXe = new System.Windows.Forms.ComboBox();
            this.cbbMaNCC = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuuHD = new System.Windows.Forms.Button();
            this.btnTaoHD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwHienThi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbMaPN);
            this.groupBox2.Controls.Add(this.btnInPN);
            this.groupBox2.Controls.Add(this.btnThemPN);
            this.groupBox2.Controls.Add(this.dtGrdVwHienThi);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.cbbMaXe);
            this.groupBox2.Controls.Add(this.cbbMaNCC);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Location = new System.Drawing.Point(12, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 268);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // cbbMaPN
            // 
            this.cbbMaPN.FormattingEnabled = true;
            this.cbbMaPN.Location = new System.Drawing.Point(113, 19);
            this.cbbMaPN.Name = "cbbMaPN";
            this.cbbMaPN.Size = new System.Drawing.Size(113, 21);
            this.cbbMaPN.TabIndex = 50;
            // 
            // btnInPN
            // 
            this.btnInPN.Image = ((System.Drawing.Image)(resources.GetObject("btnInPN.Image")));
            this.btnInPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInPN.Location = new System.Drawing.Point(6, 194);
            this.btnInPN.Name = "btnInPN";
            this.btnInPN.Size = new System.Drawing.Size(131, 49);
            this.btnInPN.TabIndex = 49;
            this.btnInPN.Text = "In phiếu nhập";
            this.btnInPN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInPN.UseVisualStyleBackColor = true;
            // 
            // btnThemPN
            // 
            this.btnThemPN.Image = ((System.Drawing.Image)(resources.GetObject("btnThemPN.Image")));
            this.btnThemPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemPN.Location = new System.Drawing.Point(6, 124);
            this.btnThemPN.Name = "btnThemPN";
            this.btnThemPN.Size = new System.Drawing.Size(131, 50);
            this.btnThemPN.TabIndex = 48;
            this.btnThemPN.Text = "Thêm phiếu nhập";
            this.btnThemPN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemPN.UseVisualStyleBackColor = true;
            // 
            // dtGrdVwHienThi
            // 
            this.dtGrdVwHienThi.AllowUserToAddRows = false;
            this.dtGrdVwHienThi.AllowUserToDeleteRows = false;
            this.dtGrdVwHienThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdVwHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwHienThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column10,
            this.Column11});
            this.dtGrdVwHienThi.Location = new System.Drawing.Point(143, 74);
            this.dtGrdVwHienThi.Name = "dtGrdVwHienThi";
            this.dtGrdVwHienThi.ReadOnly = true;
            this.dtGrdVwHienThi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdVwHienThi.Size = new System.Drawing.Size(511, 188);
            this.dtGrdVwHienThi.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Mã phiếu nhập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Mã nhà cung cấp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Mã xe";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(231, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(290, 48);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(114, 20);
            this.txtSoLuong.TabIndex = 39;
            // 
            // cbbMaXe
            // 
            this.cbbMaXe.FormattingEnabled = true;
            this.cbbMaXe.Location = new System.Drawing.Point(290, 19);
            this.cbbMaXe.Name = "cbbMaXe";
            this.cbbMaXe.Size = new System.Drawing.Size(113, 21);
            this.cbbMaXe.TabIndex = 40;
            // 
            // cbbMaNCC
            // 
            this.cbbMaNCC.FormattingEnabled = true;
            this.cbbMaNCC.Location = new System.Drawing.Point(523, 19);
            this.cbbMaNCC.Name = "cbbMaNCC";
            this.cbbMaNCC.Size = new System.Drawing.Size(114, 21);
            this.cbbMaNCC.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(475, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(523, 48);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(114, 20);
            this.txtDonGia.TabIndex = 44;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLuuHD);
            this.groupBox1.Controls.Add(this.btnTaoHD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaPN);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtThanhTien);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 136);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuHD.Image")));
            this.btnLuuHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuHD.Location = new System.Drawing.Point(177, 64);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(137, 59);
            this.btnLuuHD.TabIndex = 46;
            this.btnLuuHD.Text = "Lưu phiếu nhập";
            this.btnLuuHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuHD.UseVisualStyleBackColor = true;
            this.btnLuuHD.Click += new System.EventHandler(this.btnLuuHD_Click);
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoHD.Image")));
            this.btnTaoHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoHD.Location = new System.Drawing.Point(17, 64);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(144, 59);
            this.btnTaoHD.TabIndex = 45;
            this.btnTaoHD.Text = "Tạo phiếu nhập";
            this.btnTaoHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoHD.UseVisualStyleBackColor = true;
            this.btnTaoHD.Click += new System.EventHandler(this.btnTaoHD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // txtMaPN
            // 
            this.txtMaPN.Location = new System.Drawing.Point(111, 20);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(112, 20);
            this.txtMaPN.TabIndex = 44;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(502, 20);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(112, 20);
            this.maskedTextBox1.TabIndex = 40;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Ngày lập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Thành tiền";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(306, 20);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(112, 20);
            this.txtThanhTien.TabIndex = 39;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaPN";
            this.Column1.HeaderText = "Mã phiếu nhập";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaXe";
            this.Column2.HeaderText = "Mã xe";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaNCC";
            this.Column3.HeaderText = "Mã nhà cung cấp";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "SoLuong";
            this.Column10.HeaderText = "Số lượng";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "DonGia";
            this.Column11.HeaderText = "Đơn giá";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // FormPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 444);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPhieuNhap";
            this.Text = "FormPhieuNhap";
            this.Load += new System.EventHandler(this.FormPhieuNhap_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwHienThi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbMaPN;
        private System.Windows.Forms.Button btnInPN;
        private System.Windows.Forms.Button btnThemPN;
        private System.Windows.Forms.DataGridView dtGrdVwHienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cbbMaXe;
        private System.Windows.Forms.ComboBox cbbMaNCC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLuuHD;
        private System.Windows.Forms.Button btnTaoHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtThanhTien;
    }
}