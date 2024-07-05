using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Modelo;

namespace Arrendadora
{
    public partial class FrmCartera : Form
    {
        public FrmCartera()
        {
            InitializeComponent();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            N_Contrato_Arren Contratos = new N_Contrato_Arren();
            N_Informe Informe = new N_Informe();
            //Contratos.ConectarA("wilmer_portatil");
            //Contratos.Cadena(Program.GsPathData, Program.gsServidor);
            //Informe.ConectarA("wilmer_portatil");
            //Informe.Cadena(Program.GsPathData, Program.gsServidor);
            //Contratos.GenerarDeuda();
            GenerarDeuda();
            DGVDetalle.DataSource = Informe.Consultar();
        }
        public void GenerarDeuda(Boolean ProyInq = false)
        {

            DateTime dFechaSistema = DateTime.Today;
            DateTime dLiqHasta = DateTime.Today;
            int DiasControl;
            int iDia = 0;
            M_DatosDeudaContrato DatosDeudaCont = new M_DatosDeudaContrato();
            bool bFacturo = false;
            int DiasV = 0;
            DateTime TiempoInicial;
            DateTime TiempoFinal;
            DateTime TiempoIniInf;
            DateTime TiempoFinalInf;


            DataTable DTInmuebles = new DataTable();
            DataTable DTContratos = new DataTable();
            N_Inmuebles Inmuebles = new N_Inmuebles();
            
            N_Control Control = new N_Control();
            N_Empresas Empresa = new N_Empresas();
            N_Informe Informe = new N_Informe();

            N_Contrato_Arren Contratos = new N_Contrato_Arren();
            Contratos.ConectarA("wilmer_portatil");
            Inmuebles.ConectarA("wilmer_portatil");
            Control.ConectarA("wilmer_portatil");
            Empresa.ConectarA("wilmer_portatil");
            Informe.ConectarA("wilmer_portatil");
            //Contratos.ConectarA("Access");
            //Inmuebles.ConectarA("Access");
            //Control.ConectarA("Access");
            //Empresa.ConectarA("Access");
            //Informe.ConectarA("Access");

            dFechaSistema = DateTime.Today;

            //Control.Cadena(Program.GsPathData, Program.gsServidor);
            Control.Existe(true);
            //Empresa.Cadena(Program.GsPathData, Program.gsServidor);
            Empresa.Existe(true);
            //Informe.Cadena(Program.GsPathData, Program.gsServidor);
            //Inmuebles.Cadena(Program.GsPathData, Program.gsServidor);
            //Contratos.ConectaA = "wilmer_portatil";
            //Contratos.Cadena(Program.GsPathData, Program.gsServidor);

            Informe.BorrarDatos();

            //DTInmuebles = Inmuebles.Consultar();


            //if (DTInmuebles.Rows.Count > 0)
            //{
            //foreach (DataRow Fila in DTInmuebles.Rows)
            //{
                    //DTotalIntrs = 0; DTotalCanon = 0; DTotalDeuda = 0;
                    //Inmueble = Convert.ToInt32(Fila["cod_inmueble"]);
                    //DTContratos = Contratos.ContratosXInmueble(Inmueble);
                    
                    DTContratos = Contratos.ContratosALiquidar();
                    foreach (DataRow DRContrato in DTContratos.Rows)
                    {
                        //dFechaSistema = DateTime.Today;
                        //if (Contratos.Existe(Convert.ToInt32(DRContrato["no_contrato"]), true))
                        //{
                            TiempoInicial = DateTime.Now;
                            Contratos.CargarDatos(DRContrato);
                            //if (Contratos.C_Contrato_Arren.No_contrato == 2016109)
                            //{
                                //MessageBox.Show("entro");
                            //}
                            //Debug.Print ("Liquidando contrato: " + DRContrato["no_contrato"].ToString());
                            //Contratos.C_Contrato_Arren = (M_Contrato_Arren)DRContrato;
                            Application.DoEvents();
                            //label1.Text = "liquidando el contrato: " + Contratos.C_Contrato_Arren.No_contrato;
                            dFechaSistema = DateTime.Today;
                            if (Contratos.C_Contrato_Arren.Fecha_vencimiento > Contratos.C_Contrato_Arren.Pago_hasta)
                            {
                                if (Contratos.C_Contrato_Arren.Formapago == "A")
                                {
                                    DiasControl = (Contratos.C_Contrato_Arren.Fecha_vencimiento - Contratos.C_Contrato_Arren.Pago_hasta).Days + 1;
                                }
                                else
                                    DiasControl = (Contratos.C_Contrato_Arren.Fecha_vencimiento - Contratos.C_Contrato_Arren.Pago_hasta.AddMonths(2)).Days + 1;
                                                

                                if (DiasControl >= 30)
                                {
                                    if (dFechaSistema >= Contratos.C_Contrato_Arren.Fecha_vencimiento && dFechaSistema > Contratos.C_Contrato_Arren.Pago_hasta)
                                    { dLiqHasta = Contratos.C_Contrato_Arren.Fecha_vencimiento; }
                                    else if (Contratos.C_Contrato_Arren.Pago_hasta >= dFechaSistema)
                                    {
                                        if (ProyInq)
                                        {
                                            if (Contratos.C_Contrato_Arren.Pago_hasta.AddMonths(1) > Contratos.C_Contrato_Arren.Fecha_vencimiento)
                                                dLiqHasta = Contratos.C_Contrato_Arren.Fecha_vencimiento;
                                            else
                                                dLiqHasta = Contratos.C_Contrato_Arren.Pago_hasta.AddMonths(1).AddDays(-1);
                                        }
                                        else
                                            dLiqHasta = Contratos.C_Contrato_Arren.Pago_hasta.AddDays(-1);
                                    }
                                    else
                                    {
                                        if (Contratos.C_Contrato_Arren.Pago_hasta.Day > 28)
                                        {
                                            if (dFechaSistema.Month == 2)
                                            {
                                                iDia = 28;
                                                if (Contratos.C_Contrato_Arren.Pago_hasta.Date.Day == 29)
                                                {
                                                    if (DateTime.IsLeapYear(dFechaSistema.Year)) iDia = 29;
                                                }
                                            }
                                            if (dFechaSistema.Month == 4 || dFechaSistema.Month == 6 || dFechaSistema.Month == 9 || dFechaSistema.Month == 11) iDia = 30;
                                            else iDia = Contratos.C_Contrato_Arren.Pago_hasta.Day;
                                        }
                                        else iDia = Contratos.C_Contrato_Arren.Pago_hasta.Day;

                                        //Debug.Print CDate(iDia &"/" & Month(dFechaSistema) & "/" & Year(dFechaSistema)) -C_Contrato_Arrenpago_hasta + 1
                                        //Debug.Print CDate(Day(C_Contrato_Arrenpago_hasta) & "/" & Month(dFechaSistema) & "/" & Year(dFechaSistema))
                                        if ((Convert.ToDateTime(iDia + "/" + dFechaSistema.Month + "/" + dFechaSistema.Year) - Contratos.C_Contrato_Arren.Pago_hasta).Days + 1 >= 30)
                                        {
                                            if (dFechaSistema.Day > iDia)
                                            {
                                                iDia = Contratos.C_Contrato_Arren.Pago_hasta.Day;
                                                if (Contratos.C_Contrato_Arren.Pago_hasta.Day > 28)
                                                {
                                                    if (dFechaSistema.AddMonths(1).Month == 2)
                                                    {
                                                        if (DateTime.IsLeapYear(dFechaSistema.Year)) iDia = 29;
                                                        else iDia = 28;
                                                    }
                                                    if (dFechaSistema.AddMonths(1).Month == 4 || dFechaSistema.AddMonths(1).Month == 6 || dFechaSistema.AddMonths(1).Month == 9 || dFechaSistema.AddMonths(1).Month == 11) iDia = 30;
                                                }

                                                if (dFechaSistema.Month < 12)
                                                    dLiqHasta = Convert.ToDateTime(iDia + "/" + dFechaSistema.AddMonths(1).Month + "/" + dFechaSistema.Year).AddDays(-1);
                                                else
                                                    dLiqHasta = Convert.ToDateTime(iDia + "/" + dFechaSistema.AddMonths(1).Month + "/" + (dFechaSistema.Year + 1)).AddDays(-1);
                                            }
                                            else
                                                dLiqHasta = Convert.ToDateTime(iDia + "/" + dFechaSistema.Month + "/" + dFechaSistema.Year).AddDays(-1);
                                        }
                                        else
                                        {
                                            dLiqHasta = Contratos.C_Contrato_Arren.Pago_hasta.AddMonths(1).AddDays(-1);
                                            if (Contratos.C_Contrato_Arren.Fecha_vencimiento >= dFechaSistema && dFechaSistema > dLiqHasta && (dFechaSistema.Subtract(dLiqHasta).Days > Control.C_Control.Diasgracia))
                                                dLiqHasta = Contratos.C_Contrato_Arren.Pago_hasta.AddMonths(2).AddDays(-1);
                                            //else
                                            //    dLiqHasta = C_Contrato_Arren.Pago_hasta.AddMonths(1).AddDays(-1);
                                        }

                                    }
                                }
                                else if (Contratos.C_Contrato_Arren.Formapago =="V" && DiasControl==0)
                                    dLiqHasta = Convert.ToDateTime("01/01/1900");
                                else if (dFechaSistema < Contratos.C_Contrato_Arren.Pago_hasta && Contratos.C_Contrato_Arren.Saldo_canon==0)
                                    dLiqHasta = Convert.ToDateTime("01/01/1900");
                                else
                                    dLiqHasta = Contratos.C_Contrato_Arren.Fecha_vencimiento;

                            }
                            else
                            {
                                if (Contratos.C_Contrato_Arren.Saldo_canon > 0 || Contratos.C_Contrato_Arren.Saldo_intereses > 0) dLiqHasta = Contratos.C_Contrato_Arren.Fecha_vencimiento;
                                else dLiqHasta = Convert.ToDateTime("01/01/1900");
                            }

                            if (dLiqHasta != Convert.ToDateTime("01/01/1900"))
                            {    //if (dLiqHasta > C_Contrato_Arren.Fecha_vencimiento) dLiqHasta = C_Contrato_Arren.Fecha_vencimiento;
                                if (Contratos.C_Contrato_Arren.No_contrato == 20080082)
                                {
                                    Convert.ToInt32("100");
                                }
                                Contratos.LiquidarContratoInquilino(Control, Contratos.C_Contrato_Arren, Contratos.C_Contrato_Arren.No_contrato, dFechaSistema, DateTime.Today, dLiqHasta, 0, "", 0, false, false, 0, ref bFacturo, ref DatosDeudaCont);

                            }
                            if (dLiqHasta != Convert.ToDateTime("01/01/1900"))
                            {
                                TiempoIniInf = DateTime.Now;
                                if (DatosDeudaCont.dDeudaCanon > 0 || DatosDeudaCont.dDeudaIntrs > 0)
                                {
                                    //Informe.C_Informe = new M_Informe();
                                    Informe.C_Informe.No_contrato = Contratos.C_Contrato_Arren.No_contrato;
                                    Informe.C_Informe.Deudacanon = DatosDeudaCont.dDeudaCanon;
                                    Informe.C_Informe.Deudaintrs = DatosDeudaCont.dDeudaIntrs;
                                    Informe.C_Informe.Dias = 0;
                                    Informe.C_Informe.Cod_empresa = 1;
                                    if (Contratos.C_Contrato_Arren.Enabogado)
                                    {
                                        if (!string.IsNullOrEmpty(Contratos.C_Contrato_Arren.FEntAbogado.ToString()))
                                            dFechaSistema = Contratos.C_Contrato_Arren.FEntAbogado;
                                    }
                                    if (Contratos.C_Contrato_Arren.EnConciliacion)
                                    {
                                        if (!string.IsNullOrEmpty(Contratos.C_Contrato_Arren.Fecha_enconciliacion.ToString()))
                                            dFechaSistema = Contratos.C_Contrato_Arren.Fecha_enconciliacion;
                                    }
                                    DiasV = Contratos.SaberDias(dFechaSistema, Contratos.C_Contrato_Arren.Pago_hasta, Contratos.C_Contrato_Arren.Formapago);
                                    if (Contratos.C_Contrato_Arren.Pago_hasta < Contratos.C_Contrato_Arren.Fecha_vencimiento && DiasV > 0)
                                    {
                                        if (DiasV <= Control.C_Control.Diasgracia)
                                        {
                                            if (DatosDeudaCont.dSaldoAnt > 0)
                                            {
                                                DiasV = Contratos.SaberDias(dFechaSistema, Contratos.C_Contrato_Arren.Ultimopago, Contratos.C_Contrato_Arren.Formapago);
                                                Informe.C_Informe.Deudacanon = DatosDeudaCont.dSaldoAnt;
                                            }
                                            Informe.C_Informe.Dias = DiasV;
                                        }
                                        else
                                            Informe.C_Informe.Dias = DiasV;
                                    }
                                    else if (DatosDeudaCont.dSaldoAnt > 0 && DiasV > 0)
                                    {
                                        DiasV = Contratos.SaberDias(dFechaSistema, Contratos.C_Contrato_Arren.Ultimopago, Contratos.C_Contrato_Arren.Formapago);
                                        //Informe.C_Informe.Deudacanon = DatosDeudaCont.dSaldoAnt;
                                        if (DiasV > 0) Informe.C_Informe.Dias = DiasV;
                                    }
                                    else
                                        Informe.C_Informe.Dias = 0;
                                    Informe.Insertar(Informe.C_Informe);
                                    TiempoFinalInf = DateTime.Now;
                                    Debug.Print("Grabando en Informe: " + Contratos.C_Contrato_Arren.No_contrato + " tiempo: " + (TiempoFinalInf - TiempoIniInf).TotalSeconds);
                    }
                            }
                        TiempoFinal = DateTime.Now;
                        Debug.Print("liquidando contrato: "+ Contratos.C_Contrato_Arren.No_contrato + " tiempo: " + (TiempoFinal-TiempoInicial).TotalSeconds.ToString());
                        label1.Text = "liquidando contrato: " + Contratos.C_Contrato_Arren.No_contrato + " tiempo: " + (TiempoFinal - TiempoInicial).TotalSeconds.ToString();
                        //}
                    }
                //}

            //}
        }

    }
}
