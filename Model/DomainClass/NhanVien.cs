using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TuTor_Ngay4_8_23_CS3.DomainClass;

[Table("NhanVien")]
public partial class NhanVien
{
    [Key]
    [Column("idNhanVien")]
    public Guid IdNhanVien { get; set; }

    [Column("tenNhanVien")]
    [StringLength(50)]
    public string? TenNhanVien { get; set; }

    [Column("soDienThoai")]
    [StringLength(15)]
    [Unicode(false)]
    public string? SoDienThoai { get; set; }

    [Column("gioiTinh")]
    public bool? GioiTinh { get; set; }

    [Column("idChucVu")]
    public Guid IdChucVu { get; set; }

    [ForeignKey("IdChucVu")]
    [InverseProperty("NhanViens")]
    public virtual ChucVu IdChucVuNavigation { get; set; } = null!;
}
