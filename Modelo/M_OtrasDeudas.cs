using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_OtrasDeudas
 {
     public int Item { get; set; }
     public string Tipo_id { get; set; }
     public int Id { get; set; }
     public string Dv { get; set; }
     public DateTime Fecha { get; set; }
     public int Inmueble { get; set; }
     public string Descripcion { get; set; }
     public double Valor { get; set; }
     public string Tipo_compRe { get; set; }
     public int No_compRe { get; set; }
     public string Tipo_compPa { get; set; }
     public int No_compPa { get; set; }
 }
}
