using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class serialnoindex
    {

        public int series_No { set; get; }
        public string  Column2 { set; get; }
        public string inner_ring { set; get; }
        public string page { set; get; }
        public string outer_ring { set; get; }
        public string pages { set; get; }
    }
}
