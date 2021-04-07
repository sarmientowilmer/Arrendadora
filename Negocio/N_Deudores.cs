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
 public class N_Deudores
 {
     M_Deudores C_Deudores = new M_Deudores();
     ClsDatos Data = new ClsDatos();
     public bool Existe(string Tipo_id, int Id_deudor, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Deudores WHERE Tipo_id='" + Tipo_id + "'" + " and Id_deudor=" + Id_deudor);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Deudores.Tipo_id= DT.Rows[0]["Tipo_id"].ToString();
                 C_Deudores.Id_deudor= Convert.ToInt32(DT.Rows[0]["Id_deudor"]);
                 C_Deudores.Dv= DT.Rows[0]["Dv"].ToString();
                 C_Deudores.Apellido1= DT.Rows[0]["Apellido1"].ToString();
                 C_Deudores.Apellido2= DT.Rows[0]["Apellido2"].ToString();
                 C_Deudores.Nombre= DT.Rows[0]["Nombre"].ToString();
                 C_Deudores.Direccion= DT.Rows[0]["Direccion"].ToString();
                 C_Deudores.Telefono= DT.Rows[0]["Telefono"].ToString();
                 C_Deudores.Empresa= DT.Rows[0]["Empresa"].ToString();
                 C_Deudores.Tel_empresa= DT.Rows[0]["Tel_empresa"].ToString();
                 C_Deudores.Salario= Convert.ToDouble(DT.Rows[0]["Salario"]);
                 C_Deudores.Retencion= Convert.ToBoolean(DT.Rows[0]["Retencion"]);
                 C_Deudores.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Deudores Consultar(string Tipo_id, int Id_deudor)
     {
         if (Existe(Tipo_id, Id_deudor, true))
         {
             return C_Deudores;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Deudores");
     }
     public long Insertar(M_Deudores Deudores)
     {
         return Data.Accion("INSERT INTO Deudores (Tipo_id,Id_deudor,Dv,Apellido1,Apellido2,Nombre,Direccion,Telefono,Empresa,Tel_empresa,Salario,Retencion,Cod_empresa) VALUES (" + "'" + Deudores.Tipo_id+"'" + "," + Deudores.Id_deudor + ", '" + Deudores.Dv + "'" + ", '" + Deudores.Apellido1 + "'" + ", '" + Deudores.Apellido2 + "'" + ", '" + Deudores.Nombre + "'" + ", '" + Deudores.Direccion + "'" + ", '" + Deudores.Telefono + "'" + ", '" + Deudores.Empresa + "'" + ", '" + Deudores.Tel_empresa + "'" + "," + Deudores.Salario + "," + Deudores.Retencion + "," + Deudores.Cod_empresa + ");");
      }
     public long Actualizar(M_Deudores Deudores)
     {
         return Data.Accion("UPDATE Deudores SET Tipo_id='" + Deudores.Tipo_id + "'" + ",Id_deudor=" + Deudores.Id_deudor + ",Dv='"+Deudores.Dv + "'" + ",Apellido1='"+Deudores.Apellido1 + "'" + ",Apellido2='"+Deudores.Apellido2 + "'" + ",Nombre='"+Deudores.Nombre + "'" + ",Direccion='"+Deudores.Direccion + "'" + ",Telefono='"+Deudores.Telefono + "'" + ",Empresa='"+Deudores.Empresa + "'" + ",Tel_empresa='"+Deudores.Tel_empresa + "'" + ",Salario=" + Deudores.Salario + ",Retencion=" + Deudores.Retencion + ",Cod_empresa=" + Deudores.Cod_empresa + " WHERE Tipo_id='" + Deudores.Tipo_id + "'" + " and Id_deudor=" + Deudores.Id_deudor + ";");
      }
     public long Nuevo(M_Deudores Deudores)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Tipo_id", Deudores.Tipo_id},
           {"Id_deudor", Deudores.Id_deudor},
           {"Dv", Deudores.Dv},
           {"Apellido1", Deudores.Apellido1},
           {"Apellido2", Deudores.Apellido2},
           {"Nombre", Deudores.Nombre},
           {"Direccion", Deudores.Direccion},
           {"Telefono", Deudores.Telefono},
           {"Empresa", Deudores.Empresa},
           {"Tel_empresa", Deudores.Tel_empresa},
           {"Salario", Deudores.Salario},
           {"Retencion", Deudores.Retencion},
           {"Cod_empresa", Deudores.Cod_empresa}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Deudores(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
