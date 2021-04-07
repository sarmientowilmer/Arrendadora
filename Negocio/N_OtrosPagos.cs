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
    public class N_OtrosPagos : N_General
    {
        public M_OtrosPagos C_OtrosPagos = new M_OtrosPagos();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(int Cod_inmueble, int Item, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM otrospagos WHERE Cod_inmueble= " + Cod_inmueble + " and Item=" + Item);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_OtrosPagos.Cod_inmueble = Convert.ToInt32(DT.Rows[0]["Cod_inmueble"]);
                    C_OtrosPagos.Item = Convert.ToInt32(DT.Rows[0]["Item"]);
                    C_OtrosPagos.Tipo_compPa = DT.Rows[0]["Tipo_compPa"].ToString();
                    C_OtrosPagos.No_compPa = Convert.ToInt32(DT.Rows[0]["No_compPa"]);
                    C_OtrosPagos.Descripcion = DT.Rows[0]["Descripcion"].ToString();
                    C_OtrosPagos.Valor = Convert.ToDouble(DT.Rows[0]["Valor"]);
                    C_OtrosPagos.No_operacion = Convert.ToDouble(DT.Rows[0]["No_operacion"]);
                }
            }
            return ExisteRegistro;
        }
        public M_OtrosPagos Consultar(int Cod_inmueble, int Item)
        {
            if (Existe(Cod_inmueble, Item, true))
            {
                return C_OtrosPagos;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM otrospagos");
        }
        public DataTable Consultar(string TipoID, int ID, string TipoComp, int NoComprobante)
        {
            return Data.ConsultaT("SELECT *" +
                " FROM otrospagos" +
                " WHERE (cod_inmueble In (select cod_inmueble from prop_inmuebles where tipo_id='" + TipoID + "' and id_propietario=" + ID + ")) AND (tipo_compPa='" + TipoComp + "' AND no_compPa=" + NoComprobante + ");");
        }
        public long Insertar(M_OtrosPagos OtrosPagos)
        {
            return Data.Accion("INSERT INTO otrospagos (Cod_inmueble,Item,Tipo_compPa,No_compPa,Descripcion,Valor,No_operacion) VALUES (" + OtrosPagos.Cod_inmueble + "," + OtrosPagos.Item + ", '" + OtrosPagos.Tipo_compPa + "'" + "," + OtrosPagos.No_compPa + ", '" + OtrosPagos.Descripcion + "'" + "," + OtrosPagos.Valor + "," + OtrosPagos.No_operacion + ");");
        }
        public long Actualizar(M_OtrosPagos OtrosPagos)
        {
            return Data.Accion("UPDATE otrospagos SET Cod_inmueble=" + OtrosPagos.Cod_inmueble + ",Item=" + OtrosPagos.Item + ",Tipo_compPa='" + OtrosPagos.Tipo_compPa + "'" + ",No_compPa=" + OtrosPagos.No_compPa + ",Descripcion='" + OtrosPagos.Descripcion + "'" + ",Valor=" + OtrosPagos.Valor + ",No_operacion=" + OtrosPagos.No_operacion + " WHERE Cod_inmueble= " + OtrosPagos.Cod_inmueble + " and Item=" + OtrosPagos.Item + ";");
        }
        public long Nuevo(M_OtrosPagos OtrosPagos)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_inmueble", OtrosPagos.Cod_inmueble},
           {"Item", OtrosPagos.Item},
           {"Tipo_compPa", OtrosPagos.Tipo_compPa},
           {"No_compPa", OtrosPagos.No_compPa},
           {"Descripcion", OtrosPagos.Descripcion},
           {"Valor", OtrosPagos.Valor},
           {"No_operacion", OtrosPagos.No_operacion}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_OtrosPagos(?, ?, ?, ?, ?, ?, ?)}", Parametros);
        }
    }
}
