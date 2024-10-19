namespace QLKS_DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETDACTRUNGPHONG")]
    public partial class CHITIETDACTRUNGPHONG
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
        public int MaDacTrung { get; set; }

        public virtual DACTRUNGPHONG DACTRUNGPHONG { get; set; }

        public virtual LOAIPHONG LOAIPHONG { get; set; }
    }
}
