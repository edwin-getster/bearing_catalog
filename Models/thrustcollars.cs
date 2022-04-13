using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class thrustcollars
    {
        public string Boundary_dimensions_mm_d { set; get; }
        public string Boundary_dimensions_mm_d1 { set; get; }
        public string Boundary_dimensions_mm__B1 { set; get; }
        public string Boundary_dimensions_mm__B2 { set; get; }
        public string Boundary_dimensions_mm_r1_min { set; get; }
        public string Thrust_collar_No { set; get; }
        public string Refer_Mass_kg { set; get; }
        public string Bearing_No_NJ { set; get; }
        public string Applicable_bearing_No_NU { set; get; }
    }
}
