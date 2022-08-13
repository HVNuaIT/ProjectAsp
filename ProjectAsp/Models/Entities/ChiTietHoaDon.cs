using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectAsp.Models.Entities
{
    public partial class ChiTietHoaDon
    {
        public string MaChiTietHd { get; set; }
        public string MaSanPham { get; set; }
        public int? SoLuong { get; set; }
        public double? DonGia { get; set; }
        public int? GiamGiam { get; set; }
    }
}
