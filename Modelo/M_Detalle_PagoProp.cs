using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_Detalle_PagoProp
 {
     public string Tipo_comp { get; set; }
     public int No_comp { get; set; }
     public int No_contrato { get; set; }
     public string Relacionmes { get; set; }
     public int Item { get; set; }
     public string Periodo { get; set; }
     public double Canon { get; set; }
     public double Tasa_admon { get; set; }
     public double Valor_pagado { get; set; }
     public double Tasa_iva { get; set; }
     public double No_operacion { get; set; }
     public double Condominio { get; set; }
     public double Tasa_comision_admon { get; set; }
 }
}
