using EFCoreNetlogProject.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NetlogProject.Entity.Model
{
    public class EntityMain
    {
        public int id { get; set; }
        public DateTime createDate { get; set; }
        [ForeignKey(nameof(createdUser))]
        public int createdBy { get; set; }
        public DateTime? modifyDate { get; set; }
        [ForeignKey(nameof(modifiedUser))]
        public int? modifiedBy { get; set; }
        public bool isDeleted { get; set; }
        public User modifiedUser { get; set; }
        public User createdUser { get; set; }
    }
}
