using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_Detalle_PagoInq
 {
     public string Tipo_comp { get; set; }
     public int No_comp { get; set; }
     public int Codigo { get; set; }
     public int No_contrato { get; set; }
     public string Mes { get; set; }
     public string Periodo { get; set; }
     public DateTime Fechapago { get; set; }
     public double Canon { get; set; }
     public double Diasven { get; set; }
     public double Intereses { get; set; }
     public int Item { get; set; }
     public double Tasa_iva { get; set; }
     public double No_operacion { get; set; }
     public int No_factura { get; set; }
 }
}
