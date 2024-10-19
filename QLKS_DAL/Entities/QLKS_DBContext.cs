using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLKS_DAL.Entities
{
    public partial class QLKS_DBContext : DbContext
    {
        private static QLKS_DBContext instance;
        public QLKS_DBContext()
            : base("name=QLKS_DBContext")
        {
        }
        public static QLKS_DBContext Instance
        {
            get
            {
                if(instance == null) instance = new QLKS_DBContext();
                return instance;
            }
        }
        public virtual DbSet<CHITIETDACTRUNGPHONG> CHITIETDACTRUNGPHONGs { get; set; }
        public virtual DbSet<CHITIETPHANPHONG> CHITIETPHANPHONGs { get; set; }
        public virtual DbSet<CHITIETSUDUNGDV> CHITIETSUDUNGDVs { get; set; }
        public virtual DbSet<CHITIETTIENNGHI> CHITIETTIENNGHIs { get; set; }
        public virtual DbSet<DACTRUNGPHONG> DACTRUNGPHONGs { get; set; }
        public virtual DbSet<DICHVU> DICHVUs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LOAIDICHVU> LOAIDICHVUs { get; set; }
        public virtual DbSet<LOAIPHONG> LOAIPHONGs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIEUBAOTRIPHONG> PHIEUBAOTRIPHONGs { get; set; }
        public virtual DbSet<PHIEUDATPHONG> PHIEUDATPHONGs { get; set; }
        public virtual DbSet<PHIEUDONDEPPHONG> PHIEUDONDEPPHONGs { get; set; }
        public virtual DbSet<PHIEUPHANPHONG> PHIEUPHANPHONGs { get; set; }
        public virtual DbSet<PHIEUSUDUNGDICHVU> PHIEUSUDUNGDICHVUs { get; set; }
        public virtual DbSet<PHIEUTHUEPHONG> PHIEUTHUEPHONGs { get; set; }
        public virtual DbSet<PHONG> PHONGs { get; set; }
        public virtual DbSet<TANG> TANGs { get; set; }
        public virtual DbSet<TIENNGHI> TIENNGHIs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHITIETPHANPHONG>()
                .Property(e => e.CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<DACTRUNGPHONG>()
                .HasMany(e => e.CHITIETDACTRUNGPHONGs)
                .WithRequired(e => e.DACTRUNGPHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DICHVU>()
                .Property(e => e.DonGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DICHVU>()
                .Property(e => e.HinhAnh)
                .IsUnicode(false);

            modelBuilder.Entity<DICHVU>()
                .HasMany(e => e.CHITIETSUDUNGDVs)
                .WithRequired(e => e.DICHVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.PhuThu)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.TongTienPhong)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.TongTienDichVu)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.ThanhTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.CHITIETPHANPHONGs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.PHIEUDATPHONGs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.PHIEUTHUEPHONGs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIDICHVU>()
                .Property(e => e.TenLoaiDichVu)
                .IsUnicode(false);

            modelBuilder.Entity<LOAIDICHVU>()
                .HasMany(e => e.DICHVUs)
                .WithRequired(e => e.LOAIDICHVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIPHONG>()
                .Property(e => e.DienTich)
                .IsUnicode(false);

            modelBuilder.Entity<LOAIPHONG>()
                .Property(e => e.HinhAnh)
                .IsUnicode(false);

            modelBuilder.Entity<LOAIPHONG>()
                .Property(e => e.DonGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LOAIPHONG>()
                .HasMany(e => e.CHITIETDACTRUNGPHONGs)
                .WithRequired(e => e.LOAIPHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIPHONG>()
                .HasMany(e => e.CHITIETTIENNGHIs)
                .WithRequired(e => e.LOAIPHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIPHONG>()
                .HasMany(e => e.PHIEUDATPHONGs)
                .WithRequired(e => e.LOAIPHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIPHONG>()
                .HasMany(e => e.PHIEUTHUEPHONGs)
                .WithRequired(e => e.LOAIPHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIPHONG>()
                .HasMany(e => e.PHONGs)
                .WithRequired(e => e.LOAIPHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.HOADONs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUDATPHONGs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUSUDUNGDICHVUs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUTHUEPHONGs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUBAOTRIPHONG>()
                .Property(e => e.ChiPhi)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PHIEUDATPHONG>()
                .Property(e => e.TienCoc)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PHIEUDATPHONG>()
                .Property(e => e.CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUPHANPHONG>()
                .HasMany(e => e.CHITIETPHANPHONGs)
                .WithRequired(e => e.PHIEUPHANPHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUSUDUNGDICHVU>()
                .Property(e => e.ThanhTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PHIEUSUDUNGDICHVU>()
                .HasMany(e => e.CHITIETSUDUNGDVs)
                .WithRequired(e => e.PHIEUSUDUNGDICHVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUTHUEPHONG>()
                .Property(e => e.TraTruoc)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PHIEUTHUEPHONG>()
                .Property(e => e.CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.HOADONs)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.PHIEUBAOTRIPHONGs)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.PHIEUDATPHONGs)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.PHIEUDONDEPPHONGs)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.PHIEUPHANPHONGs)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.PHIEUSUDUNGDICHVUs)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.PHIEUTHUEPHONGs)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TANG>()
                .HasMany(e => e.PHONGs)
                .WithRequired(e => e.TANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIENNGHI>()
                .HasMany(e => e.CHITIETTIENNGHIs)
                .WithRequired(e => e.TIENNGHI)
                .WillCascadeOnDelete(false);
        }
    }
}
