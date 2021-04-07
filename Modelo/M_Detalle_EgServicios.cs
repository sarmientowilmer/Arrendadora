using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_Detalle_EgServicios
 {
     public string Tipo_comp { get; set; }
     public int No_comp { get; set; }
     public int Item { get; set; }
     public string Tipo_id { get; set; }
     public int Id { get; set; }
     public int Servicio { get; set; }
     public string Descripcion { get; set; }
     public double Valor { get; set; }
     public int Recibo { get; set; }
     public bool CanceladoE { get; set; }
     public int Modo { get; set; }
     public bool CanceladoR { get; set; }
     public int ItemGrav { get; set; }
     public double No_operacion { get; set; }
     public string Dv { get; set; }
     public int Cod_inmueble { get; set; }
     public bool Aplicadosaldo { get; set; }
 }
}
