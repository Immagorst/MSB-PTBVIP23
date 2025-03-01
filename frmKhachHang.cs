using System;
using System.Data;
using System.Windows.Forms;
using MSB_PTBVIP23.QuanLyMusicBoxPhotoBoothVIPDataSetTableAdapters;
namespace MSB_PTBVIP23
{
    public partial class frmKhachHang: Form
    {
        private QuanLyMusicBoxPhotoBoothVIPDataSet dataset;
        private KhachHangTableAdapter khachHangAdapter;
        private int selectedMaKH = -1; // Lưu mã khách hàng đang chọn
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dataset = new QuanLyMusicBoxPhotoBoothVIPDataSet();
            khachHangAdapter = new KhachHangTableAdapter();

            LoadData();
        }

        private void LoadData()
        {
            dataset.KhachHang.Clear();  // Xóa dữ liệu cũ trước khi nạp lại
            khachHangAdapter.Fill(dataset.KhachHang);
            dgvKhachHang.DataSource = dataset.KhachHang;
        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                txtTenKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells["TenKH"].Value.ToString();
                txtSDT.Text = dgvKhachHang.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
                txtEmail.Text = dgvKhachHang.Rows[e.RowIndex].Cells["Email"].Value is DBNull ? "" : dgvKhachHang.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                dtpNgayTao.Value = dgvKhachHang.Rows[e.RowIndex].Cells["NgayTao"].Value is DBNull ? DateTime.Now : Convert.ToDateTime(dgvKhachHang.Rows[e.RowIndex].Cells["NgayTao"].Value);
            }
        }

        private void btnThem_CLick(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTenKH.Text) && !string.IsNullOrWhiteSpace(txtSDT.Text) &&
                !string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                DataRow newRow = dataset.KhachHang.NewRow();
                newRow["TenKH"] = txtTenKH.Text;
                newRow["SDT"] = txtSDT.Text;
                newRow["Email"] = txtEmail.Text;
                newRow["NgayTao"] = dtpNgayTao.Value;

                dataset.KhachHang.Rows.Add(newRow);
                khachHangAdapter.Update(dataset.KhachHang);
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedMaKH == -1)
            {
                MessageBox.Show("Vui lòng chọn khách hàng để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow[] rows = dataset.KhachHang.Select($"MaKH = {selectedMaKH}");
            if (rows.Length > 0)
            {
                rows[0]["TenKH"] = txtTenKH.Text;
                rows[0]["SDT"] = txtSDT.Text;
                rows[0]["Email"] = txtEmail.Text;
                rows[0]["NgayTao"] = dtpNgayTao.Value;

                khachHangAdapter.Update(dataset.KhachHang);
                MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedMaKH == -1)
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DataRow[] rows = dataset.KhachHang.Select($"MaKH = {selectedMaKH}");
                if (rows.Length > 0)
                {
                    rows[0].Delete();
                    khachHangAdapter.Update(dataset.KhachHang);
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
            selectedMaKH = -1;
            txtTenKH.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            dtpNgayTao.Value = DateTime.Now;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
