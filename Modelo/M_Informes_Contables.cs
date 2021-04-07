using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_Informes_Contables
 {
     public int Cod_informe { get; set; }
     public int Item { get; set; }
     public DateTime Fecha { get; set; }
     public string Cuenta { get; set; }
     public string Nombre_cuenta { get; set; }
     public string Tipo_comp { get; set; }
     public int No_comp { get; set; }
     public string Descrpcion { get; set; }
     public string Tipo_saldo_ant { get; set; }
     public double Saldo_ant { get; set; }
     public double Debito { get; set; }
     public double Credito { get; set; }
     public double Nvo_saldo { get; set; }
     public string Tipo_saldo { get; set; }
     public string Tipo_aux { get; set; }
     public int Id_auxiliar { get; set; }
     public string Dv_auxiliar { get; set; }
     public string Nombre_tercero { get; set; }
     public int Cod_empresa { get; set; }
     public int Seccion { get; set; }
     public int Centro_costo { get; set; }
     public bool Cuenta_nominal { get; set; }
     public int Linea { get; set; }
     public int Clase { get; set; }
     public int Grupo { get; set; }
     public int Cta { get; set; }
     public int Subcuenta { get; set; }
     public int Subsubcuenta { get; set; }
 }
}
