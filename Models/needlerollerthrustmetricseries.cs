using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class needlerollerthrustmetricseries
    {
        public string Boundary_dimensions_mm_Shaft_dia { get; set; }
        public string Boundary_dimensions_mm__Dc1 { get; set; }
        public string Boundary_dimensions_mm__Dc { get; set; }
        public string Boundary_dimensions_mm__Dw { get; set; }
        public string Boundary_dimensions_mm__Ea { get; set; }
        public string Boundary_dimensions_mm__Eb { get; set; }
        public string Boundary_dimensions_mm__ra_max { get; set; }
        public string Bearing_No { get; set; }
        public string Basic_load_ratings_kN_Ca { get; set; }
        public string Basic_load_ratings_kN_C0a { get; set; }
        public string Fatigue_load_limit_kN_Cu { get; set; }
        public string Limiting_speeds_min_Oil_lub { get; set; }
        public string Refer_Mass_kg { get; set; }
        public string Washer_dimensions_mm_d__D { get; set; }
        public string Washer_dimensions_mm_d_d1 { get; set; }
        public string Washer_dimensions_mm_d__D1 { get; set; }
        public string Thin_h1_mm { get; set; }
        public string Thin_washer_No { get; set; }
        public string Thin_refer_mass_kg { get; set; }
        public string heavy_LS_h11_mm { get; set; }
        public string heavy_LS_a_mm { get; set; }
        public string heavy_LS_washer_No { get; set; }
        public string Heavy_LS_refer_mass_kg { get; set; }
        public string Heavy_h_mm { get; set; }
        public string Heavy_r_min_mm { get; set; }
        public string heavy_Washer_No_Shaft_piloted { get; set; }
        public string heavy_Washer_No_Housing_piloted { get; set; }
        public string heavy_Washer_No_Refer_Mass_kg { get; set; }
    }
}
