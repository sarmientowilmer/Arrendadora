using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_OtrosPagos
 {
     public int Cod_inmueble { get; set; }
     public int Item { get; set; }
     public string Tipo_compPa { get; set; }
     public int No_compPa { get; set; }
     public string Descripcion { get; set; }
     public double Valor { get; set; }
     public double No_operacion { get; set; }
 }
}
