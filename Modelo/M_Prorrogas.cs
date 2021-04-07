using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_Prorrogas
 {
     public int No_contrato { get; set; }
     public int Prorroga { get; set; }
     public DateTime Fecha_inicio { get; set; }
     public DateTime Fecha_vencimiento { get; set; }
     public double Canon { get; set; }
     public double Canonprop { get; set; }
 }
}
