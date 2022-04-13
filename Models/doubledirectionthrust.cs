using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class doubledirectionthrust
    {
        public int Boundary_dimensions_mm_d2 { get; set; }
        public int Boundary_dimensions_mm__D { get; set; }
        public int Boundary_dimensions_mm__T1 { get; set; }
        public double Boundary_dimensions_mm__T3 { get; set; }
        public int Boundary_dimensions_mm__T5 { get; set; }
        public double Boundary_dimensions_mm_r_min { get; set; }
        public double Boundary_dimensions_mm_r1_min { get; set; }
        public double Basic_load_ratings_kN_Ca { get; set; }
        public double Basic_load_ratings_kN_C0a { get; set; }
        public double Fatique_load_limits_kN_Cu { get; set; }
        public string Limiting_speeds_min_Grease_lub { get; set; }
        public string Limiting_speeds_min_Oil_lub { get; set; }
        public int With_flat_back_faces { get; set; }
        public int Bearing_No_With_spherical_back_faces { get; set; }
        public string Bearing_No_With_aligning_seat_races { get; set; }
        public double Column16 { get; set; }
        public int dimensions_mm_d3_max { get; set; }
        public int dimensions_mm__D1_min { get; set; }
        public int dimensions_mm__D2 { get; set; }
        public int dimensions_mm__D3 { get; set; }
        public double dimensions_mm__T2 { get; set; }
        public double dimensions_mm__T4 { get; set; }
        public double dimensions_mm__T6 { get; set; }
        public double dimensions_mm__A { get; set; }
        public int dimensions_mm__R { get; set; }
        public int dimensions_mm__B { get; set; }
        public double dimensions_mm__C { get; set; }
        public int mounting_dimensions_mm_da_min { get; set; }
        public int mounting_dimensions_mm__Da_max { get; set; }
        public double Mounting_dimensions_mm_ra_max { get; set; }
        public double mounting_dimensions_mm_rb_max { get; set; }
        public double refer_Mass_kg_With_flat_back_faces { get; set; }
        public double refer_Mass_kg_With_aligning_seat_races { get; set; }
    }
}
