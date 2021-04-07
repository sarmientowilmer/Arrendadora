using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_Contrato_Admon
 {
     public int No_contrato { get; set; }
     public int Cod_inmueble { get; set; }
     public DateTime Fecha_inicio { get; set; }
     public DateTime Fecha_vencimiento { get; set; }
     public double Tasa_admon { get; set; }
     public int Forma_pago { get; set; }
     public string No_cuenta { get; set; }
     public string Clase_cuenta { get; set; }
     public string Entidad { get; set; }
     public DateTime Fecha_pago { get; set; }
     public DateTime Pago_hasta { get; set; }
     public string Estado { get; set; }
     public int Periodo { get; set; }
     public int Prorrogas { get; set; }
     public bool Sujeto_iva { get; set; }
     public int Cod_empresa { get; set; }
 }
}
