using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_Informes_contabilidad
 {
     public int Cod_informe { get; set; }
     public string Nombre_informe { get; set; }
     public DateTime Fecha_inicio { get; set; }
     public DateTime Fecha_fin { get; set; }
     public int Cod_empresa { get; set; }
     public string CuentaI { get; set; }
     public string CuentaF { get; set; }
 }
}
