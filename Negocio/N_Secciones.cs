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
 public class N_Secciones
 {
     M_Secciones C_Secciones = new M_Secciones();
     ClsDatos Data = new ClsDatos();
     public bool Existe(int Seccion, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Secciones WHERE Seccion= " + Seccion);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Secciones.Seccion= Convert.ToInt32(DT.Rows[0]["Seccion"]);
                 C_Secciones.Nombre_seccion= DT.Rows[0]["Nombre_seccion"].ToString();
                 C_Secciones.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Secciones Consultar(int Seccion)
     {
         if (Existe(Seccion, true))
         {
             return C_Secciones;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Secciones");
     }
     public long Insertar(M_Secciones Secciones)
     {
         return Data.Accion("INSERT INTO Secciones (Seccion,Nombre_seccion,Cod_empresa) VALUES (" + Secciones.Seccion + ", '" + Secciones.Nombre_seccion + "'" + "," + Secciones.Cod_empresa + ");");
      }
     public long Actualizar(M_Secciones Secciones)
     {
         return Data.Accion("UPDATE Secciones SET Seccion=" + Secciones.Seccion + ",Nombre_seccion='"+Secciones.Nombre_seccion + "'" + ",Cod_empresa=" + Secciones.Cod_empresa + " WHERE Seccion= " + Secciones.Seccion + ";");
      }
     public long Nuevo(M_Secciones Secciones)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Seccion", Secciones.Seccion},
           {"Nombre_seccion", Secciones.Nombre_seccion},
           {"Cod_empresa", Secciones.Cod_empresa}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Secciones(?, ?, ?)}", Parametros);
      }
 }
}
