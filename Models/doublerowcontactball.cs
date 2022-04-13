using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class doublerowcontactball
    {
        public string Boundary_dimensions_mm_d { get; set; }
        public string Boundary_dimensions_mm__D { get; set; }
        public string Boundary_dimensions_mm__B { get; set; }
        public string Boundary_dimensions_mm_r_min { get; set; }
        public string Basic_load_ratings_KN_Open_Cr { get; set; }
        public string Basic_load_ratings_KN_Open_C0r { get; set; }
        public string Basic_load_ratings_KN_Shielded_sealed_Cr { get; set; }
        public string Basic_load_ratings_KN_Shielded_sealed_C0r { get; set; }
        public string Fatigue_load_limits_kN_Cu_Open { get; set; }
        public string Fatigue_load_limits_kN_Cu_Shielded_sealed { get; set; }
        public string Limiting_speeds_Grease_lub_Open_Z_ZZ { get; set; }
        public string Limiting_speeds_Grease_lub_Open_Rs_2RS { get; set; }
        public string Limiting_speeds_Oil_lub_Open_Z { get; set; }
        public string Bearing_No_Open { get; set; }
        public string Bearing_No_Shielded { get; set; }
        public string Bearing_No_Sealed { get; set; }
        public string Load_center_spread_mm_Open_a { get; set; }
        public string Mounting_dimensions_mm_da_min { get; set; }
        public string Mounting_dimensions_mm_da_max { get; set; }
        public string Mounting_dimensions_mm__Da_max { get; set; }
        public string Mounting_dimensions_mm_ra_max { get; set; }
        public string Refer_Mass_kg { get; set; }
    }
}
