using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_Descuentos
 {
     public int Cod_descuento { get; set; }
     public string Nombre_desc { get; set; }
     public int Afecta { get; set; }
     public bool Saldo { get; set; }
     public int Cod_empresa { get; set; }
 }
}
