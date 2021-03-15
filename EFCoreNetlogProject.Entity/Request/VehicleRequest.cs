using System;
using System.Collections.Generic;
using System.Text;

namespace NetlogProject.Entity.Request
{
    public class VehicleRequest
    {
        public int id { get; set; }
        public string plateNo { get; set; }
        public int vehicleTypeId { get; set; }
        public int userId { get; set; }
        public int createdBy { get; set; }
        public int? modifiedBy { get; set; }
        public string profilepicture { get; set; }
    }
}
