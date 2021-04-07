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
    public class N_Control : N_General
    {
        public M_Control C_Control = new M_Control();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Control");
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Control.Cod_empresa = Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                    C_Control.Empresa = DT.Rows[0]["Empresa"].ToString();
                    C_Control.Direccion = DT.Rows[0]["Direccion"].ToString();
                    C_Control.Observaciones = DT.Rows[0]["Observaciones"].ToString();
                    C_Control.Imagenlogo = DT.Rows[0]["Imagenlogo"].ToString();
                    C_Control.Icono1 = DT.Rows[0]["Icono1"].ToString();
                    C_Control.Icono2 = DT.Rows[0]["Icono2"].ToString();
                    C_Control.Tasamora = Convert.ToDouble(DT.Rows[0]["Tasamora"]);
                    C_Control.Iva = Convert.ToDouble(DT.Rows[0]["Iva"]);
                    C_Control.Retencionarren = Convert.ToDouble(DT.Rows[0]["Retencionarren"]);
                    C_Control.Diasgracia = Convert.ToInt32(DT.Rows[0]["Diasgracia"]);
                    C_Control.Maxcodeudor = Convert.ToInt32(DT.Rows[0]["Maxcodeudor"]);
                    C_Control.Maxdiasven = Convert.ToInt32(DT.Rows[0]["Maxdiasven"]);
                    C_Control.Montoretension = Convert.ToDouble(DT.Rows[0]["Montoretension"]);
                    C_Control.BotonNoCobrarIntereses = Convert.ToBoolean(DT.Rows[0]["BotonNoCobrarIntereses"]);
                    C_Control.Periodoapagar = DT.Rows[0]["Periodoapagar"].ToString();
                    C_Control.Fecha = Convert.ToDateTime(DT.Rows[0]["Fecha"]);
                    C_Control.Diaini = Convert.ToInt32(DT.Rows[0]["Diaini"]);
                    C_Control.Diafin = Convert.ToInt32(DT.Rows[0]["Diafin"]);
                    C_Control.MESCON = Convert.ToDateTime(DT.Rows[0]["MESCON"]);
                    C_Control.INMUEBLE = Convert.ToInt32(DT.Rows[0]["INMUEBLE"]);
                    C_Control.FechaProc = Convert.ToDateTime(DT.Rows[0]["FechaProc"]);
                    C_Control.EstadoFecha = Convert.ToInt32(DT.Rows[0]["EstadoFecha"]);
                    C_Control.Tasa_iva_admon = Convert.ToDouble(DT.Rows[0]["Tasa_iva_admon"]);
                    C_Control.Tasa_iva_arren = Convert.ToDouble(DT.Rows[0]["Tasa_iva_arren"]);
                    C_Control.Periodo_contable_ant = Convert.ToInt32(DT.Rows[0]["Periodo_contable_ant"]);
                    C_Control.Periodo_fiscal_ant = Convert.ToInt32(DT.Rows[0]["Periodo_fiscal_ant"]);
                    C_Control.Periodo_fiscal = Convert.ToInt32(DT.Rows[0]["Periodo_fiscal"]);
                    C_Control.Periodo_contable = Convert.ToInt32(DT.Rows[0]["Periodo_contable"]);
                    C_Control.Cuenta_reporte = DT.Rows[0]["Cuenta_reporte"].ToString();
                    C_Control.No_op = Convert.ToDouble(DT.Rows[0]["No_op"]);
                    C_Control.Tipo_liq_intrs = Convert.ToByte(DT.Rows[0]["Tipo_liq_intrs"]);
                    C_Control.Maxdiasprejuridico = Convert.ToByte(DT.Rows[0]["Maxdiasprejuridico"]);
                    C_Control.Tasa_prejuridico = Convert.ToDouble(DT.Rows[0]["Tasa_prejuridico"]);
                    C_Control.Tasa_comision_admon = Convert.ToDouble(DT.Rows[0]["Tasa_comision_admon"]);
                }
            }
            return ExisteRegistro;
        }

        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Control");
        }
        public long Insertar(M_Control Control)
        {
            return Data.Accion("INSERT INTO Control (Cod_empresa,Empresa,Direccion,Observaciones,Imagenlogo,Icono1,Icono2,Tasamora,Iva,Retencionarren,Diasgracia,Maxcodeudor,Maxdiasven,Montoretension,BotonNoCobrarIntereses,Periodoapagar,Fecha,Diaini,Diafin,MESCON,INMUEBLE,FechaProc,EstadoFecha,Tasa_iva_admon,Tasa_iva_arren,Periodo_contable_ant,Periodo_fiscal_ant,Periodo_fiscal,Periodo_contable,Cuenta_reporte,No_op,Tipo_liq_intrs,Maxdiasprejuridico,Tasa_prejuridico,Tasa_comision_admon) VALUES (" + Control.Cod_empresa + ", '" + Control.Empresa + "'" + ", '" + Control.Direccion + "'" + ", '" + Control.Observaciones + "'" + ", '" + Control.Imagenlogo + "'" + ", '" + Control.Icono1 + "'" + ", '" + Control.Icono2 + "'" + "," + Control.Tasamora + "," + Control.Iva + "," + Control.Retencionarren + "," + Control.Diasgracia + "," + Control.Maxcodeudor + "," + Control.Maxdiasven + "," + Control.Montoretension + "," + Control.BotonNoCobrarIntereses + ", '" + Control.Periodoapagar + "'" + "," + Control.Fecha + "," + Control.Diaini + "," + Control.Diafin + "," + Control.MESCON + "," + Control.INMUEBLE + "," + Control.FechaProc + "," + Control.EstadoFecha + "," + Control.Tasa_iva_admon + "," + Control.Tasa_iva_arren + "," + Control.Periodo_contable_ant + "," + Control.Periodo_fiscal_ant + "," + Control.Periodo_fiscal + "," + Control.Periodo_contable + ", '" + Control.Cuenta_reporte + "'" + "," + Control.No_op + "," + Control.Tipo_liq_intrs + "," + Control.Maxdiasprejuridico + "," + Control.Tasa_prejuridico + "," + Control.Tasa_comision_admon + ");");
        }
        public long Actualizar(M_Control Control)
        {
            return Data.Accion("UPDATE Control SET Cod_empresa=" + Control.Cod_empresa + ",Empresa='" + Control.Empresa + "'" + ",Direccion='" + Control.Direccion + "'" + ",Observaciones='" + Control.Observaciones + "'" + ",Imagenlogo='" + Control.Imagenlogo + "'" + ",Icono1='" + Control.Icono1 + "'" + ",Icono2='" + Control.Icono2 + "'" + ",Tasamora=" + Control.Tasamora + ",Iva=" + Control.Iva + ",Retencionarren=" + Control.Retencionarren + ",Diasgracia=" + Control.Diasgracia + ",Maxcodeudor=" + Control.Maxcodeudor + ",Maxdiasven=" + Control.Maxdiasven + ",Montoretension=" + Control.Montoretension + ",BotonNoCobrarIntereses=" + Control.BotonNoCobrarIntereses + ",Periodoapagar='" + Control.Periodoapagar + "'" + ",Fecha=" + Control.Fecha + ",Diaini=" + Control.Diaini + ",Diafin=" + Control.Diafin + ",MESCON=" + Control.MESCON + ",INMUEBLE=" + Control.INMUEBLE + ",FechaProc=" + Control.FechaProc + ",EstadoFecha=" + Control.EstadoFecha + ",Tasa_iva_admon=" + Control.Tasa_iva_admon + ",Tasa_iva_arren=" + Control.Tasa_iva_arren + ",Periodo_contable_ant=" + Control.Periodo_contable_ant + ",Periodo_fiscal_ant=" + Control.Periodo_fiscal_ant + ",Periodo_fiscal=" + Control.Periodo_fiscal + ",Periodo_contable=" + Control.Periodo_contable + ",Cuenta_reporte='" + Control.Cuenta_reporte + "'" + ",No_op=" + Control.No_op + ",Tipo_liq_intrs=" + Control.Tipo_liq_intrs + ",Maxdiasprejuridico=" + Control.Maxdiasprejuridico + ",Tasa_prejuridico=" + Control.Tasa_prejuridico + ",Tasa_comision_admon=" + Control.Tasa_comision_admon + ";");
        }
        public long Nuevo(M_Control Control)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Cod_empresa", Control.Cod_empresa},
           {"Empresa", Control.Empresa},
           {"Direccion", Control.Direccion},
           {"Observaciones", Control.Observaciones},
           {"Imagenlogo", Control.Imagenlogo},
           {"Icono1", Control.Icono1},
           {"Icono2", Control.Icono2},
           {"Tasamora", Control.Tasamora},
           {"Iva", Control.Iva},
           {"Retencionarren", Control.Retencionarren},
           {"Diasgracia", Control.Diasgracia},
           {"Maxcodeudor", Control.Maxcodeudor},
           {"Maxdiasven", Control.Maxdiasven},
           {"Montoretension", Control.Montoretension},
           {"BotonNoCobrarIntereses", Control.BotonNoCobrarIntereses},
           {"Periodoapagar", Control.Periodoapagar},
           {"Fecha", Control.Fecha},
           {"Diaini", Control.Diaini},
           {"Diafin", Control.Diafin},
           {"MESCON", Control.MESCON},
           {"INMUEBLE", Control.INMUEBLE},
           {"FechaProc", Control.FechaProc},
           {"EstadoFecha", Control.EstadoFecha},
           {"Tasa_iva_admon", Control.Tasa_iva_admon},
           {"Tasa_iva_arren", Control.Tasa_iva_arren},
           {"Periodo_contable_ant", Control.Periodo_contable_ant},
           {"Periodo_fiscal_ant", Control.Periodo_fiscal_ant},
           {"Periodo_fiscal", Control.Periodo_fiscal},
           {"Periodo_contable", Control.Periodo_contable},
           {"Cuenta_reporte", Control.Cuenta_reporte},
           {"No_op", Control.No_op},
           {"Tipo_liq_intrs", Control.Tipo_liq_intrs},
           {"Maxdiasprejuridico", Control.Maxdiasprejuridico},
           {"Tasa_prejuridico", Control.Tasa_prejuridico},
           {"Tasa_comision_admon", Control.Tasa_comision_admon}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Control(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
        }
    }
}
