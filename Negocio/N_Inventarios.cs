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
 public class N_Inventarios
 {
     M_Inventarios C_Inventarios = new M_Inventarios();
     ClsDatos Data = new ClsDatos();
     public bool Existe(int Cod_inmueble, int Usuario, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Inventarios WHERE Cod_inmueble= " + Cod_inmueble + " and Usuario=" + Usuario);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Inventarios.Cod_inmueble= Convert.ToInt32(DT.Rows[0]["Cod_inmueble"]);
                 C_Inventarios.Usuario= Convert.ToInt32(DT.Rows[0]["Usuario"]);
                 C_Inventarios.Fecha_prop= Convert.ToDateTime(DT.Rows[0]["Fecha_prop"]);
                 C_Inventarios.Fecha_Inq= Convert.ToDateTime(DT.Rows[0]["Fecha_Inq"]);
                 C_Inventarios.Observaciones_prop= DT.Rows[0]["Observaciones_prop"].ToString();
                 C_Inventarios.Observaciones_inq= DT.Rows[0]["Observaciones_inq"].ToString();
                 C_Inventarios.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Inventarios Consultar(int Cod_inmueble, int Usuario)
     {
         if (Existe(Cod_inmueble, Usuario, true))
         {
             return C_Inventarios;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Inventarios");
     }
     public long Insertar(M_Inventarios Inventarios)
     {
         return Data.Accion("INSERT INTO Inventarios (Cod_inmueble,Usuario,Fecha_prop,Fecha_Inq,Observaciones_prop,Observaciones_inq,Cod_empresa) VALUES (" + Inventarios.Cod_inmueble + "," + Inventarios.Usuario + "," + Inventarios.Fecha_prop + "," + Inventarios.Fecha_Inq + ", '" + Inventarios.Observaciones_prop + "'" + ", '" + Inventarios.Observaciones_inq + "'" + "," + Inventarios.Cod_empresa + ");");
      }
     public long Actualizar(M_Inventarios Inventarios)
     {
         return Data.Accion("UPDATE Inventarios SET Cod_inmueble=" + Inventarios.Cod_inmueble + ",Usuario=" + Inventarios.Usuario + ",Fecha_prop=" + Inventarios.Fecha_prop + ",Fecha_Inq=" + Inventarios.Fecha_Inq + ",Observaciones_prop='"+Inventarios.Observaciones_prop + "'" + ",Observaciones_inq='"+Inventarios.Observaciones_inq + "'" + ",Cod_empresa=" + Inventarios.Cod_empresa + " WHERE Cod_inmueble= " + Inventarios.Cod_inmueble + " and Usuario=" + Inventarios.Usuario + ";");
      }
     public long Nuevo(M_Inventarios Inventarios)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_inmueble", Inventarios.Cod_inmueble},
           {"Usuario", Inventarios.Usuario},
           {"Fecha_prop", Inventarios.Fecha_prop},
           {"Fecha_Inq", Inventarios.Fecha_Inq},
           {"Observaciones_prop", Inventarios.Observaciones_prop},
           {"Observaciones_inq", Inventarios.Observaciones_inq},
           {"Cod_empresa", Inventarios.Cod_empresa}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Inventarios(?, ?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
