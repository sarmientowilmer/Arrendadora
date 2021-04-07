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
    public class N_Cuentas_Bancarias : N_General
    {
        public M_Cuentas_Bancarias C_Cuentas_Bancarias = new M_Cuentas_Bancarias();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(int Cod_cuenta, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Cuentas_Bancarias WHERE Cod_cuenta= " + Cod_cuenta);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Cuentas_Bancarias.Cod_cuenta = Convert.ToInt32(DT.Rows[0]["Cod_cuenta"]);
                    C_Cuentas_Bancarias.Tipo_cuenta = DT.Rows[0]["Tipo_cuenta"].ToString();
                    C_Cuentas_Bancarias.Cod_banco = Convert.ToInt32(DT.Rows[0]["Cod_banco"]);
                    C_Cuentas_Bancarias.No_Cuenta = DT.Rows[0]["No_Cuenta"].ToString();
                    C_Cuentas_Bancarias.Saldo = Convert.ToDouble(DT.Rows[0]["Saldo"]);
                    C_Cuentas_Bancarias.Cuenta_Contable = DT.Rows[0]["Cuenta_Contable"].ToString();
                    C_Cuentas_Bancarias.Sucursal = DT.Rows[0]["Sucursal"].ToString();
                    C_Cuentas_Bancarias.Uso = DT.Rows[0]["Uso"].ToString();
                    C_Cuentas_Bancarias.Moneda = Convert.ToInt32(DT.Rows[0]["Moneda"]);
                    C_Cuentas_Bancarias.Cod_empresa = Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                }
            }
            return ExisteRegistro;
        }
        public M_Cuentas_Bancarias Consultar(int Cod_cuenta)
        {
            if (Existe(Cod_cuenta, true))
            {
                return C_Cuentas_Bancarias;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Cuentas_Bancarias");
        }
        public long Insertar(M_Cuentas_Bancarias Cuentas_Bancarias)
        {
            return Data.Accion("INSERT INTO Cuentas_Bancarias (Cod_cuenta,Tipo_cuenta,Cod_banco,No_Cuenta,Saldo,Cuenta_Contable,Sucursal,Uso,Moneda,Cod_empresa) VALUES (" + Cuentas_Bancarias.Cod_cuenta + ", '" + Cuentas_Bancarias.Tipo_cuenta + "'" + "," + Cuentas_Bancarias.Cod_banco + ", '" + Cuentas_Bancarias.No_Cuenta + "'" + "," + Cuentas_Bancarias.Saldo + ", '" + Cuentas_Bancarias.Cuenta_Contable + "'" + ", '" + Cuentas_Bancarias.Sucursal + "'" + ", '" + Cuentas_Bancarias.Uso + "'" + "," + Cuentas_Bancarias.Moneda + "," + Cuentas_Bancarias.Cod_empresa + ");");
        }
        public long Actualizar(M_Cuentas_Bancarias Cuentas_Bancarias)
        {
            return Data.Accion("UPDATE Cuentas_Bancarias SET Cod_cuenta=" + Cuentas_Bancarias.Cod_cuenta + ",Tipo_cuenta='" + Cuentas_Bancarias.Tipo_cuenta + "'" + ",Cod_banco=" + Cuentas_Bancarias.Cod_banco + ",No_Cuenta='" + Cuentas_Bancarias.No_Cuenta + "'" + ",Saldo=" + Cuentas_Bancarias.Saldo + ",Cuenta_Contable='" + Cuentas_Bancarias.Cuenta_Contable + "'" + ",Sucursal='" + Cuentas_Bancarias.Sucursal + "'" + ",Uso='" + Cuentas_Bancarias.Uso + "'" + ",Moneda=" + Cuentas_Bancarias.Moneda + ",Cod_empresa=" + Cuentas_Bancarias.Cod_empresa + " WHERE Cod_cuenta= " + Cuentas_Bancarias.Cod_cuenta + ";");
        }
        public long Nuevo(M_Cuentas_Bancarias Cuentas_Bancarias)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_cuenta", Cuentas_Bancarias.Cod_cuenta},
           {"Tipo_cuenta", Cuentas_Bancarias.Tipo_cuenta},
           {"Cod_banco", Cuentas_Bancarias.Cod_banco},
           {"No_Cuenta", Cuentas_Bancarias.No_Cuenta},
           {"Saldo", Cuentas_Bancarias.Saldo},
           {"Cuenta_Contable", Cuentas_Bancarias.Cuenta_Contable},
           {"Sucursal", Cuentas_Bancarias.Sucursal},
           {"Uso", Cuentas_Bancarias.Uso},
           {"Moneda", Cuentas_Bancarias.Moneda},
           {"Cod_empresa", Cuentas_Bancarias.Cod_empresa}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Cuentas_Bancarias(?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
        }
    }
}
