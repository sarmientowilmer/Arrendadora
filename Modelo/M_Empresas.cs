using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class M_Empresas
    {
        public byte Cod_empresa { get; set; }
        public string Nombre_empresa { get; set; }
        public string Direccion_empresa { get; set; }
        public string Telefono_empresa { get; set; }
        public string Fax_empresa { get; set; }
        //public binary Logo_empresa { get; set; }
        public byte[] Logo_empresa { get; set; }
        //public binary Fondo_empresa { get; set; }
        public byte[] Fondo_empresa { get; set; }
        public string Encabezado { get; set; }
        public string Observaciones { get; set; }
        public string Pie { get; set; }
        public string Resolucion { get; set; }
        public string Regimen { get; set; }
        public int Periodo_fiscal { get; set; }
        public int Año_periodo_fiscal { get; set; }
        public int Periodo_contable { get; set; }
        public int Clase { get; set; }
        public int Grupo { get; set; }
        public int Cuenta { get; set; }
        public int Subcuenta { get; set; }
        public double Tasamora { get; set; }
        public double Iva { get; set; }
        public double Retencionarren { get; set; }
        public int Diasgracia { get; set; }
        public int Maxcodeudor { get; set; }
        public int Maxdiasven { get; set; }
        public double Montoretension { get; set; }
        public bool BotonNoCobrarIntereses { get; set; }
        public string Periodoapagar { get; set; }
        public DateTime Fecha { get; set; }
        public int Diaini { get; set; }
        public int Diafin { get; set; }
        public DateTime MESCON { get; set; }
        public int INMUEBLE { get; set; }
        public DateTime FechaProc { get; set; }
        public int EstadoFecha { get; set; }
        public double Tasa_iva_admon { get; set; }
        public double Tasa_iva_arren { get; set; }
        public double Tasa_imporenta { get; set; }
        public double PmP { get; set; }
        public string Nombre_RL { get; set; }
        public string Nombre_contador { get; set; }
        public string Tipo_id_RL { get; set; }
        public double No_Id_RL { get; set; }
        public string Exp_Id_RL { get; set; }
        public string Tp_contador { get; set; }
        public string Revisor_fiscal { get; set; }
        public string Tp_revisorfiscal { get; set; }
        public string Mensajeinvinq { get; set; }
        public string Tipo_id { get; set; }
        public double Id_empresa { get; set; }
        public string Dv_empresa { get; set; }
        public bool Contab_causacion { get; set; }
        public int Ciudad { get; set; }
    }
}
