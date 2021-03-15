using NetlogProject.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreNetlogProject.Entity.Model
{
    public class User:EntityMain
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string profilePicture { get; set; }
    }
}
