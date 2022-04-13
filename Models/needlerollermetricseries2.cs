using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class needlerollermetricseries2
    {
        public string Boundary_dimensions_mm_Shaft_dia { get; set; }
        public string Boundary_dimensions_mm_d { get; set; }
        public string Boundary_dimensions_mm__F_1 { get; set; }
        public string Boundary_dimensions_mm__B { get; set; }
        public string Boundary_dimensions_mm_r_min { get; set; }
        public string Bearing_No { get; set; }
        public string Refer_Mass_kg { get; set; }
    }
}
