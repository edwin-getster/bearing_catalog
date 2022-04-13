using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class combinedneedlemetricseries2
    {
        public string Boundary_dimensions_mm_Shaft_dia { get; set; }
        public string Boundary_dimensions_mm__Fw { get; set; }
        public string Boundary_dimensions_mm__D { get; set; }
        public string Boundary_dimensions_mm__C { get; set; }
        public string Boundary_dimensions_mm_dw_E7 { get; set; }
        public string Boundary_dimensions_mm__Da { get; set; }
        public string Boundary_dimensions_mm__C1 { get; set; }
        public string Boundary_dimensions_mm__C2 { get; set; }
        public string Boundary_dimensions_mm_r_min { get; set; }
        public string Bearing_No_RAXR { get; set; }
        public string bearing_No_NAXR { get; set; }
        public string bearing_No_NAXR_Z { get; set; }
        public string Limiting_speed_min_1 { get; set; }
        public string Basic_load_ratings_kN_Cr { get; set; }
        public string basic_load_ratings_kN_radial_C0r { get; set; }
        public string basic_load_limits_kN_thrust_Ca { get; set; }
        public string basic_load_ratings_kN_Thrust_C0a { get; set; }
        public string fatigue_load_limits_kN_Cu_Radial { get; set; }
        public string fatigue_load_limits_kN_Cu_Thrust { get; set; }
        public string Refer_Mass_kg { get; set; }
        public string Matching_inner_ring_No { get; set; }
    }
}
