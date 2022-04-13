using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class radialneedlemetricseries
    {
        public string Boundary_dimensions_mm_Shaft_dia { get; set; }
        public string Boundary_dimensions_mm_Fw { get; set; }
        public string Boundary_dimensions_mm_Ew { get; set; }
        public string Boundary_dimensions_mm_Bc_0_20_0_55 { get; set; }
        public string Bearing_No { get; set; }
        public string Basic_load_ratings_kN_Cr { get; set; }
        public string Basic_load_ratings_kN_C0r { get; set; }
        public string Fatigue_load_limit_kN_Cu { get; set; }
        public string Cage_material_P_S { get; set; }
        public string Limiting_speeds_min_1_Grease_lub { get; set; }
        public string Limiting_speeds_min_1_Oil_lub { get; set; }
        public string Refer_Mass_kg { get; set; }
        public string Recommended_dimensions_S_max { get; set; }
        public string Recommended_dimensions_S_min { get; set; }
        public string Recommended_dimensions_H_max { get; set; }
        public string Recommended_dimensions_mm_H_min { get; set; }
    }
}
