using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_Cuentas
 {
     public string Cuenta { get; set; }
     public string Nombre_cuenta { get; set; }
     public bool Saldo_negativo { get; set; }
     public bool Cuenta_nominal { get; set; }
     public string Tipo_saldo { get; set; }
     public bool Desglose { get; set; }
     public bool Auxiliar { get; set; }
     public int Cod_empresa { get; set; }
     public int Usu_cap { get; set; }
     public DateTime Fecha_creacion { get; set; }
 }
}
