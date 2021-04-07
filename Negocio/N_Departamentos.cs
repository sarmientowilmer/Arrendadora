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
 public class N_Departamentos
 {
     M_Departamentos C_Departamentos = new M_Departamentos();
     ClsDatos Data = new ClsDatos();
     public bool Existe(int Cod_departamento, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM departamentos WHERE Cod_departamento= " + Cod_departamento);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Departamentos.Cod_departamento= Convert.ToInt32(DT.Rows[0]["Cod_departamento"]);
                 C_Departamentos.Nombre_departamento= DT.Rows[0]["Nombre_departamento"].ToString();
             }
         }
         return ExisteRegistro;
     }
     public M_Departamentos Consultar(int Cod_departamento)
     {
         if (Existe(Cod_departamento, true))
         {
             return C_Departamentos;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM departamentos");
     }
     public long Insertar(M_Departamentos Departamentos)
     {
         return Data.Accion("INSERT INTO departamentos (Cod_departamento,Nombre_departamento) VALUES (" + Departamentos.Cod_departamento + ", '" + Departamentos.Nombre_departamento + "'" + ");");
      }
     public long Actualizar(M_Departamentos Departamentos)
     {
         return Data.Accion("UPDATE departamentos SET Cod_departamento=" + Departamentos.Cod_departamento + ",Nombre_departamento='"+Departamentos.Nombre_departamento + "'" + " WHERE Cod_departamento= " + Departamentos.Cod_departamento + ";");
      }
     public long Nuevo(M_Departamentos Departamentos)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_departamento", Departamentos.Cod_departamento},
           {"Nombre_departamento", Departamentos.Nombre_departamento}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_departamentos(?, ?)}", Parametros);
      }
 }
}
