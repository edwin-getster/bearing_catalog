using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class singlerowmetricseries
    {
        public string Boundary_dimensions_mm_d { set; get; }
        public string Boundary_dimensions_mm__D { set; get; }
        public string Boundary_dimensions_mm__T { set; get; }
        public string Boundary_dimensions_mm__B { set; get; }
        public string Boundary_dimensions_mm__C { set; get; }
        public string Boundary_dimensions_mm_r_min { set; get; }
        public string Boundary_dimensions_mm_r1_min { set; get; }
        public string Basic_load_ratings_kN_Cr { set; get; }
        public string Basic_load_ratings_kN_C0r { set; get; }
        public string Fatigue_load_limits_kN_Cu { set; get; }
        public string limiting_speeds_min_1_Grease_lub { set; get; }
        public string limiting_speeds_min_1_Oil_lub { set; get; }
        public string Bearing_No_1 { set; get; }
        public string Dimension_series_to_ISO355_Refer { set; get; }
        public string Load_center_mm_a { set; get; }
        public string Mounting_dimensions_mm_da_min { set; get; }
        public string Mounting_dimensions_mm_db_max { set; get; }
        public string Mounting_dimensions_mm__Da_max { set; get; }
        public string mounting_dimensions_mm__Da_min { set; get; }
        public string Mounting_dimensions_mm__Db_min { set; get; }
        public string Mounting_dimensions_mm_Sa_min { set; get; }
        public string Mounting_dimensions_mm_Sb_min { set; get; }
        public string Mounting_dimensions_mm_ra_max { set; get; }
        public string Mounting_dimensions_mm_rb_min { set; get; }
        public string Con_stant_e { set; get; }
        public string axial_load_factors_Y1 { set; get; }
        public string axial_load_factors_Y0 { set; get; }
        public string Refer_Mass_kg { set; get; }
    
    }
}
