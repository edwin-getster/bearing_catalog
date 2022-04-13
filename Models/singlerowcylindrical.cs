using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class singlerowcylindrical
    {

        public string Boundary_dimensions_mm_d { set; get; }
        public string Boundary_dimensions_mm__D { set; get; }
        public string Boundary_dimensions_mm__B { set; get; }
        public string boundary_dimensions_mm__r_min { set; get; }
        public string boundary_dimensions_mm__r1_min { set; get; }
        public string Boundary_dimensions_mm__Fw { set; get; }
        public string Boundary_dimensions_mm__Ew { set; get; }
        public string basic_load_ratings_kN_Cr { set; get; }
        public string basic_load_ratings_kN_C0r { set; get; }
        public string Fatigue_load_limit_kN_Cu { set; get; }
        public string Limiting_speeds_min_1_Grease_lub { set; get; }
        public string Limiting_speeds_min_1_oil_lub { set; get; }
        public string Bearing_No_NU { set; get; }
        public string Bearing_No_NJ { set; get; }
        public string Bearing_No_NUP { set; get; }
        public string Bearing_No_N { set; get; }
        public string Bearing_No_NF { set; get; }
        public string mounting_dimensions_mm_da_min { set; get; }
        public string mounting_dimensions_mm_db_min { set; get; }
        public string mounting_dimensions_mm_db_max { set; get; }
        public string mounting_dimensions_mm_dc_min { set; get; }
        public string mounting_dimensions_mm_dd_min { set; get; }
        public string mounting_dimensions_mm__Da_max { set; get; }
        public string mounting_dimensions_mm__Db_max { set; get; }
        public string mounting_dimensions_mm__Db_min { set; get; }
        public string mounting_dimensions_mm_ra_max { set; get; }
        public string mounting_dimensions_mm_rb_max { set; get; }
        public string Refer_Mass_NU_N_kg { set; get; }
    }
}
