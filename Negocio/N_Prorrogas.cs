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
    public class N_Prorrogas : N_General
    {
        public M_Prorrogas C_Prorrogas = new M_Prorrogas();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(int No_contrato, int Prorroga, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Prorrogas WHERE No_contrato= " + No_contrato + " and Prorroga=" + Prorroga);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Prorrogas.No_contrato = Convert.ToInt32(DT.Rows[0]["No_contrato"]);
                    C_Prorrogas.Prorroga = Convert.ToInt32(DT.Rows[0]["Prorroga"]);
                    C_Prorrogas.Fecha_inicio = Convert.ToDateTime(DT.Rows[0]["Fecha_inicio"]);
                    C_Prorrogas.Fecha_vencimiento = Convert.ToDateTime(DT.Rows[0]["Fecha_vencimiento"]);
                    C_Prorrogas.Canon = Convert.ToDouble(DT.Rows[0]["Canon"]);
                    C_Prorrogas.Canonprop = Convert.ToDouble(DT.Rows[0]["Canonprop"]);
                }
            }
            return ExisteRegistro;
        }
        public M_Prorrogas Consultar(int No_contrato, int Prorroga)
        {
            if (Existe(No_contrato, Prorroga, true))
            {
                return C_Prorrogas;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar(int No_contrato)
        {
            return Data.ConsultaT("SELECT * FROM Prorrogas WHERE no_contrato=" + No_contrato);
        }

        public DataTable Consultar(int No_contrato, DateTime Fecha)
        {
            return Data.ConsultaT("select * from Prorrogas where no_contrato=" + No_contrato + " and (fecha_inicio<=#" + Fecha.ToString("yyyy/MM/dd") + "# and fecha_vencimiento>=#" + Fecha.ToString("yyyy/MM/dd") + "#)");
        }

        public double CanonInqXFecha(int No_contrato, DateTime Fecha)
        {
            DataTable DT = new DataTable();
            DT= Data.ConsultaT("SELECT canon FROM Prorrogas WHERE no_contrato=" + No_contrato + " and (fecha_inicio<=#" + Fecha.ToString("yyyy/MM/dd") + "# and fecha_vencimiento>=#" + Fecha.ToString("yyyy/MM/dd") + "#)");
            if (DT.Rows.Count > 0) return Convert.ToDouble(DT.Rows[0]["Canon"]);
            else return 0;
        }

        public long Insertar(M_Prorrogas Prorrogas)
        {
            return Data.Accion("INSERT INTO Prorrogas (No_contrato,Prorroga,Fecha_inicio,Fecha_vencimiento,Canon,Canonprop) VALUES (" + Prorrogas.No_contrato + "," + Prorrogas.Prorroga + "," + Prorrogas.Fecha_inicio + "," + Prorrogas.Fecha_vencimiento + "," + Prorrogas.Canon + "," + Prorrogas.Canonprop + ");");
        }
        public long Actualizar(M_Prorrogas Prorrogas)
        {
            return Data.Accion("UPDATE Prorrogas SET No_contrato=" + Prorrogas.No_contrato + ",Prorroga=" + Prorrogas.Prorroga + ",Fecha_inicio=" + Prorrogas.Fecha_inicio + ",Fecha_vencimiento=" + Prorrogas.Fecha_vencimiento + ",Canon=" + Prorrogas.Canon + ",Canonprop=" + Prorrogas.Canonprop + " WHERE No_contrato= " + Prorrogas.No_contrato + " and Prorroga=" + Prorrogas.Prorroga + ";");
        }
        public long Nuevo(M_Prorrogas Prorrogas)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"No_contrato", Prorrogas.No_contrato},
           {"Prorroga", Prorrogas.Prorroga},
           {"Fecha_inicio", Prorrogas.Fecha_inicio},
           {"Fecha_vencimiento", Prorrogas.Fecha_vencimiento},
           {"Canon", Prorrogas.Canon},
           {"Canonprop", Prorrogas.Canonprop}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Prorrogas(?, ?, ?, ?, ?, ?)}", Parametros);
        }
    }
}
