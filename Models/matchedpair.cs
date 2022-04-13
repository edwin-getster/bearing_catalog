using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class matchedpair
    {

        public string Boundary_dimensionsmm_d_min { set; get; }
        public int Boundary_dimensionsmm__D_min { set; get; }
        public int Boundary_dimensionsmm__B1 { set; get; }
        public double boundary_dimensionsmm_r_min { set; get; }
        public double boundary_dimensionsmm_r1_min { set; get; }
        public double basic_load_ratings_kN_Cu_With_machined_Cages_Cr { set; get; }
        public double basic_load_ratings_kN_Cu_With_machined_Cages_C0r { set; get; }

        public string Basic_load_ratings_kN_With_pressed_Cr { set; get; }
        public string Basic_load_ratings_kN_With_pressed_Cor { set; get; }
        public double Fatigue_load_ratings_kN_cu_With_machined_cages { set; get; }


        public string Fatigue_load_ratings_kN_cu_With_pressed_cages { set; get; }
        public string Factoe_f0 { set; get; }
        public string Limiting_speeds_1_min_1_Grease_lub { set; get; }
        public string Limiting_speeds_1_min_1_Oil_lub { set; get; }
        public string Bearing_No_Back_to_back_DB { set; get; }
        public string Bearing_No_Face_to_face_DF { set; get; }
        public string Bearing_No_Tandem_DT { set; get; }



        public double Load_center_spread_mm_a_1 { set; get; }
        public double Load_center_spread_mm_a_2 { set; get; }
        public double Mounting_dimensions_mm_da_min { set; get; }


        public string Mounting_dimensions_mm_db_min { set; get; }


        public double mounting_dimensions_mm__Da_max { set; get; }
        public double mounting_dimensions_mm__Db_max { set; get; }
        public double Mounting_dimensions_mm__ra_max { set; get; }
        public double Mounting_dimensions_mm__rb_max { set; get; }
        public double Refer_Mass_kg { set; get; }
    }
}
