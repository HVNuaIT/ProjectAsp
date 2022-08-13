using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectAsp.Models.Entities
{
    public partial class DatHang
    {
        public string MaDatHang { get; set; }
        public string MaSanPham { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public DateTime? NgayDatHang { get; set; }
        public bool? TinhTrang { get; set; }
    }
}
