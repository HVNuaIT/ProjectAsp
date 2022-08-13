using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectAsp.Models.Entities
{
    public partial class SanPham
    {
        public string MaSanPham { get; set; }
        public string MaDanhMuc { get; set; }
        public string TenSanPham { get; set; }
        public int? SoLuong { get; set; }
        public string HinhAnh { get; set; }
        public double? Gia { get; set; }
        public string MoTa { get; set; }
    }
}
