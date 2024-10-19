namespace QLKS_DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            CHITIETPHANPHONGs = new HashSet<CHITIETPHANPHONG>();
            PHIEUDATPHONGs = new HashSet<PHIEUDATPHONG>();
            PHIEUTHUEPHONGs = new HashSet<PHIEUTHUEPHONG>();
        }

        [Key]
        [StringLength(12)]
        public string CCCD { get; set; }

        [Required]
        [StringLength(22)]
        public string TenKhachHang { get; set; }

        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(100)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(13)]
        public string SDT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHANPHONG> CHITIETPHANPHONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDATPHONG> PHIEUDATPHONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHUEPHONG> PHIEUTHUEPHONGs { get; set; }
    }
}
