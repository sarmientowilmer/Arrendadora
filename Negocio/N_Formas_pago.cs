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
    public class N_Formas_pago : N_General
    {
        public M_Formas_pago C_Formas_pago = new M_Formas_pago();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(int Forma, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Formas_pago WHERE Forma= " + Forma);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Formas_pago.Forma = Convert.ToInt32(DT.Rows[0]["Forma"]);
                    C_Formas_pago.Nombre_forma = DT.Rows[0]["Nombre_forma"].ToString();
                    C_Formas_pago.Afecta = Convert.ToInt32(DT.Rows[0]["Afecta"]);
                    C_Formas_pago.Cod_empresa = Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                    C_Formas_pago.Cuenta_contab = DT.Rows[0]["Cuenta_contab"].ToString();
                }
            }
            return ExisteRegistro;
        }
        public M_Formas_pago Consultar(int Forma)
        {
            if (Existe(Forma, true))
            {
                return C_Formas_pago;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Formas_pago;");
        }
        public DataTable ConsultarParaOtrosComprobantes()
        {
            return Data.ConsultaT("SELECT * FROM Formas_pago WHERE forma=1  OR forma=4;");
        }
        public DataTable Consultar(string Tipo)
        {
            if (Tipo == "Egresos")
            {
                return Data.ConsultaT("SELECT * FROM Formas_pago WHERE afecta=2 OR afecta=3");
            }
            else
            {
                return Data.ConsultaT("SELECT * FROM Formas_pago WHERE afecta=1 OR afecta=3");
            }
            
        }
        public long Insertar(M_Formas_pago Formas_pago)
        {
            return Data.Accion("INSERT INTO Formas_pago (Forma,Nombre_forma,Afecta,Cod_empresa,Cuenta_contab) VALUES (" + Formas_pago.Forma + ", '" + Formas_pago.Nombre_forma + "'" + "," + Formas_pago.Afecta + "," + Formas_pago.Cod_empresa + ", '" + Formas_pago.Cuenta_contab + "'" + ");");
        }
        public long Actualizar(M_Formas_pago Formas_pago)
        {
            return Data.Accion("UPDATE Formas_pago SET Forma=" + Formas_pago.Forma + ",Nombre_forma='" + Formas_pago.Nombre_forma + "'" + ",Afecta=" + Formas_pago.Afecta + ",Cod_empresa=" + Formas_pago.Cod_empresa + ",Cuenta_contab='" + Formas_pago.Cuenta_contab + "'" + " WHERE Forma= " + Formas_pago.Forma + ";");
        }
        public long Nuevo(M_Formas_pago Formas_pago)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Forma", Formas_pago.Forma},
           {"Nombre_forma", Formas_pago.Nombre_forma},
           {"Afecta", Formas_pago.Afecta},
           {"Cod_empresa", Formas_pago.Cod_empresa},
           {"Cuenta_contab", Formas_pago.Cuenta_contab}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Formas_pago(?, ?, ?, ?, ?)}", Parametros);
        }
    }
}
