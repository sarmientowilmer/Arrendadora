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
 public class N_Saldos_Servicios
 {
     M_Saldos_Servicios C_Saldos_Servicios = new M_Saldos_Servicios();
     ClsDatos Data = new ClsDatos();
     public bool Existe(string Tipo_id, int Id, int Servicio, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Saldos_Servicios WHERE Tipo_id='" + Tipo_id + "'" + " and Id=" + Id + " and Servicio=" + Servicio);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Saldos_Servicios.Tipo_id= DT.Rows[0]["Tipo_id"].ToString();
                 C_Saldos_Servicios.Id= Convert.ToInt32(DT.Rows[0]["Id"]);
                 C_Saldos_Servicios.Servicio= Convert.ToInt32(DT.Rows[0]["Servicio"]);
                 C_Saldos_Servicios.Saldo= Convert.ToDouble(DT.Rows[0]["Saldo"]);
                 C_Saldos_Servicios.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Saldos_Servicios Consultar(string Tipo_id, int Id, int Servicio)
     {
         if (Existe(Tipo_id, Id, Servicio, true))
         {
             return C_Saldos_Servicios;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Saldos_Servicios");
     }
     public long Insertar(M_Saldos_Servicios Saldos_Servicios)
     {
         return Data.Accion("INSERT INTO Saldos_Servicios (Tipo_id,Id,Servicio,Saldo,Cod_empresa) VALUES (" + "'" + Saldos_Servicios.Tipo_id+"'" + "," + Saldos_Servicios.Id + "," + Saldos_Servicios.Servicio + "," + Saldos_Servicios.Saldo + "," + Saldos_Servicios.Cod_empresa + ");");
      }
     public long Actualizar(M_Saldos_Servicios Saldos_Servicios)
     {
         return Data.Accion("UPDATE Saldos_Servicios SET Tipo_id='" + Saldos_Servicios.Tipo_id + "'" + ",Id=" + Saldos_Servicios.Id + ",Servicio=" + Saldos_Servicios.Servicio + ",Saldo=" + Saldos_Servicios.Saldo + ",Cod_empresa=" + Saldos_Servicios.Cod_empresa + " WHERE Tipo_id='" + Saldos_Servicios.Tipo_id + "'" + " and Id=" + Saldos_Servicios.Id + " and Servicio=" + Saldos_Servicios.Servicio + ";");
      }
     public long Nuevo(M_Saldos_Servicios Saldos_Servicios)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Tipo_id", Saldos_Servicios.Tipo_id},
           {"Id", Saldos_Servicios.Id},
           {"Servicio", Saldos_Servicios.Servicio},
           {"Saldo", Saldos_Servicios.Saldo},
           {"Cod_empresa", Saldos_Servicios.Cod_empresa}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Saldos_Servicios(?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
