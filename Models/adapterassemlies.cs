using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class adapterassemlies
    {

        public string Boundary_dimensions_mm_d1 { set; get; }
        public string Boundary_dimensions_mm__B1 { set; get; }
        public string Boundary_dimensions_mm_d2 { set; get; }
        public string Boundary_dimensions_mm__B2 { set; get; }
        public string Brg_bore_d_mm { set; get; }
        public string Designations_Bearing_adapter_ass_y { set; get; }
        public string mounting_dimensions_mm_A_min { set; get; }
        public string mounting_dimensions_mm_K_min { set; get; }
        public string mounting_dimensions_mm_de_min { set; get; }
        public string mounting_dimensions_b_min { set; get; }
        public string Mass_Brg_adapter_ass_y_kg { set; get; }
        public string refer_Adapter__sleeve_No { set; get; }
        public string refer_Adapter_Locknut_No { set; get; }




    }
}
