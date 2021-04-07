using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_Pagos_Inq
 {
     public string Tipo_comp { get; set; }
     public int No_comp { get; set; }
     public int No_contrato { get; set; }
     public double Valor_pagado { get; set; }
     public double Intrs_pagado { get; set; }
     public double Retencion { get; set; }
     public DateTime Pago_hasta { get; set; }
     public double Tasa_mora { get; set; }
     public int Usu_cap { get; set; }
     public double Admon { get; set; }
     public double Tasa_iva { get; set; }
     public int Cod_empresa { get; set; }
     public double No_operacion { get; set; }
     public int No_factura { get; set; }
 }
}
