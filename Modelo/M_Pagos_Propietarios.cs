using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_Pagos_Propietarios
 {
     public string Tipo_comp { get; set; }
     public int No_comp { get; set; }
     public string Relacionmes { get; set; }
     public int Item { get; set; }
     public int Id_propietario { get; set; }
     public double Valor_pagado { get; set; }
     public int Usu_cap { get; set; }
     public double Valor_iva { get; set; }
     public int Cod_empresa { get; set; }
     public double No_operacion { get; set; }
     public int No_factura { get; set; }
     public string Tipo_comp_fra { get; set; }
 }
}
