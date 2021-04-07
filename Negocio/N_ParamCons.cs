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
 public class N_ParamCons
 {
     M_ParamCons C_ParamCons = new M_ParamCons();
     ClsDatos Data = new ClsDatos();
     public bool Existe( bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM ParamCons ");
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_ParamCons.Campo1= DT.Rows[0]["Campo1"].ToString();
                 C_ParamCons.Campo2= DT.Rows[0]["Campo2"].ToString();
                 C_ParamCons.Campo3= DT.Rows[0]["Campo3"].ToString();
                 C_ParamCons.Campo4= DT.Rows[0]["Campo4"].ToString();
                 C_ParamCons.Campo5= DT.Rows[0]["Campo5"].ToString();
                 C_ParamCons.Campo6= DT.Rows[0]["Campo6"].ToString();
                 C_ParamCons.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                 C_ParamCons.Id_us= Convert.ToInt32(DT.Rows[0]["Id_us"]);
             }
         }
         return ExisteRegistro;
     }
     //public M_ParamCons Consultar()
     //{
     //    if (Existe(Tipo_comp, true))
     //    {
     //        return C_ParamCons;
     //    }
     //    else
     //    {
     //        return null;
     //    }
     //}
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM ParamCons");
     }
     public long Insertar(M_ParamCons ParamCons)
     {
         return Data.Accion("INSERT INTO ParamCons (Campo1,Campo2,Campo3,Campo4,Campo5,Campo6,Cod_empresa,Id_us) VALUES (" + "'" + ParamCons.Campo1+"'" + ", '" + ParamCons.Campo2 + "'" + ", '" + ParamCons.Campo3 + "'" + ", '" + ParamCons.Campo4 + "'" + ", '" + ParamCons.Campo5 + "'" + ", '" + ParamCons.Campo6 + "'" + "," + ParamCons.Cod_empresa + "," + ParamCons.Id_us + ");");
      }
     public long Actualizar(M_ParamCons ParamCons)
     {
         return Data.Accion("UPDATE ParamCons SET Campo1='" + ParamCons.Campo1 + "'" + ",Campo2='"+ParamCons.Campo2 + "'" + ",Campo3='"+ParamCons.Campo3 + "'" + ",Campo4='"+ParamCons.Campo4 + "'" + ",Campo5='"+ParamCons.Campo5 + "'" + ",Campo6='"+ParamCons.Campo6 + "'" + ",Cod_empresa=" + ParamCons.Cod_empresa + ",Id_us=" + ParamCons.Id_us +  ";");
      }
     public long Nuevo(M_ParamCons ParamCons)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Campo1", ParamCons.Campo1},
           {"Campo2", ParamCons.Campo2},
           {"Campo3", ParamCons.Campo3},
           {"Campo4", ParamCons.Campo4},
           {"Campo5", ParamCons.Campo5},
           {"Campo6", ParamCons.Campo6},
           {"Cod_empresa", ParamCons.Cod_empresa},
           {"Id_us", ParamCons.Id_us}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_ParamCons(?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
