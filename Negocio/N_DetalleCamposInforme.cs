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
 public class N_DetalleCamposInforme
 {
     M_DetalleCamposInforme C_DetalleCamposInforme = new M_DetalleCamposInforme();
     ClsDatos Data = new ClsDatos();
     public bool Existe(int Cod_informe, int Linea, int Campo, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM DetalleCamposInforme WHERE Cod_informe= " + Cod_informe + " and Linea=" + Linea + " and Campo=" + Campo);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_DetalleCamposInforme.Cod_informe= Convert.ToInt32(DT.Rows[0]["Cod_informe"]);
                 C_DetalleCamposInforme.Linea= Convert.ToInt32(DT.Rows[0]["Linea"]);
                 C_DetalleCamposInforme.Campo= Convert.ToInt32(DT.Rows[0]["Campo"]);
                 C_DetalleCamposInforme.Operador= DT.Rows[0]["Operador"].ToString();
                 C_DetalleCamposInforme.Operando= DT.Rows[0]["Operando"].ToString();
                 C_DetalleCamposInforme.TotalCampo= Convert.ToDouble(DT.Rows[0]["TotalCampo"]);
                 C_DetalleCamposInforme.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
             }
         }
         return ExisteRegistro;
     }
     public M_DetalleCamposInforme Consultar(int Cod_informe, int Linea, int Campo)
     {
         if (Existe(Cod_informe, Linea, Campo, true))
         {
             return C_DetalleCamposInforme;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM DetalleCamposInforme");
     }
     public long Insertar(M_DetalleCamposInforme DetalleCamposInforme)
     {
         return Data.Accion("INSERT INTO DetalleCamposInforme (Cod_informe,Linea,Campo,Operador,Operando,TotalCampo,Cod_empresa) VALUES (" + DetalleCamposInforme.Cod_informe + "," + DetalleCamposInforme.Linea + "," + DetalleCamposInforme.Campo + ", '" + DetalleCamposInforme.Operador + "'" + ", '" + DetalleCamposInforme.Operando + "'" + "," + DetalleCamposInforme.TotalCampo + "," + DetalleCamposInforme.Cod_empresa + ");");
      }
     public long Actualizar(M_DetalleCamposInforme DetalleCamposInforme)
     {
         return Data.Accion("UPDATE DetalleCamposInforme SET Cod_informe=" + DetalleCamposInforme.Cod_informe + ",Linea=" + DetalleCamposInforme.Linea + ",Campo=" + DetalleCamposInforme.Campo + ",Operador='"+DetalleCamposInforme.Operador + "'" + ",Operando='"+DetalleCamposInforme.Operando + "'" + ",TotalCampo=" + DetalleCamposInforme.TotalCampo + ",Cod_empresa=" + DetalleCamposInforme.Cod_empresa + " WHERE Cod_informe= " + DetalleCamposInforme.Cod_informe + " and Linea=" + DetalleCamposInforme.Linea + " and Campo=" + DetalleCamposInforme.Campo + ";");
      }
     public long Nuevo(M_DetalleCamposInforme DetalleCamposInforme)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_informe", DetalleCamposInforme.Cod_informe},
           {"Linea", DetalleCamposInforme.Linea},
           {"Campo", DetalleCamposInforme.Campo},
           {"Operador", DetalleCamposInforme.Operador},
           {"Operando", DetalleCamposInforme.Operando},
           {"TotalCampo", DetalleCamposInforme.TotalCampo},
           {"Cod_empresa", DetalleCamposInforme.Cod_empresa}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_DetalleCamposInforme(?, ?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
