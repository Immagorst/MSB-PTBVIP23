using System;

using System.Data;

using System.Windows.Forms;
using MSB_PTBVIP23.QuanLyMusicBoxPhotoBoothVIPDataSetTableAdapters;
namespace MSB_PTBVIP23
{
    public partial class frmHoaDon: Form
    {
        private QuanLyMusicBoxPhotoBoothVIPDataSet dataset;
        private HoaDonTableAdapter hoaDonAdapter;
        private PhongMusicBoxTableAdapter phongMusicBoxAdapter;
        private PhongPhotoBoothTableAdapter phongPhotoBoothAdapter;
        private int selectedMaHD = -1; // Lưu mã hóa đơn đang chọn
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dataset = new QuanLyMusicBoxPhotoBoothVIPDataSet();
            hoaDonAdapter = new HoaDonTableAdapter();
            phongMusicBoxAdapter = new PhongMusicBoxTableAdapter();
            phongPhotoBoothAdapter = new PhongPhotoBoothTableAdapter();
            LoadData();
            LoadComboBox();
        }
        private void LoadData()
        {
            hoaDonAdapter.Fill(dataset.HoaDon);
            phongMusicBoxAdapter.Fill(dataset.PhongMusicBox);
            phongPhotoBoothAdapter.Fill(dataset.PhongPhotoBooth);

            dgvHoaDonMusicBox.DataSource = dataset.PhongMusicBox;
            dgvHoaDonPhotoBooth.DataSource = dataset.PhongPhotoBooth;
        }
        private void LoadComboBox()
        { 
            DataTable dtPhong = new DataTable();
            dtPhong.Columns.Add("ID" , typeof(int));
            dtPhong.Columns.Add("TenPhong", typeof(string));

        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }


        private void dgvHoaDonPhotoBooth_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
