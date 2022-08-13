using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectAsp.Models.Entities
{
    public partial class TaiKhoan
    {
        public string MaTaiKhoan { get; set; }
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }
        public bool? Quyen { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
    }
}
