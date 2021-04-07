using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class M_Saldo_Caja
    {
        public int Año { get; set; }
        public int Mes { get; set; }
        public string Cuenta { get; set; }
        public string Tipo_aux { get; set; }
        public double Id_auxiliar { get; set; }
        public string Dv { get; set; }
        public double Saldo { get; set; }
        public int Cod_empresa { get; set; }
    }
}
