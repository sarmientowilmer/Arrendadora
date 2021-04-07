using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_Cuentas_Bancarias
 {
     public int Cod_cuenta { get; set; }
     public string Tipo_cuenta { get; set; }
     public int Cod_banco { get; set; }
     public string No_Cuenta { get; set; }
     public double Saldo { get; set; }
     public string Cuenta_Contable { get; set; }
     public string Sucursal { get; set; }
     public string Uso { get; set; }
     public int Moneda { get; set; }
     public int Cod_empresa { get; set; }
 }
}
