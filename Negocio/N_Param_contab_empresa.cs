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
 public class N_Param_contab_empresa
 {
     M_Param_contab_empresa C_Param_contab_empresa = new M_Param_contab_empresa();
     ClsDatos Data = new ClsDatos();
     public bool Existe( bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM param_contab_empresa ");
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Param_contab_empresa.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                 C_Param_contab_empresa.Utilidad= DT.Rows[0]["Utilidad"].ToString();
                 C_Param_contab_empresa.Perdida= DT.Rows[0]["Perdida"].ToString();
                 C_Param_contab_empresa.Capital= DT.Rows[0]["Capital"].ToString();
                 C_Param_contab_empresa.Imporenta= DT.Rows[0]["Imporenta"].ToString();
                 C_Param_contab_empresa.GyP= DT.Rows[0]["GyP"].ToString();
             }
         }
         return ExisteRegistro;
     }
     //public M_Param_contab_empresa Consultar()
     //{
     //    if (Existe(Tipo_comp, true))
     //    {
     //        return C_Param_contab_empresa;
     //    }
     //    else
     //    {
     //        return null;
     //    }
     //}
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM param_contab_empresa");
     }
     public long Insertar(M_Param_contab_empresa Param_contab_empresa)
     {
         return Data.Accion("INSERT INTO param_contab_empresa (Cod_empresa,Utilidad,Perdida,Capital,Imporenta,GyP) VALUES (" + Param_contab_empresa.Cod_empresa + ", '" + Param_contab_empresa.Utilidad + "'" + ", '" + Param_contab_empresa.Perdida + "'" + ", '" + Param_contab_empresa.Capital + "'" + ", '" + Param_contab_empresa.Imporenta + "'" + ", '" + Param_contab_empresa.GyP + "'" + ");");
      }
     public long Actualizar(M_Param_contab_empresa Param_contab_empresa)
     {
         return Data.Accion("UPDATE param_contab_empresa SET Cod_empresa=" + Param_contab_empresa.Cod_empresa + ",Utilidad='"+Param_contab_empresa.Utilidad + "'" + ",Perdida='"+Param_contab_empresa.Perdida + "'" + ",Capital='"+Param_contab_empresa.Capital + "'" + ",Imporenta='"+Param_contab_empresa.Imporenta + "'" + ",GyP='"+Param_contab_empresa.GyP + "'" +  ";");
      }
     public long Nuevo(M_Param_contab_empresa Param_contab_empresa)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_empresa", Param_contab_empresa.Cod_empresa},
           {"Utilidad", Param_contab_empresa.Utilidad},
           {"Perdida", Param_contab_empresa.Perdida},
           {"Capital", Param_contab_empresa.Capital},
           {"Imporenta", Param_contab_empresa.Imporenta},
           {"GyP", Param_contab_empresa.GyP}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_param_contab_empresa(?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
