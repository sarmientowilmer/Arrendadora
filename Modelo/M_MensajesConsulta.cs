using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class M_MensajesConsulta
    {
        public int No_mensaje { get; set; }
        public string Mensaje { get; set; }
        //public binary Imagen { get; set; }
        public byte[] Imagen { get; set; }
        public int Cod_empresa { get; set; }
    }
}
