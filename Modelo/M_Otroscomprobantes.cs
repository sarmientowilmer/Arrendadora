using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class M_Otroscomprobantes
    {
        public DateTime Fecha { get; set; }
        public string Tipo_comp { get; set; }
        public int No_comp { get; set; }
        public string Tipo_id { get; set; }
        public int Id { get; set; }
        public string Dv { get; set; }
        public string Descripcion { get; set; }
        public double Valor { get; set; }
        public int Forma_pago { get; set; }
        public int Cod_cuenta { get; set; }
        public string Clase_cuenta { get; set; }
        public string Num { get; set; }
        public string Entidad { get; set; }
        public string Estado { get; set; }
        public DateTime FechaAplic { get; set; }
        public int Usu_cap { get; set; }
        public DateTime Fecha_vence { get; set; }
        public int Cod_empresa { get; set; }
        public double No_operacion { get; set; }
        public int Cod_concepto { get; set; }
        public double Valor_base { get; set; }
        public int Usu_aprueba { get; set; }
        public int Estado_contab { get; set; }
        public int Centro_costo { get; set; }
        public int Seccion { get; set; }
    }
}
