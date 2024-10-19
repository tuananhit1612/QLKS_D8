namespace QLKS_DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DICHVU")]
    public partial class DICHVU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DICHVU()
        {
            CHITIETSUDUNGDVs = new HashSet<CHITIETSUDUNGDV>();
        }

        [Key]
        public int MaDichVu { get; set; }

        public int MaLoaiDichVu { get; set; }

        [Required]
        [StringLength(121)]
        public string TenDichVu { get; set; }

        public decimal DonGia { get; set; }

        public int SoLuongConLai { get; set; }

        [Required]
        [StringLength(121)]
        public string HinhAnh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETSUDUNGDV> CHITIETSUDUNGDVs { get; set; }

        public virtual LOAIDICHVU LOAIDICHVU { get; set; }
    }
}
