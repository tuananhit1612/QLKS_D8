namespace QLKS_DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [Key]
        public int MaHoaDon { get; set; }

        public int MaPhong { get; set; }

        public DateTime NgayLap { get; set; }

        public decimal PhuThu { get; set; }

        [Required]
        [StringLength(121)]
        public string HinhThucThanhToan { get; set; }

        public decimal TongTienPhong { get; set; }

        public decimal TongTienDichVu { get; set; }

        public decimal ThanhTien { get; set; }

        public int MaNhanVien { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
