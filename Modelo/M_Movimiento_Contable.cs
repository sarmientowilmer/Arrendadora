using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_Movimiento_Contable
 {
     public int Seccion { get; set; }
     public int Item { get; set; }
     public string Tipo_comp { get; set; }
     public int No_comp { get; set; }
     public string Cuenta { get; set; }
     public string Tipo_aux { get; set; }
     public int Id_aux { get; set; }
     public string Dv { get; set; }
     public string Descripcion { get; set; }
     public double Valor_debito { get; set; }
     public double Valor_credito { get; set; }
     public int Centro_costo { get; set; }
     public int Cod_empresa { get; set; }
 }
}
