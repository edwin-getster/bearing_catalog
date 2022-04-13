using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Models
{
    [Keyless]
    public class adapterassembliesshperical
    {
       public string Boundary_dimensions_mm_d1 { set; get; }
       public string Boundary_dimensions_mm__B1 { set; get; }
       public string Boundary_dimensions_mm_d2 { set; get; }
       public string Boundary_dimensions_mm__B2 { set; get; }
       public string Boundary_dimensions_mm__B3 { set; get; }
       public string Brg_bore_d_mm { set; get; }
       public string Designations_Bearing_adapter_ass_y { set; get; }
       public string Mounting_dimensions_mm_A_min { set; get; }
       public string Mounting_dimensions_mm_K_min { set; get; }

       public string Mounting_dimensions_mm_de_min { set; get; }
       public string Mounting_dimensions_mm_b_min { set; get; }
       public string Mass_Brg_adapter_ass_y_kg { set; get; }
       public string refer_Adapter_sleeve_No { set; get; }
       public string refer_Adapter_Locknut_No { set; get; }
      

    }
}
