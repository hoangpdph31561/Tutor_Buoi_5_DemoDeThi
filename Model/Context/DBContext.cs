using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TuTor_Ngay4_8_23_CS3.DomainClass;

namespace TuTor_Ngay4_8_23_CS3.Context;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChucVu> ChucVus { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=PHAMDUCHOANG\\SQLEXPRESS;Initial Catalog=TUTOR_CS3_CHUCVU;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChucVu>(entity =>
        {
            entity.Property(e => e.IdChucVu).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.Property(e => e.IdNhanVien).ValueGeneratedNever();

            entity.HasOne(d => d.IdChucVuNavigation).WithMany(p => p.NhanViens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NhanVien_ChucVu");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
