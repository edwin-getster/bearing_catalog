using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class heavydutyneedleinnerrings
    {
        public string Boundary_dimensions_mm_Shaft_dia { get; set; }
        public string Boundary_dimensions_mm_d { get; set; }
        public string Boundary_dimensions_mm__F{ get; set; }
        public string Boundary_dimensions_mm__B { get; set; }
        public string Boundary_dimensions_mm_r_min { get; set; }
        public string Inner_ring_No { get; set; }
        public string Refer_Mass_kg { get; set; }
        public string shaftdia_loose_transition_fit_max { get; set; }
        public string shaftdia_loose_transition_fit_min { get; set; }
        public string shaftdia_interference_fit_max { get; set; }
        public string shaftdia_interference_fit_min { get; set; }
        public string Used_with_bearing_No { get; set; }
    }
}
