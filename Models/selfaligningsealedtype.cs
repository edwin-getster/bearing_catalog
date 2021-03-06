using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class selfaligningsealedtype
    {
        public string Boundary_dimensions_mm_d { get; set; }
        public string Boundary_dimensions_mm__D { get; set; }
        public string Boundary_dimensions_mm__B { get; set; }
        public string Boundary_dimensions_mm_r_min { get; set; }
        public string Basic_load_ratings_kN_Cr { get; set; }
        public string Basic_load_ratings_kN_C0r { get; set; }
        public string Fatigue_load_limits_kN_Cu { get; set; }
        public string Limiting_speed_min_1_Grease_lub { get; set; }
        public string Bearing_No { get; set; }
        public string Mounting_dimensions_mm_da_min { get; set; }
        public string mounting_dimensions_mm_da_max { get; set; }
        public string Mounting_dimensions_mm__Da_max { get; set; }
        public string Mounting_dimensions_mm_ra_max { get; set; }
        public string Con_stant_e { get; set; }
        public string axial_load_factors_Y1 { get; set; }
        public string axial_load_factors_Y2 { get; set; }
        public string axial_load_factors_Y0 { get; set; }
        public string Refer_Mass_kg { get; set; }
    }
}
