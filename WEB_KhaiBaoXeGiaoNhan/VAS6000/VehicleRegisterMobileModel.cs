﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WEB_KhaiBaoXeGiaoNhan.VAS6000
{
    public partial class VehicleRegisterMobileModel
    {
        public Guid VehicleRegisterMobileId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? RegisterTime { get; set; }
        public string Dvvc { get; set; }
        public string SoDonHang { get; set; }
        public string GiaoNhan { get; set; }
        public string VehicleNumber { get; set; }
        public string DriverName { get; set; }
        public string DriverIdCard { get; set; }
        public string Note3 { get; set; }
        public decimal? TrongLuongGiaoDuKien { get; set; }
        public DateTime? ThoiGianToiDuKien { get; set; }
        public DateTime? ThoiGianToiThucTe { get; set; }
        public string Dvvccode { get; set; }
        public decimal? TrongLuongGiaoThucTe { get; set; }
        public decimal? TapChat { get; set; }
        public int? CungDuongCode { get; set; }
        public string CungDuongName { get; set; }
        public string Assets { get; set; }
        public string Note { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string ScaleTicketCode { get; set; }
        public bool? AllowEdit { get; set; }
        public bool? IsActive { get; set; }
        public int? BonusHour { get; set; }
        public string Romooc { get; set; }
        public string CompanyCode { get; set; }
    }
}
