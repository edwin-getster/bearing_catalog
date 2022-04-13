using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class needlerollerthrustinchseries
    {
        public string Boundary_dimensions_mm_Shaft_dia_in { get; set; }
        public string Boundary_dimensions_mm__Dc1 { get; set; }
        public string Boundary_dimensions_mm__Dc { get; set; }
        public string Boundary_dimensions_mm__Dw { get; set; }
        public string Boundary_dimensions_mm__Eb { get; set; }
        public string Boundary_dimensions_mm__Ea { get; set; }
        public string Bearing_No { get; set; }
        public string Basic_load_ratings_kN_Ca { get; set; }
        public string Basic_load_ratings_kN_C0a { get; set; }
        public string Fatique_load_limits_kN_Cu { get; set; }
        public string Limiting_speed_1_min_1     { get; set; }
        public string Refer_Mass_kg { get; set; }
        public string Washer_No { get; set; }
        public string Washer_dimensions_mm_d { get; set; }
        public string Washer_dimensions_mm_d1 { get; set; }
        public string Washer_dimensions_mm_h_max { get; set; }
        public string Washer_dimensions_mm_h_min { get; set; }
        public string Piloting_dimensions_mm_S_max { get; set; }
        public string Piloting_dimensions_mm_S_min { get; set; }
        public string Dia_to_clear_O_D_mm_H_2 { get; set; }
        public string Refer_Washer_mass_kg { get; set; }
        
    }
}
