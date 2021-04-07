using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_Detalle_informe_contabilidad
 {
     public int Cod_informe { get; set; }
     public int Linea { get; set; }
     public string Descripcion { get; set; }
     public string Cuenta { get; set; }
     public bool Desglose { get; set; }
     public string Valor { get; set; }
     public bool Visible { get; set; }
     public double Valor_linea { get; set; }
     public int Cod_empresa { get; set; }
 }
}
