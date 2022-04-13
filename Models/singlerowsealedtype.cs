using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class singlerowsealedtype
    {

        public string Boundarydimensions_mm_d { set; get; }

        public int  Boundarydimensions_mm__D { set; get; }
        public int Boundarydimensions_mm__B { set; get; }

        public double Boundarydimensions_mm_r { set; get; }
        public double Basic_load_ratings_kN_Cr { set; get; }
        public double Basic_load_ratings_kN_C0r { set; get; }
        public double Fatigue_load_limit_kN_Cu { set; get; }
        public double Factor_f0 { set; get; }



        public string Limiting_speeds_min_1_Grease_lub_Z_ZZ_RU_2RU { set; get; }
        public string Limiting_speeds_min_1_Grease_lub_RD_2RD { set; get; }
        public string Limiting_speeds_min_1_Grease_lub_RS_2RS { set; get; }
        public string Limiting_speeds_min_1_Grease_lub_Oil_lub_Z { set; get; }
        public string Bearing_No_Shielded { set; get; }
        public string Bearing_No_Non_contact_sealed { set; get; }
        public string Bearing_No_Extremely_light_sealed { set; get; }
        public string Bearing_No_Contact_sealed { set; get; }

        public int Mounting_dimensions_mm_da_min { set; get; }

        public string Mounting_dimensions_mm__da_max { set; get; }
        public string Mounting_dimensions_mm_Da_max { set; get; }
        public double Mounting_dimensions_mm_ra_max { set; get; }
        public double Refer_Mass_Open_type_kg { set; get; }
    }
}
