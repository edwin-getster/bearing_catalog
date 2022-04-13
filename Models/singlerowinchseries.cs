using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class singlerowinchseries
    {
        public string Boundary_dimensions_mm_d { get; set; }
        public string Boundary_dimensions_mm__D { get; set; }
        public string Boundary_dimensions_mm__T { get; set; }
        public string Boundary_dimensions_mm__B { get; set; }
        public string Boundary_dimensions_mm__C { get; set; }
        public string Boundary_dimensions_mm_r_min { get; set; }
        public string Boundary_dimensions_mm__r1_min { get; set; }
        public string Basic_load_ratings_kN_Cr { get; set; }
        public string Basic_load_ratings_kN_C0r { get; set; }
        public string Fatigue_load_limits_kN_Cu { get; set; }
        public string Limiting_speeds_min_1_Grease_lub { get; set; }
        public string Limiting_speeds_min_1_Oil_lub { get; set; }
        public string Bearing_No_Inner_ring { get; set; }
        public string Bearing_No_Outer_ring { get; set; }
        public string Load_center_mm_a { get; set; }
        public string mounting_dimensions_mm_da { get; set; }
        public string mounting_dimensions_mm_db { get; set; }
        public string mounting_dimensions_mm__Da { get; set; }
        public string mounting_dimensions_mm__Db { get; set; }
        public string mounting_dimensions_mm_ra_max { get; set; }
        public string mounting_dimensions_mm_rb_max { get; set; }
        public string Con_stant_e { get; set; }
        public string axial_load_factors_Y1 { get; set; }
        public string axial_load_factors_Y0 { get; set; }
        public string refer_Mass_kg_Inner_ring { get; set; }
        public string refer_Mass_kg_Outer_ring { get; set; }
       
    }
}
