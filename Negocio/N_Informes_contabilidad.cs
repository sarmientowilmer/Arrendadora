using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoDatos;
using Modelo;

namespace Logica
{
 public class N_Informes_contabilidad
 {
     M_Informes_contabilidad C_Informes_contabilidad = new M_Informes_contabilidad();
     ClsDatos Data = new ClsDatos();
     public bool Existe(int Cod_informe, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM informes_contabilidad WHERE Cod_informe= " + Cod_informe);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Informes_contabilidad.Cod_informe= Convert.ToInt32(DT.Rows[0]["Cod_informe"]);
                 C_Informes_contabilidad.Nombre_informe= DT.Rows[0]["Nombre_informe"].ToString();
                 C_Informes_contabilidad.Fecha_inicio= Convert.ToDateTime(DT.Rows[0]["Fecha_inicio"]);
                 C_Informes_contabilidad.Fecha_fin= Convert.ToDateTime(DT.Rows[0]["Fecha_fin"]);
                 C_Informes_contabilidad.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                 C_Informes_contabilidad.CuentaI= DT.Rows[0]["CuentaI"].ToString();
                 C_Informes_contabilidad.CuentaF= DT.Rows[0]["CuentaF"].ToString();
             }
         }
         return ExisteRegistro;
     }
     public M_Informes_contabilidad Consultar(int Cod_informe)
     {
         if (Existe(Cod_informe, true))
         {
             return C_Informes_contabilidad;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM informes_contabilidad");
     }
     public long Insertar(M_Informes_contabilidad Informes_contabilidad)
     {
         return Data.Accion("INSERT INTO informes_contabilidad (Cod_informe,Nombre_informe,Fecha_inicio,Fecha_fin,Cod_empresa,CuentaI,CuentaF) VALUES (" + Informes_contabilidad.Cod_informe + ", '" + Informes_contabilidad.Nombre_informe + "'" + "," + Informes_contabilidad.Fecha_inicio + "," + Informes_contabilidad.Fecha_fin + "," + Informes_contabilidad.Cod_empresa + ", '" + Informes_contabilidad.CuentaI + "'" + ", '" + Informes_contabilidad.CuentaF + "'" + ");");
      }
     public long Actualizar(M_Informes_contabilidad Informes_contabilidad)
     {
         return Data.Accion("UPDATE informes_contabilidad SET Cod_informe=" + Informes_contabilidad.Cod_informe + ",Nombre_informe='"+Informes_contabilidad.Nombre_informe + "'" + ",Fecha_inicio=" + Informes_contabilidad.Fecha_inicio + ",Fecha_fin=" + Informes_contabilidad.Fecha_fin + ",Cod_empresa=" + Informes_contabilidad.Cod_empresa + ",CuentaI='"+Informes_contabilidad.CuentaI + "'" + ",CuentaF='"+Informes_contabilidad.CuentaF + "'" + " WHERE Cod_informe= " + Informes_contabilidad.Cod_informe + ";");
      }
     public long Nuevo(M_Informes_contabilidad Informes_contabilidad)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_informe", Informes_contabilidad.Cod_informe},
           {"Nombre_informe", Informes_contabilidad.Nombre_informe},
           {"Fecha_inicio", Informes_contabilidad.Fecha_inicio},
           {"Fecha_fin", Informes_contabilidad.Fecha_fin},
           {"Cod_empresa", Informes_contabilidad.Cod_empresa},
           {"CuentaI", Informes_contabilidad.CuentaI},
           {"CuentaF", Informes_contabilidad.CuentaF}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_informes_contabilidad(?, ?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
