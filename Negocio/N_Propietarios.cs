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
 public class N_Propietarios
 {
     M_Propietarios C_Propietarios = new M_Propietarios();
     ClsDatos Data = new ClsDatos();
     public bool Existe(string Tipo_id, int Id_propietario, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Propietarios WHERE Tipo_id='" + Tipo_id + "'" + " and Id_propietario=" + Id_propietario);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Propietarios.Tipo_id= DT.Rows[0]["Tipo_id"].ToString();
                 C_Propietarios.Id_propietario= Convert.ToInt32(DT.Rows[0]["Id_propietario"]);
                 C_Propietarios.Dv= DT.Rows[0]["Dv"].ToString();
                 C_Propietarios.Apellido1= DT.Rows[0]["Apellido1"].ToString();
                 C_Propietarios.Apellido2= DT.Rows[0]["Apellido2"].ToString();
                 C_Propietarios.Nombre= DT.Rows[0]["Nombre"].ToString();
                 C_Propietarios.Direccion= DT.Rows[0]["Direccion"].ToString();
                 C_Propietarios.Telefono= DT.Rows[0]["Telefono"].ToString();
                 C_Propietarios.Ciudad= DT.Rows[0]["Ciudad"].ToString();
                 C_Propietarios.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Propietarios Consultar(string Tipo_id, int Id_propietario)
     {
         if (Existe(Tipo_id, Id_propietario, true))
         {
             return C_Propietarios;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Propietarios");
     }
     public long Insertar(M_Propietarios Propietarios)
     {
         return Data.Accion("INSERT INTO Propietarios (Tipo_id,Id_propietario,Dv,Apellido1,Apellido2,Nombre,Direccion,Telefono,Ciudad,Cod_empresa) VALUES (" + "'" + Propietarios.Tipo_id+"'" + "," + Propietarios.Id_propietario + ", '" + Propietarios.Dv + "'" + ", '" + Propietarios.Apellido1 + "'" + ", '" + Propietarios.Apellido2 + "'" + ", '" + Propietarios.Nombre + "'" + ", '" + Propietarios.Direccion + "'" + ", '" + Propietarios.Telefono + "'" + ", '" + Propietarios.Ciudad + "'" + "," + Propietarios.Cod_empresa + ");");
      }
     public long Actualizar(M_Propietarios Propietarios)
     {
         return Data.Accion("UPDATE Propietarios SET Tipo_id='" + Propietarios.Tipo_id + "'" + ",Id_propietario=" + Propietarios.Id_propietario + ",Dv='"+Propietarios.Dv + "'" + ",Apellido1='"+Propietarios.Apellido1 + "'" + ",Apellido2='"+Propietarios.Apellido2 + "'" + ",Nombre='"+Propietarios.Nombre + "'" + ",Direccion='"+Propietarios.Direccion + "'" + ",Telefono='"+Propietarios.Telefono + "'" + ",Ciudad='"+Propietarios.Ciudad + "'" + ",Cod_empresa=" + Propietarios.Cod_empresa + " WHERE Tipo_id='" + Propietarios.Tipo_id + "'" + " and Id_propietario=" + Propietarios.Id_propietario + ";");
      }
     public long Nuevo(M_Propietarios Propietarios)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Tipo_id", Propietarios.Tipo_id},
           {"Id_propietario", Propietarios.Id_propietario},
           {"Dv", Propietarios.Dv},
           {"Apellido1", Propietarios.Apellido1},
           {"Apellido2", Propietarios.Apellido2},
           {"Nombre", Propietarios.Nombre},
           {"Direccion", Propietarios.Direccion},
           {"Telefono", Propietarios.Telefono},
           {"Ciudad", Propietarios.Ciudad},
           {"Cod_empresa", Propietarios.Cod_empresa}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Propietarios(?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
