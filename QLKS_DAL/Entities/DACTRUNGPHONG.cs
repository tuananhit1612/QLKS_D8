namespace QLKS_DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DACTRUNGPHONG")]
    public partial class DACTRUNGPHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DACTRUNGPHONG()
        {
            CHITIETDACTRUNGPHONGs = new HashSet<CHITIETDACTRUNGPHONG>();
        }

        [Key]
        public int MaDacTrung { get; set; }

        [Required]
        [StringLength(20)]
        public string TenDacTrung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDACTRUNGPHONG> CHITIETDACTRUNGPHONGs { get; set; }
    }
}
