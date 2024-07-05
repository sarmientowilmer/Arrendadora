using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoDatos;
using Modelo;

namespace Negocio
{
 public class N_Detalle_informe_contabilidad
 {
     M_Detalle_informe_contabilidad C_Detalle_informe_contabilidad = new M_Detalle_informe_contabilidad();
     ClsDatos Data = new ClsDatos();
     public bool Existe(int Cod_informe, int Linea, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM detalle_informe_contabilidad WHERE Cod_informe= " + Cod_informe + " and Linea=" + Linea);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Detalle_informe_contabilidad.Cod_informe= Convert.ToInt32(DT.Rows[0]["Cod_informe"]);
                 C_Detalle_informe_contabilidad.Linea= Convert.ToInt32(DT.Rows[0]["Linea"]);
                 C_Detalle_informe_contabilidad.Descripcion= DT.Rows[0]["Descripcion"].ToString();
                 C_Detalle_informe_contabilidad.Cuenta= DT.Rows[0]["Cuenta"].ToString();
                 C_Detalle_informe_contabilidad.Desglose= Convert.ToBoolean(DT.Rows[0]["Desglose"]);
                 C_Detalle_informe_contabilidad.Valor= DT.Rows[0]["Valor"].ToString();
                 C_Detalle_informe_contabilidad.Visible= Convert.ToBoolean(DT.Rows[0]["Visible"]);
                 C_Detalle_informe_contabilidad.Valor_linea= Convert.ToDouble(DT.Rows[0]["Valor_linea"]);
                 C_Detalle_informe_contabilidad.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Detalle_informe_contabilidad Consultar(int Cod_informe, int Linea)
     {
         if (Existe(Cod_informe, Linea, true))
         {
             return C_Detalle_informe_contabilidad;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM detalle_informe_contabilidad");
     }
     public long Insertar(M_Detalle_informe_contabilidad Detalle_informe_contabilidad)
     {
         return Data.Accion("INSERT INTO detalle_informe_contabilidad (Cod_informe,Linea,Descripcion,Cuenta,Desglose,Valor,Visible,Valor_linea,Cod_empresa) VALUES (" + Detalle_informe_contabilidad.Cod_informe + "," + Detalle_informe_contabilidad.Linea + ", '" + Detalle_informe_contabilidad.Descripcion + "'" + ", '" + Detalle_informe_contabilidad.Cuenta + "'" + "," + Detalle_informe_contabilidad.Desglose + ", '" + Detalle_informe_contabilidad.Valor + "'" + "," + Detalle_informe_contabilidad.Visible + "," + Detalle_informe_contabilidad.Valor_linea + "," + Detalle_informe_contabilidad.Cod_empresa + ");");
      }
     public long Actualizar(M_Detalle_informe_contabilidad Detalle_informe_contabilidad)
     {
         return Data.Accion("UPDATE detalle_informe_contabilidad SET Cod_informe=" + Detalle_informe_contabilidad.Cod_informe + ",Linea=" + Detalle_informe_contabilidad.Linea + ",Descripcion='"+Detalle_informe_contabilidad.Descripcion + "'" + ",Cuenta='"+Detalle_informe_contabilidad.Cuenta + "'" + ",Desglose=" + Detalle_informe_contabilidad.Desglose + ",Valor='"+Detalle_informe_contabilidad.Valor + "'" + ",Visible=" + Detalle_informe_contabilidad.Visible + ",Valor_linea=" + Detalle_informe_contabilidad.Valor_linea + ",Cod_empresa=" + Detalle_informe_contabilidad.Cod_empresa + " WHERE Cod_informe= " + Detalle_informe_contabilidad.Cod_informe + " and Linea=" + Detalle_informe_contabilidad.Linea + ";");
      }
     public long Nuevo(M_Detalle_informe_contabilidad Detalle_informe_contabilidad)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_informe", Detalle_informe_contabilidad.Cod_informe},
           {"Linea", Detalle_informe_contabilidad.Linea},
           {"Descripcion", Detalle_informe_contabilidad.Descripcion},
           {"Cuenta", Detalle_informe_contabilidad.Cuenta},
           {"Desglose", Detalle_informe_contabilidad.Desglose},
           {"Valor", Detalle_informe_contabilidad.Valor},
           {"Visible", Detalle_informe_contabilidad.Visible},
           {"Valor_linea", Detalle_informe_contabilidad.Valor_linea},
           {"Cod_empresa", Detalle_informe_contabilidad.Cod_empresa}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_detalle_informe_contabilidad(?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
