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
    public class N_Descuentos_Prop : N_General
    {
        public M_Descuentos_Prop C_Descuentos_Prop = new M_Descuentos_Prop();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(int No_contrato, int Item, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Descuentos_Prop WHERE No_contrato= " + No_contrato + " and Item=" + Item);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Descuentos_Prop.No_contrato = Convert.ToInt32(DT.Rows[0]["No_contrato"]);
                    C_Descuentos_Prop.Item = Convert.ToInt32(DT.Rows[0]["Item"]);
                    C_Descuentos_Prop.Tipo_compRe = DT.Rows[0]["Tipo_compRe"].ToString();
                    C_Descuentos_Prop.No_compRe = Convert.ToInt32(DT.Rows[0]["No_compRe"]);
                    C_Descuentos_Prop.Tipo_compPa = DT.Rows[0]["Tipo_compPa"].ToString();
                    C_Descuentos_Prop.No_compPa = Convert.ToInt32(DT.Rows[0]["No_compPa"]);
                    C_Descuentos_Prop.Cod_descuento = Convert.ToInt32(DT.Rows[0]["Cod_descuento"]);
                    C_Descuentos_Prop.Descripcion = DT.Rows[0]["Descripcion"].ToString();
                    C_Descuentos_Prop.Valor = Convert.ToDouble(DT.Rows[0]["Valor"]);
                    C_Descuentos_Prop.Vr_desProp = Convert.ToDouble(DT.Rows[0]["Vr_desProp"]);
                    C_Descuentos_Prop.Usu_cap = Convert.ToInt32(DT.Rows[0]["Usu_cap"]);
                    C_Descuentos_Prop.FECHA = Convert.ToDateTime(DT.Rows[0]["FECHA"]);
                    C_Descuentos_Prop.No_operacion = Convert.ToDouble(DT.Rows[0]["No_operacion"]);
                    C_Descuentos_Prop.No_operacionpa = Convert.ToDouble(DT.Rows[0]["No_operacionpa"]);
                    C_Descuentos_Prop.Cod_inmueble = Convert.ToInt32(DT.Rows[0]["Cod_inmueble"]);
                }
            }
            return ExisteRegistro;
        }
        public M_Descuentos_Prop Consultar(int No_contrato, int Item)
        {
            if (Existe(No_contrato, Item, true))
            {
                return C_Descuentos_Prop;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Descuentos_Prop");
        }
        public DataTable Consultar(string TipoID, int ID, string TipoComp, int NoComprobante)
        {
            return Data.ConsultaT("SELECT Descuentos_Prop.*, Descuentos.nombre_desc" +
                " FROM Descuentos INNER JOIN Descuentos_Prop ON Descuentos.cod_descuento = Descuentos_Prop.cod_descuento" +
                " WHERE Descuentos_Prop.cod_inmueble In (SELECT prop_inmuebles.cod_inmueble FROM Prop_Inmuebles" +
                    " WHERE prop_inmuebles.tipo_id='" + TipoID + "' AND prop_inmuebles.id_propietario=" + ID + ")" +
                " AND descuentos_prop.tipo_compPa='" + TipoComp + "' and descuentos_prop.no_compPa=" + NoComprobante + ";");
        }
        public long Insertar(M_Descuentos_Prop Descuentos_Prop)
        {
            return Data.Accion("INSERT INTO Descuentos_Prop (No_contrato,Item,Tipo_compRe,No_compRe,Tipo_compPa,No_compPa,Cod_descuento,Descripcion,Valor,Vr_desProp,Usu_cap,FECHA,No_operacion,No_operacionpa,Cod_inmueble) VALUES (" + Descuentos_Prop.No_contrato + "," + Descuentos_Prop.Item + ", '" + Descuentos_Prop.Tipo_compRe + "'" + "," + Descuentos_Prop.No_compRe + ", '" + Descuentos_Prop.Tipo_compPa + "'" + "," + Descuentos_Prop.No_compPa + "," + Descuentos_Prop.Cod_descuento + ", '" + Descuentos_Prop.Descripcion + "'" + "," + Descuentos_Prop.Valor + "," + Descuentos_Prop.Vr_desProp + "," + Descuentos_Prop.Usu_cap + "," + Descuentos_Prop.FECHA + "," + Descuentos_Prop.No_operacion + "," + Descuentos_Prop.No_operacionpa + "," + Descuentos_Prop.Cod_inmueble + ");");
        }
        public long Actualizar(M_Descuentos_Prop Descuentos_Prop)
        {
            return Data.Accion("UPDATE Descuentos_Prop SET No_contrato=" + Descuentos_Prop.No_contrato + ",Item=" + Descuentos_Prop.Item + ",Tipo_compRe='" + Descuentos_Prop.Tipo_compRe + "'" + ",No_compRe=" + Descuentos_Prop.No_compRe + ",Tipo_compPa='" + Descuentos_Prop.Tipo_compPa + "'" + ",No_compPa=" + Descuentos_Prop.No_compPa + ",Cod_descuento=" + Descuentos_Prop.Cod_descuento + ",Descripcion='" + Descuentos_Prop.Descripcion + "'" + ",Valor=" + Descuentos_Prop.Valor + ",Vr_desProp=" + Descuentos_Prop.Vr_desProp + ",Usu_cap=" + Descuentos_Prop.Usu_cap + ",FECHA=" + Descuentos_Prop.FECHA + ",No_operacion=" + Descuentos_Prop.No_operacion + ",No_operacionpa=" + Descuentos_Prop.No_operacionpa + ",Cod_inmueble=" + Descuentos_Prop.Cod_inmueble + " WHERE No_contrato= " + Descuentos_Prop.No_contrato + " and Item=" + Descuentos_Prop.Item + ";");
        }
        public long Nuevo(M_Descuentos_Prop Descuentos_Prop)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"No_contrato", Descuentos_Prop.No_contrato},
           {"Item", Descuentos_Prop.Item},
           {"Tipo_compRe", Descuentos_Prop.Tipo_compRe},
           {"No_compRe", Descuentos_Prop.No_compRe},
           {"Tipo_compPa", Descuentos_Prop.Tipo_compPa},
           {"No_compPa", Descuentos_Prop.No_compPa},
           {"Cod_descuento", Descuentos_Prop.Cod_descuento},
           {"Descripcion", Descuentos_Prop.Descripcion},
           {"Valor", Descuentos_Prop.Valor},
           {"Vr_desProp", Descuentos_Prop.Vr_desProp},
           {"Usu_cap", Descuentos_Prop.Usu_cap},
           {"FECHA", Descuentos_Prop.FECHA},
           {"No_operacion", Descuentos_Prop.No_operacion},
           {"No_operacionpa", Descuentos_Prop.No_operacionpa},
           {"Cod_inmueble", Descuentos_Prop.Cod_inmueble}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Descuentos_Prop(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
        }
    }
}
