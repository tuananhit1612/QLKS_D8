﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_BUS.ViewModels
{
    public class PhongDatTruocViewModel : PhongViewModel
    {
        public DateTime? ngayBatDau { get; set; }
        public DateTime? ngayKetThuc { get; set; }
        public string tenKH { get; set; }
        public string loai { get; set; }
    }
}