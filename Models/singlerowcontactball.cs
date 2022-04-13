using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class singlerowcontactball
    {


        public string Boundary_dimensions_mm_d { set; get; }
        public string Boundary_dimensions_mm__D { set; get; }
        public string Boundary_dimensions_mm__B { set; get; }
        public string Boundary_dimensions_mm_r_min { set; get; }
        public string Boundary_dimensions_mm_r1_min { set; get; }
        public string basic_load_ratings_kN_With_machined_cage_Cr { set; get; }
        public string basic_load_ratings_kN_With_machined_cage_Cor { set; get; }
        public string basic_load_ratings_kN_With_pressed_cage_Cr { set; get; }
        public string basic_load_ratings_kN_With_pressed_cage_C0r { set; get; }
        public string Fatigue_load_limits_kN_Cu_With_machined_cage { set; get; }
        public string Fatigue_load_limits_kN_Cu_With_pressed_cage { set; get; }
        public string Factor_f0 { set; get; }
        public string Limiting_speeds_1_min_1_Grease_lub { set; get; }
        public string Limiting_speeds_1_min_1_Oil_lub { set; get; }
        public string Bearing_No_2 { set; get; }
        public string Load_center_mm_a { set; get; }
        public string Mounting_dimensions_mm_da_min { set; get; }
        public string Mounting_dimensions_mm_Da_max { set; get; }
        public string Mounting_dimensions_mm_ra_max { set; get; }
        public string Refer_Mass_kg { set; get; }
    }
}
