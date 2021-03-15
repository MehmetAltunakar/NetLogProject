using System;
using System.Collections.Generic;
using System.Text;

namespace NetlogProject.Entity.Request
{
    public class PictureGroupRequest
    {
        public int id { get; set; }
        public string pictureImage { get; set; }
        public int createdBy { get; set; }
        public int? modifiedBy { get; set; }
    }
}
