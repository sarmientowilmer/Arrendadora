using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_Conceptos
 {
     public int Cod_concepto { get; set; }
     public string Descripcion_concepto { get; set; }
     public int Cod_empresa { get; set; }
     public string Cuenta { get; set; }
     public bool Auxiliar { get; set; }
     public bool Empresa { get; set; }
     public string Tipo_mov { get; set; }
     public byte Permite { get; set; }
 }
}
