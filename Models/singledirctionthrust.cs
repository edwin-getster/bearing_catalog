using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class singledirctionthrust
    {
        public string Boundary_dimensions_mm_d { get; set; }
        public string Boundary_dimensions_mm__D { get; set; }
        public string Boundary_dimensions_mm__T { get; set; }
        public string Boundary_dimensions_mm__T1 { get; set; }
        public string Boundary_dimensions_mm__T2 { get; set; }
        public string Boundary_dimensions_mm_r_min { get; set; }
        public string Basic_load_ratings_kN_Ca { get; set; }
        public string Basic_load_ratings_kN_C0a { get; set; }
        public string Fatique_load_limits_kN_Cu { get; set; }
        public string Limiting_speeds_min_1_Grease_lub { get; set; }
        public string Limiting_speeds_min_1_Oil_lub { get; set; }
        public string Bearing_No_With_flat_back_faces { get; set; }
        public string Bearing_No_With_spherical_back_face { get; set; }
        public string Bearing_No_With_aligning_seat_race { get; set; }
        public string Dimensions_mm_d1_max { get; set; }
        public string dimensions_mm__D1_min { get; set; }
        public string dimensions_mm__D2 { get; set; }
        public string dimensions_mm__D3 { get; set; }
        public string dimensions_mm__A { get; set; }
        public string dimensions_mm__R { get; set; }
        public string dimensions_mm__C { get; set; }
        public string mounting_dimensions_mm_da_min { get; set; }
        public string mounting_dimensions_mm__Da_max { get; set; }
        public string mounting_dimensions_mm_ra_max { get; set; }
        public string Refer_Mass_kg_With_flat_back_faces_seat_race { get; set; }
        public string Refer_Mass_kg_With_spherical_back_faces { get; set; }
        public string Refer_Mass_kg_With_aligning_seat_race { get; set; }

    }
}
