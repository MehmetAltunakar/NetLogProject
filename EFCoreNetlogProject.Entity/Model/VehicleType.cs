using NetlogProject.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreNetlogProject.Entity.Model
{
    public class VehicleType : EntityMain
    {
        public int id { get; set; }
        public string? name { get; set; }
        public IEnumerable<Vehicle> vehicles { get; set; }
    }
}
