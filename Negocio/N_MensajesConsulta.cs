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
 public class N_MensajesConsulta
 {
     M_MensajesConsulta C_MensajesConsulta = new M_MensajesConsulta();
     ClsDatos Data = new ClsDatos();
     public bool Existe(int No_mensaje, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM MensajesConsulta WHERE No_mensaje= " + No_mensaje);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_MensajesConsulta.No_mensaje= Convert.ToInt32(DT.Rows[0]["No_mensaje"]);
                 C_MensajesConsulta.Mensaje= DT.Rows[0]["Mensaje"].ToString();
                 C_MensajesConsulta.Imagen= (byte[])(DT.Rows[0]["Imagen"]);
                 C_MensajesConsulta.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
             }
         }
         return ExisteRegistro;
     }
     public M_MensajesConsulta Consultar(int No_mensaje)
     {
         if (Existe(No_mensaje, true))
         {
             return C_MensajesConsulta;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM MensajesConsulta");
     }
     public long Insertar(M_MensajesConsulta MensajesConsulta)
     {
         return Data.Accion("INSERT INTO MensajesConsulta (No_mensaje,Mensaje,Imagen,Cod_empresa) VALUES (" + MensajesConsulta.No_mensaje + ", '" + MensajesConsulta.Mensaje + "'" + "," + MensajesConsulta.Imagen + "," + MensajesConsulta.Cod_empresa + ");");
      }
     public long Actualizar(M_MensajesConsulta MensajesConsulta)
     {
         return Data.Accion("UPDATE MensajesConsulta SET No_mensaje=" + MensajesConsulta.No_mensaje + ",Mensaje='"+MensajesConsulta.Mensaje + "'" + ",Imagen=" + MensajesConsulta.Imagen + ",Cod_empresa=" + MensajesConsulta.Cod_empresa + " WHERE No_mensaje= " + MensajesConsulta.No_mensaje + ";");
      }
     public long Nuevo(M_MensajesConsulta MensajesConsulta)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"No_mensaje", MensajesConsulta.No_mensaje},
           {"Mensaje", MensajesConsulta.Mensaje},
           {"Imagen", MensajesConsulta.Imagen},
           {"Cod_empresa", MensajesConsulta.Cod_empresa}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_MensajesConsulta(?, ?, ?, ?)}", Parametros);
      }
 }
}
