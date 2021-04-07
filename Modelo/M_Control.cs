using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_Control
 {
     public int Cod_empresa { get; set; }
     public string Empresa { get; set; }
     public string Direccion { get; set; }
     public string Observaciones { get; set; }
     public string Imagenlogo { get; set; }
     public string Icono1 { get; set; }
     public string Icono2 { get; set; }
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
     public int Periodo_contable_ant { get; set; }
     public int Periodo_fiscal_ant { get; set; }
     public int Periodo_fiscal { get; set; }
     public int Periodo_contable { get; set; }
     public string Cuenta_reporte { get; set; }
     public double No_op { get; set; }
     public byte Tipo_liq_intrs { get; set; }
     public byte Maxdiasprejuridico { get; set; }
     public double Tasa_prejuridico { get; set; }
     public double Tasa_comision_admon { get; set; }
 }
}
