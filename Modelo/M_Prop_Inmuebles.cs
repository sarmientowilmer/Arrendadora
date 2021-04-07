using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class M_Prop_Inmuebles
    {
        public int Cod_inmueble { get; set; }
        public string Tipo_id { get; set; }
        public int Id_propietario { get; set; }
        public string Dv { get; set; }
        public string Estado_propietario { get; set; }
        public DateTime Fecha_hasta { get; set; }
    }
}
