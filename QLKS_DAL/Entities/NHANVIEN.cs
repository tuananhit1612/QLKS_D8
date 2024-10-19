namespace QLKS_DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            HOADONs = new HashSet<HOADON>();
            PHIEUDATPHONGs = new HashSet<PHIEUDATPHONG>();
            PHIEUSUDUNGDICHVUs = new HashSet<PHIEUSUDUNGDICHVU>();
            PHIEUTHUEPHONGs = new HashSet<PHIEUTHUEPHONG>();
        }

        [Key]
        public int MaNhanVien { get; set; }

        [Required]
        [StringLength(22)]
        public string Ho { get; set; }

        [Required]
        [StringLength(22)]
        public string Ten { get; set; }

        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(13)]
        public string SoDienThoai { get; set; }

        [Required]
        [StringLength(22)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(33)]
        public string ChucVu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDATPHONG> PHIEUDATPHONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUSUDUNGDICHVU> PHIEUSUDUNGDICHVUs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHUEPHONG> PHIEUTHUEPHONGs { get; set; }
    }
}
