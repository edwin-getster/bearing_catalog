using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class doublerowdeepgroove
    {
        public string Boundary_dimensions_mm_d { get; set; }
        public int Boundary_dimensions_mm__D { get; set; }
        public int Boundary_dimensions_mm__B { get; set; }
        public double Boundary_dimensions_mm_r_min { get; set; }
        public double Basic_load_ratings_kN_Cr { get; set; }
        public double Basic_load_ratings_kN_C0r { get; set; }
        public double Fatigue_load_ratings_kN_Cu { get; set; }
        public double Factor_f0 { get; set; }
        public string Limiting_speeds_min_1_Grease_lub { get; set; }
        public string Limiting_speeds_min_1_Oil_lub { get; set; }
        public int Bearing_No { get; set; }
        public int Mounting_dimensions_mm_da_min { get; set; }
        public int Mounting_dimensions_mm__Da_max { get; set; }
        public double Mounting_dimensions_mm_ra_max { get; set; }
        public double Refer_Mass_kg { get; set; }
    }
}
