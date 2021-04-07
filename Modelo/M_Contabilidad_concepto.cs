using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_Contabilidad_concepto
 {
     public int Cod_concepto { get; set; }
     public int Item { get; set; }
     public string Cuenta { get; set; }
     public string Tipo_aux { get; set; }
     public double Id_auxiliar { get; set; }
     public string Tipo_mov { get; set; }
     public string Valor_aplica { get; set; }
     public int Cod_empresa { get; set; }
 }
}
