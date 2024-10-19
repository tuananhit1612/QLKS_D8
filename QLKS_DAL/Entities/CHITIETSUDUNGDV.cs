namespace QLKS_DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETSUDUNGDV")]
    public partial class CHITIETSUDUNGDV
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoPhieuDV { get; set; }

        [StringLength(200)]
        public string MoTa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDichVu { get; set; }

        public virtual DICHVU DICHVU { get; set; }

        public virtual PHIEUSUDUNGDICHVU PHIEUSUDUNGDICHVU { get; set; }
    }
}
