using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class heavydutyneedlemetricseries
    {
        public  string Boundary_dimensions_mm_Shaft_dia { get; set; }
        public  string Boundary_dimensions_mm_Fw { get; set; }
        public  string Boundary_dimensions_mm__D { get; set; }
        public  string Boundary_dimensions_mm__C { get; set; }
        public  string Boundary_dimensions_mm_r_min { get; set; }
        public  string Bearing_No { get; set; }
        public  string Column7 { get; set; }
        public  string Basic_load_ratings_kN_Cr { get; set; }
        public  string Basic_load_ratings_kN_C0r { get; set; }
        public  string Fatigue_load_limits_kN_Cu { get; set; }
        public  string Limiting_speeds_min_1_Grease_lub { get; set; }
        public  string Limiting_speeds_min_1_Oil_lub { get; set; }
        public  string Refer_Mass_kg { get; set; }
    }
}
