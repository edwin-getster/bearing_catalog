using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class singlerowsnapringgroovetype
    {

        public int Boundary_dimensions_mm_d { set; get; }
        public int Boundary_dimensions_mm__D { set; get; }
        public int Boundary_dimensions_mm__B { set; get; }
        public double Boundary_dimensions_mm_r1 { set; get; }
        public double Boundary_dimensions_mm_r1_min { set; get; }
        public double Basic_load_ratings_kN_Cr { set; get; }
        public double Basic_load_ratings_kN_C0r { set; get; }
        public double Fatigue_load_ratings_kN_Cu { set; get; }
        public double Factor_f0 { set; get; }
        public string limiting_speeds_min_1_Grease_lub { set; get; }
        public string limiting_speeds_min_1_Oil_lub { set; get; }
        public string Bearing_No_With_snap_ring_groove { set; get; }
        public string Bearing_No_With_locating_snap_ring { set; get; }
        public double Dimensions_of_snap_ring_groove_mm__D1_max { set; get; }
        public double Dimensions_of_snap_ring_groove_mm_a_max { set; get; }
        public string Dimensions_of_snap_ring_groove_mm_b_0_15 { set; get; }
        public double Dimensions_of_snap_ring_groove_mm_r_max { set; get; }
        public double Dimensions_of_locating_snap_ring_mm__D2 { set; get; }
        public double Dimensions_of_locating_snap_ring_mm_f_0_05 { set; get; }
        public int Mounting_dimensions_mm_da_min { set; get; }
        public int Mounting_dimensions_mm__Da_max { set; get; }
        public double Mounting_dimensions_mm_DX_min { set; get; }
        public double Mounting_dimensions_mm_CY_max { set; get; }
        public double mounting_dimension_mm_ra_max { set; get; }
        public double mounting_dimension_mm_rb_max { set; get; }
        public double Refer_Mass_kg { set; get; }
        public string Refer_Bearing_No { set; get; }
    }
}

