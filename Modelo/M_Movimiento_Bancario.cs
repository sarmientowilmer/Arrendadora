using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_Movimiento_Bancario
 {
     public int Cod_cuenta { get; set; }
     public int Consecutivo { get; set; }
     public DateTime Fecha_girada { get; set; }
     public DateTime Fecha_captura { get; set; }
     public DateTime Fecha_cobro { get; set; }
     public string Tipo_id { get; set; }
     public int No_id { get; set; }
     public string Dv { get; set; }
     public string Beneficiario { get; set; }
     public string No_documento { get; set; }
     public string Descripcion { get; set; }
     public int Cod_trans { get; set; }
     public int Cod_concepto { get; set; }
     public int Centro_costo { get; set; }
     public int Usuario_cap { get; set; }
     public int Seccion { get; set; }
     public double Valor_girado { get; set; }
     public int Forma_grabacion { get; set; }
     public int No_comp { get; set; }
     public string Estado { get; set; }
 }
}
