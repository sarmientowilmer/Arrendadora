using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class NR_ReporteOtrosComprobantes
    {
        public DateTime Fecha_proceso { get; set; }
        public int Tipo_servicio { get; set; }
        public double Saldo_anterior { get; set; }
        public int Cantidad_ingresos { get; set; }
        public double Total_ingresos { get; set; }
        public int Cantidad_egresos { get; set; }
        public double Total_egresos { get; set; }
        public double Nuevo_saldo { get; set; }

        //public List<NR_ListadoOtrosComprobantes> Detalle = new List<NR_ListadoOtrosComprobantes>();
    }
}
