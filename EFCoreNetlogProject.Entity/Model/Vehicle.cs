using NetlogProject.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreNetlogProject.Entity.Model
{
    public class Vehicle : EntityMain
    {
        public int id { get; set; }
        public string? plateNo { get; set; }
        public int? vehicleTypeId { get; set; }
        public int? userId { get; set; }
        public User user { get; set; }
        public VehicleType vehicleType { get; set; }
        public IEnumerable<Maintenance> maintenances { get; set; }
    }
}
