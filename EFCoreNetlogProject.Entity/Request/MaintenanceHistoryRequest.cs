using System;
using System.Collections.Generic;
using System.Text;

namespace NetlogProject.Entity.Request
{
    public class MaintenanceHistoryRequest
    {
        public int id { get; set; }
        public int maintenanceId { get; set; }
        public int actionTypeId { get; set; }
        public string? text { get; set; }
        public int createdBy { get; set; }
        public int? modifiedBy { get; set; }
    }
}
