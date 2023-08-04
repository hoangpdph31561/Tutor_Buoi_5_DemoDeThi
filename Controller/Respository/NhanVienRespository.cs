using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuTor_Ngay4_8_23_CS3.Context;
using TuTor_Ngay4_8_23_CS3.DomainClass;

namespace TuTor_Ngay4_8_23_CS3.Controller.Respository
{
    internal class NhanVienRespository
    {
        DBContext _db;
        public NhanVienRespository()
        {
            _db = new DBContext();
        }
        /// <summary>
        /// Lấy ra các đối tượng trong bảng chức vụ
        /// </summary>
        /// <returns>chức vụ</returns>
        public List<ChucVu> GetChucVus()
        {
            return _db.ChucVus.ToList();
        }
        /// <summary>
        /// Lấy ra các đối tượng trong bảng nhân viên
        /// </summary>
        /// <param name="find">tên không muốn tìm</param>
        /// <returns>nhân viên</returns>
        public List<NhanVien> GetNhanViens(string find)
        {
            //tìm tất cả nhân viên
            if(find == null)
            {
                return _db.NhanViens.ToList();
            }
            //nếu có chuỗi truyền vào thì tìm theo tên
            return _db.NhanViens.Where(x => !x.TenNhanVien.Trim().ToLower().Contains(find.Trim().ToLower())).ToList();
        }
        public bool AddNhanVien(NhanVien nhanVien)
        {
            if(nhanVien == null)
            {
                return false;
            }
            nhanVien.IdNhanVien = Guid.NewGuid();
            _db.NhanViens.Add(nhanVien);
            _db.SaveChanges();
            return true;
        }
        public bool UpdateNhanVien(Guid? id, NhanVien nhanVienUpdate)
        {
            var esixt = _db.NhanViens.FirstOrDefault(x => x.IdNhanVien == id);
            if(esixt == null || nhanVienUpdate == null)
            {
                return false;
            }
            esixt.TenNhanVien = nhanVienUpdate.TenNhanVien;
            esixt.SoDienThoai = nhanVienUpdate.SoDienThoai;
            esixt.GioiTinh = nhanVienUpdate.GioiTinh;
            esixt.IdChucVu = nhanVienUpdate.IdChucVu;
            _db.NhanViens.Update(esixt);
            _db.SaveChanges();
            return true;
        }
        public bool DeleteNhanVien(Guid? id)
        {
            var nhanVien = _db.NhanViens.FirstOrDefault(x => x.IdNhanVien == id);
            if(nhanVien == null)
            {
                return false;
            }
            _db.NhanViens.Remove(nhanVien);
            _db.SaveChanges();
            return true;
        }
    }
}
