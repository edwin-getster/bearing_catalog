using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class tdotype
    {

          public string Boundary_dimensions_mm_d { set; get; }
          public string Boundary_dimensions_mm__D { set; get; }
          public string Boundary_dimensions_mm__T { set; get; }
          public string Boundary_dimensions_mm__C { set; get; }
          public string Boundary_dimensions_mm_r_min { set; get; }
          public string Boundary_dimensions_mm_r1_min { set; get; }
          public string Basic_load_ratings_kN_Cr { set; get; }
          public string Basic_load_ratings_kN_C0r { set; get; }
          public string Fatigue_load_limits_kN_Cu { set; get; }
          public string Limiting_speeds_min_1_Grease_lub { set; get; }
          public string Limiting_speeds_min_1_Oil_lub { set; get; }
          public string Bearing_No { set; get; }
          public string Mounting_dimensions_mm_da_min { set; get; }
          public string Mounting_dimensions_mm__Da_min { set; get; }
          public string Mounting_dimensions_mm_sa_min { set; get; }
          public string Mounting_dimensions_mm_ra_max { set; get; }
          public string Mounting_dimensions_mm_rb_max { set; get; }
          public string Con_stant_e { set; get; }
          public string Axial_load_factors_Y2 { set; get; }
          public string axial_load_factors_Y3 { set; get; }
          public string Axial_load_factors_Y0 { set; get; }
          public string Refer_Mass_kg { set; get; }
    }
}
