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
 public class N_Informes_Contables
 {
     M_Informes_Contables C_Informes_Contables = new M_Informes_Contables();
     ClsDatos Data = new ClsDatos();
     public bool Existe(int Cod_informe, int Item, bool CargarDatos)
     {
         DataTable DT = new DataTable();
         DT = Data.ConsultaT("SELECT * FROM Informes_Contables WHERE Cod_informe= " + Cod_informe + " and Item=" + Item);
         bool ExisteRegistro = false;
         if (DT.Rows.Count > 0)
         {
             ExisteRegistro = true;
             if (CargarDatos)
             {
                 C_Informes_Contables.Cod_informe= Convert.ToInt32(DT.Rows[0]["Cod_informe"]);
                 C_Informes_Contables.Item= Convert.ToInt32(DT.Rows[0]["Item"]);
                 C_Informes_Contables.Fecha= Convert.ToDateTime(DT.Rows[0]["Fecha"]);
                 C_Informes_Contables.Cuenta= DT.Rows[0]["Cuenta"].ToString();
                 C_Informes_Contables.Nombre_cuenta= DT.Rows[0]["Nombre_cuenta"].ToString();
                 C_Informes_Contables.Tipo_comp= DT.Rows[0]["Tipo_comp"].ToString();
                 C_Informes_Contables.No_comp= Convert.ToInt32(DT.Rows[0]["No_comp"]);
                 C_Informes_Contables.Descrpcion= DT.Rows[0]["Descrpcion"].ToString();
                 C_Informes_Contables.Tipo_saldo_ant= DT.Rows[0]["Tipo_saldo_ant"].ToString();
                 C_Informes_Contables.Saldo_ant= Convert.ToDouble(DT.Rows[0]["Saldo_ant"]);
                 C_Informes_Contables.Debito= Convert.ToDouble(DT.Rows[0]["Debito"]);
                 C_Informes_Contables.Credito= Convert.ToDouble(DT.Rows[0]["Credito"]);
                 C_Informes_Contables.Nvo_saldo= Convert.ToDouble(DT.Rows[0]["Nvo_saldo"]);
                 C_Informes_Contables.Tipo_saldo= DT.Rows[0]["Tipo_saldo"].ToString();
                 C_Informes_Contables.Tipo_aux= DT.Rows[0]["Tipo_aux"].ToString();
                 C_Informes_Contables.Id_auxiliar= Convert.ToInt32(DT.Rows[0]["Id_auxiliar"]);
                 C_Informes_Contables.Dv_auxiliar= DT.Rows[0]["Dv_auxiliar"].ToString();
                 C_Informes_Contables.Nombre_tercero= DT.Rows[0]["Nombre_tercero"].ToString();
                 C_Informes_Contables.Cod_empresa= Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                 C_Informes_Contables.Seccion= Convert.ToInt32(DT.Rows[0]["Seccion"]);
                 C_Informes_Contables.Centro_costo= Convert.ToInt32(DT.Rows[0]["Centro_costo"]);
                 C_Informes_Contables.Cuenta_nominal= Convert.ToBoolean(DT.Rows[0]["Cuenta_nominal"]);
                 C_Informes_Contables.Linea= Convert.ToInt32(DT.Rows[0]["Linea"]);
                 C_Informes_Contables.Clase= Convert.ToInt32(DT.Rows[0]["Clase"]);
                 C_Informes_Contables.Grupo= Convert.ToInt32(DT.Rows[0]["Grupo"]);
                 C_Informes_Contables.Cta= Convert.ToInt32(DT.Rows[0]["Cta"]);
                 C_Informes_Contables.Subcuenta= Convert.ToInt32(DT.Rows[0]["Subcuenta"]);
                 C_Informes_Contables.Subsubcuenta= Convert.ToInt32(DT.Rows[0]["Subsubcuenta"]);
             }
         }
         return ExisteRegistro;
     }
     public M_Informes_Contables Consultar(int Cod_informe, int Item)
     {
         if (Existe(Cod_informe, Item, true))
         {
             return C_Informes_Contables;
         }
         else
         {
             return null;
         }
     }
     public DataTable Consultar()
     {
         return Data.ConsultaT("SELECT * FROM Informes_Contables");
     }
     public long Insertar(M_Informes_Contables Informes_Contables)
     {
         return Data.Accion("INSERT INTO Informes_Contables (Cod_informe,Item,Fecha,Cuenta,Nombre_cuenta,Tipo_comp,No_comp,Descrpcion,Tipo_saldo_ant,Saldo_ant,Debito,Credito,Nvo_saldo,Tipo_saldo,Tipo_aux,Id_auxiliar,Dv_auxiliar,Nombre_tercero,Cod_empresa,Seccion,Centro_costo,Cuenta_nominal,Linea,Clase,Grupo,Cta,Subcuenta,Subsubcuenta) VALUES (" + Informes_Contables.Cod_informe + "," + Informes_Contables.Item + "," + Informes_Contables.Fecha + ", '" + Informes_Contables.Cuenta + "'" + ", '" + Informes_Contables.Nombre_cuenta + "'" + ", '" + Informes_Contables.Tipo_comp + "'" + "," + Informes_Contables.No_comp + ", '" + Informes_Contables.Descrpcion + "'" + ", '" + Informes_Contables.Tipo_saldo_ant + "'" + "," + Informes_Contables.Saldo_ant + "," + Informes_Contables.Debito + "," + Informes_Contables.Credito + "," + Informes_Contables.Nvo_saldo + ", '" + Informes_Contables.Tipo_saldo + "'" + ", '" + Informes_Contables.Tipo_aux + "'" + "," + Informes_Contables.Id_auxiliar + ", '" + Informes_Contables.Dv_auxiliar + "'" + ", '" + Informes_Contables.Nombre_tercero + "'" + "," + Informes_Contables.Cod_empresa + "," + Informes_Contables.Seccion + "," + Informes_Contables.Centro_costo + "," + Informes_Contables.Cuenta_nominal + "," + Informes_Contables.Linea + "," + Informes_Contables.Clase + "," + Informes_Contables.Grupo + "," + Informes_Contables.Cta + "," + Informes_Contables.Subcuenta + "," + Informes_Contables.Subsubcuenta + ");");
      }
     public long Actualizar(M_Informes_Contables Informes_Contables)
     {
         return Data.Accion("UPDATE Informes_Contables SET Cod_informe=" + Informes_Contables.Cod_informe + ",Item=" + Informes_Contables.Item + ",Fecha=" + Informes_Contables.Fecha + ",Cuenta='"+Informes_Contables.Cuenta + "'" + ",Nombre_cuenta='"+Informes_Contables.Nombre_cuenta + "'" + ",Tipo_comp='"+Informes_Contables.Tipo_comp + "'" + ",No_comp=" + Informes_Contables.No_comp + ",Descrpcion='"+Informes_Contables.Descrpcion + "'" + ",Tipo_saldo_ant='"+Informes_Contables.Tipo_saldo_ant + "'" + ",Saldo_ant=" + Informes_Contables.Saldo_ant + ",Debito=" + Informes_Contables.Debito + ",Credito=" + Informes_Contables.Credito + ",Nvo_saldo=" + Informes_Contables.Nvo_saldo + ",Tipo_saldo='"+Informes_Contables.Tipo_saldo + "'" + ",Tipo_aux='"+Informes_Contables.Tipo_aux + "'" + ",Id_auxiliar=" + Informes_Contables.Id_auxiliar + ",Dv_auxiliar='"+Informes_Contables.Dv_auxiliar + "'" + ",Nombre_tercero='"+Informes_Contables.Nombre_tercero + "'" + ",Cod_empresa=" + Informes_Contables.Cod_empresa + ",Seccion=" + Informes_Contables.Seccion + ",Centro_costo=" + Informes_Contables.Centro_costo + ",Cuenta_nominal=" + Informes_Contables.Cuenta_nominal + ",Linea=" + Informes_Contables.Linea + ",Clase=" + Informes_Contables.Clase + ",Grupo=" + Informes_Contables.Grupo + ",Cta=" + Informes_Contables.Cta + ",Subcuenta=" + Informes_Contables.Subcuenta + ",Subsubcuenta=" + Informes_Contables.Subsubcuenta + " WHERE Cod_informe= " + Informes_Contables.Cod_informe + " and Item=" + Informes_Contables.Item + ";");
      }
     public long Nuevo(M_Informes_Contables Informes_Contables)
     {
         Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_informe", Informes_Contables.Cod_informe},
           {"Item", Informes_Contables.Item},
           {"Fecha", Informes_Contables.Fecha},
           {"Cuenta", Informes_Contables.Cuenta},
           {"Nombre_cuenta", Informes_Contables.Nombre_cuenta},
           {"Tipo_comp", Informes_Contables.Tipo_comp},
           {"No_comp", Informes_Contables.No_comp},
           {"Descrpcion", Informes_Contables.Descrpcion},
           {"Tipo_saldo_ant", Informes_Contables.Tipo_saldo_ant},
           {"Saldo_ant", Informes_Contables.Saldo_ant},
           {"Debito", Informes_Contables.Debito},
           {"Credito", Informes_Contables.Credito},
           {"Nvo_saldo", Informes_Contables.Nvo_saldo},
           {"Tipo_saldo", Informes_Contables.Tipo_saldo},
           {"Tipo_aux", Informes_Contables.Tipo_aux},
           {"Id_auxiliar", Informes_Contables.Id_auxiliar},
           {"Dv_auxiliar", Informes_Contables.Dv_auxiliar},
           {"Nombre_tercero", Informes_Contables.Nombre_tercero},
           {"Cod_empresa", Informes_Contables.Cod_empresa},
           {"Seccion", Informes_Contables.Seccion},
           {"Centro_costo", Informes_Contables.Centro_costo},
           {"Cuenta_nominal", Informes_Contables.Cuenta_nominal},
           {"Linea", Informes_Contables.Linea},
           {"Clase", Informes_Contables.Clase},
           {"Grupo", Informes_Contables.Grupo},
           {"Cta", Informes_Contables.Cta},
           {"Subcuenta", Informes_Contables.Subcuenta},
           {"Subsubcuenta", Informes_Contables.Subsubcuenta}
         };
         return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Informes_Contables(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
      }
 }
}
