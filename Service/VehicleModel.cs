//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Service
{
    using System;
    using System.Collections.Generic;
    
    public partial class VehicleModel
    {
        public System.Guid VehicleId { get; set; }
        public Nullable<int> Type { get; set; }
        public string VehicleNumber { get; set; }
        public string VehicleOwner { get; set; }
        public decimal VehicleWeight { get; set; }
        public Nullable<int> isRoMooc { get; set; }
        public Nullable<decimal> TrongLuongDangKiem { get; set; }
        public Nullable<decimal> TyLeVuot { get; set; }
        public Nullable<bool> isLock { get; set; }
        public Nullable<bool> isLockEdit { get; set; }
        public Nullable<System.Guid> CreatedUserId { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<System.Guid> LastEditUserId { get; set; }
        public Nullable<System.DateTime> LastEditTime { get; set; }
        public Nullable<decimal> TempWeight { get; set; }
        public Nullable<System.DateTime> UpdateTempWeightTime { get; set; }
        public Nullable<bool> isContainer { get; set; }
        public Nullable<bool> isDauKeo { get; set; }
        public Nullable<System.Guid> DriverId { get; set; }
        public string DriverName { get; set; }
        public string DriverCardNo { get; set; }
    }
}
