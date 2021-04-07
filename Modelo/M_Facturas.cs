using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
 public class M_Facturas
 {
     public string Tipo_comp { get; set; }
     public int No_comp { get; set; }
     public double Saldo_anterior { get; set; }
     public double Recargo_mora { get; set; }
     public double Cargo_mes { get; set; }
     public double Iva_arriendo { get; set; }
     public double Retension { get; set; }
     public double Administracion { get; set; }
     public double Portesycorreo { get; set; }
     public string Otros_descripcion { get; set; }
     public double Otros_valor { get; set; }
     public DateTime Pago_desde { get; set; }
     public int Dias { get; set; }
     public DateTime Fecha_vencimiento { get; set; }
     public string Notas { get; set; }
     public byte Estado_factura { get; set; }
     public double No_operacion { get; set; }
     public int Cod_empresa { get; set; }
     public byte Estado_impresion { get; set; }
     public int No_proceso { get; set; }
     public int No_contrato { get; set; }
     public bool Refacturada { get; set; }
     public int Fra_ant { get; set; }
 }
}
