using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TuTor_Ngay4_8_23_CS3.DomainClass;

[Table("ChucVu")]
public partial class ChucVu
{
    [Key]
    [Column("idChucVu")]
    public Guid IdChucVu { get; set; }

    [Column("tenChucVu")]
    [StringLength(50)]
    public string? TenChucVu { get; set; }

    [InverseProperty("IdChucVuNavigation")]
    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
