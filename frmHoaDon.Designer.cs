namespace MSB_PTBVIP23
{
    partial class frmHoaDon
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
            this.components = new System.ComponentModel.Container();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvHoaDonMusicBox = new System.Windows.Forms.DataGridView();
            this.txtNguoiBan = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.cbIDPhong = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.dgvHoaDonPhotoBooth = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonMusicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonPhotoBooth)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(12, 94);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(100, 20);
            this.txtTenKH.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvHoaDonMusicBox
            // 
            this.dgvHoaDonMusicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHoaDonMusicBox.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvHoaDonMusicBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonMusicBox.Location = new System.Drawing.Point(409, 266);
            this.dgvHoaDonMusicBox.Name = "dgvHoaDonMusicBox";
            this.dgvHoaDonMusicBox.Size = new System.Drawing.Size(391, 184);
            this.dgvHoaDonMusicBox.TabIndex = 3;
            //this.dgvHoaDonMusicBox.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            //this.dgvHoaDonMusicBox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick);
            // 
            // txtNguoiBan
            // 
            this.txtNguoiBan.Location = new System.Drawing.Point(118, 94);
            this.txtNguoiBan.Name = "txtNguoiBan";
            this.txtNguoiBan.Size = new System.Drawing.Size(111, 20);
            this.txtNguoiBan.TabIndex = 4;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(235, 94);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(100, 20);
            this.txtTongTien.TabIndex = 5;
            // 
            // cbIDPhong
            // 
            this.cbIDPhong.FormattingEnabled = true;
            this.cbIDPhong.Location = new System.Drawing.Point(341, 94);
            this.cbIDPhong.Name = "cbIDPhong";
            this.cbIDPhong.Size = new System.Drawing.Size(119, 21);
            this.cbIDPhong.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(509, 87);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(73, 28);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(507, 142);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(628, 142);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(628, 90);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Người Bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tổng Tiền";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "ID Phòng";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(325, 9);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(150, 13);
            this.lb5.TabIndex = 16;
            this.lb5.Text = "Quản Lý Danh Sách Hóa Đơn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 17;
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Location = new System.Drawing.Point(118, 141);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayBan.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ngày Bán";
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dgvHoaDonPhotoBooth
            // 
            this.dgvHoaDonPhotoBooth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvHoaDonPhotoBooth.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvHoaDonPhotoBooth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonPhotoBooth.Location = new System.Drawing.Point(2, 266);
            this.dgvHoaDonPhotoBooth.Name = "dgvHoaDonPhotoBooth";
            this.dgvHoaDonPhotoBooth.Size = new System.Drawing.Size(401, 184);
            this.dgvHoaDonPhotoBooth.TabIndex = 20;
            this.dgvHoaDonPhotoBooth.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDonPhotoBooth_CellClick);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvHoaDonPhotoBooth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpNgayBan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbIDPhong);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtNguoiBan);
            this.Controls.Add(this.dgvHoaDonMusicBox);
            this.Controls.Add(this.txtTenKH);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonMusicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonPhotoBooth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.DataGridView dgvHoaDonMusicBox;
        private System.Windows.Forms.TextBox txtNguoiBan;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.ComboBox cbIDPhong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.Label label7;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.DataGridView dgvHoaDonPhotoBooth;
    }
}