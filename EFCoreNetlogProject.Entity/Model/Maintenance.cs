using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetlogProject.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace EFCoreNetlogProject.Entity.Model
{
    public class Maintenance : EntityMain
    {
        public int id { get; set; }
        public int? vehicleId { get; set; }
        [ForeignKey(nameof(user))]
        public int? userId { get; set; }
        public string? description { get; set; }
        public int? pictureGroupId { get; set; }
        public DateTime? expectedTimeToFix { get; set; }
        [ForeignKey(nameof(responsibleUser))]
        public int? responsibleUserId { get; set; }
        public string? locationLongitude { get; set; }
        public string? locationLatitude { get; set; }
        public int? statusId { get; set; }
        public Vehicle vehicle { get; set; }
        public User user { get; set; }
        public User responsibleUser { get; set; }
        public PictureGroup pictureGroup { get; set; }
        public Status status { get; set; }
        public IEnumerable<MaintenanceHistory> maintenanceHistories { get; set; }

    }
}
