namespace QLKS_DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHONG")]
    public partial class PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONG()
        {
            HOADONs = new HashSet<HOADON>();
            PHIEUBAOTRIPHONGs = new HashSet<PHIEUBAOTRIPHONG>();
            PHIEUDATPHONGs = new HashSet<PHIEUDATPHONG>();
            PHIEUDONDEPPHONGs = new HashSet<PHIEUDONDEPPHONG>();
            PHIEUPHANPHONGs = new HashSet<PHIEUPHANPHONG>();
            PHIEUSUDUNGDICHVUs = new HashSet<PHIEUSUDUNGDICHVU>();
            PHIEUTHUEPHONGs = new HashSet<PHIEUTHUEPHONG>();
        }

        [Key]
        public int MaPhong { get; set; }

        [StringLength(20)]
        public string TinhTrang { get; set; }

        public byte MaTang { get; set; }

        public int MaLoaiPhong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }

        public virtual LOAIPHONG LOAIPHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUBAOTRIPHONG> PHIEUBAOTRIPHONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDATPHONG> PHIEUDATPHONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDONDEPPHONG> PHIEUDONDEPPHONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUPHANPHONG> PHIEUPHANPHONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUSUDUNGDICHVU> PHIEUSUDUNGDICHVUs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHUEPHONG> PHIEUTHUEPHONGs { get; set; }

        public virtual TANG TANG { get; set; }
    }
}
