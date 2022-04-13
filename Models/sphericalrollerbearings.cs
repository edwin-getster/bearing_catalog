using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class sphericalrollerbearings
    {
        public string Boundary_dimensions_mm_d { set; get; }
        public string Boundary_dimensions_mm__D { set; get; }
        public string Boundary_dimensions_mm__B { set; get; }
        public string Boundary_dimensions_mm_r_min { set; get; }
        public string Basic_load_ratings_kN_Cr { set; get; }
        public string Basic_load_ratings_kN_C0r { set; get; }
        public string Fatigue_load_limits_kN_Cu { set; get; }
        public string Limiting_speeds_min_1_Grease_lub { set; get; }
        public string Limiting_speeds_min_1_Oil_lub { set; get; }
        public string Bearing_No_Cylindrical_bore { set; get; }
        public string Bearing_No_Tapered_bore { set; get; }
        public string mounting_dimensions_mm_da_min  { set; get; }
        public string mounting_dimensions_mm_da_max { set; get; }
        public string mounting_dimensions_mm__Da_max { set; get; }
        public string mounting_dimensions_mm__Da_min { set; get; }
        public string mounting_dimensions_mm_ra_max { set; get; }
        public string Con_stant_e { set; get; }
        public string Axial_load_factors_Y1 { set; get; }
        public string Axial_load_factors_Y2 { set; get; }
        public string Axial_load_factors_Y0 { set; get; }
        public string refer_Mass_kg_Cylindrical_bore { set; get; }
        public string refer_Mass_kg_Tapered_bore { set; get; }
    }
}
