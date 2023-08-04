using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuTor_Ngay4_8_23_CS3.Controller.Service;
using TuTor_Ngay4_8_23_CS3.DomainClass;

namespace TuTor_Ngay4_8_23_CS3.View
{
    public partial class QuanLyNhanVien : Form
    {
        NhanVienService _service = new NhanVienService();
        List<Guid> _lstIdChucVu = new List<Guid>();
        Guid? _idWhenClick;
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            radBtnNam.Checked = true;
            radBtnNu.Checked = false;
            LoadDataGridView(null);
        }
        private void LoadCombobox()
        {
            foreach (var item in _service.GetChucVus())
            {
                _lstIdChucVu.Add(item.IdChucVu);
                cmbChucVu.Items.Add(item.TenChucVu);
            }
            cmbChucVu.SelectedIndex = 0;
        }
        private void LoadDataGridView(string find)
        {
            int stt = 1;
            Type type = typeof(NhanVien);
            dgvNhanVien.ColumnCount = type.GetProperties().Length + 1;
            dgvNhanVien.Columns[0].Name = "STT";
            dgvNhanVien.Columns[1].Name = "Mã nhân viên";
            dgvNhanVien.Columns[2].Name = "Họ tên";
            dgvNhanVien.Columns[3].Name = "Giới tính";
            dgvNhanVien.Columns[4].Name = "Chức vụ";
            dgvNhanVien.Columns[5].Name = "Số ĐT";
            dgvNhanVien.Rows.Clear();
            foreach (var item in _service.GetNhanViens(find))
            {
                var result = _service.GetChucVus().First(x => x.IdChucVu == item.IdChucVu);
                dgvNhanVien.Rows.Add(stt++, item.IdNhanVien, item.TenNhanVien,
                    (item.GioiTinh == true ? "Nam" : "Nữ"),
                    result.TenChucVu, item.SoDienThoai);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            nhanvien.TenNhanVien = txtHoTen.Text;
            nhanvien.SoDienThoai = txtSoDienThoai.Text;
            if (radBtnNam.Checked)
            {
                nhanvien.GioiTinh = true;
            }
            else
            {
                nhanvien.GioiTinh = false;
            }
            nhanvien.IdChucVu = _lstIdChucVu[cmbChucVu.SelectedIndex];
            _service.AddNhanVien(nhanvien);
            LoadDataGridView(null);

        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index == _service.GetNhanViens(null).Count) return;
            _idWhenClick = Guid.Parse(dgvNhanVien.Rows[index].Cells[1].Value.ToString());
            var result = _service.GetNhanViens(null).First(x => x.IdNhanVien == _idWhenClick);
            txtHoTen.Text = result.TenNhanVien;
            txtSoDienThoai.Text = result.SoDienThoai;
            if (result.GioiTinh == true)
            {
                radBtnNam.Checked = true;
                radBtnNu.Checked = false;
            }
            else
            {
                radBtnNam.Checked = false;
                radBtnNu.Checked = true;
            }
            //combobox???
            int indexCombobox = _lstIdChucVu.FindIndex(x => x == result.IdChucVu);
            cmbChucVu.SelectedIndex = indexCombobox;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            nhanvien.TenNhanVien = txtHoTen.Text;
            nhanvien.SoDienThoai = txtSoDienThoai.Text;
            if (radBtnNam.Checked)
            {
                nhanvien.GioiTinh = true;
            }
            else
            {
                nhanvien.GioiTinh = false;
            }
            nhanvien.IdChucVu = _lstIdChucVu[cmbChucVu.SelectedIndex];
            _service.UpdateNhanVien(_idWhenClick, nhanvien);
            LoadDataGridView(null);
            _idWhenClick = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _service.DeleteNhanVien(_idWhenClick);
            LoadDataGridView(null);
            _idWhenClick = null;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim().Length == 0 || txtTimKiem.Text == null)
            {
                LoadDataGridView(null);
            }
            else
            {
                LoadDataGridView(txtTimKiem.Text);
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtSoDienThoai.Text = "";
            radBtnNam.Checked = true;
            radBtnNu.Checked = false;
            cmbChucVu.SelectedIndex = 1;
            _idWhenClick = null;
        }
    }
}
