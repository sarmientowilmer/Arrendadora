using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_Procesos_facturacion
 {
     public DateTime Fecha_proceso { get; set; }
     public int No_proceso { get; set; }
     public string Tipo_id_desde { get; set; }
     public int Id_desde { get; set; }
     public string Dv_desde { get; set; }
     public string Tipo_id_hasta { get; set; }
     public int Id_hasta { get; set; }
     public string Dv_hasta { get; set; }
     public int Dia_venc_desde { get; set; }
     public int Dia_venc_hasta { get; set; }
     public int No_factura_inicial { get; set; }
     public double No_operacion { get; set; }
     public int Cod_empresa { get; set; }
     public int No_factura_final { get; set; }
     public double Portesycorreo { get; set; }
 }
}
