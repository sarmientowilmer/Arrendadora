using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoDatos;
using Modelo;
using System.Diagnostics;

namespace Logica
{
    public class N_Contrato_Arren : N_General
    {
        public M_Contrato_Arren C_Contrato_Arren = new M_Contrato_Arren();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(int No_contrato, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Contrato_Arren WHERE no_contrato=" + No_contrato);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Contrato_Arren.No_contrato = Convert.ToInt32(DT.Rows[0]["No_contrato"]);
                    C_Contrato_Arren.Tipo_id = DT.Rows[0]["Tipo_id"].ToString();
                    C_Contrato_Arren.Id_inquilino = Convert.ToInt32(DT.Rows[0]["Id_inquilino"]);
                    C_Contrato_Arren.Dv = DT.Rows[0]["Dv"].ToString();
                    C_Contrato_Arren.Cod_inmueble = Convert.ToInt32(DT.Rows[0]["Cod_inmueble"]);
                    C_Contrato_Arren.Fecha_inicio = Convert.ToDateTime(DT.Rows[0]["Fecha_inicio"]);
                    C_Contrato_Arren.Fecha_vencimiento = Convert.ToDateTime(DT.Rows[0]["Fecha_vencimiento"]);
                    C_Contrato_Arren.Fecha_pago = Convert.ToDateTime(DT.Rows[0]["Fecha_pago"]);
                    C_Contrato_Arren.Pago_hasta = Convert.ToDateTime(DT.Rows[0]["Pago_hasta"]);
                    C_Contrato_Arren.Canon = Convert.ToDouble(DT.Rows[0]["Canon"]);
                    C_Contrato_Arren.Periodo = Convert.ToInt32(DT.Rows[0]["Periodo"]);
                    C_Contrato_Arren.Prorrogas = Convert.ToInt32(DT.Rows[0]["Prorrogas"]);
                    C_Contrato_Arren.Estado = DT.Rows[0]["Estado"].ToString();
                    C_Contrato_Arren.Formapago = DT.Rows[0]["Formapago"].ToString();
                    C_Contrato_Arren.Enabogado = Convert.ToBoolean(DT.Rows[0]["Enabogado"]);
                    if (!string.IsNullOrWhiteSpace(DT.Rows[0]["FEntAbogado"].ToString()))
                    {
                        C_Contrato_Arren.FEntAbogado = Convert.ToDateTime(DT.Rows[0]["FEntAbogado"]);
                    }

                    C_Contrato_Arren.Sujeto_iva = Convert.ToBoolean(DT.Rows[0]["Sujeto_iva"]);
                    C_Contrato_Arren.Cod_empresa = Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                    C_Contrato_Arren.Cod_empresa_conta = Convert.ToInt32(DT.Rows[0]["Cod_empresa_conta"]);
                    C_Contrato_Arren.EnConciliacion = Convert.ToBoolean(DT.Rows[0]["EnConciliacion"]);
                    if (!string.IsNullOrWhiteSpace(DT.Rows[0]["Fecha_enconciliacion"].ToString()))
                    {
                        C_Contrato_Arren.Fecha_enconciliacion = Convert.ToDateTime(DT.Rows[0]["Fecha_enconciliacion"]);
                    }
                    C_Contrato_Arren.Tasa_admon_prop = Convert.ToDouble(DT.Rows[0]["Tasa_admon_prop"]);
                    C_Contrato_Arren.Forma_pago_prop = Convert.ToInt32(DT.Rows[0]["Forma_pago_prop"]);
                    C_Contrato_Arren.No_cuenta_prop = DT.Rows[0]["No_cuenta_prop"].ToString();
                    C_Contrato_Arren.Clase_cuenta_prop = DT.Rows[0]["Clase_cuenta_prop"].ToString();
                    C_Contrato_Arren.Entidad_prop = DT.Rows[0]["Entidad_prop"].ToString();
                    C_Contrato_Arren.Fecha_pago_prop = Convert.ToDateTime(DT.Rows[0]["Fecha_pago_prop"]);
                    C_Contrato_Arren.Pago_hasta_prop = Convert.ToDateTime(DT.Rows[0]["Pago_hasta_prop"]);
                    C_Contrato_Arren.Sujeto_iva_prop = Convert.ToBoolean(DT.Rows[0]["Sujeto_iva_prop"]);
                    C_Contrato_Arren.Saldo_canon = Convert.ToDouble(DT.Rows[0]["Saldo_canon"]);
                    C_Contrato_Arren.Saldo_intereses = Convert.ToDouble(DT.Rows[0]["Saldo_intereses"]);
                    C_Contrato_Arren.Ultimopago = Convert.ToDateTime(DT.Rows[0]["Ultimopago"]);
                    C_Contrato_Arren.Condominio = Convert.ToBoolean(DT.Rows[0]["Condominio"]);
                    C_Contrato_Arren.Liq_hasta = Convert.ToDateTime(DT.Rows[0]["Liq_hasta"]);
                    C_Contrato_Arren.Canonprop = Convert.ToDouble(DT.Rows[0]["Canonprop"]);
                    C_Contrato_Arren.Comisionadmon = Convert.ToBoolean(DT.Rows[0]["Comisionadmon"]);
                }
            }
            return ExisteRegistro;
        }
        public M_Contrato_Arren CargarDatos(DataRow v)
        {
            C_Contrato_Arren.No_contrato = Convert.ToInt32(v["No_contrato"]);
            C_Contrato_Arren.Tipo_id = v["Tipo_id"].ToString();
            C_Contrato_Arren.Id_inquilino = Convert.ToInt32(v["Id_inquilino"]);
            C_Contrato_Arren.Dv = v["Dv"].ToString();
            C_Contrato_Arren.Cod_inmueble = Convert.ToInt32(v["Cod_inmueble"]);
            C_Contrato_Arren.Fecha_inicio = Convert.ToDateTime(v["Fecha_inicio"]);
            C_Contrato_Arren.Fecha_vencimiento = Convert.ToDateTime(v["Fecha_vencimiento"]);
            C_Contrato_Arren.Fecha_pago = Convert.ToDateTime(v["Fecha_pago"]);
            C_Contrato_Arren.Pago_hasta = Convert.ToDateTime(v["Pago_hasta"]);
            C_Contrato_Arren.Canon = Convert.ToDouble(v["Canon"]);
            C_Contrato_Arren.Periodo = Convert.ToInt32(v["Periodo"]);
            C_Contrato_Arren.Prorrogas = Convert.ToInt32(v["Prorrogas"]);
            C_Contrato_Arren.Estado = v["Estado"].ToString();
            C_Contrato_Arren.Formapago = v["Formapago"].ToString();
            C_Contrato_Arren.Enabogado = Convert.ToBoolean(v["Enabogado"]);
            if (!string.IsNullOrWhiteSpace(v["FEntAbogado"].ToString()))
            {
                C_Contrato_Arren.FEntAbogado = Convert.ToDateTime(v["FEntAbogado"]);
            }

            C_Contrato_Arren.Sujeto_iva = Convert.ToBoolean(v["Sujeto_iva"]);
            C_Contrato_Arren.Cod_empresa = Convert.ToInt32(v["Cod_empresa"]);
            C_Contrato_Arren.Cod_empresa_conta = Convert.ToInt32(v["Cod_empresa_conta"]);
            C_Contrato_Arren.EnConciliacion = Convert.ToBoolean(v["EnConciliacion"]);
            if (!string.IsNullOrWhiteSpace(v["Fecha_enconciliacion"].ToString()))
            {
                C_Contrato_Arren.Fecha_enconciliacion = Convert.ToDateTime(v["Fecha_enconciliacion"]);
            }
            C_Contrato_Arren.Tasa_admon_prop = Convert.ToDouble(v["Tasa_admon_prop"]);
            C_Contrato_Arren.Forma_pago_prop = Convert.ToInt32(v["Forma_pago_prop"]);
            C_Contrato_Arren.No_cuenta_prop = v["No_cuenta_prop"].ToString();
            C_Contrato_Arren.Clase_cuenta_prop = v["Clase_cuenta_prop"].ToString();
            C_Contrato_Arren.Entidad_prop = v["Entidad_prop"].ToString();
            C_Contrato_Arren.Fecha_pago_prop = Convert.ToDateTime(v["Fecha_pago_prop"]);
            C_Contrato_Arren.Pago_hasta_prop = Convert.ToDateTime(v["Pago_hasta_prop"]);
            C_Contrato_Arren.Sujeto_iva_prop = Convert.ToBoolean(v["Sujeto_iva_prop"]);
            C_Contrato_Arren.Saldo_canon = Convert.ToDouble(v["Saldo_canon"]);
            C_Contrato_Arren.Saldo_intereses = Convert.ToDouble(v["Saldo_intereses"]);
            if (v["Ultimopago"] != DBNull.Value)
                C_Contrato_Arren.Ultimopago = Convert.ToDateTime(v["Ultimopago"]);
            C_Contrato_Arren.Condominio = Convert.ToBoolean(v["Condominio"]);
            C_Contrato_Arren.Liq_hasta = Convert.ToDateTime(v["Liq_hasta"]);
            C_Contrato_Arren.Canonprop = Convert.ToDouble(v["Canonprop"]);
            C_Contrato_Arren.Comisionadmon = Convert.ToBoolean(v["Comisionadmon"]);
            return C_Contrato_Arren;
        }
        public M_Contrato_Arren Consultar(int No_contrato)
        {
            if (Existe(No_contrato, true))
            {
                return C_Contrato_Arren;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Contrato_Arren");
        }
        public DataTable ContratosALiquidar()
        {
            return Data.ConsultaT("SELECT Contrato_Arren.* FROM contrato_arren " +
                " WHERE(((Contrato_Arren.fecha_vencimiento) >Contrato_arren.pago_hasta)) OR(((Contrato_Arren.saldo_canon) > 0)) OR(((Contrato_Arren.saldo_intereses) > 0));");
        }
        public DataTable ContratosXInmueble(int CodInmueble)
        {
            return Data.ConsultaT("SELECT * FROM Contrato_Arren WHERE cod_inmueble=" + CodInmueble);
        }
        public long Insertar(M_Contrato_Arren Contrato_Arren)
        {
            return Data.Accion("INSERT INTO Contrato_Arren (No_contrato,Tipo_id,Id_inquilino,Dv,Cod_inmueble,Fecha_inicio,Fecha_vencimiento,Fecha_pago,Pago_hasta,Canon,Periodo,Prorrogas,Estado,Formapago,Enabogado,FEntAbogado,Sujeto_iva,Cod_empresa,Cod_empresa_conta,EnConciliacion,Fecha_enconciliacion,Tasa_admon_prop,Forma_pago_prop,No_cuenta_prop,Clase_cuenta_prop,Entidad_prop,Fecha_pago_prop,Pago_hasta_prop,Sujeto_iva_prop,Saldo_canon,Saldo_intereses,Ultimopago,Condominio,Liq_hasta,Canonprop,Comisionadmon) VALUES (" + Contrato_Arren.No_contrato + ", '" + Contrato_Arren.Tipo_id + "'" + "," + Contrato_Arren.Id_inquilino + ", '" + Contrato_Arren.Dv + "'" + "," + Contrato_Arren.Cod_inmueble + "," + Contrato_Arren.Fecha_inicio + "," + Contrato_Arren.Fecha_vencimiento + "," + Contrato_Arren.Fecha_pago + "," + Contrato_Arren.Pago_hasta + "," + Contrato_Arren.Canon + "," + Contrato_Arren.Periodo + "," + Contrato_Arren.Prorrogas + ", '" + Contrato_Arren.Estado + "'" + ", '" + Contrato_Arren.Formapago + "'" + "," + Contrato_Arren.Enabogado + "," + Contrato_Arren.FEntAbogado + "," + Contrato_Arren.Sujeto_iva + "," + Contrato_Arren.Cod_empresa + "," + Contrato_Arren.Cod_empresa_conta + "," + Contrato_Arren.EnConciliacion + "," + Contrato_Arren.Fecha_enconciliacion + "," + Contrato_Arren.Tasa_admon_prop + "," + Contrato_Arren.Forma_pago_prop + ", '" + Contrato_Arren.No_cuenta_prop + "'" + ", '" + Contrato_Arren.Clase_cuenta_prop + "'" + ", '" + Contrato_Arren.Entidad_prop + "'" + "," + Contrato_Arren.Fecha_pago_prop + "," + Contrato_Arren.Pago_hasta_prop + "," + Contrato_Arren.Sujeto_iva_prop + "," + Contrato_Arren.Saldo_canon + "," + Contrato_Arren.Saldo_intereses + "," + Contrato_Arren.Ultimopago + "," + Contrato_Arren.Condominio + "," + Contrato_Arren.Liq_hasta + "," + Contrato_Arren.Canonprop + "," + Contrato_Arren.Comisionadmon + ");");
        }
        public long Actualizar(M_Contrato_Arren Contrato_Arren)
        {
            return Data.Accion("UPDATE Contrato_Arren SET No_contrato=" + Contrato_Arren.No_contrato + ",Tipo_id='" + Contrato_Arren.Tipo_id + "'" + ",Id_inquilino=" + Contrato_Arren.Id_inquilino + ",Dv='" + Contrato_Arren.Dv + "'" + ",Cod_inmueble=" + Contrato_Arren.Cod_inmueble + ",Fecha_inicio=" + Contrato_Arren.Fecha_inicio + ",Fecha_vencimiento=" + Contrato_Arren.Fecha_vencimiento + ",Fecha_pago=" + Contrato_Arren.Fecha_pago + ",Pago_hasta=" + Contrato_Arren.Pago_hasta + ",Canon=" + Contrato_Arren.Canon + ",Periodo=" + Contrato_Arren.Periodo + ",Prorrogas=" + Contrato_Arren.Prorrogas + ",Estado='" + Contrato_Arren.Estado + "'" + ",Formapago='" + Contrato_Arren.Formapago + "'" + ",Enabogado=" + Contrato_Arren.Enabogado + ",FEntAbogado=" + Contrato_Arren.FEntAbogado + ",Sujeto_iva=" + Contrato_Arren.Sujeto_iva + ",Cod_empresa=" + Contrato_Arren.Cod_empresa + ",Cod_empresa_conta=" + Contrato_Arren.Cod_empresa_conta + ",EnConciliacion=" + Contrato_Arren.EnConciliacion + ",Fecha_enconciliacion=" + Contrato_Arren.Fecha_enconciliacion + ",Tasa_admon_prop=" + Contrato_Arren.Tasa_admon_prop + ",Forma_pago_prop=" + Contrato_Arren.Forma_pago_prop + ",No_cuenta_prop='" + Contrato_Arren.No_cuenta_prop + "'" + ",Clase_cuenta_prop='" + Contrato_Arren.Clase_cuenta_prop + "'" + ",Entidad_prop='" + Contrato_Arren.Entidad_prop + "'" + ",Fecha_pago_prop=" + Contrato_Arren.Fecha_pago_prop + ",Pago_hasta_prop=" + Contrato_Arren.Pago_hasta_prop + ",Sujeto_iva_prop=" + Contrato_Arren.Sujeto_iva_prop + ",Saldo_canon=" + Contrato_Arren.Saldo_canon + ",Saldo_intereses=" + Contrato_Arren.Saldo_intereses + ",Ultimopago=" + Contrato_Arren.Ultimopago + ",Condominio=" + Contrato_Arren.Condominio + ",Liq_hasta=" + Contrato_Arren.Liq_hasta + ",Canonprop=" + Contrato_Arren.Canonprop + ",Comisionadmon=" + Contrato_Arren.Comisionadmon + " WHERE No_contrato= " + Contrato_Arren.No_contrato + ";");
        }
        public long Nuevo(M_Contrato_Arren Contrato_Arren)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
            {
               {"No_contrato", Contrato_Arren.No_contrato},
               {"Tipo_id", Contrato_Arren.Tipo_id},
               {"Id_inquilino", Contrato_Arren.Id_inquilino},
               {"Dv", Contrato_Arren.Dv},
               {"Cod_inmueble", Contrato_Arren.Cod_inmueble},
               {"Fecha_inicio", Contrato_Arren.Fecha_inicio},
               {"Fecha_vencimiento", Contrato_Arren.Fecha_vencimiento},
               {"Fecha_pago", Contrato_Arren.Fecha_pago},
               {"Pago_hasta", Contrato_Arren.Pago_hasta},
               {"Canon", Contrato_Arren.Canon},
               {"Periodo", Contrato_Arren.Periodo},
               {"Prorrogas", Contrato_Arren.Prorrogas},
               {"Estado", Contrato_Arren.Estado},
               {"Formapago", Contrato_Arren.Formapago},
               {"Enabogado", Contrato_Arren.Enabogado},
               {"FEntAbogado", Contrato_Arren.FEntAbogado},
               {"Sujeto_iva", Contrato_Arren.Sujeto_iva},
               {"Cod_empresa", Contrato_Arren.Cod_empresa},
               {"Cod_empresa_conta", Contrato_Arren.Cod_empresa_conta},
               {"EnConciliacion", Contrato_Arren.EnConciliacion},
               {"Fecha_enconciliacion", Contrato_Arren.Fecha_enconciliacion},
               {"Tasa_admon_prop", Contrato_Arren.Tasa_admon_prop},
               {"Forma_pago_prop", Contrato_Arren.Forma_pago_prop},
               {"No_cuenta_prop", Contrato_Arren.No_cuenta_prop},
               {"Clase_cuenta_prop", Contrato_Arren.Clase_cuenta_prop},
               {"Entidad_prop", Contrato_Arren.Entidad_prop},
               {"Fecha_pago_prop", Contrato_Arren.Fecha_pago_prop},
               {"Pago_hasta_prop", Contrato_Arren.Pago_hasta_prop},
               {"Sujeto_iva_prop", Contrato_Arren.Sujeto_iva_prop},
               {"Saldo_canon", Contrato_Arren.Saldo_canon},
               {"Saldo_intereses", Contrato_Arren.Saldo_intereses},
               {"Ultimopago", Contrato_Arren.Ultimopago},
               {"Condominio", Contrato_Arren.Condominio},
               {"Liq_hasta", Contrato_Arren.Liq_hasta},
               {"Canonprop", Contrato_Arren.Canonprop},
               {"Comisionadmon", Contrato_Arren.Comisionadmon}
            };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Contrato_Arren(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
        }
        
        public string GenerarDeudaSP()
        {
            //Dictionary<string, object> Parametros = new Dictionary<string, object>
            //{
            //};
            //return Data.EjecutarSPString("{CALL GenerarDeudaSP()}", null);
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("select Resultado from GenerarDeudaSP");
            if (DT.Rows.Count > 0)
            {
                return DT.Rows[0]["Resultado"].ToString();
            }
            else return "No retornó datos";

        }
        public void GenerarDeuda(Boolean ProyInq = false)
        {
            //Dim rsI As dao.Recordset
            //Dim rsL As dao.Recordset
            //Dim rsContrato As dao.Recordset
            //Dim sFormaPago As String, fPagoHasta As Date
            //Dim iDiasgracia As Integer, dTasaMora As Double
            //Dim I As Integer
            //Dim mValorCanon As Double
            //Dim inicio As Date
            //Dim fFechaPago As Date
            //Dim fInicio As Date
            DateTime dFechaSistema = DateTime.Today;
            DateTime dLiqHasta = DateTime.Today;
            //Dim bContabCausacion As Boolean
            //Dim iDia As Integer
            //double dTotalCanon = 0;
            //double dTotalIntrs = 0;
            //double dTotalDeuda = 0;
            int Inmueble = 0;
            int iDia = 0;
            M_DatosDeudaContrato DatosDeudaCont = new M_DatosDeudaContrato();
            bool bFacturo = false;
            int DiasV = 0;
            /*
               On Error GoTo GenerarDeuda_Error

            frmProgreso.lblEtiqueta.Caption = "Por Favor espere, vamos a generar saldos.."
            //frmProgreso.pbrBarra.Min = 1
            frmProgreso.lblMin = 1
            CentrarForma frmProgreso
            frmProgreso.Show
            */
            DataTable DTInmuebles = new DataTable();
            DataTable DTContratos = new DataTable();
            N_Inmuebles Inmuebles = new N_Inmuebles();
            N_Control Control = new N_Control();
            N_Empresas Empresa = new N_Empresas();
            N_Informe Informe = new N_Informe();

            dFechaSistema = DateTime.Today;

            //Control.Cadena(GsPath);
            Control.Existe(true);
            //Empresa.Cadena(GsPath);
            Empresa.Existe(true);
            //Informe.Cadena(GsPath);
            //Inmuebles.Cadena(GsPath);

            Informe.BorrarDatos();

            DTInmuebles = Inmuebles.Consultar();


            if (DTInmuebles.Rows.Count > 0)
            {
                foreach (DataRow Fila in DTInmuebles.Rows)
                {
                    //DTotalIntrs = 0; DTotalCanon = 0; DTotalDeuda = 0;
                    Inmueble = Convert.ToInt32(Fila["cod_inmueble"]);
                    DTContratos = ContratosXInmueble(Inmueble);
                    foreach (DataRow DRContrato in DTContratos.Rows)
                    {
                        if (Existe(Convert.ToInt32(DRContrato["no_contrato"]), true))
                        {
                            Debug.Print("liquidando el contrato: " + C_Contrato_Arren.No_contrato);
                            //dFechaSistema = DateTime.Today;
                            if (C_Contrato_Arren.Fecha_vencimiento > C_Contrato_Arren.Pago_hasta)
                            {
                                if ((C_Contrato_Arren.Fecha_vencimiento - C_Contrato_Arren.Pago_hasta).Days + 1 >= 30)
                                {
                                    if (dFechaSistema >= C_Contrato_Arren.Fecha_vencimiento && dFechaSistema > C_Contrato_Arren.Pago_hasta)
                                    { dLiqHasta = C_Contrato_Arren.Fecha_vencimiento; }
                                    else if (C_Contrato_Arren.Pago_hasta >= dFechaSistema)
                                    {
                                        if (ProyInq)
                                        {
                                            if (C_Contrato_Arren.Pago_hasta.AddMonths(1) > C_Contrato_Arren.Fecha_vencimiento)
                                                dLiqHasta = C_Contrato_Arren.Fecha_vencimiento;
                                            else
                                                dLiqHasta = C_Contrato_Arren.Pago_hasta.AddMonths(1).AddDays(-1);
                                        }
                                        else
                                            dLiqHasta = C_Contrato_Arren.Pago_hasta.AddDays(-1);
                                    }
                                    else
                                    {
                                        if (C_Contrato_Arren.Pago_hasta.Day > 28)
                                        {
                                            if (dFechaSistema.Month == 2)
                                            {
                                                iDia = 28;
                                                if (C_Contrato_Arren.Pago_hasta.Date.Day == 29)
                                                {
                                                    if (DateTime.IsLeapYear(dFechaSistema.Year)) iDia = 29;
                                                }
                                            }
                                            if (dFechaSistema.Month == 4 || dFechaSistema.Month == 6 || dFechaSistema.Month == 9 || dFechaSistema.Month == 11) iDia = 30;
                                            else iDia = C_Contrato_Arren.Pago_hasta.Day;
                                        }
                                        else iDia = C_Contrato_Arren.Pago_hasta.Day;

                                        //Debug.Print CDate(iDia &"/" & Month(dFechaSistema) & "/" & Year(dFechaSistema)) -C_Contrato_Arrenpago_hasta + 1
                                        //Debug.Print CDate(Day(C_Contrato_Arrenpago_hasta) & "/" & Month(dFechaSistema) & "/" & Year(dFechaSistema))
                                        if ((Convert.ToDateTime(iDia + "/" + dFechaSistema.Month + "/" + dFechaSistema.Year) - C_Contrato_Arren.Pago_hasta).Days + 1 >= 30)
                                        {
                                            if (dFechaSistema.Day > iDia)
                                            {
                                                iDia = C_Contrato_Arren.Pago_hasta.Day;
                                                if (C_Contrato_Arren.Pago_hasta.Day > 28)
                                                {
                                                    if (dFechaSistema.AddMonths(1).Month == 2)
                                                    {
                                                        if (DateTime.IsLeapYear(dFechaSistema.Year)) iDia = 29; iDia = 28;
                                                    }
                                                    if (dFechaSistema.AddMonths(1).Month == 4 || dFechaSistema.AddMonths(1).Month == 6 || dFechaSistema.AddMonths(1).Month == 9 || dFechaSistema.AddMonths(1).Month == 11) iDia = 30;
                                                }

                                                if (dFechaSistema.Month < 12)
                                                    dLiqHasta = Convert.ToDateTime(iDia + "/" + dFechaSistema.AddMonths(1).Month + "/" + dFechaSistema.Year).AddDays(-1);
                                                else
                                                    dLiqHasta = Convert.ToDateTime(iDia + "/" + dFechaSistema.AddMonths(1).Month + "/" + dFechaSistema.Year + 1).AddDays(-1);
                                            }
                                            else
                                                dLiqHasta = Convert.ToDateTime(iDia + "/" + dFechaSistema.Month + "/" + dFechaSistema.Year).AddDays(-1);
                                        }
                                        else
                                        {
                                            dLiqHasta = C_Contrato_Arren.Pago_hasta.AddMonths(1).AddDays(-1);
                                            if (C_Contrato_Arren.Fecha_vencimiento >= dFechaSistema && dFechaSistema > dLiqHasta && (dFechaSistema.Subtract(dLiqHasta).Days > Control.C_Control.Diasgracia))
                                                dLiqHasta = C_Contrato_Arren.Pago_hasta.AddMonths(2).AddDays(-1);
                                            //else
                                            //    dLiqHasta = C_Contrato_Arren.Pago_hasta.AddMonths(1).AddDays(-1);
                                        }

                                    }
                                }
                                else
                                    dLiqHasta = C_Contrato_Arren.Fecha_vencimiento;

                            }
                            else
                            {
                                if (C_Contrato_Arren.Saldo_canon > 0 || C_Contrato_Arren.Saldo_intereses > 0) dLiqHasta = C_Contrato_Arren.Fecha_vencimiento; dLiqHasta = Convert.ToDateTime("01/01/1900");
                            }

                            if (dLiqHasta != Convert.ToDateTime("01/01/1900"))
                            {    //if (dLiqHasta > C_Contrato_Arren.Fecha_vencimiento) dLiqHasta = C_Contrato_Arren.Fecha_vencimiento;
                                if (C_Contrato_Arren.No_contrato == 2016109)
                                {
                                    Convert.ToInt32("100");
                                }
                                LiquidarContratoInquilino(Control, C_Contrato_Arren, C_Contrato_Arren.No_contrato, dFechaSistema, DateTime.Today, dLiqHasta, 0, "", 0, false, false, 0, ref bFacturo, ref DatosDeudaCont);
                                
                            }
                            if (dLiqHasta != Convert.ToDateTime("01/01/1900"))
                            {
                                if (DatosDeudaCont.dDeudaCanon > 0 || DatosDeudaCont.dDeudaIntrs > 0)
                                {
                                    Informe.C_Informe.No_contrato = C_Contrato_Arren.No_contrato;
                                    Informe.C_Informe.Deudacanon = DatosDeudaCont.dDeudaCanon;
                                    Informe.C_Informe.Deudaintrs = DatosDeudaCont.dDeudaIntrs;
                                    if (C_Contrato_Arren.Enabogado)
                                    {
                                        if (!string.IsNullOrEmpty(C_Contrato_Arren.FEntAbogado.ToString()))
                                            dFechaSistema = C_Contrato_Arren.FEntAbogado;
                                    }
                                    if (C_Contrato_Arren.EnConciliacion)
                                    {
                                        if (!string.IsNullOrEmpty(C_Contrato_Arren.Fecha_enconciliacion.ToString()))
                                            dFechaSistema = C_Contrato_Arren.Fecha_enconciliacion;
                                    }
                                    DiasV = SaberDias(dFechaSistema, C_Contrato_Arren.Pago_hasta, C_Contrato_Arren.Formapago);
                                    if (C_Contrato_Arren.Pago_hasta < C_Contrato_Arren.Fecha_vencimiento && DiasV > 0)
                                    {
                                        if (DiasV < Control.C_Control.Diasgracia)
                                        {
                                            if (DatosDeudaCont.dSaldoAnt > 0)
                                            {
                                                DiasV = SaberDias(dFechaSistema, C_Contrato_Arren.Ultimopago, C_Contrato_Arren.Formapago);
                                                Informe.C_Informe.Deudacanon = DatosDeudaCont.dSaldoAnt;
                                            }
                                            Informe.C_Informe.Dias = DiasV;
                                        }
                                        else
                                            Informe.C_Informe.Dias = DiasV;
                                    }
                                    else
                                        Informe.C_Informe.Dias = 0;
                                    Informe.Insertar(Informe.C_Informe);
                                }
                            }
                        }
                    }
                }

            }
        }


        public DataTable LiquidarContratoInquilino(N_Control Control, M_Contrato_Arren Contrato, int NoContrato, DateTime FechaSistema, DateTime FechaAplica, DateTime LiquidarHasta, long NoFactura, string tipo_comp, long No_comp, bool Grabaliq, bool Facturar, double NoOperacion, ref bool bFacturo, ref M_DatosDeudaContrato mDatosDeuda)
        {
            DataTable DTLiquidarContrato = new DataTable();
            DataRow DRFila = null;
            DateTime inicio;
            DateTime PagoHasta;
            DateTime fVence;
            DateTime dFechaSistema;
            DateTime dFechaAplica;
            double DSalCanon=0;
            double DSalIntrs=0;
            double DTotalCanon=0;
            double DTotalIntrs=0;
            double DValorCanon=0;
            double DValorIVA=0;
            double DRetension=0;
            //double DNetoPagar;
            //bool bAplicaRetencion;
            //DateTime fUltimoPago;
            int iDiasLiq;
            int dia;
            //DateTime dIni;
            //DateTime dFin;
            DateTime dFechaDesde;
            double dCanonTemp;
            double mValorCanon;
            int Cod = 3;
            DateTime diapago;
            int ms, yy;
            DateTime fIni, fFin;
            int dias = 0;
            int diasven = 0;
            double Intrs;
            int Meses;
            DateTime dtFechaPago;
            DateTime TiempoInicial;
            DateTime TiempoFinal;
            //string AplicaRetencion;

            C_Contrato_Arren = Contrato;
            //if (Existe(NoContrato, true))
            if (C_Contrato_Arren.No_contrato == NoContrato)
            {
                //N_Inmuebles Inmueble = new N_Inmuebles();
                //N_Auxiliares Tercero = new N_Auxiliares();
                //TiempoFinal = DateTime.Now;
                //Debug.Print("Tiempo iniciando Terceros: " + (TiempoFinal - TiempoInicial).TotalSeconds);
                TiempoInicial = DateTime.Now;
                N_Detalle_PagoInq LiqPago = new N_Detalle_PagoInq();
                TiempoFinal = DateTime.Now;
                Debug.Print("Tiempo iniciando detallepagoinquilino: " + (TiempoFinal - TiempoInicial).TotalSeconds);
                //N_Control Control = new N_Control();
                TiempoInicial = DateTime.Now;
                N_Prorrogas Prorrogas = new N_Prorrogas();
                TiempoFinal = DateTime.Now;
                Debug.Print("Tiempo iniciando Prorrogas: " + (TiempoFinal - TiempoInicial).TotalSeconds);

                //DataTable DTProrrogas;

                if (ConectaA != null)
                {
                    //Tercero.ConectarA(ConectaA);
                    //LiqPago.ConectarA(ConectaA);
                    //Control.ConectarA(ConectaA);
                    //Prorrogas.ConectarA(ConectaA);
                }

                //Inmueble.Cadena(GsPath);
                //Tercero.Cadena(GsPath);
                //LiqPago.Cadena(GsPath);
                //Control.Cadena(GsPath);
                //TiempoInicial = DateTime.Now;
                //Control.Existe(true);
                //TiempoFinal = DateTime.Now;
                //Debug.Print("Tiempo Cargando datos Control: " + (TiempoFinal - TiempoInicial).TotalSeconds);
                //Prorrogas.Cadena(GsPath);

                //TiempoFinal = DateTime.Now;
                //Debug.Print("Tiempo en definición de clases: " + (TiempoFinal - TiempoInicial).TotalSeconds);
                TiempoInicial = DateTime.Now;
                if (Grabaliq)
                {
                    DTLiquidarContrato = LiqPago.Consultar(-1);
                }
                

                dFechaSistema = FechaSistema;
                dFechaAplica = FechaAplica;

                // Inicia las variables
                DSalCanon = 0;
                DSalIntrs = 0;
                DTotalCanon = 0;
                DTotalIntrs = 0;
                DValorCanon = 0;
                DValorIVA = 0;
                //DRetension = 0;
                // dVrRecargo1 = 0
                // dVrRecargo2 = 0
                //DNetoPagar = 0;

                if (Facturar && (C_Contrato_Arren.Pago_hasta > C_Contrato_Arren.Liq_hasta) || C_Contrato_Arren.Fecha_inicio > FechaAplica)
                {
                    bFacturo = false;
                    mDatosDeuda.dDeudaCanon = 0;
                    mDatosDeuda.dDeudaIntrs = 0;
                    mDatosDeuda.dIVAArriendo = 0;
                    mDatosDeuda.dRetension = 0;
                    mDatosDeuda.dSaldoAnt = 0;
                    mDatosDeuda.dSaldoIntrs = 0;
                    mDatosDeuda.dVrCanon = 0;
                }
                else
                    bFacturo = true;
                TiempoFinal = DateTime.Now;
                Debug.Print("Tiempo inicializando variables: " + (TiempoFinal - TiempoInicial).TotalSeconds);
                TiempoInicial = DateTime.Now;
                //// averiguar si el tercero nos aplica retencion
                //bAplicaRetencion = false;
                //AplicaRetencion = Tercero.AplicaRetencion(C_Contrato_Arren.Tipo_id, C_Contrato_Arren.Id_inquilino);
                //if (AplicaRetencion != "No Existe")
                //{
                //    if (AplicaRetencion == "True" || AplicaRetencion=="False") bAplicaRetencion = Convert.ToBoolean(AplicaRetencion);
                //    else bAplicaRetencion = Convert.ToBoolean(Convert.ToInt16(AplicaRetencion));
                //}
                ///*if (Tercero.Existe(C_Contrato_Arren.Tipo_id, C_Contrato_Arren.Id_inquilino, true))
                //{
                //    bAplicaRetencion = Tercero.C_Auxiliares.Nosaplica_retencion;
                //}*/
                //TiempoFinal = DateTime.Now;
                //Debug.Print("Tiempo buscando el tercero: " + (TiempoFinal - TiempoInicial).TotalSeconds);

                dFechaDesde = C_Contrato_Arren.Pago_hasta; // fecha desde la que se liquida
                if (Facturar)
                {
                    if (C_Contrato_Arren.Pago_hasta >= C_Contrato_Arren.Liq_hasta)
                        dFechaDesde = C_Contrato_Arren.Liq_hasta;
                }
                inicio = dFechaDesde; // Format(fPagoHasta, "dd/mm/yyyy")
                                      // mValorCanon = Format(lblContrato(6).Caption, "###0.00")
                DValorCanon = C_Contrato_Arren.Canon;
                Cod = 3;
                dia = SaberDiaPago(C_Contrato_Arren.Fecha_pago, inicio);
                string fFechaPago = dia + "/" + inicio.Month + "/" + inicio.Year;
                TiempoInicial = DateTime.Now;
                if (C_Contrato_Arren.Saldo_canon > 0 || C_Contrato_Arren.Saldo_intereses > 0)
                {
                    if (Grabaliq)
                    {
                        DRFila = DTLiquidarContrato.NewRow();
                        DRFila["Codigo"] = 1;
                        DRFila["tipo_comp"] = tipo_comp;
                        DRFila["No_comp"] = No_comp;
                        DRFila["no_contrato"] = NoContrato;
                        DRFila["periodo"] = "Saldo Anterior";
                        DRFila["canon"] = C_Contrato_Arren.Saldo_canon;
                        DRFila["intereses"] = C_Contrato_Arren.Saldo_intereses;
                        DRFila["no_operacion"] = NoOperacion;
                        DRFila["No_factura"] = NoFactura;
                        DTLiquidarContrato.Rows.Add(DRFila);
                    }
                    DTotalCanon = DTotalCanon + C_Contrato_Arren.Saldo_canon;
                    diasven = 0;
                    DSalCanon = C_Contrato_Arren.Saldo_canon;
                    if (C_Contrato_Arren.Saldo_canon > 0)
                    {
                        if (C_Contrato_Arren.Enabogado)
                        {
                            diasven = SaberDias(C_Contrato_Arren.FEntAbogado, C_Contrato_Arren.Ultimopago, C_Contrato_Arren.Formapago);
                        }
                        else if (C_Contrato_Arren.EnConciliacion)
                        {
                            diasven = SaberDias(C_Contrato_Arren.Fecha_enconciliacion, C_Contrato_Arren.Ultimopago, C_Contrato_Arren.Formapago);
                        }
                        else
                        {
                            int D = SaberDias(inicio, C_Contrato_Arren.Ultimopago, C_Contrato_Arren.Formapago);
                            if (D > 30 && D < 60)
                            {
                                diasven = SaberDias(FechaAplica, inicio, C_Contrato_Arren.Formapago);
                                // !FechaPago = Format(inicio, "dd/mm/yyyy")
                                dtFechaPago = inicio;
                                if (diasven < 0)
                                {
                                    diasven = SaberDias(FechaAplica, C_Contrato_Arren.Ultimopago, C_Contrato_Arren.Formapago);
                                    dtFechaPago = C_Contrato_Arren.Ultimopago;
                                }
                            }
                            else if (D >= 60) diasven = 0;
                            else if (D <= 30)
                            {
                                diasven = C_Contrato_Arren.Ultimopago == FechaAplica
                                    ? 0
                                    : SaberDias(FechaAplica, C_Contrato_Arren.Ultimopago, C_Contrato_Arren.Formapago);
                            }
                            else if (D < -30) diasven = 0;
                            else diasven = 0;

                            if (inicio >= C_Contrato_Arren.Fecha_vencimiento)
                            {
                                if (C_Contrato_Arren.Ultimopago == FechaAplica)
                                    diasven = 0;
                            }
                        }
                    }
                    if (diasven < 0) diasven = 0;

                    // If diasven > iDiasgracia Then
                    Intrs = Math.Round(((DSalCanon * Control.C_Control.Tasamora) / 30) * diasven, 0);
                    DSalIntrs = DSalIntrs + Intrs;
                    DTotalIntrs = DTotalIntrs + Intrs;
                    if (Intrs > 0)
                    {
                        if (Grabaliq)
                        {
                            DRFila = DTLiquidarContrato.NewRow();
                            DRFila["Codigo"] = 2;
                            DRFila["tipo_comp"] = tipo_comp;
                            DRFila["No_comp"] = No_comp;
                            DRFila["no_contrato"] = NoContrato;
                            DRFila["periodo"] = "Sanción Moratoria saldo Canon";
                            DRFila["fechapago"] = C_Contrato_Arren.Ultimopago;
                            DRFila["diasven"] = diasven;
                            DRFila["intereses"] = Intrs;
                            DRFila["no_operacion"] = NoOperacion;
                            DRFila["No_factura"] = NoFactura;
                            DTLiquidarContrato.Rows.Add(DRFila);
                        }
                    }
                }
                TiempoFinal = DateTime.Now;
                Debug.Print("Tiempo en saldo canon e intereses del saldo " + (TiempoFinal - TiempoInicial).TotalSeconds);

                if (LiquidarHasta > C_Contrato_Arren.Fecha_vencimiento)
                    fVence = LiquidarHasta.AddDays(-1);
                else if (LiquidarHasta < C_Contrato_Arren.Pago_hasta)
                    fVence = C_Contrato_Arren.Pago_hasta;
                else
                    fVence = C_Contrato_Arren.Fecha_vencimiento;
                if (C_Contrato_Arren.Enabogado)
                {
                    // fVence = fentabog
                    dFechaAplica = C_Contrato_Arren.FEntAbogado;
                    dFechaSistema = C_Contrato_Arren.FEntAbogado;
                }
                if (C_Contrato_Arren.EnConciliacion)
                    dFechaAplica = C_Contrato_Arren.Fecha_enconciliacion;
                do
                {
                    if (inicio < fVence)
                    {
                        {
                            if (Grabaliq)
                            {
                                DRFila = DTLiquidarContrato.NewRow();
                                DRFila["Codigo"] = Cod;
                                DRFila["tipo_comp"] = tipo_comp;
                                DRFila["No_comp"] = No_comp;
                                DRFila["no_contrato"] = NoContrato;
                            }

                            // Calcula el día de pago
                            TiempoInicial = DateTime.Now;
                            diapago = inicio;
                            if (C_Contrato_Arren.Formapago == "A")
                            {
                                dia = SaberDiaPago(C_Contrato_Arren.Fecha_pago, inicio);
                                diapago = Convert.ToDateTime(dia + "/" + inicio.Month + "/" + inicio.Year);
                            }
                            else if (C_Contrato_Arren.Formapago == "V")
                            {
                                ms = inicio.Month + 1;
                                if (ms >= 12)
                                {
                                    yy = inicio.Year + 1;
                                    ms = 1;
                                    diapago = Convert.ToDateTime(dia + "/" + ms + "/" + yy);
                                }
                                else
                                {
                                    //string s = (C_Contrato_Arren.Fecha_pago.Day.ToString("00") + "/" + (inicio.Month + 1).ToString("00") + "/" + inicio.Year.ToString());
                                    diapago = Convert.ToDateTime(C_Contrato_Arren.Fecha_pago.Day.ToString("00") + "/" + (inicio.Month + 1).ToString("00") + "/" + inicio.Year.ToString());

                                }

                            }
                            TiempoFinal = DateTime.Now;
                            Debug.Print("Tiempo calculando dia de pago: " + (TiempoFinal-TiempoInicial).TotalSeconds);
                            TiempoInicial = DateTime.Now;
                            if (diapago < dFechaSistema)
                            {
                                if (C_Contrato_Arren.Formapago == "A")
                                    diasven = SaberDias(dFechaAplica, diapago, C_Contrato_Arren.Formapago);
                                else if (C_Contrato_Arren.Formapago == "V")
                                    diasven = SaberDias(dFechaAplica, diapago.AddMonths(-1), C_Contrato_Arren.Formapago);
                            }
                            else if (diapago >= fVence)
                                // ElseIf diapago >= CDate(lblContrato(2).Caption) Then
                                break;
                            else
                                diasven = 0;
                            if (Grabaliq)
                            {
                                DRFila["mes"] = inicio.ToString("MMMM");
                                //DRFila["mes"] = NoOperacion;
                            }
                            // PagoHasta = DateAdd("d", -1, DateAdd("m", 1, inicio))
                            TiempoFinal = DateTime.Now;
                            Debug.Print("Tiempo calculando días vencido: " + (TiempoFinal - TiempoInicial).TotalSeconds);
                            TiempoInicial = DateTime.Now;
                            iDiasLiq = 0;
                            if (diapago.AddMonths(1).AddDays(-1) == C_Contrato_Arren.Fecha_vencimiento)
                            {
                                PagoHasta = inicio.AddMonths(1);
                                if (PagoHasta.Day != C_Contrato_Arren.Fecha_inicio.Day)
                                {
                                    //dia =C_Contrato_Arren.Fecha_inicio.Day;
                                    dia = SaberDiaPago(C_Contrato_Arren.Fecha_inicio.AddMonths(1), C_Contrato_Arren.Fecha_inicio.AddMonths(1));
                                    PagoHasta = Convert.ToDateTime(dia + "/" + PagoHasta.Month + "/" + PagoHasta.Year);
                                }

                                iDiasLiq = 30;
                            }// por favor revisar en las otras liquidaciones
                            else if (LiquidarHasta.Month == inicio.Month && LiquidarHasta.Year == inicio.Year)
                            {
                                // Debug.Print Month(LiquidarHasta) & " - " & Month(CDate(diapago))
                                if (LiquidarHasta.Month != diapago.Month)
                                    iDiasLiq = (30 - diapago.Day) + LiquidarHasta.Day + 1;
                                else if (LiquidarHasta < C_Contrato_Arren.Fecha_vencimiento)
                                {
                                    if ((LiquidarHasta - inicio).Days < 28)
                                    {
                                        if (inicio.Day == 1)
                                            iDiasLiq = 30;
                                        else
                                            iDiasLiq = 30 - inicio.Day;
                                    }
                                    else
                                        iDiasLiq = 30;
                                }
                                else iDiasLiq = LiquidarHasta.Subtract(diapago).Days + 1; //Convert.ToInt32(LiquidarHasta - diapago) + 1;
                                PagoHasta = LiquidarHasta.AddDays(1);
                            }
                            else
                            {
                                if (C_Contrato_Arren.Fecha_vencimiento.Month != diapago.Month)
                                {
                                    // revisar este cambio en las otras liquidaciones
                                    // Debug.Print (C_Contrato_Arren.fecha_vencimiento - CDate(diapago))
                                    if ((C_Contrato_Arren.Fecha_vencimiento - diapago).Days > 31)
                                        iDiasLiq = (C_Contrato_Arren.Fecha_vencimiento - diapago).Days + 1;
                                    else if (diapago.Day <= 30)
                                        iDiasLiq = (30 - diapago.Day) + C_Contrato_Arren.Fecha_vencimiento.Day + 1;
                                    else
                                        // iDiasLiq = (30 - Day(diapago)) + Day(C_Contrato_Arren.fecha_vencimiento) + 1
                                        iDiasLiq = (diapago - C_Contrato_Arren.Fecha_vencimiento).Days + 1;
                                }
                                else
                                    iDiasLiq = (C_Contrato_Arren.Fecha_vencimiento - diapago).Days + 1;
                                // iDiasLiq = C_Contrato_Arren.fecha_vencimiento - CDate(diapago) + 1 'ojo no cambiar
                                if (iDiasLiq >= 30)
                                {
                                    PagoHasta = inicio.AddMonths(1);
                                    if (PagoHasta.Day != C_Contrato_Arren.Fecha_inicio.Day)
                                    {
                                        //dia = Day((DateTime)C_Contrato_Arren.fecha_inicio);
                                        dia = SaberDiaPago(C_Contrato_Arren.Fecha_inicio.AddMonths(1), C_Contrato_Arren.Fecha_inicio.AddMonths(1));
                                        if (C_Contrato_Arren.Fecha_pago.Day != PagoHasta.Day)
                                            PagoHasta = Convert.ToDateTime(dia + "/" + PagoHasta.Month + "/" + PagoHasta.Year);
                                    }
                                    else
                                    {
                                    }

                                    iDiasLiq = 30;
                                }
                                else
                                {
                                    PagoHasta = C_Contrato_Arren.Fecha_vencimiento.AddDays(1);
                                    //iDiasLiq = iDiasLiq;
                                }
                            }
                            TiempoFinal = DateTime.Now;
                            Debug.Print("Tiempo calculando días liquidados y pago hasta:" + (TiempoFinal - TiempoInicial).TotalSeconds);
                            if (Grabaliq)
                            {
                                DRFila["periodo"] = inicio.ToString("dd/MM/yyyy") + " a " + PagoHasta.AddDays(-1).ToString("dd/MM/yyyy");
                                DRFila["FechaPago"] = diapago.ToString();
                            }
                            // averiguar valor del canon
                            TiempoInicial = DateTime.Now;
                            mValorCanon = C_Contrato_Arren.Canon;
                            if (C_Contrato_Arren.Prorrogas != 0)
                            {
                                //Pro = C_Contrato_Arren.Prorrogas - 1;
                                dCanonTemp = Prorrogas.CanonInqXFecha(C_Contrato_Arren.No_contrato, inicio);
                                if (dCanonTemp > 0) mValorCanon = dCanonTemp;
                                
                                /*DTProrrogas = Prorrogas.Consultar(C_Contrato_Arren.No_contrato);

                                if (DTProrrogas.Rows.Count > 0)
                                {
                                    for (int i = DTProrrogas.Rows.Count - 1; i == 0; i--)
                                    {
                                        if (Convert.ToDateTime(DTProrrogas.Rows[i]["fecha_inicio"]) <= inicio && Convert.ToDateTime(DTProrrogas.Rows[i]["fecha_vencimiento"]) >= inicio)
                                        {
                                            mValorCanon = Convert.ToDouble(DTProrrogas.Rows[i]["canon"]);
                                            break;
                                        }
                                    }
                                }*/
                            }
                            if (iDiasLiq < 30)
                                mValorCanon = Math.Round(mValorCanon / 30 * iDiasLiq, 0);
                            if (Grabaliq)
                            {
                                DRFila["canon"] = mValorCanon;
                                DRFila["diasven"] = diasven;
                            }

                            DTotalCanon = DTotalCanon + mValorCanon;
                            TiempoFinal = DateTime.Now;
                            Debug.Print("Tiempo buscando el canon: " + (TiempoFinal - TiempoInicial).TotalSeconds);
                            // calcular intereses de mora
                            TiempoInicial = DateTime.Now;
                            Intrs = 0;
                            if (diasven <= Control.C_Control.Diasgracia && Cod >= 3)
                                Intrs = 0;
                            else
                            {
                                /// liquida sanción mora diferencial
                                if (Control.C_Control.Tipo_liq_intrs == 1)
                                {
                                    Intrs = Math.Round(mValorCanon * Control.C_Control.Tasamora / 30 * diasven, 0);
                                }
                                if (Control.C_Control.Tipo_liq_intrs == 2)
                                {
                                    if (diasven >= Control.C_Control.Diasgracia + 1 && diasven <= Control.C_Control.Maxdiasprejuridico)
                                    {
                                        Intrs = Math.Round(mValorCanon * Control.C_Control.Tasamora, 0);
                                    }
                                    if (diasven >= Control.C_Control.Maxdiasprejuridico + 1)
                                    {
                                        Intrs = Math.Round(mValorCanon * Control.C_Control.Tasamora, 0);
                                        Intrs = Intrs + Math.Round((Intrs + mValorCanon) * Control.C_Control.Tasa_prejuridico, 0);
                                    }
                                }
                            }
                            if (Grabaliq)
                            {
                                DRFila["intereses"] = Intrs;
                            }
                            DTotalIntrs = DTotalIntrs + Intrs;
                            TiempoFinal = DateTime.Now;
                            Debug.Print("Tiempo calculando la sanción moratoria: " + (TiempoFinal - TiempoInicial).TotalSeconds);
                            // ''''  ojo revisar acá
                            fIni = Convert.ToDateTime("01/" + dFechaAplica.Month + "/" + dFechaAplica.Year);
                            fFin = fIni.AddMonths(1).AddDays(-1);
                            // If dFechaAplica = inicio Then
                            if (inicio >= fIni && inicio <= fFin)
                                DValorCanon = mValorCanon;
                            else
                            {
                                DSalCanon = DSalCanon + mValorCanon;
                                DSalIntrs = DSalIntrs + Intrs;
                            }
                            //Calculando el IVA 
                            if (C_Contrato_Arren.Sujeto_iva)
                            {
                                if (Grabaliq)
                                    DRFila["tasa_iva"] = Control.C_Control.Tasa_iva_arren;
                                DValorIVA = DValorIVA + Math.Round(DValorCanon * Control.C_Control.Tasa_iva_arren, 0);
                            }
                            else if (Grabaliq)
                                DRFila["tasa_iva"] = 0;
                            if (Grabaliq)
                            {
                                DRFila["no_operacion"] = NoOperacion;
                                DRFila["No_factura"] = NoFactura;
                                DTLiquidarContrato.Rows.Add(DRFila);
                            }
                        }

                        inicio = PagoHasta;
                        Cod = Cod + 1;
                    }
                    else
                    {
                    }
                    TiempoInicial = DateTime.Now;
                    PagoHasta = inicio;
                    // Meses = DateDiff("m", inicio, dFechaSistema)
                    Meses = ((LiquidarHasta.Month-inicio.Month) + 12 * (LiquidarHasta.Year-inicio.Year));
                    //Meses = DateTime.DateDiff("m", inicio, LiquidarHasta);
                    if (C_Contrato_Arren.Formapago == "A")
                    {
                        if (inicio < fVence)
                        {
                            if (LiquidarHasta != fVence)
                                dias = (LiquidarHasta - PagoHasta).Days;
                            else if (LiquidarHasta == fVence)
                                dias = (LiquidarHasta - PagoHasta).Days;
                            else
                                dias = (dFechaSistema - PagoHasta).Days;
                        }
                        else
                        {
                            dias = 0;
                            Meses = 0;
                        }
                    }
                    else if (Meses == 0 & C_Contrato_Arren.Formapago == "V")
                        dias = 0;
                    TiempoFinal = DateTime.Now;
                    Debug.Print("Tiempo calculando si hay más meses o días a liquidar: " + (TiempoFinal-TiempoInicial).TotalSeconds);
                }
                while (Meses > 0 | dias > 0);// ojo no cambiar// & " and prorroga=" & pro '& " and (fecha_inicio<=#" & Format(inicio, "dd/mm/yyyy") & "# and fecha_vencimiento>=#" & Format(inicio, "dd/mm/yyyy") & "#)"


            }


            mDatosDeuda.dDeudaCanon = DTotalCanon;
            mDatosDeuda.dDeudaIntrs = DTotalIntrs;
            mDatosDeuda.dIVAArriendo = DValorIVA;
            mDatosDeuda.dRetension = DRetension;
            mDatosDeuda.dSaldoAnt = DSalCanon;
            mDatosDeuda.dSaldoIntrs = DSalIntrs;
            mDatosDeuda.dVrCanon = DValorCanon;
            
            //mDatosDeuda.dValorRecargo1 = dVrRecargo1;
            //mDatosDeuda.dValorRecargo2 = dVrRecargo2;


            return DTLiquidarContrato;
        }

        public int SaberDiaPago(DateTime Fecha, DateTime Inicio)
        {
            int dia = 0;
            switch (Fecha.Day)
            {
                case 29 - 31:
                    {
                        switch (Inicio.Month)
                        {
                            case 2:
                                {
                                    if (Fecha.Day == 29)
                                    {
                                        if (DateTime.IsLeapYear(Inicio.Year))
                                            dia = 29;
                                    }
                                    else
                                        dia = 28;
                                    break;
                                }

                            case 4:
                                {
                                    if (Fecha.Day >= 30)
                                        dia = 30;
                                    else
                                        dia = Fecha.Day;
                                    break;
                                }
                            case 6:
                                {
                                    if (Fecha.Day >= 30)
                                        dia = 30;
                                    else
                                        dia = Fecha.Day;
                                    break;
                                }
                            case 9:
                                {
                                    if (Fecha.Day >= 30)
                                        dia = 30;
                                    else
                                        dia = Fecha.Day;
                                    break;
                                }
                            case 11:
                                {
                                    if (Fecha.Day >= 30)
                                        dia = 30;
                                    else
                                        dia = Fecha.Day;
                                    break;
                                }

                            default:
                                {
                                    dia = Fecha.Day;
                                    break;
                                }
                        }

                        break;
                    }

                default:
                    {
                        dia = Fecha.Day;
                        break;
                    }
            }
            return dia;
        }
        public int SaberDias(DateTime fActual, DateTime fInicial, string f)
        {
            DateTime dt;
            int Dias = 0;
            if (f == "A")
            {
                Dias = (fActual - fInicial).Days + 1;
                //Dias = DateDiff("d", CDate(fInicial), CDate(fActual)) + 1;
            }
            else if (f == "V")
            {
                dt = fInicial.AddMonths(1);
                //dt = DateAdd("m", 1, fInicial)
                Dias = (fActual - dt).Days + 1;
                //Dias= DateDiff("d", dt, CDate(fActual)) + 1
            }
            return Dias;
        }

        public DataTable LiquidarContratosPropietario(string Tipo_Id, int Id, string DV, DateTime FechaSistema, string tipo_comp, long No_comp, long RelacionMes, byte DiaLiq, DateTime fUltimoPago, bool Grabaliq, double NoOperacion)
        {
            N_Inmuebles Inmuebles = new N_Inmuebles();
            N_Contrato_Arren Contrato = new N_Contrato_Arren();
            N_Detalle_PagoProp LiquidacionPropietario = new N_Detalle_PagoProp();

            DataTable DTLiquidacionPropietario = new DataTable();
            DataRow DRFila = null;

            //dao.Recordset rsInmuebles;
            //dao.Recordset rsPago;
            //dao.Recordset RS;
            //dao.Recordset rst;
            //dao.Recordset rsContrato;
            //Dim rsLiqPago as dao.recordset
            //Inmuebles.ConectarA(ConectaA);
            //Inmuebles.Cadena(GsPath);
            //Contrato.ConectarA(ConectaA);
            //Contrato.Cadena(GsPath);
            //LiquidacionPropietario.ConectarA(ConectaA);
            //LiquidacionPropietario.Cadena(GsPath);
            DTLiquidacionPropietario = LiquidacionPropietario.Consultar("EG", -1);
            //DTLiquidacionPropietario.Columns.Add("comision", typeof(double));
            //DTLiquidacionPropietario.Columns.Add("comision_admon", typeof(double));
            //DTLiquidacionPropietario.Columns.Add("iva", typeof(double));
            //DTLiquidacionPropietario.Columns.Add("inmueble", typeof(int));
            //DRFila = DTLiquidacionPropietario.NewRow();
            //FilaPrueba = DTLiquidacionPropietario.NewRow();

            //long lItem;
            //string SQL;
            //double DTotalIVA;
            string Estado;
            DateTime FVen;
            DateTime Inicio = Convert.ToDateTime("01/01/1900");
            //DateTime FPH;
            int IItem = -1;

            DataTable DTInmueblesPropietario = new DataTable();

            //////inicializa variables

            //Inmuebles.DatosServidoryPath(GsPath);
            //Contrato.DatosServidoryPath(GsPath);

            //inicia la liquidación

            DTInmueblesPropietario = Inmuebles.ConsultaXPropietarioConContrato(Tipo_Id, Id, DV);

            if (DTInmueblesPropietario.Rows.Count > 0)
            {
                //DTotalIVA = 0;
                for (int i = 0; i <= DTInmueblesPropietario.Rows.Count - 1; i++)
                {
                    //DRFila = DTLiquidacionPropietario.NewRow();
                    //averiguar si el inmueble tiene varios contratos por pagar ej: 1 cancelado y 1 Arrendado
                    //datos del contrato
                    /////////////////////////
                    if (Contrato.Existe(Convert.ToInt32(DTInmueblesPropietario.Rows[i]["no_contrato"]), true))
                    {
                        //if (!string.IsNullOrWhiteSpace(Contrato.C_Contrato_Arren.Pago_hasta_prop.ToString()))
                        //{
                        //    Inicio = Contrato.C_Contrato_Arren.Pago_hasta_prop;
                        //}
                        //FPH = Contrato.C_Contrato_Arren.Pago_hasta_prop;
                        if (!string.IsNullOrWhiteSpace(Contrato.C_Contrato_Arren.Estado))
                        {
                            FVen = Contrato.C_Contrato_Arren.Fecha_vencimiento;
                            Estado = Contrato.C_Contrato_Arren.Estado;
                            //if ((Convert.ToDateTime(Inicio) < Contrato.C_Contrato_Arren.Fecha_vencimiento))
                            if (Contrato.C_Contrato_Arren.Pago_hasta_prop < Contrato.C_Contrato_Arren.Fecha_vencimiento)
                            {
                                if ((DiaLiq == 0) | (DiaLiq == Contrato.C_Contrato_Arren.Fecha_pago_prop.Day))
                                {
                                    DRFila = LiquidarContratoPropietario(ref DTLiquidacionPropietario, Tipo_Id, Id, DV, Contrato.C_Contrato_Arren.No_contrato, FechaSistema, tipo_comp, No_comp, RelacionMes, IItem, DiaLiq, Grabaliq, NoOperacion);

                                }
                            }
                        }
                        else
                        {
                            if (!string.IsNullOrWhiteSpace(DTInmueblesPropietario.Rows[i]["ultimocont"].ToString()))
                            {
                                DRFila = LiquidarContratoPropietario(ref DTLiquidacionPropietario, Tipo_Id, Id, DV, Convert.ToInt32(DTInmueblesPropietario.Rows[i]["ultimocont"]), FechaSistema, tipo_comp, No_comp, RelacionMes, IItem, DiaLiq, Grabaliq, NoOperacion);
                            }
                        }
                    }
                    //copiando en trabajo por si acaso
                    if (Grabaliq && DRFila != null)
                    {
                        //string Tabla = DRFila.Table.TableName.ToString();
                        //DTLiquidacionPropietario.ImportRow(DRFila);
                        //DTLiquidacionPropietario.Rows.Add(FilaPrueba);
                    }
                }
            }
            //Console.Write("cantidad de registros id " + Id + " inmuebles " + DTLiquidacionPropietario.Rows.Count);
            return DTLiquidacionPropietario;
        }
        public DataRow LiquidarContratoPropietario(ref DataTable DTLiquidacion, string Tipo_Id, long Id, string DV, int NoContrato, DateTime FechaSistema, string tipo_comp, long No_comp, long RelacionMes, long lItem, byte DiaLiq, bool Grabaliq, double NoOperacion)
        {

            N_Contrato_Arren Contrato = new N_Contrato_Arren();
            N_Detalle_PagoProp LiquidacionPago = new N_Detalle_PagoProp();
            N_Prorrogas Prorrogas = new N_Prorrogas();
            N_Control Control = new N_Control();
            N_Inmuebles Inmueble = new N_Inmuebles();

            //DataTable DTLiquidacion = new DataTable();
            DataRow DRFila = null;
            //Contrato.ConectarA(ConectaA);
            //Contrato.Cadena(GsPath);
            //LiquidacionPago.ConectarA(ConectaA);
            //LiquidacionPago.Cadena(GsPath);
            //Prorrogas.ConectarA(ConectaA);
            //Prorrogas.Cadena(GsPath);
            //Control.ConectarA(ConectaA);
            //Control.Cadena(GsPath);
            Control.Existe(true);
            //Inmueble.ConectarA(ConectaA);
            //Inmueble.Cadena(GsPath);


            //double DCanon, DAdmon;
            //double DTasa;
            DateTime FInicio;
            //DateTime FFechaPago;
            //string Estado;
            //string FVen;
            //string FPH;
            DateTime PagoHasta;
            int Pro;
            //dao.Recordset rst;
            int iDiasLiq;


            //On Error GoTo errE;

            //MensajeEstado "Liquidando contrato " + NoContrato + "...";


            //inicia la liquidaciòn

            //DTLiquidacion = LiquidacionPago.Consultar("EG", -1);
            DRFila = DTLiquidacion.NewRow();

            //SQL = "select * from detalle_pagoprop where tipo_comp='" + tipo_comp + "' and no_comp=" + No_comp + " AND  no_operacion=" + NoOperacion;
            //Set rsLiqPago = miDb.OpenRecordset(SQL, dbOpenDynaset);

            /////////////////////
            //datos del contrato
            ///////////////////////
            if (Contrato.Existe(NoContrato, true))
            {
                FInicio = Contrato.C_Contrato_Arren.Pago_hasta_prop;
                DRFila["tipo_comp"] = tipo_comp;
                DRFila["No_comp"] = No_comp;
                DRFila["no_contrato"] = NoContrato;
                DRFila["RelacionMes"] = RelacionMes;
                DRFila["Item"] = lItem; //daoPagos.Recordset!Item
                iDiasLiq = Contrato.C_Contrato_Arren.Fecha_vencimiento.Subtract(Contrato.C_Contrato_Arren.Pago_hasta_prop).Days;  //rsContrato!fecha_vencimiento - rsContrato!pago_hasta_prop;
                PagoHasta = FInicio.AddMonths(1); // DateAdd("m", 1, inicio);
                if (Contrato.C_Contrato_Arren.Fecha_vencimiento.Day == Contrato.C_Contrato_Arren.Fecha_inicio.Day)
                {
                    PagoHasta = FInicio.AddMonths(1); // DateAdd("m", 1, inicio);
                    iDiasLiq = 30;
                }
                else
                {
                    if (iDiasLiq >= 30)
                    {
                        PagoHasta = FInicio.AddMonths(1); // DateAdd("m", 1, inicio);
                        iDiasLiq = 30;
                    }
                    else if (iDiasLiq >= 1 & iDiasLiq < 30)
                    {
                        PagoHasta = Contrato.C_Contrato_Arren.Fecha_vencimiento; // rsContrato!fecha_vencimiento;
                                                                                 //iDiasLiq = iDiasLiq
                    }
                }
                DRFila["periodo"] = FInicio.ToString("dd-MMM-yyyy") + " a " + PagoHasta.AddDays(-1).ToString("dd-MMM-yyyy");
                DRFila["canon"] = Contrato.C_Contrato_Arren.Canonprop;
                if (Contrato.C_Contrato_Arren.Prorrogas != 0)
                {
                    Pro = Contrato.C_Contrato_Arren.Prorrogas - 1; // rsContrato!prorrogas - 1;
                                                                   //SQL1 = "select * from prorrogas where no_contrato=" + NoContrato + " and (fecha_inicio<=#" + System.String.Format(inicio, "mm/dd/yyyy") + "# and fecha_vencimiento>=#" + System.String.Format(inicio, "mm/dd/yyyy") + "#)"; //& [ª0006ª] & pro
                                                                   //Set rsP = miDb.OpenRecordset(SQL1, dbOpenDynaset);
                    DataTable DTProrrogas = Prorrogas.Consultar(Contrato.C_Contrato_Arren.No_contrato, FInicio);

                    if (DTProrrogas.Rows.Count > 0)
                    {
                        if ((DateTime)DTProrrogas.Rows[0]["fecha_inicio"] <= FInicio && (DateTime)DTProrrogas.Rows[0]["fecha_vencimiento"] >= FInicio)
                        {
                            DRFila["canon"] = DTProrrogas.Rows[0]["canonprop"];
                        }
                    }
                }
                if (iDiasLiq < 30)
                {
                    //ojo revisar en los cambios
                    DRFila["canon"] = Math.Round(Convert.ToDouble(DRFila["canon"]) / 30 * (iDiasLiq + 1)); // System.String.Format((!canon / 30) * (iDiasLiq + 1), "0");
                }
                //dTasa = rsContrato!Tasa_Admon_prop;
                DRFila["tasa_admon"] = Contrato.C_Contrato_Arren.Tasa_admon_prop;
                DRFila["comision"] = Math.Round(Convert.ToDouble(DRFila["canon"]) * Contrato.C_Contrato_Arren.Tasa_admon_prop, 0);
                DRFila["tasa_iva"] = 0;
                if (Contrato.C_Contrato_Arren.Sujeto_iva_prop)
                {
                    //mTotalIVA = mTotalIVA + Format(mAdmon * dTasaIVAAdmon, "0")
                    DRFila["tasa_iva"] = Control.C_Control.Tasa_iva_admon; // dTasaIVAAdmon;
                }
                DRFila["iva"] = Math.Round(Convert.ToDouble(DRFila["tasa_iva"]) * Convert.ToDouble(DRFila["comision"]), 0);
                DRFila["condominio"] = 0;
                DRFila["tasa_comision_admon"] = 0;
                DRFila["comision_admon"] = 0;
                if (Contrato.C_Contrato_Arren.Comisionadmon)
                {
                    Inmueble.Existe(Contrato.C_Contrato_Arren.Cod_inmueble, true);
                    DRFila["condominio"] = Inmueble.C_Inmuebles.Valor_admon;
                    DRFila["tasa_comision_admon"] = Control.C_Control.Tasa_comision_admon;
                    DRFila["comision_admon"] = Math.Round(Inmueble.C_Inmuebles.Valor_admon * Control.C_Control.Tasa_comision_admon, 0);
                }
                DRFila["no_operacion"] = NoOperacion;
                DRFila["valor_pagado"] = 0;
                DRFila["inmueble"] = Contrato.C_Contrato_Arren.Cod_inmueble;
            }

            /*SQL1 = "select contrato_arren.*, inmuebles.direccion " + " from contrato_arren INNER JOIN inmuebles ON contrato_arren.cod_inmueble=inmuebles.cod_inmueble" + " where " + " contrato_arren.no_contrato=" + NoContrato;
            Set rsContrato = miDb.OpenRecordset(SQL1);
            rsLiqPago.AddNew;
            inicio = rsContrato!pago_hasta_prop;
            !tipo_comp = tipo_comp;
            !No_comp = No_comp;
            !no_contrato = NoContrato;
            !RelacionMes = RelacionMes;
            !Item = lItem; //daoPagos.Recordset!Item
            iDiasLiq = rsContrato!fecha_vencimiento - rsContrato!pago_hasta_prop;*/
            /// OJO REVISAR LIQUIDACIONES CUANDO SEA FEBRERO
            /*if (DateTime.Now.Day(DateAdd("d", 1, rsContrato!fecha_vencimiento)) == DateTime.Now.Day(rsContrato!fecha_inicio))
            {
                PagoHasta = DateAdd("m", 1, inicio);
                !periodo = System.String.Format(inicio, "dd/mm/yyyy") + " a " + System.String.Format(DateAdd("d", -1, PagoHasta), "dd/mm/yyyy");
                iDiasLiq = 30;
            }
            else
            {
                if (iDiasLiq >= 30)
                {
                    PagoHasta = DateAdd("m", 1, inicio);
                    !periodo = System.String.Format(inicio, "dd/mm/yyyy") + " a " + System.String.Format(DateAdd("d", -1, PagoHasta), "dd/mm/yyyy");
                    iDiasLiq = 30;
                }
                else if (iDiasLiq >= 1 & iDiasLiq < 30)
                {
                    PagoHasta = rsContrato!fecha_vencimiento;
                    !periodo = System.String.Format(inicio, "dd/mm/yyyy") + " a " + System.String.Format(PagoHasta, "dd/mm/yyyy");
                    //iDiasLiq = iDiasLiq
                }
            }*/
            //.Recordset!fechapago = diapago
            //averiguar canon

            /*if (Contrato.C_Contrato_Arren.Prorrogas != 0 ){
                Pro = rsContrato!prorrogas - 1;
                SQL1 = "select * from prorrogas where no_contrato=" + NoContrato + " and (fecha_inicio<=#" + System.String.Format(inicio, "mm/dd/yyyy") + "# and fecha_vencimiento>=#" + System.String.Format(inicio, "mm/dd/yyyy") + "#)"; //& [ª0006ª] & pro
                Set rsP = miDb.OpenRecordset(SQL1, dbOpenDynaset);
                if (!rsP.EOF)
                {
                    if (rsP!fecha_inicio <= inicio & rsP!fecha_vencimiento >= inicio ){
                        !canon = rsP!canonprop;
                    }else{
                        !canon = System.String.Format(rsInmu!canonprop, "###0");
                    }
                }
                else
                {
                    !canon = System.String.Format(rsInmu!canonprop, "###0");
                }
            }else{
                !canon = System.String.Format(rsInmu!canonprop, "###0");
            }
            if (iDiasLiq < 30)
            {
                //ojo revisar en los cambios
                !canon = System.String.Format((!canon / 30) * (iDiasLiq + 1), "0");
            }
            dTasa = rsContrato!Tasa_Admon_prop;
            !Tasa_Admon = dTasa;
            !tasa_iva = 0;
            if (rsContrato!sujeto_iva_prop == true ){
                //mTotalIVA = mTotalIVA + Format(mAdmon * dTasaIVAAdmon, "0")
                !tasa_iva = dTasaIVAAdmon;
            }
            !no_operacion = NoOperacion;
            SQL = "SELECT comisionadmon FROM contrato_arren WHERE no_contrato=" + NoContrato;
            Set rsP = miDb.OpenRecordset(SQL);
            if (!rsP.EOF)
            {
                if (rsP!comisionadmon ){
                    !Condominio = rsInmuebles!valor_admon;
                    !tasa_comision_admon = dTasaComisionAdmon;
                }
            }*/
            DTLiquidacion.Rows.Add(DRFila);
            return DRFila;

        }

    }
}
