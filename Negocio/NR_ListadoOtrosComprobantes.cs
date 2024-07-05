using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NR_ListadoOtrosComprobantes
    {
        public DateTime Fecha { get; set; }
        public string Tipo_comp { get; set; }
        public string Nombre_comp { get; set; }
        public int No_comp { get; set; }
        public string Tipo_id { get; set; }
        public int Id { get; set; }
        public string Dv { get; set; }
        public string Nombre_tercero { get; set; }
        public string Descripcion { get; set; }
        public double Valor { get; set; }
        public string Estado { get; set; }
        public int Usu_cap { get; set; }
        public string Descripcion_Estado { get; set; }
        public string Nombre_forma { get; set; }
    }
}
