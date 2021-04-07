using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class M_Transacciones_bancarias
    {
        public int Cod_trans { get; set; }
        public string Nombre_trans { get; set; }
        public string Operador_saldo { get; set; }
        public int Cod_empresa { get; set; }
    }
}
