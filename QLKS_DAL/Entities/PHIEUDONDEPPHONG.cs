namespace QLKS_DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUDONDEPPHONG")]
    public partial class PHIEUDONDEPPHONG
    {
        [Key]
        [Column(Order = 0)]
        public int MaDonDep { get; set; }

        public int MaPhong { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime NgayGioDonDep { get; set; }

        public DateTime NgayGioKetThuc { get; set; }

        [Required]
        [StringLength(20)]
        public string MoTa { get; set; }

        [Required]
        [StringLength(20)]
        public string TinhTrang { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
