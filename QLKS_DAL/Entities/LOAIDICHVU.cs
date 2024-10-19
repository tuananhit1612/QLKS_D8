namespace QLKS_DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIDICHVU")]
    public partial class LOAIDICHVU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIDICHVU()
        {
            DICHVUs = new HashSet<DICHVU>();
        }

        [Key]
        public int MaLoaiDichVu { get; set; }

        [StringLength(212)]
        public string TenLoaiDichVu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DICHVU> DICHVUs { get; set; }
    }
}
