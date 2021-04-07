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
    public class N_Saldos_Generales:N_General
    {
        public M_Saldos_Generales C_Saldos_Generales = new M_Saldos_Generales();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(int Tipo_servicio, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Saldos_Generales WHERE Tipo_servicio= " + Tipo_servicio);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Saldos_Generales.Tipo_servicio = Convert.ToInt32(DT.Rows[0]["Tipo_servicio"]);
                    C_Saldos_Generales.Saldo = Convert.ToDouble(DT.Rows[0]["Saldo"]);
                }
            }
            return ExisteRegistro;
        }
        public M_Saldos_Generales Consultar(int Tipo_servicio)
        {
            if (Existe(Tipo_servicio, true))
            {
                return C_Saldos_Generales;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Saldos_Generales");
        }
        public long Insertar(M_Saldos_Generales Saldos_Generales)
        {
            return Data.Accion("INSERT INTO Saldos_Generales (Tipo_servicio,Saldo) VALUES (" + Saldos_Generales.Tipo_servicio + "," + Saldos_Generales.Saldo + ");");
        }
        public long Actualizar(M_Saldos_Generales Saldos_Generales)
        {
            return Data.Accion("UPDATE Saldos_Generales SET Tipo_servicio=" + Saldos_Generales.Tipo_servicio + ",Saldo=" + Saldos_Generales.Saldo + " WHERE Tipo_servicio= " + Saldos_Generales.Tipo_servicio + ";");
        }
        public long Nuevo(M_Saldos_Generales Saldos_Generales)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Tipo_servicio", Saldos_Generales.Tipo_servicio},
           {"Saldo", Saldos_Generales.Saldo}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Saldos_Generales(?, ?)}", Parametros);
        }

        public long RegistrarMovimiento(int Tipo_servicio, string Signo, double Valor)
        {
            long resultado = -1;
            if (Existe(Tipo_servicio, true))
            {
                if (Signo == "+") { C_Saldos_Generales.Saldo+= Valor; }
                if (Signo == "-") { C_Saldos_Generales.Saldo -= Valor; }
                resultado = Actualizar(C_Saldos_Generales);
            }
            return resultado;
        }
    }
}
