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
    public class N_Otroscomprobantes: N_General
    {
        public M_Otroscomprobantes C_Otroscomprobantes = new M_Otroscomprobantes();
        //ClsDatos Data = new ClsDatos();

        public bool Existe(string Tipo_comp, int No_comp, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM otroscomprobantes WHERE Tipo_comp='" + Tipo_comp + "'" + " and No_comp=" + No_comp);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Otroscomprobantes.Fecha = Convert.ToDateTime(DT.Rows[0]["Fecha"]);
                    C_Otroscomprobantes.Tipo_comp = DT.Rows[0]["Tipo_comp"].ToString();
                    C_Otroscomprobantes.No_comp = Convert.ToInt32(DT.Rows[0]["No_comp"]);
                    C_Otroscomprobantes.Tipo_id = DT.Rows[0]["Tipo_id"].ToString();
                    C_Otroscomprobantes.Id = Convert.ToInt32(DT.Rows[0]["Id"]);
                    C_Otroscomprobantes.Dv = DT.Rows[0]["Dv"].ToString();
                    C_Otroscomprobantes.Descripcion = DT.Rows[0]["Descripcion"].ToString();
                    C_Otroscomprobantes.Valor = Convert.ToDouble(DT.Rows[0]["Valor"]);
                    C_Otroscomprobantes.Forma_pago = Convert.ToInt32(DT.Rows[0]["Forma_pago"]);
                    C_Otroscomprobantes.Cod_cuenta = Convert.ToInt32(DT.Rows[0]["Cod_cuenta"]);
                    C_Otroscomprobantes.Clase_cuenta = DT.Rows[0]["Clase_cuenta"].ToString();
                    C_Otroscomprobantes.Num = DT.Rows[0]["Num"].ToString();
                    C_Otroscomprobantes.Entidad = DT.Rows[0]["Entidad"].ToString();
                    C_Otroscomprobantes.Estado = DT.Rows[0]["Estado"].ToString();
                    if (!string.IsNullOrWhiteSpace(DT.Rows[0]["FechaAplic"].ToString()))
                    {
                        C_Otroscomprobantes.FechaAplic = Convert.ToDateTime(DT.Rows[0]["FechaAplic"]);
                    }
                    else
                    {
                        //C_Otroscomprobantes.FechaAplic = null ;
                    }
                    C_Otroscomprobantes.Usu_cap = Convert.ToInt32(DT.Rows[0]["Usu_cap"]);
                    if (!string.IsNullOrWhiteSpace(DT.Rows[0]["Fecha_vence"].ToString()))
                    {
                        C_Otroscomprobantes.Fecha_vence = Convert.ToDateTime(DT.Rows[0]["Fecha_vence"]);
                    }
                    C_Otroscomprobantes.Cod_empresa = Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                    C_Otroscomprobantes.No_operacion = Convert.ToDouble(DT.Rows[0]["No_operacion"]);
                    C_Otroscomprobantes.Cod_concepto = Convert.ToInt32(DT.Rows[0]["Cod_concepto"]);
                    C_Otroscomprobantes.Valor_base = Convert.ToDouble(DT.Rows[0]["Valor_base"]);
                    C_Otroscomprobantes.Usu_aprueba = Convert.ToInt32(DT.Rows[0]["Usu_aprueba"]);
                    C_Otroscomprobantes.Estado_contab = Convert.ToInt32(DT.Rows[0]["Estado_contab"]);
                    C_Otroscomprobantes.Centro_costo = Convert.ToInt32(DT.Rows[0]["Centro_costo"]);
                    C_Otroscomprobantes.Seccion = Convert.ToInt32(DT.Rows[0]["Seccion"]);
                }
            }
            return ExisteRegistro;
        }

        public M_Otroscomprobantes Consultar(string Tipo_comp, int No_comp)
        {
            if (Existe(Tipo_comp, No_comp, true))
            {
                return C_Otroscomprobantes;
            }
            else
            {
                return null;
            }
        }
        public  DataTable ConsultaComprobantes(string FechaDesde, string FechaHasta)
        {
            if (Data.ConectaA == "Access")
            {
                return Data.ConsultaT("SELECT otroscomprobantes.fecha, otroscomprobantes.tipo_comp, Tipos_Comp.nombre_comp, otroscomprobantes.no_comp, otroscomprobantes.tipo_id, otroscomprobantes.id, otroscomprobantes.dv, (Auxiliares.nombre+' '+Auxiliares.apellido1+' '+Auxiliares.apellido2) AS nombre_tercero, otroscomprobantes.descripcion, otroscomprobantes.valor, otroscomprobantes.estado, otroscomprobantes.usu_cap, estados_comp.descripcion_estado, Formas_pago.nombre_forma" +
                    " FROM(Auxiliares INNER JOIN((otroscomprobantes INNER JOIN Tipos_Comp ON otroscomprobantes.tipo_comp = Tipos_Comp.tipo_comp) INNER JOIN estados_comp ON otroscomprobantes.estado = estados_comp.estado) ON(Auxiliares.tipo_aux = otroscomprobantes.tipo_id) AND(Auxiliares.id_aux = otroscomprobantes.id)) INNER JOIN Formas_pago ON otroscomprobantes.forma_pago = Formas_pago.forma" +
                    " WHERE otroscomprobantes.fecha BETWEEN #" + FechaDesde + "# AND #" + FechaHasta + "#" +
                    " ORDER BY otroscomprobantes.tipo_comp, otroscomprobantes.no_comp;");
            }
            else
            {
                return Data.ConsultaT("SELECT otroscomprobantes.fecha, otroscomprobantes.tipo_comp, Tipos_Comp.nombre_comp, otroscomprobantes.no_comp, otroscomprobantes.tipo_id, otroscomprobantes.id, otroscomprobantes.dv, (Auxiliares.nombre+' '+Auxiliares.apellido1+' '+Auxiliares.apellido2) AS nombre_tercero, otroscomprobantes.descripcion, otroscomprobantes.valor, otroscomprobantes.estado, otroscomprobantes.usu_cap, estados_comp.descripcion_estado, Formas_pago.nombre_forma" +
                    " FROM(Auxiliares INNER JOIN((otroscomprobantes INNER JOIN Tipos_Comp ON otroscomprobantes.tipo_comp = Tipos_Comp.tipo_comp) INNER JOIN estados_comp ON otroscomprobantes.estado = estados_comp.estado) ON(Auxiliares.tipo_aux = otroscomprobantes.tipo_id) AND(Auxiliares.id_aux = otroscomprobantes.id)) INNER JOIN Formas_pago ON otroscomprobantes.forma_pago = Formas_pago.forma" +
                    " WHERE otroscomprobantes.fecha BETWEEN #" + FechaDesde + "# AND #" + FechaHasta + "#" +
                    " ORDER BY otroscomprobantes.tipo_comp, otroscomprobantes.no_comp;");
            }
        }

        public DataTable TotalesComprobantes(string FechaDesde, string FechaHasta)
        {
            string CadSql = "SELECT otroscomprobantes.tipo_comp, otroscomprobantes.forma_pago, Count(otroscomprobantes.valor) AS Cantidad, Sum(otroscomprobantes.valor) AS Total " +
            " FROM otroscomprobantes " +
            " WHERE otroscomprobantes.fecha Between #" + FechaDesde +"# And #" + FechaHasta + "# AND otroscomprobantes.estado<>'D' " +
            " GROUP BY otroscomprobantes.tipo_comp, otroscomprobantes.forma_pago;";
            return Data.ConsultaT(CadSql);
        }

        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM otroscomprobantes");
        }

        public long Insertar(M_Otroscomprobantes Otroscomprobantes)
        {
            bool SinFechaAplic = false;
            bool SinFechaVence = false;
            string CadenaSql = "";
            long resultado = 0;
            
            if (string.IsNullOrWhiteSpace(Otroscomprobantes.FechaAplic.ToString()))
            {
                SinFechaAplic = true;
            }
            if (string.IsNullOrWhiteSpace(Otroscomprobantes.Fecha_vence.ToString()))
            {
                SinFechaVence = true;
            }
            CadenaSql = "INSERT INTO otroscomprobantes (Fecha,Tipo_comp,No_comp,Tipo_id,Id,Dv,Descripcion,Valor,Forma_pago,Cod_cuenta,Clase_cuenta,Num,Entidad,Estado,FechaAplic,Usu_cap,Fecha_vence,Cod_empresa,No_operacion,Cod_concepto,Valor_base,Usu_aprueba,Estado_contab,Centro_costo,Seccion) VALUES (#" + Otroscomprobantes.Fecha.ToString("yyyy/MM/dd") + "#, '" + Otroscomprobantes.Tipo_comp + "'" + "," + Otroscomprobantes.No_comp + ", '" + Otroscomprobantes.Tipo_id + "'" + "," + Otroscomprobantes.Id + ", '" + Otroscomprobantes.Dv + "'" + ", '" + Otroscomprobantes.Descripcion + "'" + "," + Otroscomprobantes.Valor + "," + Otroscomprobantes.Forma_pago + "," + Otroscomprobantes.Cod_cuenta + ", '" + Otroscomprobantes.Clase_cuenta + "'" + ", '" + Otroscomprobantes.Num + "'" + ", '" + Otroscomprobantes.Entidad + "'" + ", '" + Otroscomprobantes.Estado + "'" + ",#" + Otroscomprobantes.FechaAplic.ToString("yyyy/MM/dd") + "#," + Otroscomprobantes.Usu_cap + ",#" + Otroscomprobantes.Fecha_vence.ToString("yyyy/MM/dd") + "#," + Otroscomprobantes.Cod_empresa + "," + Otroscomprobantes.No_operacion + "," + Otroscomprobantes.Cod_concepto + "," + Otroscomprobantes.Valor_base + "," + Otroscomprobantes.Usu_aprueba + "," + Otroscomprobantes.Estado_contab + "," + Otroscomprobantes.Centro_costo + "," + Otroscomprobantes.Seccion + ");";
            if (!SinFechaAplic && !SinFechaVence)
            {
                CadenaSql = "INSERT INTO otroscomprobantes (Fecha,Tipo_comp,No_comp,Tipo_id,Id,Dv,Descripcion,Valor,Forma_pago,Cod_cuenta,Clase_cuenta,Num,Entidad,Estado,Usu_cap,Cod_empresa,No_operacion,Cod_concepto,Valor_base,Usu_aprueba,Estado_contab,Centro_costo,Seccion) VALUES (#" + Otroscomprobantes.Fecha.ToString("yyyy/MM/dd") + "#, '" + Otroscomprobantes.Tipo_comp + "'" + "," + Otroscomprobantes.No_comp + ", '" + Otroscomprobantes.Tipo_id + "'" + "," + Otroscomprobantes.Id + ", '" + Otroscomprobantes.Dv + "'" + ", '" + Otroscomprobantes.Descripcion + "'" + "," + Otroscomprobantes.Valor + "," + Otroscomprobantes.Forma_pago + "," + Otroscomprobantes.Cod_cuenta + ", '" + Otroscomprobantes.Clase_cuenta + "'" + ", '" + Otroscomprobantes.Num + "'" + ", '" + Otroscomprobantes.Entidad + "'" + ", '" + Otroscomprobantes.Estado + "'" + "," + Otroscomprobantes.Usu_cap + "," + Otroscomprobantes.Cod_empresa + "," + Otroscomprobantes.No_operacion + "," + Otroscomprobantes.Cod_concepto + "," + Otroscomprobantes.Valor_base + "," + Otroscomprobantes.Usu_aprueba + "," + Otroscomprobantes.Estado_contab + "," + Otroscomprobantes.Centro_costo + "," + Otroscomprobantes.Seccion + ");";
            }
            else
            {
                if (SinFechaAplic)
                {
                    CadenaSql = "INSERT INTO otroscomprobantes (Fecha,Tipo_comp,No_comp,Tipo_id,Id,Dv,Descripcion,Valor,Forma_pago,Cod_cuenta,Clase_cuenta,Num,Entidad,Estado,Usu_cap,Fecha_vence,Cod_empresa,No_operacion,Cod_concepto,Valor_base,Usu_aprueba,Estado_contab,Centro_costo,Seccion) VALUES (#" + Otroscomprobantes.Fecha.ToString("yyyy/MM/dd") + "#, '" + Otroscomprobantes.Tipo_comp + "'" + "," + Otroscomprobantes.No_comp + ", '" + Otroscomprobantes.Tipo_id + "'" + "," + Otroscomprobantes.Id + ", '" + Otroscomprobantes.Dv + "'" + ", '" + Otroscomprobantes.Descripcion + "'" + "," + Otroscomprobantes.Valor + "," + Otroscomprobantes.Forma_pago + "," + Otroscomprobantes.Cod_cuenta + ", '" + Otroscomprobantes.Clase_cuenta + "'" + ", '" + Otroscomprobantes.Num + "'" + ", '" + Otroscomprobantes.Entidad + "'" + ", '" + Otroscomprobantes.Estado + "'" + "," + Otroscomprobantes.Usu_cap + ",#" + Otroscomprobantes.Fecha_vence.ToString("yyyy/MM/dd") + "#," + Otroscomprobantes.Cod_empresa + "," + Otroscomprobantes.No_operacion + "," + Otroscomprobantes.Cod_concepto + "," + Otroscomprobantes.Valor_base + "," + Otroscomprobantes.Usu_aprueba + "," + Otroscomprobantes.Estado_contab + "," + Otroscomprobantes.Centro_costo + "," + Otroscomprobantes.Seccion + ");";
                }
                if (SinFechaVence)
                {
                    CadenaSql = "INSERT INTO otroscomprobantes (Fecha,Tipo_comp,No_comp,Tipo_id,Id,Dv,Descripcion,Valor,Forma_pago,Cod_cuenta,Clase_cuenta,Num,Entidad,Estado,FechaAplic,Usu_cap,Cod_empresa,No_operacion,Cod_concepto,Valor_base,Usu_aprueba,Estado_contab,Centro_costo,Seccion) VALUES (#" + Otroscomprobantes.Fecha.ToString("yyyy/MM/dd") + "#, '" + Otroscomprobantes.Tipo_comp + "'" + "," + Otroscomprobantes.No_comp + ", '" + Otroscomprobantes.Tipo_id + "'" + "," + Otroscomprobantes.Id + ", '" + Otroscomprobantes.Dv + "'" + ", '" + Otroscomprobantes.Descripcion + "'" + ",'" + Otroscomprobantes.Valor + "'," + Otroscomprobantes.Forma_pago + "," + Otroscomprobantes.Cod_cuenta + ", '" + Otroscomprobantes.Clase_cuenta + "'" + ", '" + Otroscomprobantes.Num + "'" + ", '" + Otroscomprobantes.Entidad + "'" + ", '" + Otroscomprobantes.Estado + "'" + ",#" + Otroscomprobantes.FechaAplic.ToString("yyyy/MM/dd") + "#," + Otroscomprobantes.Usu_cap + "," + Otroscomprobantes.Cod_empresa + "," + Otroscomprobantes.No_operacion + "," + Otroscomprobantes.Cod_concepto + "," + Otroscomprobantes.Valor_base + "," + Otroscomprobantes.Usu_aprueba + "," + Otroscomprobantes.Estado_contab + "," + Otroscomprobantes.Centro_costo + "," + Otroscomprobantes.Seccion + ");";
                }
            }
            //CadenaSql = CadenaSql.Replace("#", "'");
            resultado=Data.Accion(CadenaSql);
            if (resultado == 1)
            {
                //grabar en el saldo
                N_Saldos_Diarios SaldosDiarios = new N_Saldos_Diarios();
                
                //SaldosDiarios.Cadena(Data.GsPath, Data.ConectaA);
                if (C_Otroscomprobantes.Forma_pago==1)
                    resultado = SaldosDiarios.RegistrarMovimiento(C_Otroscomprobantes.Fecha, 2, C_Otroscomprobantes.Valor, C_Otroscomprobantes.Tipo_comp.ToString(), "+");
                if (C_Otroscomprobantes.Forma_pago==4)
                    resultado = SaldosDiarios.RegistrarMovimiento(C_Otroscomprobantes.Fecha, 21, C_Otroscomprobantes.Valor, C_Otroscomprobantes.Tipo_comp.ToString(), "+");
            }
            return resultado;
        }

        public long Anular(M_Otroscomprobantes Otroscomprobantes)
        {

            long resultado = Data.Accion("UPDATE otroscomprobantes SET estado='D' WHERE tipo_comp='" + Otroscomprobantes.Tipo_comp + "' AND no_comp=" + Otroscomprobantes.No_comp + ";");
            if (resultado == 1)
            {
                //grabar en el saldo
                N_Saldos_Diarios SaldosDiarios = new N_Saldos_Diarios();
                //SaldosDiarios.Cadena(Data.GsPath, Data.ConectaA);
                if (C_Otroscomprobantes.Forma_pago==1)
                    resultado = SaldosDiarios.RegistrarMovimiento(C_Otroscomprobantes.Fecha, 2, C_Otroscomprobantes.Valor, C_Otroscomprobantes.Tipo_comp.ToString(), "-");
                if (C_Otroscomprobantes.Forma_pago==4)
                    resultado = SaldosDiarios.RegistrarMovimiento(C_Otroscomprobantes.Fecha, 21, C_Otroscomprobantes.Valor, C_Otroscomprobantes.Tipo_comp.ToString(), "-");

            }
            return resultado;
        }

        public long Actualizar(M_Otroscomprobantes Otroscomprobantes)
        {
            bool SinFechaAplic=false;
            bool SinFechaVence = false;
            string CadenaSql = "";
            if (string.IsNullOrWhiteSpace(Otroscomprobantes.FechaAplic.ToString()))
            {
                SinFechaAplic = true;
            }
            if (string.IsNullOrWhiteSpace(Otroscomprobantes.Fecha_vence.ToString()))
            {
                SinFechaVence = true;
            }
            CadenaSql = "UPDATE otroscomprobantes SET Fecha=#" + Otroscomprobantes.Fecha.ToString("yyyy/MM/dd") + "#,Tipo_comp='" + Otroscomprobantes.Tipo_comp + "'" + ",No_comp=" + Otroscomprobantes.No_comp + ",Tipo_id='" + Otroscomprobantes.Tipo_id + "'" + ",Id=" + Otroscomprobantes.Id + ",Dv='" + Otroscomprobantes.Dv + "'" + ",Descripcion='" + Otroscomprobantes.Descripcion + "'" + ",Valor='" + Otroscomprobantes.Valor + "',Forma_pago=" + Otroscomprobantes.Forma_pago + ",Cod_cuenta=" + Otroscomprobantes.Cod_cuenta + ",Clase_cuenta='" + Otroscomprobantes.Clase_cuenta + "'" + ",Num='" + Otroscomprobantes.Num + "'" + ",Entidad='" + Otroscomprobantes.Entidad + "'" + ",Estado='" + Otroscomprobantes.Estado + "'" + ",FechaAplic=#" + Otroscomprobantes.FechaAplic.ToString("yyyy/MM/dd") + "#,Usu_cap=" + Otroscomprobantes.Usu_cap + ",Fecha_vence=#" + Otroscomprobantes.Fecha_vence.ToString("yyyy/MM/dd") + "#,Cod_empresa=" + Otroscomprobantes.Cod_empresa + ",No_operacion=" + Otroscomprobantes.No_operacion + ",Cod_concepto=" + Otroscomprobantes.Cod_concepto + ",Valor_base=" + Otroscomprobantes.Valor_base + ",Usu_aprueba=" + Otroscomprobantes.Usu_aprueba + ",Estado_contab=" + Otroscomprobantes.Estado_contab + ",Centro_costo=" + Otroscomprobantes.Centro_costo + ",Seccion=" + Otroscomprobantes.Seccion + " WHERE Tipo_comp='" + Otroscomprobantes.Tipo_comp + "'" + " and No_comp=" + Otroscomprobantes.No_comp + ";";
            if (!SinFechaAplic && !SinFechaVence)
            {
                CadenaSql = "UPDATE otroscomprobantes SET Fecha=#" + Otroscomprobantes.Fecha.ToString("yyyy/MM/dd") + "#,Tipo_comp='" + Otroscomprobantes.Tipo_comp + "'" + ",No_comp=" + Otroscomprobantes.No_comp + ",Tipo_id='" + Otroscomprobantes.Tipo_id + "'" + ",Id=" + Otroscomprobantes.Id + ",Dv='" + Otroscomprobantes.Dv + "'" + ",Descripcion='" + Otroscomprobantes.Descripcion + "'" + ",Valor='" + Otroscomprobantes.Valor + "',Forma_pago=" + Otroscomprobantes.Forma_pago + ",Cod_cuenta=" + Otroscomprobantes.Cod_cuenta + ",Clase_cuenta='" + Otroscomprobantes.Clase_cuenta + "'" + ",Num='" + Otroscomprobantes.Num + "'" + ",Entidad='" + Otroscomprobantes.Entidad + "'" + ",Estado='" + Otroscomprobantes.Estado + "'" + ",Usu_cap=" + Otroscomprobantes.Usu_cap +  ",Cod_empresa=" + Otroscomprobantes.Cod_empresa + ",No_operacion=" + Otroscomprobantes.No_operacion + ",Cod_concepto=" + Otroscomprobantes.Cod_concepto + ",Valor_base=" + Otroscomprobantes.Valor_base + ",Usu_aprueba=" + Otroscomprobantes.Usu_aprueba + ",Estado_contab=" + Otroscomprobantes.Estado_contab + ",Centro_costo=" + Otroscomprobantes.Centro_costo + ",Seccion=" + Otroscomprobantes.Seccion + " WHERE Tipo_comp='" + Otroscomprobantes.Tipo_comp + "'" + " and No_comp=" + Otroscomprobantes.No_comp + ";";
            }
            else
            {
                if (!SinFechaAplic)
                {
                    CadenaSql = "UPDATE otroscomprobantes SET Fecha=#" + Otroscomprobantes.Fecha.ToString("yyyy/MM/dd") + "#,Tipo_comp='" + Otroscomprobantes.Tipo_comp + "'" + ",No_comp=" + Otroscomprobantes.No_comp + ",Tipo_id='" + Otroscomprobantes.Tipo_id + "'" + ",Id=" + Otroscomprobantes.Id + ",Dv='" + Otroscomprobantes.Dv + "'" + ",Descripcion='" + Otroscomprobantes.Descripcion + "'" + ",Valor='" + Otroscomprobantes.Valor + "',Forma_pago=" + Otroscomprobantes.Forma_pago + ",Cod_cuenta=" + Otroscomprobantes.Cod_cuenta + ",Clase_cuenta='" + Otroscomprobantes.Clase_cuenta + "'" + ",Num='" + Otroscomprobantes.Num + "'" + ",Entidad='" + Otroscomprobantes.Entidad + "'" + ",Estado='" + Otroscomprobantes.Estado + "'" +  ",Usu_cap=" + Otroscomprobantes.Usu_cap + ",Fecha_vence=#" + Otroscomprobantes.Fecha_vence.ToString("yyyy/MM/dd") + "#,Cod_empresa=" + Otroscomprobantes.Cod_empresa + ",No_operacion=" + Otroscomprobantes.No_operacion + ",Cod_concepto=" + Otroscomprobantes.Cod_concepto + ",Valor_base=" + Otroscomprobantes.Valor_base + ",Usu_aprueba=" + Otroscomprobantes.Usu_aprueba + ",Estado_contab=" + Otroscomprobantes.Estado_contab + ",Centro_costo=" + Otroscomprobantes.Centro_costo + ",Seccion=" + Otroscomprobantes.Seccion + " WHERE Tipo_comp='" + Otroscomprobantes.Tipo_comp + "'" + " and No_comp=" + Otroscomprobantes.No_comp + ";";
                }
                if (!SinFechaVence)
                {
                    CadenaSql = "UPDATE otroscomprobantes SET Fecha=#" + Otroscomprobantes.Fecha.ToString("yyyy/MM/dd") + "#,Tipo_comp='" + Otroscomprobantes.Tipo_comp + "'" + ",No_comp=" + Otroscomprobantes.No_comp + ",Tipo_id='" + Otroscomprobantes.Tipo_id + "'" + ",Id=" + Otroscomprobantes.Id + ",Dv='" + Otroscomprobantes.Dv + "'" + ",Descripcion='" + Otroscomprobantes.Descripcion + "'" + ",Valor='" + Otroscomprobantes.Valor + "',Forma_pago=" + Otroscomprobantes.Forma_pago + ",Cod_cuenta=" + Otroscomprobantes.Cod_cuenta + ",Clase_cuenta='" + Otroscomprobantes.Clase_cuenta + "'" + ",Num='" + Otroscomprobantes.Num + "'" + ",Entidad='" + Otroscomprobantes.Entidad + "'" + ",Estado='" + Otroscomprobantes.Estado + "'" + ",FechaAplic=#" + Otroscomprobantes.FechaAplic.ToString("yyyy/MM/dd") + "#,Usu_cap=" + Otroscomprobantes.Usu_cap +  ",Cod_empresa=" + Otroscomprobantes.Cod_empresa + ",No_operacion=" + Otroscomprobantes.No_operacion + ",Cod_concepto=" + Otroscomprobantes.Cod_concepto + ",Valor_base=" + Otroscomprobantes.Valor_base + ",Usu_aprueba=" + Otroscomprobantes.Usu_aprueba + ",Estado_contab=" + Otroscomprobantes.Estado_contab + ",Centro_costo=" + Otroscomprobantes.Centro_costo + ",Seccion=" + Otroscomprobantes.Seccion + " WHERE Tipo_comp='" + Otroscomprobantes.Tipo_comp + "'" + " and No_comp=" + Otroscomprobantes.No_comp + ";";
                }
            }
            return Data.Accion(CadenaSql);
        }

        public long Nuevo(M_Otroscomprobantes Otroscomprobantes)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Fecha", Otroscomprobantes.Fecha.ToShortDateString()},
           {"Tipo_comp", Otroscomprobantes.Tipo_comp},
           {"No_comp", Otroscomprobantes.No_comp},
           {"Tipo_id", Otroscomprobantes.Tipo_id},
           {"Id", Otroscomprobantes.Id},
           {"Dv", Otroscomprobantes.Dv},
           {"Descripcion", Otroscomprobantes.Descripcion},
           {"Valor", Otroscomprobantes.Valor},
           {"Forma_pago", Otroscomprobantes.Forma_pago},
           {"Cod_cuenta", Otroscomprobantes.Cod_cuenta},
           {"Clase_cuenta", Otroscomprobantes.Clase_cuenta},
           {"Num", Otroscomprobantes.Num},
           {"Entidad", Otroscomprobantes.Entidad},
           {"Estado", Otroscomprobantes.Estado},
           {"FechaAplic", Otroscomprobantes.FechaAplic.ToShortDateString()},
           {"Usu_cap", Otroscomprobantes.Usu_cap},
           {"Fecha_vence", Otroscomprobantes.Fecha_vence.ToShortDateString()},
           {"Cod_empresa", Otroscomprobantes.Cod_empresa},
           {"No_operacion", Otroscomprobantes.No_operacion},
           {"Cod_concepto", Otroscomprobantes.Cod_concepto},
           {"Valor_base", Otroscomprobantes.Valor_base},
           {"Usu_aprueba", Otroscomprobantes.Usu_aprueba},
           {"Estado_contab", Otroscomprobantes.Estado_contab},
           {"Centro_costo", Otroscomprobantes.Centro_costo},
           {"Seccion", Otroscomprobantes.Seccion}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_otroscomprobantes(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
        }
    }
}
