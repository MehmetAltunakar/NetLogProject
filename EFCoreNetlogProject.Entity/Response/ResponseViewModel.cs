using System;
using System.Collections.Generic;
using System.Text;

namespace NetlogProject.Entity.Response
{
    public class ResponseViewModel
    {
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; }
        public object Data { get; set; }
        
    }
}
