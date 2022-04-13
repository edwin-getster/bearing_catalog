using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class miniatureonewayclutches
    {
        public string Boundary_dimensions_mm_Shaft_dia { get; set; }
        public string Boundary_dimensions_mm__Fw { get; set; }
        public string Boundary_dimensions_mm__D1 { get; set; }
        public string Boundary_dimensions_mm__D2 { get; set; }
        public string Boundary_dimensions_mm__B { get; set; }
        public string Boundary_dimensions_mm__A { get; set; }
        public string Torque_capacity_N_m { get; set; }
        public string designations_1_WC_series { get; set; }
        public string designations_EWC_series { get; set; }
        public string no_of_outer_ring_protrusion { get; set; }
        public string recommended_housing_dimensions_mm_HD { get; set; }
        public string recommended_housing_dimensions_mm_a { get; set; }
        public string recommended_housing_dimensions_mm_b { get; set; }
        public string recommended_housing_dimensions_mm_r { get; set; }
        public string recommended_housing_dimensions_mm_Da { get; set; }
        public string recommended_housing_dimensions_mm_D2 { get; set; }
        public string refer_Mass_g_1_WC { get; set; }
        public string refer_Mass_g_1_EWC { get; set; }
    }
}
