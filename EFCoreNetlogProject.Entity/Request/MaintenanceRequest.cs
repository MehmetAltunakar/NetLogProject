using System;
using System.Collections.Generic;
using System.Text;

namespace NetlogProject.Entity.Request
{
    public class MaintenanceRequest
    {
        public int id { get; set; }
        public int vehicleId { get; set; }
        public int userId { get; set; }
        public string description { get; set; }
        public int pictureGroupId { get; set; }
        public DateTime? expectedTimeToFix { get; set; }
        public int responsibleUserId { get; set; }
        public string locationLongitude { get; set; }
        public string locationLatitude { get; set; }
        public int statusId { get; set; }
        public int createdBy { get; set; }
        public int? modifiedBy { get; set; }

    }
}
