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
 public class N_ModosEG
 {
     M_ModosEG C_ModosEG = new M_ModosEG();
     ClsDatos Data = new ClsDatos();
     public bool Existe(int Modo, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM ModosEG WHERE Modo= " + Modo);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_ModosEG.Modo= Convert.ToInt32(DT.Rows[0]["Modo"]);
                 C_ModosEG.Descripcion= DT.Rows[0]["Descripcion"].ToString();
                 C_ModosEG.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
             }
         }
         return ExisteRegistro;
     }
     public M_ModosEG Consultar(int Modo)
     {
         if (Existe(Modo, true))
         {
             return C_ModosEG;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM ModosEG");
     }
     public long Insertar(M_ModosEG ModosEG)
     {
         return Data.Accion("INSERT INTO ModosEG (Modo,Descripcion,Cod_empresa) VALUES (" + ModosEG.Modo + ", '" + ModosEG.Descripcion + "'" + "," + ModosEG.Cod_empresa + ");");
      }
     public long Actualizar(M_ModosEG ModosEG)
     {
         return Data.Accion("UPDATE ModosEG SET Modo=" + ModosEG.Modo + ",Descripcion='"+ModosEG.Descripcion + "'" + ",Cod_empresa=" + ModosEG.Cod_empresa + " WHERE Modo= " + ModosEG.Modo + ";");
      }
     public long Nuevo(M_ModosEG ModosEG)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Modo", ModosEG.Modo},
           {"Descripcion", ModosEG.Descripcion},
           {"Cod_empresa", ModosEG.Cod_empresa}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_ModosEG(?, ?, ?)}", Parametros);
      }
 }
}
