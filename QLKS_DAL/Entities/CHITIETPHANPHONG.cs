namespace QLKS_DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETPHANPHONG")]
    public partial class CHITIETPHANPHONG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string CCCD { get; set; }

        [StringLength(200)]
        public string MoTa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoPhieuPP { get; set; }

        public virtual PHIEUPHANPHONG PHIEUPHANPHONG { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
