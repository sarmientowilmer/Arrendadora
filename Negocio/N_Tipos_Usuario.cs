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
 public class N_Tipos_Usuario
 {
     M_Tipos_Usuario C_Tipos_Usuario = new M_Tipos_Usuario();
     ClsDatos Data = new ClsDatos();
     public bool Existe(string Tipo_usuario, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Tipos_Usuario WHERE Tipo_usuario='" + Tipo_usuario + "'");
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Tipos_Usuario.Tipo_usuario= DT.Rows[0]["Tipo_usuario"].ToString();
                 C_Tipos_Usuario.Descripcion_tipo= DT.Rows[0]["Descripcion_tipo"].ToString();
                 C_Tipos_Usuario.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Tipos_Usuario Consultar(string Tipo_usuario)
     {
         if (Existe(Tipo_usuario, true))
         {
             return C_Tipos_Usuario;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Tipos_Usuario");
     }
     public long Insertar(M_Tipos_Usuario Tipos_Usuario)
     {
         return Data.Accion("INSERT INTO Tipos_Usuario (Tipo_usuario,Descripcion_tipo,Cod_empresa) VALUES (" + "'" + Tipos_Usuario.Tipo_usuario+"'" + ", '" + Tipos_Usuario.Descripcion_tipo + "'" + "," + Tipos_Usuario.Cod_empresa + ");");
      }
     public long Actualizar(M_Tipos_Usuario Tipos_Usuario)
     {
         return Data.Accion("UPDATE Tipos_Usuario SET Tipo_usuario='" + Tipos_Usuario.Tipo_usuario + "'" + ",Descripcion_tipo='"+Tipos_Usuario.Descripcion_tipo + "'" + ",Cod_empresa=" + Tipos_Usuario.Cod_empresa + " WHERE Tipo_usuario='" + Tipos_Usuario.Tipo_usuario + "'" + ";");
      }
     public long Nuevo(M_Tipos_Usuario Tipos_Usuario)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Tipo_usuario", Tipos_Usuario.Tipo_usuario},
           {"Descripcion_tipo", Tipos_Usuario.Descripcion_tipo},
           {"Cod_empresa", Tipos_Usuario.Cod_empresa}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Tipos_Usuario(?, ?, ?)}", Parametros);
      }
 }
}
