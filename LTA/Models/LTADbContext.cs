using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTA.Models
{
    public partial class LTADbContext : DbContext
    {
        private object modelBuider;
        public LTADbContext()
            : base("name=LTADbContext")
        {
        }


        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<PhieuThu> PhieuThus { get; set; }
        public virtual DbSet<Ngay> Ngays { get; set; }
        public virtual DbSet<ThanhToan> ThanhToans { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public System.Data.Entity.DbSet<LTA.Models.LoaiDanhMuc> LoaiDanhMucs { get; set; }
        public virtual DbSet<DonThanhToan> DonThanhToans { get; set; }
        public virtual DbSet<DonPhieuThu> DonPhieuThus { get; set; }
        public virtual DbSet<CheckAccount> CheckAccounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NhanVien>()
                 .Property(e => e.TenNhanVien)
                 .IsUnicode(false);
            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);
            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDTNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
               .Property(e => e.TenKhachHang)
               .IsUnicode(false);
            modelBuilder.Entity<KhachHang>()
               .Property(e => e.MaKhachHang)
               .IsUnicode(false);

            modelBuilder.Entity<PhieuThu>()
              .Property(e => e.SoPhieuThu)
              .IsUnicode(false);
            modelBuilder.Entity<PhieuThu>()
              .Property(e => e.MaNhanVien)
              .IsUnicode(false);
            modelBuilder.Entity<PhieuThu>()
              .Property(e => e.NgayThang)
              .IsUnicode(false);
            modelBuilder.Entity<PhieuThu>()
              .Property(e => e.SoKhach)
              .IsUnicode(false);
            modelBuilder.Entity<PhieuThu>()
              .Property(e => e.TongTien)
              .IsUnicode(false);

            modelBuilder.Entity<Ngay>()
              .Property(e => e.NgayThang)
              .IsUnicode(false);

            modelBuilder.Entity<ThanhToan>()
              .Property(e => e.SoPhieuThanhToan)
              .IsUnicode(false);
            modelBuilder.Entity<ThanhToan>()
              .Property(e => e.MaNhanVien)
              .IsUnicode(false);
            modelBuilder.Entity<ThanhToan>()
              .Property(e => e.NgayThang)
              .IsUnicode(false);
            modelBuilder.Entity<ThanhToan>()
              .Property(e => e.TongTien)
              .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
              .Property(e => e.SoDon)
              .IsUnicode(false);
            modelBuilder.Entity<DonHang>()
              .Property(e => e.MaNhanVien)
              .IsUnicode(false);
            modelBuilder.Entity<DonHang>()
              .Property(e => e.NgayThang)
              .IsUnicode(false);
            modelBuilder.Entity<DonHang>()
              .Property(e => e.MaDanhMuc)
              .IsUnicode(false);

            modelBuilder.Entity<DanhMuc>()
              .Property(e => e.MaDanhMuc)
              .IsUnicode(false);
            modelBuilder.Entity<DanhMuc>()
              .Property(e => e.TenDanhMuc)
              .IsUnicode(false);

            modelBuilder.Entity<LoaiDanhMuc>()
             .Property(e => e.MaLoaiDanhMuc)
             .IsUnicode(false);
            modelBuilder.Entity<LoaiDanhMuc>()
             .Property(e => e.TenLoaiDanhMuc)
             .IsUnicode(false);

            modelBuilder.Entity<DonThanhToan>()
             .Property(e => e.SoPhieuThanhToan)
             .IsUnicode(false);
            modelBuilder.Entity<DonThanhToan>()
             .Property(e => e.MaDanhMuc)
             .IsUnicode(false);
            modelBuilder.Entity<DonThanhToan>()
             .Property(e => e.TienDanhMuc)
             .IsUnicode(false);
            modelBuilder.Entity<DonThanhToan>()
             .Property(e => e.SoDon)
             .IsUnicode(false);

            modelBuilder.Entity<DonPhieuThu>()
             .Property(e => e.SoPhieuThu)
             .IsUnicode(false);
            modelBuilder.Entity<DonPhieuThu>()
             .Property(e => e.MaDanhMuc)
             .IsUnicode(false);
            modelBuilder.Entity<DonPhieuThu>()
             .Property(e => e.TienDanhMuc)
             .IsUnicode(false);
            modelBuilder.Entity<DonPhieuThu>()
             .Property(e => e.DonGiaDanhMuc)
             .IsUnicode(false);
        }
    }
}
