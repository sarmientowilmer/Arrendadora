using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class M_Controlcambios
    {
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public string Valorold { get; set; }
        public string Valornvo { get; set; }
        public int Autorizo { get; set; }
        public int Usuario { get; set; }
        public string Tabla { get; set; }
        public string Campo { get; set; }
        public int Cod_empresa { get; set; }
        public string Motivo { get; set; }
    }
}
