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
    public class N_Detalle_PagoProp : N_General
    {
        public M_Detalle_PagoProp C_Detalle_PagoProp = new M_Detalle_PagoProp();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(string Tipo_comp, int No_comp, int No_contrato, string Relacionmes, int Item, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Detalle_PagoProp WHERE Tipo_comp='" + Tipo_comp + "'" + " and No_comp=" + No_comp + " and No_contrato=" + No_contrato + " and Relacionmes='" + Relacionmes + "'" + " and Item=" + Item);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Detalle_PagoProp.Tipo_comp = DT.Rows[0]["Tipo_comp"].ToString();
                    C_Detalle_PagoProp.No_comp = Convert.ToInt32(DT.Rows[0]["No_comp"]);
                    C_Detalle_PagoProp.No_contrato = Convert.ToInt32(DT.Rows[0]["No_contrato"]);
                    C_Detalle_PagoProp.Relacionmes = DT.Rows[0]["Relacionmes"].ToString();
                    C_Detalle_PagoProp.Item = Convert.ToInt32(DT.Rows[0]["Item"]);
                    C_Detalle_PagoProp.Periodo = DT.Rows[0]["Periodo"].ToString();
                    C_Detalle_PagoProp.Canon = Convert.ToDouble(DT.Rows[0]["Canon"]);
                    C_Detalle_PagoProp.Tasa_admon = Convert.ToDouble(DT.Rows[0]["Tasa_admon"]);
                    C_Detalle_PagoProp.Valor_pagado = Convert.ToDouble(DT.Rows[0]["Valor_pagado"]);
                    C_Detalle_PagoProp.Tasa_iva = Convert.ToDouble(DT.Rows[0]["Tasa_iva"]);
                    C_Detalle_PagoProp.No_operacion = Convert.ToDouble(DT.Rows[0]["No_operacion"]);
                    C_Detalle_PagoProp.Condominio = Convert.ToDouble(DT.Rows[0]["Condominio"]);
                    C_Detalle_PagoProp.Tasa_comision_admon = Convert.ToDouble(DT.Rows[0]["Tasa_comision_admon"]);
                }
            }
            return ExisteRegistro;
        }

        public M_Detalle_PagoProp Consultar(string Tipo_comp, int No_comp, int No_contrato, string Relacionmes, int Item)
        {
            if (Existe(Tipo_comp, No_comp, No_contrato, Relacionmes, Item, true))
            {
                return C_Detalle_PagoProp;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Detalle_PagoProp");
        }
        public DataTable Consultar(string Tipo_comp, int No_comp)
        {
            return Data.ConsultaT("SELECT *, ROUND(canon*tasa_admon,0) as comision, ROUND(ROUND(canon*tasa_admon,0)*tasa_iva,0) as iva, ROUND(condominio*tasa_comision_admon,0) as comision_admon, "+
            " (SELECT cod_inmueble FROM contrato_arren WHERE no_contrato = detalle_pagoprop.no_contrato) as inmueble FROM Detalle_PagoProp WHERE tipo_comp='" + Tipo_comp +"' AND no_comp="+ No_comp);
        }
        public DataTable ConsultaConsolidada(string Tipo_comp, int No_comp)
        {
            return Data.ConsultaT("SELECT Detalle_PagoProp.no_comp, Detalle_PagoProp.no_contrato, Detalle_PagoProp.periodo, Detalle_PagoProp.canon, Detalle_PagoProp.tasa_admon, Round(detalle_pagoprop.canon*detalle_pagoprop.tasa_admon,0) AS comision, Detalle_PagoProp.tasa_iva, Round((detalle_pagoprop.canon*detalle_pagoprop.tasa_admon)*tasa_iva,0) AS iva, Detalle_PagoProp.condominio, Detalle_PagoProp.tasa_comision_admon, Round(detalle_pagoprop.condominio*tasa_comision_admon,0) AS comision_admon, (SELECT Sum(descuentos_prop.vr_desProp) AS descuentos" +                        " FROM descuentos_prop WHERE(((descuentos_prop.tipo_compPa) = pagos_propietarios.tipo_comp)"+
                        " AND((descuentos_prop.no_compPa) = pagos_propietarios.no_comp)" +
                        " AND((descuentos_prop.cod_inmueble) = contrato_arren.cod_inmueble))) AS descuentos,"+
                        " (select sum(valor) from otrospagos where tipo_compPa = pagos_propietarios.tipo_comp and no_compPa = pagos_propietarios.no_comp and cod_inmueble = contrato_arren.cod_inmueble) AS otrospagos"+
                    " FROM contrato_arren INNER JOIN(pagos_propietarios INNER JOIN detalle_pagoprop ON (Pagos_Propietarios.item = Detalle_PagoProp.item) AND(Pagos_Propietarios.relacionmes = Detalle_PagoProp.relacionmes) AND(Pagos_Propietarios.no_comp = Detalle_PagoProp.no_comp) AND(Pagos_Propietarios.tipo_comp = Detalle_PagoProp.tipo_comp)) ON Contrato_Arren.no_contrato = Detalle_PagoProp.no_contrato"+
                    " WHERE Pagos_Propietarios.tipo_comp = '" + Tipo_comp +  "' AND Pagos_Propietarios.no_comp = " + No_comp+ ";");
        }
        public long Insertar(M_Detalle_PagoProp Detalle_PagoProp)
        {
            return Data.Accion("INSERT INTO Detalle_PagoProp (Tipo_comp,No_comp,No_contrato,Relacionmes,Item,Periodo,Canon,Tasa_admon,Valor_pagado,Tasa_iva,No_operacion,Condominio,Tasa_comision_admon) VALUES (" + "'" + Detalle_PagoProp.Tipo_comp + "'" + "," + Detalle_PagoProp.No_comp + "," + Detalle_PagoProp.No_contrato + ", '" + Detalle_PagoProp.Relacionmes + "'" + "," + Detalle_PagoProp.Item + ", '" + Detalle_PagoProp.Periodo + "'" + "," + Detalle_PagoProp.Canon + "," + Detalle_PagoProp.Tasa_admon + "," + Detalle_PagoProp.Valor_pagado + "," + Detalle_PagoProp.Tasa_iva + "," + Detalle_PagoProp.No_operacion + "," + Detalle_PagoProp.Condominio + "," + Detalle_PagoProp.Tasa_comision_admon + ");");
        }
        public long Actualizar(M_Detalle_PagoProp Detalle_PagoProp)
        {
            return Data.Accion("UPDATE Detalle_PagoProp SET Tipo_comp='" + Detalle_PagoProp.Tipo_comp + "'" + ",No_comp=" + Detalle_PagoProp.No_comp + ",No_contrato=" + Detalle_PagoProp.No_contrato + ",Relacionmes='" + Detalle_PagoProp.Relacionmes + "'" + ",Item=" + Detalle_PagoProp.Item + ",Periodo='" + Detalle_PagoProp.Periodo + "'" + ",Canon=" + Detalle_PagoProp.Canon + ",Tasa_admon=" + Detalle_PagoProp.Tasa_admon + ",Valor_pagado=" + Detalle_PagoProp.Valor_pagado + ",Tasa_iva=" + Detalle_PagoProp.Tasa_iva + ",No_operacion=" + Detalle_PagoProp.No_operacion + ",Condominio=" + Detalle_PagoProp.Condominio + ",Tasa_comision_admon=" + Detalle_PagoProp.Tasa_comision_admon + " WHERE Tipo_comp='" + Detalle_PagoProp.Tipo_comp + "'" + " and No_comp=" + Detalle_PagoProp.No_comp + " and No_contrato=" + Detalle_PagoProp.No_contrato + " and Relacionmes='" + Detalle_PagoProp.Relacionmes + "'" + " and Item=" + Detalle_PagoProp.Item + ";");
        }
        public long Nuevo(M_Detalle_PagoProp Detalle_PagoProp)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Tipo_comp", Detalle_PagoProp.Tipo_comp},
           {"No_comp", Detalle_PagoProp.No_comp},
           {"No_contrato", Detalle_PagoProp.No_contrato},
           {"Relacionmes", Detalle_PagoProp.Relacionmes},
           {"Item", Detalle_PagoProp.Item},
           {"Periodo", Detalle_PagoProp.Periodo},
           {"Canon", Detalle_PagoProp.Canon},
           {"Tasa_admon", Detalle_PagoProp.Tasa_admon},
           {"Valor_pagado", Detalle_PagoProp.Valor_pagado},
           {"Tasa_iva", Detalle_PagoProp.Tasa_iva},
           {"No_operacion", Detalle_PagoProp.No_operacion},
           {"Condominio", Detalle_PagoProp.Condominio},
           {"Tasa_comision_admon", Detalle_PagoProp.Tasa_comision_admon}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Detalle_PagoProp(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
        }
    }
}
