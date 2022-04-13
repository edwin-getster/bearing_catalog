using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class doublerowcylidrical
    {
        public string Boundary_dimensions_mm_d { get; set; }
        public string Boundary_dimensions_mm__D { get; set; }
        public string Boundary_dimensions_mm__B { get; set; }
        public string Boundary_dimensions_mm_r_min { get; set; }
        public string Boundary_dimensions_mm_Fw { get; set; }
        public string Boundary_dimensions_mm_Ew { get; set; }
        public string Basic_load_ratings_kN_Cr { get; set; }
        public string Basic_load_ratings_kN_C0r { get; set; }
        public string Fatigue_load_limit_kN_Cu { get; set; }
        public string Limiting_speeds_min_1_Grease_lub { get; set; }
        public string Limiting_speeds_min_1_oil_lub { get; set; }
        public string Bearing_No_NN_Cylindrical_bore { get; set; }
        public string Bearing_No_NN_Tapered_bore { get; set; }
        public string bearing_No_NNU_Cylindrical_bore { get; set; }
        public string Bearing_No_NNUl_Tapered_bore { get; set; }
        public string Mounting_dimensions_mm_da_min { get; set; }
        public string Mounting_dimensions_mm_da_max { get; set; }
        public string Mounting_dimensions_mm_db_min { get; set; }
        public string Mounting_dimensions_mm__Da_min { get; set; }
        public string Mounting_dimensions_mm__Da_max { get; set; }
        public string Mounting_dimensions_mm_ra_max { get; set; }
        public string Refer_Cylindrical_bore { get; set; }
        public string Mass_kg_Tapered_bore { get; set; }
    }
}
