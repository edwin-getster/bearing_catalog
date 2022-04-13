using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class extrasmallminiatureballbearings
    {
        public string Boundary_dimensions_mm_d { get; set; }
        public int  Boundary_dimensions_mm__D { get; set; }
        public double Boundary_dimensions_mm__B { get; set; }
        public string Boundary_dimensions_mm__B1 { get; set; }
        public double boundary_dimensions_mm_r_min { get; set; }
        public string boundary_dimensions_mm_r1_min { get; set; }
        public double Basic_load_ratings_kN_Cr { get; set; }
        public double Basic_load_ratings_kN_C0r { get; set; }
        public double Fatigue_load_limit_kN_Cu { get; set; }
        public double Factor_f0 { get; set; }
        public string Limiting_speeds_min_1_Grease_lub_Factor_Oil_lub_Open_ZZ_2RU { get; set; }
        public string Limiting_speeds_min_1_Grease_lub_Factor_Oil_lub_2RD { get; set; }
        public string Limiting_speeds_min_1Grease_lub_Facto_Oil_lub_2RS { get; set; }
        public string Limiting_speeds_min_1_Grease_lub_Factor_Oil_lub_Open_Z { get; set; }
        public string Bearing_No_open { get; set; }
        public string Bearing_No_Shileded { get; set; }
        public string Bearing_No_Non_contact_sealed { get; set; }
        public string Bearing_No_Extremely_light_shielded { get; set; }
        public string Bearing_No_contact_sealed { get; set; }
        public double Mounting_dimensions_mm_d_a_min { get; set; }
        public double Mounting_dimensions_mm_Da_max { get; set; }
        public double Mounting_dimensions_mm_ra_max { get; set; }
        public double Refer_Mass_g { get; set; }
    }
}
