namespace QLKS_DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIPHONG")]
    public partial class LOAIPHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIPHONG()
        {
            CHITIETDACTRUNGPHONGs = new HashSet<CHITIETDACTRUNGPHONG>();
            CHITIETTIENNGHIs = new HashSet<CHITIETTIENNGHI>();
            PHIEUDATPHONGs = new HashSet<PHIEUDATPHONG>();
            PHIEUTHUEPHONGs = new HashSet<PHIEUTHUEPHONG>();
            PHONGs = new HashSet<PHONG>();
        }

        [Key]
        public int MaLoaiPhong { get; set; }

        [Required]
        [StringLength(25)]
        public string TenLoaiPhong { get; set; }

        public int SoNguoi { get; set; }

        [Required]
        [StringLength(20)]
        public string DienTich { get; set; }

        [Required]
        [StringLength(200)]
        public string MoTa { get; set; }

        [Required]
        [StringLength(100)]
        public string HinhAnh { get; set; }

        public decimal DonGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDACTRUNGPHONG> CHITIETDACTRUNGPHONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETTIENNGHI> CHITIETTIENNGHIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDATPHONG> PHIEUDATPHONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHUEPHONG> PHIEUTHUEPHONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHONG> PHONGs { get; set; }
    }
}
