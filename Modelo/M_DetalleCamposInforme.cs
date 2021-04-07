using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_DetalleCamposInforme
 {
     public int Cod_informe { get; set; }
     public int Linea { get; set; }
     public int Campo { get; set; }
     public string Operador { get; set; }
     public string Operando { get; set; }
     public double TotalCampo { get; set; }
     public int Cod_empresa { get; set; }
 }
}
