using MSB_PTBVIP23;
using System;
using System.Windows.Forms;

namespace MSB_PTBVIP23
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
             // Đặt form chính là MDI Container
        }

        private void OpenChildForm(Form childForm)
        {
            childForm.MdiParent = this;
            childForm.Show();
        }

        // ===================== HỆ THỐNG =====================

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // ===================== QUẢN LÝ =====================

        private void KhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang());
        }

        private void PhongMusicBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPhongMusicBox());
        }

        private void PhongPhotoBoothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPhongPhotoBooth());
        }

        private void PhuKienChupAnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPhuKienChupAnh());
        }

        private void MatHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmMatHang());
        }

        private void NhaCungCapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhaCungCap());
        }

        private void NhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanVien());
        }

        private void DonViTinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDonViTinh());
        }

        // ===================== HÓA ĐƠN =====================

        private void HoaDonNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDonNhap());
        }

        private void ChiTietHoaDonNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChiTietHoaDonNhap());
        }

        private void HoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDon());
        }

        private void ChiTietHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChiTietHoaDon());
        }

        // ===================== BÁO CÁO =====================

        private void BaoCaoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBaoCaoDoanhThu());
        }

        private void BaoCaoHoaDonDaThanhToanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBaoCaoHoaDonThanhToan());
        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {

        }
    }
}
