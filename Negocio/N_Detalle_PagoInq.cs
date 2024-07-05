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
    public class N_Detalle_PagoInq : N_General
    {
        M_Detalle_PagoInq C_Detalle_PagoInq = new M_Detalle_PagoInq();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(int No_comp, int Codigo, int Item, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Detalle_PagoInq WHERE No_comp= " + No_comp + " and Codigo=" + Codigo + " and Item=" + Item);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Detalle_PagoInq.Tipo_comp = DT.Rows[0]["Tipo_comp"].ToString();
                    C_Detalle_PagoInq.No_comp = Convert.ToInt32(DT.Rows[0]["No_comp"]);
                    C_Detalle_PagoInq.Codigo = Convert.ToInt32(DT.Rows[0]["Codigo"]);
                    C_Detalle_PagoInq.No_contrato = Convert.ToInt32(DT.Rows[0]["No_contrato"]);
                    C_Detalle_PagoInq.Mes = DT.Rows[0]["Mes"].ToString();
                    C_Detalle_PagoInq.Periodo = DT.Rows[0]["Periodo"].ToString();
                    C_Detalle_PagoInq.Fechapago = Convert.ToDateTime(DT.Rows[0]["Fechapago"]);
                    C_Detalle_PagoInq.Canon = Convert.ToDouble(DT.Rows[0]["Canon"]);
                    C_Detalle_PagoInq.Diasven = Convert.ToDouble(DT.Rows[0]["Diasven"]);
                    C_Detalle_PagoInq.Intereses = Convert.ToDouble(DT.Rows[0]["Intereses"]);
                    C_Detalle_PagoInq.Item = Convert.ToInt32(DT.Rows[0]["Item"]);
                    C_Detalle_PagoInq.Tasa_iva = Convert.ToDouble(DT.Rows[0]["Tasa_iva"]);
                    C_Detalle_PagoInq.No_operacion = Convert.ToDouble(DT.Rows[0]["No_operacion"]);
                    C_Detalle_PagoInq.No_factura = Convert.ToInt32(DT.Rows[0]["No_factura"]);
                }
            }
            return ExisteRegistro;
        }
        public M_Detalle_PagoInq Consultar(int No_comp, int Codigo, int Item)
        {
            if (Existe(No_comp, Codigo, Item, true))
            {
                return C_Detalle_PagoInq;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar (int No_comp)
        {
            return Data.ConsultaT("SELECT * FROM Detalle_PagoInq WHERE No_comp=" + No_comp);
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Detalle_PagoInq");
        }
        public long Insertar(M_Detalle_PagoInq Detalle_PagoInq)
        {
            return Data.Accion("INSERT INTO Detalle_PagoInq (Tipo_comp,No_comp,Codigo,No_contrato,Mes,Periodo,Fechapago,Canon,Diasven,Intereses,Item,Tasa_iva,No_operacion,No_factura) VALUES (" + "'" + Detalle_PagoInq.Tipo_comp + "'" + "," + Detalle_PagoInq.No_comp + "," + Detalle_PagoInq.Codigo + "," + Detalle_PagoInq.No_contrato + ", '" + Detalle_PagoInq.Mes + "'" + ", '" + Detalle_PagoInq.Periodo + "'" + "," + Detalle_PagoInq.Fechapago + "," + Detalle_PagoInq.Canon + "," + Detalle_PagoInq.Diasven + "," + Detalle_PagoInq.Intereses + "," + Detalle_PagoInq.Item + "," + Detalle_PagoInq.Tasa_iva + "," + Detalle_PagoInq.No_operacion + "," + Detalle_PagoInq.No_factura + ");");
        }
        public long Actualizar(M_Detalle_PagoInq Detalle_PagoInq)
        {
            return Data.Accion("UPDATE Detalle_PagoInq SET Tipo_comp='" + Detalle_PagoInq.Tipo_comp + "'" + ",No_comp=" + Detalle_PagoInq.No_comp + ",Codigo=" + Detalle_PagoInq.Codigo + ",No_contrato=" + Detalle_PagoInq.No_contrato + ",Mes='" + Detalle_PagoInq.Mes + "'" + ",Periodo='" + Detalle_PagoInq.Periodo + "'" + ",Fechapago=" + Detalle_PagoInq.Fechapago + ",Canon=" + Detalle_PagoInq.Canon + ",Diasven=" + Detalle_PagoInq.Diasven + ",Intereses=" + Detalle_PagoInq.Intereses + ",Item=" + Detalle_PagoInq.Item + ",Tasa_iva=" + Detalle_PagoInq.Tasa_iva + ",No_operacion=" + Detalle_PagoInq.No_operacion + ",No_factura=" + Detalle_PagoInq.No_factura + " WHERE No_comp= " + Detalle_PagoInq.No_comp + " and Codigo=" + Detalle_PagoInq.Codigo + " and Item=" + Detalle_PagoInq.Item + ";");
        }
        public long Nuevo(M_Detalle_PagoInq Detalle_PagoInq)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Tipo_comp", Detalle_PagoInq.Tipo_comp},
           {"No_comp", Detalle_PagoInq.No_comp},
           {"Codigo", Detalle_PagoInq.Codigo},
           {"No_contrato", Detalle_PagoInq.No_contrato},
           {"Mes", Detalle_PagoInq.Mes},
           {"Periodo", Detalle_PagoInq.Periodo},
           {"Fechapago", Detalle_PagoInq.Fechapago},
           {"Canon", Detalle_PagoInq.Canon},
           {"Diasven", Detalle_PagoInq.Diasven},
           {"Intereses", Detalle_PagoInq.Intereses},
           {"Item", Detalle_PagoInq.Item},
           {"Tasa_iva", Detalle_PagoInq.Tasa_iva},
           {"No_operacion", Detalle_PagoInq.No_operacion},
           {"No_factura", Detalle_PagoInq.No_factura}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Detalle_PagoInq(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
        }
    }
}
