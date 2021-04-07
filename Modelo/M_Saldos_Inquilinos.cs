using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_Saldos_Inquilinos
 {
     public int No_contrato { get; set; }
     public double Canon { get; set; }
     public double Intereses { get; set; }
     public DateTime Ultimopago { get; set; }
 }
}
