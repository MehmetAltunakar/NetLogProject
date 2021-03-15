using System;
using System.Collections.Generic;
using System.Text;

namespace NetlogProject.Entity.Model
{
    public class Identity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
