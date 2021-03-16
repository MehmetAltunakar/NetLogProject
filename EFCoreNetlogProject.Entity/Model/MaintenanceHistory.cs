using NetlogProject.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreNetlogProject.Entity.Model
{
    public class MaintenanceHistory : EntityMain
    {
        public int id { get; set; }
        public int? maintenanceId { get; set; }
        public int? actionTypeId { get; set; }
        public string? text { get; set; }
        public Maintenance maintenance { get; set; }
        public ActionType actionType { get; set; }
    }
}
