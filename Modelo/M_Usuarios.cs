using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_Usuarios
 {
     public int Id { get; set; }
     public string Apellido1 { get; set; }
     public string Apellido2 { get; set; }
     public string Nombres { get; set; }
     public string Clave { get; set; }
     public string Tipo { get; set; }
     public int Cod_empresa { get; set; }
     public bool Arrendadora { get; set; }
     public bool Contabilidad { get; set; }
     public bool IngArren { get; set; }
     public bool IngContab { get; set; }
     public bool Cons_contab { get; set; }
 }
}
