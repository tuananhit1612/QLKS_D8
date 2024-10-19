namespace QLKS_DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUSUDUNGDICHVU")]
    public partial class PHIEUSUDUNGDICHVU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUSUDUNGDICHVU()
        {
            CHITIETSUDUNGDVs = new HashSet<CHITIETSUDUNGDV>();
        }

        [Key]
        public int SoPhieuDV { get; set; }

        public int MaPhong { get; set; }

        public DateTime ThoiGian { get; set; }

        public int SoLuong { get; set; }

        public decimal ThanhTien { get; set; }

        public int MaNhanVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETSUDUNGDV> CHITIETSUDUNGDVs { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
