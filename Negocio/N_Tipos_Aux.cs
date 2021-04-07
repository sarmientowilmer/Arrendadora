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
 public class N_Tipos_Aux
 {
     M_Tipos_Aux C_Tipos_Aux = new M_Tipos_Aux();
     ClsDatos Data = new ClsDatos();
     public bool Existe(string Tipo_aux, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Tipos_Aux WHERE Tipo_aux='" + Tipo_aux + "'");
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Tipos_Aux.Tipo_aux= DT.Rows[0]["Tipo_aux"].ToString();
                 C_Tipos_Aux.Nombre_tipo= DT.Rows[0]["Nombre_tipo"].ToString();
                 C_Tipos_Aux.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Tipos_Aux Consultar(string Tipo_aux)
     {
         if (Existe(Tipo_aux, true))
         {
             return C_Tipos_Aux;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Tipos_Aux");
     }
     public long Insertar(M_Tipos_Aux Tipos_Aux)
     {
         return Data.Accion("INSERT INTO Tipos_Aux (Tipo_aux,Nombre_tipo,Cod_empresa) VALUES (" + "'" + Tipos_Aux.Tipo_aux+"'" + ", '" + Tipos_Aux.Nombre_tipo + "'" + "," + Tipos_Aux.Cod_empresa + ");");
      }
     public long Actualizar(M_Tipos_Aux Tipos_Aux)
     {
         return Data.Accion("UPDATE Tipos_Aux SET Tipo_aux='" + Tipos_Aux.Tipo_aux + "'" + ",Nombre_tipo='"+Tipos_Aux.Nombre_tipo + "'" + ",Cod_empresa=" + Tipos_Aux.Cod_empresa + " WHERE Tipo_aux='" + Tipos_Aux.Tipo_aux + "'" + ";");
      }
     public long Nuevo(M_Tipos_Aux Tipos_Aux)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Tipo_aux", Tipos_Aux.Tipo_aux},
           {"Nombre_tipo", Tipos_Aux.Nombre_tipo},
           {"Cod_empresa", Tipos_Aux.Cod_empresa}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Tipos_Aux(?, ?, ?)}", Parametros);
      }
 }
}
