namespace QLKS_DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TIENNGHI")]
    public partial class TIENNGHI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIENNGHI()
        {
            CHITIETTIENNGHIs = new HashSet<CHITIETTIENNGHI>();
        }

        [Key]
        public int MaTienNghi { get; set; }

        [Required]
        [StringLength(50)]
        public string TenTienNghi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETTIENNGHI> CHITIETTIENNGHIs { get; set; }
    }
}
