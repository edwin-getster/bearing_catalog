using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class flangedtype
    {
        public string Boundary_dimensions_mm_d { get; set; }
        public int Boundary_dimensions_mm__D { get; set; }
        public double Boundary_dimensions_mm__B { get; set; }
        public string Boundary_dimensions_mm__B1 { get; set; }
        public double Boundary_dimensions_mm_r_min { get; set; }
        public string Boundary_dimensions_mm_r_1min { get; set; }
        public double Basic_load_ratings_kN_Cr { get; set; }
        public string Basic_load_ratings_kN_C0r { get; set; }
        public double Fatigue_load_limit_kN_Cu { get; set; }
        public double Factor_f0 { get; set; }
        public string Limiting_speeds_min_1_Grease_lub_Oil_lub_Open_ZZ_ZZX { get; set; }
        public string Limiting_speeds_min_1_Grease_lub_Oil_lub_Open_Z_ZX { get; set; }
        public string Bearing_No_Open { get; set; }
        public string Column14 { get; set; }
        public string Bearing_No_Shielded { get; set; }
        public string Column16 { get; set; }
        public double Dimensions_of_flange_mm__D1 { get; set; }
        public string Dimensions_of_flange_mm__D2 { get; set; }
        public  double Dimensions_of_flange_mm__C1 { get; set; }
        public  string Dimensions_of_flange_mm_c2 { get; set; }
        public  double Mounting_dimensions_mm_da_min { get; set; }
        public double Mounting_dimensions_mm_ra_max { get; set; }
        public  double Refer_Mass_g { get; set; }
    }   
}
