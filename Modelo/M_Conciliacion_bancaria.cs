using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_Conciliacion_bancaria
 {
     public int Cod_cuenta { get; set; }
     public int Año_Conc { get; set; }
     public int Mes_conc { get; set; }
     public double Saldo { get; set; }
     public double Saldo_ext { get; set; }
     public int No_conc { get; set; }
     public DateTime Fecha_conc { get; set; }
     public int Cod_empresa { get; set; }
 }
}
