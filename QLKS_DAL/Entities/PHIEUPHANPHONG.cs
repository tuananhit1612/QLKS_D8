namespace QLKS_DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUPHANPHONG")]
    public partial class PHIEUPHANPHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUPHANPHONG()
        {
            CHITIETPHANPHONGs = new HashSet<CHITIETPHANPHONG>();
        }

        [Key]
        public int SoPhieuPP { get; set; }

        public int? SoPhieuThuePhong { get; set; }

        [Required]
        [StringLength(122)]
        public string GhiChu { get; set; }

        [Required]
        [StringLength(20)]
        public string Loai { get; set; }

        public int MaPhong { get; set; }

        public int? SoPhieuDatPhong { get; set; }

        [StringLength(100)]
        public string TinhTrang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHANPHONG> CHITIETPHANPHONGs { get; set; }

        public virtual PHIEUDATPHONG PHIEUDATPHONG { get; set; }

        public virtual PHONG PHONG { get; set; }

        public virtual PHIEUTHUEPHONG PHIEUTHUEPHONG { get; set; }
    }
}
