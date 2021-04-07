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
    public class N_Pagos_Propietarios : N_General
    {
        M_Pagos_Propietarios C_Pagos_Propietarios = new M_Pagos_Propietarios();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(string Tipo_comp, int No_comp, string Relacionmes, int Item, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Pagos_Propietarios WHERE Tipo_comp='" + Tipo_comp + "'" + " and No_comp=" + No_comp + " and Relacionmes='" + Relacionmes + "'" + " and Item=" + Item);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Pagos_Propietarios.Tipo_comp = DT.Rows[0]["Tipo_comp"].ToString();
                    C_Pagos_Propietarios.No_comp = Convert.ToInt32(DT.Rows[0]["No_comp"]);
                    C_Pagos_Propietarios.Relacionmes = DT.Rows[0]["Relacionmes"].ToString();
                    C_Pagos_Propietarios.Item = Convert.ToInt32(DT.Rows[0]["Item"]);
                    C_Pagos_Propietarios.Id_propietario = Convert.ToInt32(DT.Rows[0]["Id_propietario"]);
                    C_Pagos_Propietarios.Valor_pagado = Convert.ToDouble(DT.Rows[0]["Valor_pagado"]);
                    C_Pagos_Propietarios.Usu_cap = Convert.ToInt32(DT.Rows[0]["Usu_cap"]);
                    C_Pagos_Propietarios.Valor_iva = Convert.ToDouble(DT.Rows[0]["Valor_iva"]);
                    C_Pagos_Propietarios.Cod_empresa = Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                    C_Pagos_Propietarios.No_operacion = Convert.ToDouble(DT.Rows[0]["No_operacion"]);
                    C_Pagos_Propietarios.No_factura = Convert.ToInt32(DT.Rows[0]["No_factura"]);
                    C_Pagos_Propietarios.Tipo_comp_fra = DT.Rows[0]["Tipo_comp_fra"].ToString();
                }
            }
            return ExisteRegistro;
        }
        public M_Pagos_Propietarios Consultar(string Tipo_comp, int No_comp, string Relacionmes, int Item)
        {
            if (Existe(Tipo_comp, No_comp, Relacionmes, Item, true))
            {
                return C_Pagos_Propietarios;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM pagos_propietarios");
        }
        public DataTable Consultar(string Tipo_id, int Id, string DV)
        {
            return Data.ConsultaT("SELECT comprobantes.fecha, comprobantes.no_comp, pagos_propietarios.relacionmes, pagos_propietarios.valor_pagado, pagos_propietarios.valor_iva, Formas_pago.nombre_forma, IIf(comprobantes.clase_cuenta = 'A','Ahorros',IIf(comprobantes.clase_cuenta = 'C','Corriente','')) AS cta, comprobantes.num, comprobantes.entidad" +
                        " FROM formas_pago INNER JOIN(pagos_propietarios INNER JOIN comprobantes ON(pagos_propietarios.no_comp = comprobantes.no_comp) AND(pagos_propietarios.tipo_comp = comprobantes.tipo_comp)) ON formas_pago.forma = comprobantes.forma_pago" +
                        " WHERE (comprobantes.tipo_id = '" + Tipo_id + "' AND comprobantes.id =" + Id + ") AND (comprobantes.estado = 'A' Or comprobantes.estado = 'V')" +
                        " ORDER BY comprobantes.fecha;");
        }
        public long Insertar(M_Pagos_Propietarios Pagos_Propietarios)
        {
            return Data.Accion("INSERT INTO pagos_propietarios (Tipo_comp,No_comp,Relacionmes,Item,Id_propietario,Valor_pagado,Usu_cap,Valor_iva,Cod_empresa,No_operacion,No_factura,Tipo_comp_fra) VALUES (" + "'" + Pagos_Propietarios.Tipo_comp + "'" + "," + Pagos_Propietarios.No_comp + ", '" + Pagos_Propietarios.Relacionmes + "'" + "," + Pagos_Propietarios.Item + "," + Pagos_Propietarios.Id_propietario + "," + Pagos_Propietarios.Valor_pagado + "," + Pagos_Propietarios.Usu_cap + "," + Pagos_Propietarios.Valor_iva + "," + Pagos_Propietarios.Cod_empresa + "," + Pagos_Propietarios.No_operacion + "," + Pagos_Propietarios.No_factura + ", '" + Pagos_Propietarios.Tipo_comp_fra + "'" + ");");
        }
        public long Actualizar(M_Pagos_Propietarios Pagos_Propietarios)
        {
            return Data.Accion("UPDATE pagos_propietarios SET Tipo_comp='" + Pagos_Propietarios.Tipo_comp + "'" + ",No_comp=" + Pagos_Propietarios.No_comp + ",Relacionmes='" + Pagos_Propietarios.Relacionmes + "'" + ",Item=" + Pagos_Propietarios.Item + ",Id_propietario=" + Pagos_Propietarios.Id_propietario + ",Valor_pagado=" + Pagos_Propietarios.Valor_pagado + ",Usu_cap=" + Pagos_Propietarios.Usu_cap + ",Valor_iva=" + Pagos_Propietarios.Valor_iva + ",Cod_empresa=" + Pagos_Propietarios.Cod_empresa + ",No_operacion=" + Pagos_Propietarios.No_operacion + ",No_factura=" + Pagos_Propietarios.No_factura + ",Tipo_comp_fra='" + Pagos_Propietarios.Tipo_comp_fra + "'" + " WHERE Tipo_comp='" + Pagos_Propietarios.Tipo_comp + "'" + " and No_comp=" + Pagos_Propietarios.No_comp + " and Relacionmes='" + Pagos_Propietarios.Relacionmes + "'" + " and Item=" + Pagos_Propietarios.Item + ";");
        }
        public long Nuevo(M_Pagos_Propietarios Pagos_Propietarios)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Tipo_comp", Pagos_Propietarios.Tipo_comp},
           {"No_comp", Pagos_Propietarios.No_comp},
           {"Relacionmes", Pagos_Propietarios.Relacionmes},
           {"Item", Pagos_Propietarios.Item},
           {"Id_propietario", Pagos_Propietarios.Id_propietario},
           {"Valor_pagado", Pagos_Propietarios.Valor_pagado},
           {"Usu_cap", Pagos_Propietarios.Usu_cap},
           {"Valor_iva", Pagos_Propietarios.Valor_iva},
           {"Cod_empresa", Pagos_Propietarios.Cod_empresa},
           {"No_operacion", Pagos_Propietarios.No_operacion},
           {"No_factura", Pagos_Propietarios.No_factura},
           {"Tipo_comp_fra", Pagos_Propietarios.Tipo_comp_fra}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Pagos_Propietarios(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
        }
    }
}
