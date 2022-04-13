using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class needlerollerthrustmetricseries2
    {
        public string Boundary_dimensions_mm_Shaft_dia { get; set; }
        public string Boundary_dimensions_mm__Dc1 { get; set; }
        public string Boundary_dimensions_mm__Dc { get; set; }
        public string Boundary_dimensions_mm__sDw { get; set; }
        public string Boundary_dimensions_mm__T { get; set; }
        public string Boundary_dimensions_mm__Eb_min { get; set; }
        public string Boundary_dimensions_mm__Ea_min { get; set; }
        public string Boundary_dimensions_mm__ra_max { get; set; }
        public string Bearing_No { get; set; }
        public string Basic_load_ratings_kN_Ca { get; set; }
        public string Basic_load_ratings_kN_C0a { get; set; }
        public string Fatiuge_load_limits_kN_Cu { get; set; }
        public string Limiting_speeds_min_Oil_lub { get; set; }
        public string Refer_Mass_kg { get; set; }
        public string Washer_dimensions_mm_d { get; set; }
        public string Washer_dimensions_mm__D1 { get; set; }
        public string Washer_dimensions_mm__D_d1 { get; set; }
        public string washer_dimensions_mm_h_max { get; set; }
        public string washer_dimensions_mm_h_min { get; set; }
        public string Washer_dimensions_mm_r_min { get; set; }
        public string Washer_No_Shaft_piloted { get; set; }
        public string Washer_No_Housing_piloted { get; set; }
        public string Refer_mass__kg { get; set; }
    }
}
