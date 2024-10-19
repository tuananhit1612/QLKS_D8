namespace QLKS_DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUTHUEPHONG")]
    public partial class PHIEUTHUEPHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUTHUEPHONG()
        {
            PHIEUPHANPHONGs = new HashSet<PHIEUPHANPHONG>();
        }

        [Key]
        public int SoPhieuThuePhong { get; set; }

        public int MaPhong { get; set; }

        public int MaLoaiPhong { get; set; }

        public decimal TraTruoc { get; set; }

        public DateTime NgayThuePhong { get; set; }

        public DateTime NgayDuKienTraPhong { get; set; }

        [Required]
        [StringLength(200)]
        public string GhiChu { get; set; }

        [Required]
        [StringLength(20)]
        public string TinhTrang { get; set; }

        public int MaNhanVien { get; set; }

        [Required]
        [StringLength(12)]
        public string CCCD { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual LOAIPHONG LOAIPHONG { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUPHANPHONG> PHIEUPHANPHONGs { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}