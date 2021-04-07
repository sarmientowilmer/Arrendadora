using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_Descuentos_Prop
 {
     public int No_contrato { get; set; }
     public int Item { get; set; }
     public string Tipo_compRe { get; set; }
     public int No_compRe { get; set; }
     public string Tipo_compPa { get; set; }
     public int No_compPa { get; set; }
     public int Cod_descuento { get; set; }
     public string Descripcion { get; set; }
     public double Valor { get; set; }
     public double Vr_desProp { get; set; }
     public int Usu_cap { get; set; }
     public DateTime FECHA { get; set; }
     public double No_operacion { get; set; }
     public double No_operacionpa { get; set; }
     public int Cod_inmueble { get; set; }
 }
}
