//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GPServices
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehicle
    {
        public int VehicleId { get; set; }
        public int DriverId { get; set; }
        public string Brand { get; set; }
        public string LicencePlate { get; set; }
        public Nullable<decimal> Length { get; set; }
        public Nullable<decimal> Width { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> Capacity { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public bool IsRead { get; set; }
    
        public virtual Driver Driver { get; set; }
    }
}