using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class radialneedleinchseries
    {
        public string Boundary_dimensions_mm_Shaft_dia_in { get; set; }
        public string Boundary_dimensions_mm_Fw { get; set; }
        public string Boundary_dimensions_mm_Ew { get; set; }
        public string Boundary_dimensions_mm_Bc { get; set; }
        public string Bearing_No { get; set; }  
        public string Basic_load_ratings_kN_Cr { get; set; }
        public string Basic_load_ratings_kN_C0r { get; set; }
        public string Fatigue_load_limits_kN_Cu { get; set; }
        public string Limiting_speeds_min_Grease_lub { get; set; }
        public string Limiting_speeds_min_Oil_lub { get; set; }
        public string Recommended_dimensions_mm_Shaft_dia_h5_max { get; set; }
        public string Recommended_dimensions_mm_Shaft_dia_h5_min { get; set; }
        public string Recommended_dimensions_mm_S_Housing_bore_dia_G6_max { get; set; }
        public string Recommended_dimensions_mm_S_Housing_bore_dia_G6_min { get; set; }
        public string Refer_Mass_kg { get; set; }
      
    }
}
