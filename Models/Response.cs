using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    public class Response
    {
        public string Message { get; set; }
        public bool Status { get; set; }
        public string TableName { get; set; }
        public object Data { get; set; }
    }
}
