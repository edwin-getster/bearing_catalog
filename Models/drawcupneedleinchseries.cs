using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class drawcupneedleinchseries
    {
        public string Boundary_dimensions_mm_Shaft_dia { get; set; }
        public string Boundary_dimensions_mm_Fw { get; set; }
        public string Boundary_dimensions_mm__D { get; set; }
        public string Boundary_dimensions_mm_C { get; set; }
        public string Boundary_dimensions_mm_Y_max { get; set; }
        public string Bearing_No_With_open_ends { get; set; }
        public string Bearing_No_With_closed_end { get; set; }
        public string Basic_load_ratings_kN_Cr { get; set; }
        public string Basic_load_ratings_kN_C0r { get; set; }
        public string Fatigue_load_limits_kN_Cu { get; set; }
        public string Limiting_speeds_min_1_Grease_lub { get; set; }
        public string Limiting_speeds_min_1_Oil_lub { get; set; }
        public string Refer_Mass_kg_With_open_ends { get; set; }
        public string Refer_Mass_kg_With_closed_end { get; set; }
        public string Inspection_gage { get; set; }
    }
}
