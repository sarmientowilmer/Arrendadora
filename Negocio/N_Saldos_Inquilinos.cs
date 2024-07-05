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
 public class N_Saldos_Inquilinos
 {
     M_Saldos_Inquilinos C_Saldos_Inquilinos = new M_Saldos_Inquilinos();
     ClsDatos Data = new ClsDatos();
     public bool Existe( bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Saldos_Inquilinos ");
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Saldos_Inquilinos.No_contrato= Convert.ToInt32(DT.Rows[0]["No_contrato"]);
                 C_Saldos_Inquilinos.Canon= Convert.ToDouble(DT.Rows[0]["Canon"]);
                 C_Saldos_Inquilinos.Intereses= Convert.ToDouble(DT.Rows[0]["Intereses"]);
                 C_Saldos_Inquilinos.Ultimopago= Convert.ToDateTime(DT.Rows[0]["Ultimopago"]);
             }
         }
         return ExisteRegistro;
     }
     //public M_Saldos_Inquilinos Consultar()
     //{
     //    if (Existe(Año, Mes, Cuenta, Tipo_aux, Id_auxiliar, Cod_empresa, true))
     //    {
     //        return C_Saldos_Inquilinos;
     //    }
     //    else
     //    {
     //        return null;
     //    }
     //}
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Saldos_Inquilinos");
     }
     public long Insertar(M_Saldos_Inquilinos Saldos_Inquilinos)
     {
         return Data.Accion("INSERT INTO Saldos_Inquilinos (No_contrato,Canon,Intereses,Ultimopago) VALUES (" + Saldos_Inquilinos.No_contrato + "," + Saldos_Inquilinos.Canon + "," + Saldos_Inquilinos.Intereses + "," + Saldos_Inquilinos.Ultimopago + ");");
      }
     public long Actualizar(M_Saldos_Inquilinos Saldos_Inquilinos)
     {
         return Data.Accion("UPDATE Saldos_Inquilinos SET No_contrato=" + Saldos_Inquilinos.No_contrato + ",Canon=" + Saldos_Inquilinos.Canon + ",Intereses=" + Saldos_Inquilinos.Intereses + ",Ultimopago=" + Saldos_Inquilinos.Ultimopago + ";");
      }
     public long Nuevo(M_Saldos_Inquilinos Saldos_Inquilinos)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"No_contrato", Saldos_Inquilinos.No_contrato},
           {"Canon", Saldos_Inquilinos.Canon},
           {"Intereses", Saldos_Inquilinos.Intereses},
           {"Ultimopago", Saldos_Inquilinos.Ultimopago}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Saldos_Inquilinos(?, ?, ?, ?)}", Parametros);
      }
 }
}
