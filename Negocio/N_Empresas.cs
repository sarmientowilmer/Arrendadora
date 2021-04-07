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
    public class N_Empresas : N_General
    {
        public M_Empresas C_Empresas = new M_Empresas();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Empresas");
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Empresas.Cod_empresa = Convert.ToByte(DT.Rows[0]["Cod_empresa"]);
                    C_Empresas.Nombre_empresa = DT.Rows[0]["Nombre_empresa"].ToString();
                    C_Empresas.Direccion_empresa = DT.Rows[0]["Direccion_empresa"].ToString();
                    C_Empresas.Telefono_empresa = DT.Rows[0]["Telefono_empresa"].ToString();
                    C_Empresas.Fax_empresa = DT.Rows[0]["Fax_empresa"].ToString();
                    C_Empresas.Logo_empresa = (byte[])DT.Rows[0]["Logo_empresa"];
                    //C_Empresas.Fondo_empresa = (byte[])(DT.Rows[0]["Fondo_empresa"]);
                    C_Empresas.Encabezado = DT.Rows[0]["Encabezado"].ToString();
                    C_Empresas.Observaciones = DT.Rows[0]["Observaciones"].ToString();
                    C_Empresas.Pie = DT.Rows[0]["Pie"].ToString();
                    C_Empresas.Resolucion = DT.Rows[0]["Resolucion"].ToString();
                    C_Empresas.Regimen = DT.Rows[0]["Regimen"].ToString();
                    C_Empresas.Periodo_fiscal = Convert.ToInt32(DT.Rows[0]["Periodo_fiscal"]);
                    C_Empresas.Año_periodo_fiscal = Convert.ToInt32(DT.Rows[0]["Año_periodo_fiscal"]);
                    C_Empresas.Periodo_contable = Convert.ToInt32(DT.Rows[0]["Periodo_contable"]);
                    C_Empresas.Clase = Convert.ToInt32(DT.Rows[0]["Clase"]);
                    C_Empresas.Grupo = Convert.ToInt32(DT.Rows[0]["Grupo"]);
                    C_Empresas.Cuenta = Convert.ToInt32(DT.Rows[0]["Cuenta"]);
                    C_Empresas.Subcuenta = Convert.ToInt32(DT.Rows[0]["Subcuenta"]);
                    C_Empresas.Tasamora = Convert.ToDouble(DT.Rows[0]["Tasamora"]);
                    C_Empresas.Iva = Convert.ToDouble(DT.Rows[0]["Iva"]);
                    C_Empresas.Retencionarren = Convert.ToDouble(DT.Rows[0]["Retencionarren"]);
                    C_Empresas.Diasgracia = Convert.ToInt32(DT.Rows[0]["Diasgracia"]);
                    C_Empresas.Maxcodeudor = Convert.ToInt32(DT.Rows[0]["Maxcodeudor"]);
                    C_Empresas.Maxdiasven = Convert.ToInt32(DT.Rows[0]["Maxdiasven"]);
                    C_Empresas.Montoretension = Convert.ToDouble(DT.Rows[0]["Montoretension"]);
                    C_Empresas.BotonNoCobrarIntereses = Convert.ToBoolean(DT.Rows[0]["BotonNoCobrarIntereses"]);
                    C_Empresas.Periodoapagar = DT.Rows[0]["Periodoapagar"].ToString();
                    C_Empresas.Fecha = Convert.ToDateTime(DT.Rows[0]["Fecha"]);
                    C_Empresas.Diaini = Convert.ToInt32(DT.Rows[0]["Diaini"]);
                    C_Empresas.Diafin = Convert.ToInt32(DT.Rows[0]["Diafin"]);
                    C_Empresas.MESCON = Convert.ToDateTime(DT.Rows[0]["MESCON"]);
                    C_Empresas.INMUEBLE = Convert.ToInt32(DT.Rows[0]["INMUEBLE"]);
                    C_Empresas.FechaProc = Convert.ToDateTime(DT.Rows[0]["FechaProc"]);
                    C_Empresas.EstadoFecha = Convert.ToInt32(DT.Rows[0]["EstadoFecha"]);
                    C_Empresas.Tasa_iva_admon = Convert.ToDouble(DT.Rows[0]["Tasa_iva_admon"]);
                    C_Empresas.Tasa_iva_arren = Convert.ToDouble(DT.Rows[0]["Tasa_iva_arren"]);
                    C_Empresas.Tasa_imporenta = Convert.ToDouble(DT.Rows[0]["Tasa_imporenta"]);
                    C_Empresas.PmP = Convert.ToDouble(DT.Rows[0]["PmP"]);
                    C_Empresas.Nombre_RL = DT.Rows[0]["Nombre_RL"].ToString();
                    C_Empresas.Nombre_contador = DT.Rows[0]["Nombre_contador"].ToString();
                    C_Empresas.Tipo_id_RL = DT.Rows[0]["Tipo_id_RL"].ToString();
                    C_Empresas.No_Id_RL = Convert.ToDouble(DT.Rows[0]["No_Id_RL"]);
                    C_Empresas.Exp_Id_RL = DT.Rows[0]["Exp_Id_RL"].ToString();
                    C_Empresas.Tp_contador = DT.Rows[0]["Tp_contador"].ToString();
                    C_Empresas.Revisor_fiscal = DT.Rows[0]["Revisor_fiscal"].ToString();
                    C_Empresas.Tp_revisorfiscal = DT.Rows[0]["Tp_revisorfiscal"].ToString();
                    C_Empresas.Mensajeinvinq = DT.Rows[0]["Mensajeinvinq"].ToString();
                    C_Empresas.Tipo_id = DT.Rows[0]["Tipo_id"].ToString();
                    C_Empresas.Id_empresa = Convert.ToDouble(DT.Rows[0]["Id_empresa"]);
                    C_Empresas.Dv_empresa = DT.Rows[0]["Dv_empresa"].ToString();
                    C_Empresas.Contab_causacion = Convert.ToBoolean(DT.Rows[0]["Contab_causacion"]);
                    C_Empresas.Ciudad = Convert.ToInt32(DT.Rows[0]["Ciudad"]);
                }
            }
            return ExisteRegistro;
        }
        //public M_Empresas Consultar()
        //{
        //    if (Existe(Tipo_id, Id_deudor, true))
        //    {
        //        return C_Empresas;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Empresas");
        }
        public long Insertar(M_Empresas Empresas)
        {
            return Data.Accion("INSERT INTO Empresas (Cod_empresa,Nombre_empresa,Direccion_empresa,Telefono_empresa,Fax_empresa,Logo_empresa,Fondo_empresa,Encabezado,Observaciones,Pie,Resolucion,Regimen,Periodo_fiscal,Año_periodo_fiscal,Periodo_contable,Clase,Grupo,Cuenta,Subcuenta,Tasamora,Iva,Retencionarren,Diasgracia,Maxcodeudor,Maxdiasven,Montoretension,BotonNoCobrarIntereses,Periodoapagar,Fecha,Diaini,Diafin,MESCON,INMUEBLE,FechaProc,EstadoFecha,Tasa_iva_admon,Tasa_iva_arren,Tasa_imporenta,PmP,Nombre_RL,Nombre_contador,Tipo_id_RL,No_Id_RL,Exp_Id_RL,Tp_contador,Revisor_fiscal,Tp_revisorfiscal,Mensajeinvinq,Tipo_id,Id_empresa,Dv_empresa,Contab_causacion,Ciudad) VALUES (" + Empresas.Cod_empresa + ", '" + Empresas.Nombre_empresa + "'" + ", '" + Empresas.Direccion_empresa + "'" + ", '" + Empresas.Telefono_empresa + "'" + ", '" + Empresas.Fax_empresa + "'" + "," + Empresas.Logo_empresa + "," + Empresas.Fondo_empresa + ", '" + Empresas.Encabezado + "'" + ", '" + Empresas.Observaciones + "'" + ", '" + Empresas.Pie + "'" + ", '" + Empresas.Resolucion + "'" + ", '" + Empresas.Regimen + "'" + "," + Empresas.Periodo_fiscal + "," + Empresas.Año_periodo_fiscal + "," + Empresas.Periodo_contable + "," + Empresas.Clase + "," + Empresas.Grupo + "," + Empresas.Cuenta + "," + Empresas.Subcuenta + "," + Empresas.Tasamora + "," + Empresas.Iva + "," + Empresas.Retencionarren + "," + Empresas.Diasgracia + "," + Empresas.Maxcodeudor + "," + Empresas.Maxdiasven + "," + Empresas.Montoretension + "," + Empresas.BotonNoCobrarIntereses + ", '" + Empresas.Periodoapagar + "'" + "," + Empresas.Fecha + "," + Empresas.Diaini + "," + Empresas.Diafin + "," + Empresas.MESCON + "," + Empresas.INMUEBLE + "," + Empresas.FechaProc + "," + Empresas.EstadoFecha + "," + Empresas.Tasa_iva_admon + "," + Empresas.Tasa_iva_arren + "," + Empresas.Tasa_imporenta + "," + Empresas.PmP + ", '" + Empresas.Nombre_RL + "'" + ", '" + Empresas.Nombre_contador + "'" + ", '" + Empresas.Tipo_id_RL + "'" + "," + Empresas.No_Id_RL + ", '" + Empresas.Exp_Id_RL + "'" + ", '" + Empresas.Tp_contador + "'" + ", '" + Empresas.Revisor_fiscal + "'" + ", '" + Empresas.Tp_revisorfiscal + "'" + ", '" + Empresas.Mensajeinvinq + "'" + ", '" + Empresas.Tipo_id + "'" + "," + Empresas.Id_empresa + ", '" + Empresas.Dv_empresa + "'" + "," + Empresas.Contab_causacion + "," + Empresas.Ciudad + ");");
        }
        public long Actualizar(M_Empresas Empresas)
        {
            return Data.Accion("UPDATE Empresas SET Cod_empresa=" + Empresas.Cod_empresa + ",Nombre_empresa='" + Empresas.Nombre_empresa + "'" + ",Direccion_empresa='" + Empresas.Direccion_empresa + "'" + ",Telefono_empresa='" + Empresas.Telefono_empresa + "'" + ",Fax_empresa='" + Empresas.Fax_empresa + "'" + ",Logo_empresa=" + Empresas.Logo_empresa + ",Fondo_empresa=" + Empresas.Fondo_empresa + ",Encabezado='" + Empresas.Encabezado + "'" + ",Observaciones='" + Empresas.Observaciones + "'" + ",Pie='" + Empresas.Pie + "'" + ",Resolucion='" + Empresas.Resolucion + "'" + ",Regimen='" + Empresas.Regimen + "'" + ",Periodo_fiscal=" + Empresas.Periodo_fiscal + ",Año_periodo_fiscal=" + Empresas.Año_periodo_fiscal + ",Periodo_contable=" + Empresas.Periodo_contable + ",Clase=" + Empresas.Clase + ",Grupo=" + Empresas.Grupo + ",Cuenta=" + Empresas.Cuenta + ",Subcuenta=" + Empresas.Subcuenta + ",Tasamora=" + Empresas.Tasamora + ",Iva=" + Empresas.Iva + ",Retencionarren=" + Empresas.Retencionarren + ",Diasgracia=" + Empresas.Diasgracia + ",Maxcodeudor=" + Empresas.Maxcodeudor + ",Maxdiasven=" + Empresas.Maxdiasven + ",Montoretension=" + Empresas.Montoretension + ",BotonNoCobrarIntereses=" + Empresas.BotonNoCobrarIntereses + ",Periodoapagar='" + Empresas.Periodoapagar + "'" + ",Fecha=" + Empresas.Fecha + ",Diaini=" + Empresas.Diaini + ",Diafin=" + Empresas.Diafin + ",MESCON=" + Empresas.MESCON + ",INMUEBLE=" + Empresas.INMUEBLE + ",FechaProc=" + Empresas.FechaProc + ",EstadoFecha=" + Empresas.EstadoFecha + ",Tasa_iva_admon=" + Empresas.Tasa_iva_admon + ",Tasa_iva_arren=" + Empresas.Tasa_iva_arren + ",Tasa_imporenta=" + Empresas.Tasa_imporenta + ",PmP=" + Empresas.PmP + ",Nombre_RL='" + Empresas.Nombre_RL + "'" + ",Nombre_contador='" + Empresas.Nombre_contador + "'" + ",Tipo_id_RL='" + Empresas.Tipo_id_RL + "'" + ",No_Id_RL=" + Empresas.No_Id_RL + ",Exp_Id_RL='" + Empresas.Exp_Id_RL + "'" + ",Tp_contador='" + Empresas.Tp_contador + "'" + ",Revisor_fiscal='" + Empresas.Revisor_fiscal + "'" + ",Tp_revisorfiscal='" + Empresas.Tp_revisorfiscal + "'" + ",Mensajeinvinq='" + Empresas.Mensajeinvinq + "'" + ",Tipo_id='" + Empresas.Tipo_id + "'" + ",Id_empresa=" + Empresas.Id_empresa + ",Dv_empresa='" + Empresas.Dv_empresa + "'" + ",Contab_causacion=" + Empresas.Contab_causacion + ",Ciudad=" + Empresas.Ciudad + ";");
        }
        public long Nuevo(M_Empresas Empresas)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_empresa", Empresas.Cod_empresa},
           {"Nombre_empresa", Empresas.Nombre_empresa},
           {"Direccion_empresa", Empresas.Direccion_empresa},
           {"Telefono_empresa", Empresas.Telefono_empresa},
           {"Fax_empresa", Empresas.Fax_empresa},
           {"Logo_empresa", Empresas.Logo_empresa},
           {"Fondo_empresa", Empresas.Fondo_empresa},
           {"Encabezado", Empresas.Encabezado},
           {"Observaciones", Empresas.Observaciones},
           {"Pie", Empresas.Pie},
           {"Resolucion", Empresas.Resolucion},
           {"Regimen", Empresas.Regimen},
           {"Periodo_fiscal", Empresas.Periodo_fiscal},
           {"Año_periodo_fiscal", Empresas.Año_periodo_fiscal},
           {"Periodo_contable", Empresas.Periodo_contable},
           {"Clase", Empresas.Clase},
           {"Grupo", Empresas.Grupo},
           {"Cuenta", Empresas.Cuenta},
           {"Subcuenta", Empresas.Subcuenta},
           {"Tasamora", Empresas.Tasamora},
           {"Iva", Empresas.Iva},
           {"Retencionarren", Empresas.Retencionarren},
           {"Diasgracia", Empresas.Diasgracia},
           {"Maxcodeudor", Empresas.Maxcodeudor},
           {"Maxdiasven", Empresas.Maxdiasven},
           {"Montoretension", Empresas.Montoretension},
           {"BotonNoCobrarIntereses", Empresas.BotonNoCobrarIntereses},
           {"Periodoapagar", Empresas.Periodoapagar},
           {"Fecha", Empresas.Fecha},
           {"Diaini", Empresas.Diaini},
           {"Diafin", Empresas.Diafin},
           {"MESCON", Empresas.MESCON},
           {"INMUEBLE", Empresas.INMUEBLE},
           {"FechaProc", Empresas.FechaProc},
           {"EstadoFecha", Empresas.EstadoFecha},
           {"Tasa_iva_admon", Empresas.Tasa_iva_admon},
           {"Tasa_iva_arren", Empresas.Tasa_iva_arren},
           {"Tasa_imporenta", Empresas.Tasa_imporenta},
           {"PmP", Empresas.PmP},
           {"Nombre_RL", Empresas.Nombre_RL},
           {"Nombre_contador", Empresas.Nombre_contador},
           {"Tipo_id_RL", Empresas.Tipo_id_RL},
           {"No_Id_RL", Empresas.No_Id_RL},
           {"Exp_Id_RL", Empresas.Exp_Id_RL},
           {"Tp_contador", Empresas.Tp_contador},
           {"Revisor_fiscal", Empresas.Revisor_fiscal},
           {"Tp_revisorfiscal", Empresas.Tp_revisorfiscal},
           {"Mensajeinvinq", Empresas.Mensajeinvinq},
           {"Tipo_id", Empresas.Tipo_id},
           {"Id_empresa", Empresas.Id_empresa},
           {"Dv_empresa", Empresas.Dv_empresa},
           {"Contab_causacion", Empresas.Contab_causacion},
           {"Ciudad", Empresas.Ciudad}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Empresas(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
        }
    }
}
