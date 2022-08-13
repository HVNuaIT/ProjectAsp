using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ProjectAsp.Models.Entities
{
    public partial class ShopBanHangContext : DbContext
    {
        public ShopBanHangContext()
        {
        }

        public ShopBanHangContext(DbContextOptions<ShopBanHangContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<DatHang> DatHangs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=DESKTOP-US9F04C\\SQLEXPRESS2012;Initial Catalog=ShopBanHang;Persist Security Info=True;User ID=sa;Password=123");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ChiTietHoaDon>(entity =>
            {
                entity.HasKey(e => e.MaChiTietHd);

                entity.ToTable("ChiTietHoaDon");

                entity.Property(e => e.MaChiTietHd)
                    .HasMaxLength(10)
                    .HasColumnName("MaChiTietHD")
                    .IsFixedLength(true);

                entity.Property(e => e.MaSanPham)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DanhMuc>(entity =>
            {
                entity.HasKey(e => e.MaDanhMuc);

                entity.ToTable("DanhMuc");

                entity.Property(e => e.MaDanhMuc)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DatHang>(entity =>
            {
                entity.HasKey(e => e.MaDatHang);

                entity.ToTable("DatHang");

                entity.Property(e => e.MaDatHang)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MaSanPham)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.NgayDatHang).HasColumnType("date");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSanPham);

                entity.ToTable("SanPham");

                entity.Property(e => e.MaSanPham)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MaDanhMuc)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.HasKey(e => e.MaTaiKhoan);

                entity.ToTable("TaiKhoan");

                entity.Property(e => e.MaTaiKhoan)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.DiaChi).HasMaxLength(50);

                entity.Property(e => e.MatKhau).HasMaxLength(50);

                entity.Property(e => e.SoDienThoai).HasMaxLength(50);

                entity.Property(e => e.TenTaiKhoan).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
