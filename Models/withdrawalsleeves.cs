using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class withdrawalsleeves
    { 
        public string Boundary_dimensions_mm_d1 { get; set; }
        public string Boundary_dimensions_mm__B1 { get; set; }
        public string Boundary_dimensions_mm__B2 { get; set; }
        public string Boundary_dimensions_mm_G_1_Screw_size { get; set; }
        public string Boundary_dimensions_mm_G1 { get; set; }
        public string Brg_bore_d_mm { get; set; }
        public string Designations_Bearing_withdrawal_sleeve { get; set; }
        public string Mass_Brg_withdrawal_sleeve_kg { get; set; }
        public string Refer_Applicable_locknut_No { get; set; }
    }
}
