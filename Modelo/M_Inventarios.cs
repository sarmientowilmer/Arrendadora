using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_Inventarios
 {
     public int Cod_inmueble { get; set; }
     public int Usuario { get; set; }
     public DateTime Fecha_prop { get; set; }
     public DateTime Fecha_Inq { get; set; }
     public string Observaciones_prop { get; set; }
     public string Observaciones_inq { get; set; }
     public int Cod_empresa { get; set; }
 }
}
