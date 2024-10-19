namespace QLKS_DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETTIENNGHI")]
    public partial class CHITIETTIENNGHI
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLoaiPhong { get; set; }

        [StringLength(200)]
        public string MoTa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaTienNghi { get; set; }

        public virtual LOAIPHONG LOAIPHONG { get; set; }

        public virtual TIENNGHI TIENNGHI { get; set; }
    }
}
