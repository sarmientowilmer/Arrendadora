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
    public class N_Informe : N_General
    {
        public M_Informe C_Informe = new M_Informe();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(int No_contrato, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Informe WHERE No_contrato= " + No_contrato);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Informe.No_contrato = Convert.ToInt32(DT.Rows[0]["No_contrato"]);
                    C_Informe.Deudacanon = Convert.ToDouble(DT.Rows[0]["Deudacanon"]);
                    C_Informe.Deudaintrs = Convert.ToDouble(DT.Rows[0]["Deudaintrs"]);
                    C_Informe.Dias = Convert.ToInt32(DT.Rows[0]["Dias"]);
                    C_Informe.Cod_empresa = Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                }
            }
            return ExisteRegistro;
        }
        public M_Informe Consultar(int No_contrato)
        {
            if (Existe(No_contrato, true))
            {
                return C_Informe;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Informe");
        }
        public long Insertar(M_Informe Informe)
        {
            return Data.Accion("INSERT INTO informe (No_contrato,Deudacanon,Deudaintrs,Dias,Cod_empresa) VALUES (" + Informe.No_contrato + "," + Informe.Deudacanon + "," + Informe.Deudaintrs + "," + Informe.Dias + "," + Informe.Cod_empresa + ");");
        }
        public long Actualizar(M_Informe Informe)
        {
            return Data.Accion("UPDATE Informe SET No_contrato=" + Informe.No_contrato + ",Deudacanon=" + Informe.Deudacanon + ",Deudaintrs=" + Informe.Deudaintrs + ",Dias=" + Informe.Dias + ",Cod_empresa=" + Informe.Cod_empresa + " WHERE No_contrato= " + Informe.No_contrato + ";");
        }
        public long Nuevo(M_Informe Informe)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"No_contrato", Informe.No_contrato},
           {"Deudacanon", Informe.Deudacanon},
           {"Deudaintrs", Informe.Deudaintrs},
           {"Dias", Informe.Dias},
           {"Cod_empresa", Informe.Cod_empresa}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Informe(?, ?, ?, ?, ?)}", Parametros);
        }

        public long BorrarDatos()
        {
            return Data.Accion("DELETE informe.* FROM informe");
        }
    }
}
