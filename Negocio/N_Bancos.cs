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
    public class N_Bancos : N_General
    {
        public M_Bancos C_Bancos = new M_Bancos();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(int Cod_banco, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Bancos WHERE Cod_banco= " + Cod_banco);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Bancos.Cod_banco = Convert.ToInt32(DT.Rows[0]["Cod_banco"]);
                    C_Bancos.Nombre_banco = DT.Rows[0]["Nombre_banco"].ToString();
                    C_Bancos.Cod_empresa = Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                    C_Bancos.No_id = Convert.ToDouble(DT.Rows[0]["No_id"]);
                    C_Bancos.Dv = DT.Rows[0]["Dv"].ToString();
                }
            }
            return ExisteRegistro;
        }
        public M_Bancos Consultar(int Cod_banco)
        {
            if (Existe(Cod_banco, true))
            {
                return C_Bancos;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Bancos");
        }
        public long Insertar(M_Bancos Bancos)
        {
            return Data.Accion("INSERT INTO Bancos (Cod_banco,Nombre_banco,Cod_empresa,No_id,Dv) VALUES (" + Bancos.Cod_banco + ", '" + Bancos.Nombre_banco + "'" + "," + Bancos.Cod_empresa + "," + Bancos.No_id + ", '" + Bancos.Dv + "'" + ");");
        }
        public long Actualizar(M_Bancos Bancos)
        {
            return Data.Accion("UPDATE Bancos SET Cod_banco=" + Bancos.Cod_banco + ",Nombre_banco='" + Bancos.Nombre_banco + "'" + ",Cod_empresa=" + Bancos.Cod_empresa + ",No_id=" + Bancos.No_id + ",Dv='" + Bancos.Dv + "'" + " WHERE Cod_banco= " + Bancos.Cod_banco + ";");
        }
        public long Nuevo(M_Bancos Bancos)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_banco", Bancos.Cod_banco},
           {"Nombre_banco", Bancos.Nombre_banco},
           {"Cod_empresa", Bancos.Cod_empresa},
           {"No_id", Bancos.No_id},
           {"Dv", Bancos.Dv}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Bancos(?, ?, ?, ?, ?)}", Parametros);
        }
    }
}
