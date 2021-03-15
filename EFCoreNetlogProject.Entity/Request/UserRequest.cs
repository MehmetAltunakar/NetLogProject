using System;
using System.Collections.Generic;
using System.Text;

namespace NetlogProject.Entity.Request
{
    public class UserRequest
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public int createdBy { get; set; }
        public int? modifiedBy { get; set; }
        public string profilepicture { get; set; }
    }
}
