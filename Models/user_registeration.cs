using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    public class user_registeration
    {
        public int Id { set; get; }
        public int user_id { set; get; }
        public string text { set; get; }
        public string password { set; get; }
        public string mobile_number { set; get; }
        public string photo_id { set; get; }

        [DefaultValue(true)]
        public bool user_type { set; get; } = true;
        public string authkey { set; get; }
    }
}

