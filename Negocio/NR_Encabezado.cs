using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    class NR_Encabezado
    {
        public int Cod_encabezado { get; set; }
        public string Titulo { get; set; }
        public string Tipo_comp { get; set; }
        public int No_comp { get; set; }
        public int No_contrato { get; set; }
        public DateTime Ultimo_pago { get; set; }
    }
}
