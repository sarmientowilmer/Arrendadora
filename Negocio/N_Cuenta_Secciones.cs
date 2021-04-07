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
 public class N_Cuenta_Secciones
 {
     M_Cuenta_Secciones C_Cuenta_Secciones = new M_Cuenta_Secciones();
     ClsDatos Data = new ClsDatos();
     public bool Existe(string Cuenta, int Seccion, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Cuenta_Secciones WHERE Cuenta='" + Cuenta + "'" + " and Seccion=" + Seccion);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Cuenta_Secciones.Cuenta= DT.Rows[0]["Cuenta"].ToString();
                 C_Cuenta_Secciones.Seccion= Convert.ToInt32(DT.Rows[0]["Seccion"]);
                 C_Cuenta_Secciones.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Cuenta_Secciones Consultar(string Cuenta, int Seccion)
     {
         if (Existe(Cuenta, Seccion, true))
         {
             return C_Cuenta_Secciones;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Cuenta_Secciones");
     }
     public long Insertar(M_Cuenta_Secciones Cuenta_Secciones)
     {
         return Data.Accion("INSERT INTO Cuenta_Secciones (Cuenta,Seccion,Cod_empresa) VALUES (" + "'" + Cuenta_Secciones.Cuenta+"'" + "," + Cuenta_Secciones.Seccion + "," + Cuenta_Secciones.Cod_empresa + ");");
      }
     public long Actualizar(M_Cuenta_Secciones Cuenta_Secciones)
     {
         return Data.Accion("UPDATE Cuenta_Secciones SET Cuenta='" + Cuenta_Secciones.Cuenta + "'" + ",Seccion=" + Cuenta_Secciones.Seccion + ",Cod_empresa=" + Cuenta_Secciones.Cod_empresa + " WHERE Cuenta='" + Cuenta_Secciones.Cuenta + "'" + " and Seccion=" + Cuenta_Secciones.Seccion + ";");
      }
     public long Nuevo(M_Cuenta_Secciones Cuenta_Secciones)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cuenta", Cuenta_Secciones.Cuenta},
           {"Seccion", Cuenta_Secciones.Seccion},
           {"Cod_empresa", Cuenta_Secciones.Cod_empresa}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Cuenta_Secciones(?, ?, ?)}", Parametros);
      }
 }
}
