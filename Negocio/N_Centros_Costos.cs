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
 public class N_Centros_Costos
 {
     M_Centros_Costos C_Centros_Costos = new M_Centros_Costos();
     ClsDatos Data = new ClsDatos();
     public bool Existe(int Cod_ccosto, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Centros_Costos WHERE Cod_ccosto= " + Cod_ccosto);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Centros_Costos.Cod_ccosto= Convert.ToInt32(DT.Rows[0]["Cod_ccosto"]);
                 C_Centros_Costos.Nombre_ccosto= DT.Rows[0]["Nombre_ccosto"].ToString();
                 C_Centros_Costos.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Centros_Costos Consultar(int Cod_ccosto)
     {
         if (Existe(Cod_ccosto, true))
         {
             return C_Centros_Costos;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Centros_Costos");
     }
     public long Insertar(M_Centros_Costos Centros_Costos)
     {
         return Data.Accion("INSERT INTO Centros_Costos (Cod_ccosto,Nombre_ccosto,Cod_empresa) VALUES (" + Centros_Costos.Cod_ccosto + ", '" + Centros_Costos.Nombre_ccosto + "'" + "," + Centros_Costos.Cod_empresa + ");");
      }
     public long Actualizar(M_Centros_Costos Centros_Costos)
     {
         return Data.Accion("UPDATE Centros_Costos SET Cod_ccosto=" + Centros_Costos.Cod_ccosto + ",Nombre_ccosto='"+Centros_Costos.Nombre_ccosto + "'" + ",Cod_empresa=" + Centros_Costos.Cod_empresa + " WHERE Cod_ccosto= " + Centros_Costos.Cod_ccosto + ";");
      }
     public long Nuevo(M_Centros_Costos Centros_Costos)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_ccosto", Centros_Costos.Cod_ccosto},
           {"Nombre_ccosto", Centros_Costos.Nombre_ccosto},
           {"Cod_empresa", Centros_Costos.Cod_empresa}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Centros_Costos(?, ?, ?)}", Parametros);
      }
 }
}
