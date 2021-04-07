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
 public class N_Tipos_telefono
 {
     M_Tipos_telefono C_Tipos_telefono = new M_Tipos_telefono();
     ClsDatos Data = new ClsDatos();
     public bool Existe(int Tipo_telefono, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM tipos_telefono WHERE Tipo_telefono= " + Tipo_telefono);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Tipos_telefono.Tipo_telefono= Convert.ToInt32(DT.Rows[0]["Tipo_telefono"]);
                 C_Tipos_telefono.Descripcion_tipo= DT.Rows[0]["Descripcion_tipo"].ToString();
             }
         }
         return ExisteRegistro;
     }
     public M_Tipos_telefono Consultar(int Tipo_telefono)
     {
         if (Existe(Tipo_telefono, true))
         {
             return C_Tipos_telefono;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM tipos_telefono");
     }
     public long Insertar(M_Tipos_telefono Tipos_telefono)
     {
         return Data.Accion("INSERT INTO tipos_telefono (Tipo_telefono,Descripcion_tipo) VALUES (" + Tipos_telefono.Tipo_telefono + ", '" + Tipos_telefono.Descripcion_tipo + "'" + ");");
      }
     public long Actualizar(M_Tipos_telefono Tipos_telefono)
     {
         return Data.Accion("UPDATE tipos_telefono SET Tipo_telefono=" + Tipos_telefono.Tipo_telefono + ",Descripcion_tipo='"+Tipos_telefono.Descripcion_tipo + "'" + " WHERE Tipo_telefono= " + Tipos_telefono.Tipo_telefono + ";");
      }
     public long Nuevo(M_Tipos_telefono Tipos_telefono)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Tipo_telefono", Tipos_telefono.Tipo_telefono},
           {"Descripcion_tipo", Tipos_telefono.Descripcion_tipo}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_tipos_telefono(?, ?)}", Parametros);
      }
 }
}
