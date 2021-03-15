using System;
using System.Collections.Generic;
using System.Text;

namespace NetlogProject.Entity.Request
{
    public class VehicleTypeRequest
    {

        public int id { get; set; }
        public string name { get; set; }
        public int createdBy { get; set; }
        public int? modifiedBy { get; set; }
    }
}
