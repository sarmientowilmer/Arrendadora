using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_Detalle_conciliacion
 {
     public int No_conc { get; set; }
     public string Descripcion { get; set; }
     public int Item { get; set; }
     public string Op_saldo { get; set; }
     public double Valor_trans { get; set; }
     public int Cod_empresa { get; set; }
 }
}
