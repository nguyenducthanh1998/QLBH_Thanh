namespace QuanLyBanHang
{
    partial class frmHoaDonMua
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridHDM = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dtpNgayMuaHDM = new System.Windows.Forms.DateTimePicker();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtMoTaHDM = new System.Windows.Forms.TextBox();
            this.txtGiaMuaHDM = new System.Windows.Forms.TextBox();
            this.txtSoLuongHDM = new System.Windows.Forms.TextBox();
            this.txtTenHDM = new System.Windows.Forms.TextBox();
            this.txtMaHDM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridTimKiemHDM = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.colMaHDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenHDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongHDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHDM)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTimKiemHDM)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(980, 461);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridHDM);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(972, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hóa đơn mua hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridHDM
            // 
            this.gridHDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHDM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHDM,
            this.colTenHDM,
            this.colSoLuongHDM,
            this.colGiaMua,
            this.colNgayMua,
            this.colMota,
            this.colMaHang});
            this.gridHDM.Location = new System.Drawing.Point(316, 9);
            this.gridHDM.Name = "gridHDM";
            this.gridHDM.Size = new System.Drawing.Size(650, 423);
            this.gridHDM.TabIndex = 1;
            this.gridHDM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHDM_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnNhap);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.dtpNgayMuaHDM);
            this.groupBox1.Controls.Add(this.txtMaHang);
            this.groupBox1.Controls.Add(this.txtMoTaHDM);
            this.groupBox1.Controls.Add(this.txtGiaMuaHDM);
            this.groupBox1.Controls.Add(this.txtSoLuongHDM);
            this.groupBox1.Controls.Add(this.txtTenHDM);
            this.groupBox1.Controls.Add(this.txtMaHDM);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 423);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // btnClear
            // 
            this.btnClear.Image = global::QuanLyBanHang.Properties.Resources.renew1;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(225, 377);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 30);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Làm mới";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            this.btnNhap.Image = global::QuanLyBanHang.Properties.Resources._103;
            this.btnNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhap.Location = new System.Drawing.Point(6, 377);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(63, 30);
            this.btnNhap.TabIndex = 8;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyBanHang.Properties.Resources.edit;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(79, 377);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(63, 30);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyBanHang.Properties.Resources.delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(152, 377);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(63, 30);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dtpNgayMuaHDM
            // 
            this.dtpNgayMuaHDM.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayMuaHDM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMuaHDM.Location = new System.Drawing.Point(71, 176);
            this.dtpNgayMuaHDM.Name = "dtpNgayMuaHDM";
            this.dtpNgayMuaHDM.Size = new System.Drawing.Size(227, 20);
            this.dtpNgayMuaHDM.TabIndex = 4;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(71, 290);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(227, 20);
            this.txtMaHang.TabIndex = 7;
            // 
            // txtMoTaHDM
            // 
            this.txtMoTaHDM.Location = new System.Drawing.Point(71, 213);
            this.txtMoTaHDM.Multiline = true;
            this.txtMoTaHDM.Name = "txtMoTaHDM";
            this.txtMoTaHDM.Size = new System.Drawing.Size(227, 58);
            this.txtMoTaHDM.TabIndex = 5;
            // 
            // txtGiaMuaHDM
            // 
            this.txtGiaMuaHDM.Location = new System.Drawing.Point(71, 139);
            this.txtGiaMuaHDM.Name = "txtGiaMuaHDM";
            this.txtGiaMuaHDM.Size = new System.Drawing.Size(227, 20);
            this.txtGiaMuaHDM.TabIndex = 3;
            // 
            // txtSoLuongHDM
            // 
            this.txtSoLuongHDM.Location = new System.Drawing.Point(71, 102);
            this.txtSoLuongHDM.Name = "txtSoLuongHDM";
            this.txtSoLuongHDM.Size = new System.Drawing.Size(227, 20);
            this.txtSoLuongHDM.TabIndex = 2;
            // 
            // txtTenHDM
            // 
            this.txtTenHDM.Location = new System.Drawing.Point(71, 65);
            this.txtTenHDM.Name = "txtTenHDM";
            this.txtTenHDM.Size = new System.Drawing.Size(227, 20);
            this.txtTenHDM.TabIndex = 1;
            // 
            // txtMaHDM
            // 
            this.txtMaHDM.Location = new System.Drawing.Point(71, 28);
            this.txtMaHDM.Name = "txtMaHDM";
            this.txtMaHDM.Size = new System.Drawing.Size(227, 20);
            this.txtMaHDM.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mô tả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày mua:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá mua:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên HĐ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã HĐ:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridTimKiemHDM);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(972, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tra cứu hóa đơn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridTimKiemHDM
            // 
            this.gridTimKiemHDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTimKiemHDM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.gridTimKiemHDM.Location = new System.Drawing.Point(316, 6);
            this.gridTimKiemHDM.Name = "gridTimKiemHDM";
            this.gridTimKiemHDM.Size = new System.Drawing.Size(650, 423);
            this.gridTimKiemHDM.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHoaDon";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã hóa đơn";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenHoaDon";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên hóa đơn";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SoLuong";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GiaMua";
            this.dataGridViewTextBoxColumn4.HeaderText = "Giá mua";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NgayMua";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ngày mua";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MoTa";
            this.dataGridViewTextBoxColumn6.HeaderText = "Mô tả";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MaHang";
            this.dataGridViewTextBoxColumn7.HeaderText = "Mã hàng";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 178);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Image = global::QuanLyBanHang.Properties.Resources.search;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(207, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 31);
            this.button4.TabIndex = 2;
            this.button4.Text = "Tìm kiếm   \r\n";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Từ khóa:";
            // 
            // colMaHDM
            // 
            this.colMaHDM.DataPropertyName = "MaHoaDon";
            this.colMaHDM.HeaderText = "Mã hóa đơn";
            this.colMaHDM.Name = "colMaHDM";
            // 
            // colTenHDM
            // 
            this.colTenHDM.DataPropertyName = "TenHoaDon";
            this.colTenHDM.HeaderText = "Tên hóa đơn";
            this.colTenHDM.Name = "colTenHDM";
            // 
            // colSoLuongHDM
            // 
            this.colSoLuongHDM.DataPropertyName = "SoLuong";
            this.colSoLuongHDM.HeaderText = "Số lượng";
            this.colSoLuongHDM.Name = "colSoLuongHDM";
            // 
            // colGiaMua
            // 
            this.colGiaMua.DataPropertyName = "GiaMua";
            dataGridViewCellStyle1.Format = "#,###,###";
            this.colGiaMua.DefaultCellStyle = dataGridViewCellStyle1;
            this.colGiaMua.HeaderText = "Giá mua";
            this.colGiaMua.Name = "colGiaMua";
            // 
            // colNgayMua
            // 
            this.colNgayMua.DataPropertyName = "NgayMua";
            this.colNgayMua.HeaderText = "Ngày mua";
            this.colNgayMua.Name = "colNgayMua";
            // 
            // colMota
            // 
            this.colMota.DataPropertyName = "MoTa";
            this.colMota.HeaderText = "Mô tả";
            this.colMota.Name = "colMota";
            // 
            // colMaHang
            // 
            this.colMaHang.DataPropertyName = "MaHang";
            this.colMaHang.HeaderText = "Mã hàng";
            this.colMaHang.Name = "colMaHang";
            // 
            // frmHoaDonMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 486);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmHoaDonMua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin hóa đơn mua hàng";
            this.Load += new System.EventHandler(this.frmHoaDonMua_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHDM)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTimKiemHDM)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView gridHDM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DateTimePicker dtpNgayMuaHDM;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtMoTaHDM;
        private System.Windows.Forms.TextBox txtGiaMuaHDM;
        private System.Windows.Forms.TextBox txtSoLuongHDM;
        private System.Windows.Forms.TextBox txtTenHDM;
        private System.Windows.Forms.TextBox txtMaHDM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView gridTimKiemHDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongHDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHang;
    }
}