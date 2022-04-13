using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class singlerowopentype
    {
        public string Boundary_dimensions_mm_d { set; get; }
        public int Boundary_dimensions_mm__D { set; get; }
        public int Boundary_dimensions_mm__B { set; get; }
        public double Boundary_dimensions_mm_min { set; get; }
        public double Basic_load_ratings_kN_Cr { set; get; }
        public double Basic_load_ratings_kN_C0r { set; get; }
        public double Fatigue_load_limit_kN_Cu { set; get; }
        public double Factor_f0 { set; get; }
        public string Limiting_speeds_min_1_Grease_lub { set; get; }
        public string Limiting_speeds_min_1_Oil_lub { set; get; }
        public int Bearing_No { set; get; }
        public double Mounting_dimensions_mm_da_min { set; get; }
        public double Mounting_dimensions_mm_Da_max { set; get; }
        public double Mounting_dimensions_mm_ra_max { set; get; }
        public double Refer_Mass_kg { set; get; }
    }
}
