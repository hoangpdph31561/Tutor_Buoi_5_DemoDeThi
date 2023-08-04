using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuTor_Ngay4_8_23_CS3.Controller.Respository;
using TuTor_Ngay4_8_23_CS3.DomainClass;

namespace TuTor_Ngay4_8_23_CS3.Controller.Service
{
    internal class NhanVienService
    {
        NhanVienRespository _res;
        public NhanVienService()
        {
            _res = new NhanVienRespository();
        }
        public List<ChucVu> GetChucVus()
        {
            return _res.GetChucVus();
        }
        public List<NhanVien> GetNhanViens(string find)
        {
            return _res.GetNhanViens(find);
        }
        public void AddNhanVien(NhanVien nhanvien)
        {
            if(_res.AddNhanVien(nhanvien))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateNhanVien(Guid? id , NhanVien nhanvienUpdate)
        {
            if(_res.UpdateNhanVien(id, nhanvienUpdate))
            {
                MessageBox.Show("Đã sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteNhanVien(Guid? id)
        {
            if(_res.DeleteNhanVien(id))
            {
                MessageBox.Show("Đã Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
