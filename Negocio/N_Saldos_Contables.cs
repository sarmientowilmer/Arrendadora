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
    public class N_Saldos_Contables : N_General
    {
        public M_Saldos_Contables C_Saldos_Contables = new M_Saldos_Contables();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(int Año, int Mes, string Cuenta, string Tipo_aux, double Id_auxiliar, int Cod_empresa, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Saldos_Contables WHERE Año= " + Año + " and Mes=" + Mes + " and Cuenta='" + Cuenta + "'" + " and Tipo_aux='" + Tipo_aux + "'" + " and Id_auxiliar=" + Id_auxiliar + " and Cod_empresa=" + Cod_empresa);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Saldos_Contables.Año = Convert.ToInt32(DT.Rows[0]["Año"]);
                    C_Saldos_Contables.Mes = Convert.ToInt32(DT.Rows[0]["Mes"]);
                    C_Saldos_Contables.Cuenta = DT.Rows[0]["Cuenta"].ToString();
                    C_Saldos_Contables.Tipo_aux = DT.Rows[0]["Tipo_aux"].ToString();
                    C_Saldos_Contables.Id_auxiliar = Convert.ToDouble(DT.Rows[0]["Id_auxiliar"]);
                    C_Saldos_Contables.Dv = DT.Rows[0]["Dv"].ToString();
                    C_Saldos_Contables.Saldo = Convert.ToDouble(DT.Rows[0]["Saldo"]);
                    C_Saldos_Contables.Debitos = Convert.ToDouble(DT.Rows[0]["Debitos"]);
                    C_Saldos_Contables.Creditos = Convert.ToDouble(DT.Rows[0]["Creditos"]);
                    C_Saldos_Contables.Cod_empresa = Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                }
            }
            return ExisteRegistro;
        }
        public M_Saldos_Contables Consultar(int Año, int Mes, string Cuenta, string Tipo_aux, double Id_auxiliar, int Cod_empresa)
        {
            if (Existe(Año, Mes, Cuenta, Tipo_aux, Id_auxiliar, Cod_empresa, true))
            {
                return C_Saldos_Contables;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Saldos_Contables");
        }
        public long Insertar(M_Saldos_Contables Saldos_Contables)
        {
            return Data.Accion("INSERT INTO Saldos_Contables (Año,Mes,Cuenta,Tipo_aux,Id_auxiliar,Dv,Saldo,Debitos,Creditos,Cod_empresa) VALUES (" + Saldos_Contables.Año + "," + Saldos_Contables.Mes + ", '" + Saldos_Contables.Cuenta + "'" + ", '" + Saldos_Contables.Tipo_aux + "'" + "," + Saldos_Contables.Id_auxiliar + ", '" + Saldos_Contables.Dv + "'" + "," + Saldos_Contables.Saldo + "," + Saldos_Contables.Debitos + "," + Saldos_Contables.Creditos + "," + Saldos_Contables.Cod_empresa + ");");
        }
        public long Actualizar(M_Saldos_Contables Saldos_Contables)
        {
            return Data.Accion("UPDATE Saldos_Contables SET Año=" + Saldos_Contables.Año + ",Mes=" + Saldos_Contables.Mes + ",Cuenta='" + Saldos_Contables.Cuenta + "'" + ",Tipo_aux='" + Saldos_Contables.Tipo_aux + "'" + ",Id_auxiliar=" + Saldos_Contables.Id_auxiliar + ",Dv='" + Saldos_Contables.Dv + "'" + ",Saldo=" + Saldos_Contables.Saldo + ",Debitos=" + Saldos_Contables.Debitos + ",Creditos=" + Saldos_Contables.Creditos + ",Cod_empresa=" + Saldos_Contables.Cod_empresa + " WHERE Año= " + Saldos_Contables.Año + " and Mes=" + Saldos_Contables.Mes + " and Cuenta='" + Saldos_Contables.Cuenta + "'" + " and Tipo_aux='" + Saldos_Contables.Tipo_aux + "'" + " and Id_auxiliar=" + Saldos_Contables.Id_auxiliar + " and Cod_empresa=" + Saldos_Contables.Cod_empresa + ";");
        }
        public long Nuevo(M_Saldos_Contables Saldos_Contables)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Año", Saldos_Contables.Año},
           {"Mes", Saldos_Contables.Mes},
           {"Cuenta", Saldos_Contables.Cuenta},
           {"Tipo_aux", Saldos_Contables.Tipo_aux},
           {"Id_auxiliar", Saldos_Contables.Id_auxiliar},
           {"Dv", Saldos_Contables.Dv},
           {"Saldo", Saldos_Contables.Saldo},
           {"Debitos", Saldos_Contables.Debitos},
           {"Creditos", Saldos_Contables.Creditos},
           {"Cod_empresa", Saldos_Contables.Cod_empresa}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Saldos_Contables(?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
        }
    }
}
