using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;


namespace Arrendadora
{
    public partial class FrmOtrosComprobantes : Form
    {
        N_Otroscomprobantes OtrosComprobantes = new N_Otroscomprobantes();
        public static FrmOtrosComprobantes F1;
        FrmPrincipal FormPrincipal = new FrmPrincipal();
        public FrmOtrosComprobantes()
        {
            InitializeComponent();
            F1 = this;
        }
        public FrmOtrosComprobantes(FrmPrincipal _Frm)
        {
            InitializeComponent();
            FormPrincipal = _Frm;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            FormPrincipal.MensajeEstado("Cargando formulario de Otros Comprobantes...");
            //OtrosComprobantes.Cadena(Program.GsPathData, Program.gsServidor);
            DTPDesde.Value = DateTime.Today;
            //DGVDatos.DataSource = OtrosComprobantes.ConsultaComprobantes(DTPDesde.Value.ToString("yyyy/MM/dd"), DTPHasta.Value.ToString("yyyy/MM/dd"));
            //DGVDatos.Columns["estado"].Width = 80;
            TotalesOtrosComprobantes();
            FormPrincipal.MensajeEstado("Listo");
        }

        public void ActualizarDatos()
        {
            FormPrincipal.MensajeEstado("Actualizando datos...");
            DGVDatos.DataSource = OtrosComprobantes.ConsultaComprobantes(DTPDesde.Value.ToString("yyyy/MM/dd"), DTPDesde.Value.ToString("yyyy/MM/dd"));
            TotalesOtrosComprobantes();
            CargarSaldos();
            FormPrincipal.MensajeEstado("Listo");
        }

        private void TotalesOtrosComprobantes()
        {
            FormPrincipal.MensajeEstado("Calculando totales...");
            LblCantIngresos.Text = "0";
            LblTotalIngresos.Text = "0.00";
            LblCantSalida.Text = "0";
            LblTotalSalida.Text = "0.00";
            LblCantIngresosB.Text = "0";
            LblIngresosB.Text = "0.00";
            LblCantEgresosB.Text = "0";
            LblEgresosB.Text = "0.00";

            int CantIngresos = 0;
            double TotalIngresos = 0;
            int CantEgresos = 0;
            double TotalEgresos = 0;


            DataTable DT = new DataTable();
            DT = OtrosComprobantes.TotalesComprobantes(DTPDesde.Value.ToString("yyyy/MM/dd"), DTPDesde.Value.ToString("yyyy/MM/dd"));
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow Fila in DT.Rows)
                {
                    switch (Fila["tipo_comp"].ToString())
                    {
                        case "OI":
                            CantIngresos += Convert.ToInt32(Fila["Cantidad"]);
                            TotalIngresos += Convert.ToDouble(Fila["Total"]);
                            if (Fila["forma_pago"].ToString() == "1")
                            {
                                LblCantIngresos.Text = Fila["Cantidad"].ToString();
                                LblTotalIngresos.Text = string.Format("{0:N2}", Convert.ToDouble(Fila["Total"].ToString()));
                            }
                            if (Fila["forma_pago"].ToString() == "4")
                            {
                                LblCantIngresosB.Text = Fila["Cantidad"].ToString();
                                LblIngresosB.Text = string.Format("{0:N2}", Convert.ToDouble(Fila["Total"].ToString()));
                            }

                            break;
                        case "OE":
                            CantEgresos += Convert.ToInt32(Fila["Cantidad"]);
                            TotalEgresos += Convert.ToDouble(Fila["Total"]);
                            if (Fila["forma_pago"].ToString() == "1")
                            {
                                LblCantSalida.Text = Fila["Cantidad"].ToString();
                                //double Valor = Convert.ToDouble(Fila["Total"].ToString());
                                LblTotalSalida.Text = string.Format("{0:N2}", Fila["Total"]);
                            }
                            if (Fila["forma_pago"].ToString() == "4")
                            {
                                LblCantEgresosB.Text = Fila["Cantidad"].ToString();
                                //double Valor = Convert.ToDouble(Fila["Total"].ToString());
                                LblEgresosB.Text = string.Format("{0:N2}", Fila["Total"]);
                            }

                            break;
                    }
                }
            }
            LblTCantIngresos.Text = CantIngresos.ToString();
            LblTIngresos.Text = TotalIngresos.ToString("N2");
            LblTCantEgresos.Text = CantEgresos.ToString();
            LblTEgresos.Text = TotalEgresos.ToString("N2");

            FormPrincipal.MensajeEstado("Listo");
        }

        private void CmdNuevo_Click(object sender, EventArgs e)
        {
            Form F = new FrmOtroComprobante(FormPrincipal, this);
            
            F.ShowDialog();
        }

        private void DGVDatos_DoubleClick(object sender, EventArgs e)
        {
            if (DGVDatos.Rows.Count > 0 && (Program.IdUsuario == 88159430 || DTPDesde.Value.ToString("yyyy-MM-dd")==DateTime.Today.ToString("yyyy-MM-dd")))
            {
                FrmOtroComprobante Formulario = new FrmOtroComprobante(FormPrincipal, DGVDatos.CurrentRow.Cells["tipo_comp"].Value.ToString(), Convert.ToInt32(DGVDatos.CurrentRow.Cells["no_comp"].Value),this);
                Formulario.ShowDialog();
            }
        }

        private void FrmOtrosComprobantes_Activated(object sender, EventArgs e)
        {
            //DGVDatos.DataSource = OtrosComprobantes.ConsultaComprobantes(DTPDesde.Value.ToString("yyyy/MM/dd"), DTPDesde.Value.ToString("yyyy/MM/dd"));
            //TotalesOtrosComprobantes();
            //CargarSaldos();
            ActualizarDatos();
        }

        private void DGVDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DGVDatos.Columns[e.ColumnIndex].Name == "descripcion_estado")
            {
                //if((string)e.Value == "Vigente")
                //{
                //    DGVDatos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
                //}
                if ((string)e.Value == "Anulado")
                {
                    DGVDatos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
            //if (DGVDatos.CurrentRow.Cells["estado"].Value.ToString() == "V")
            //{
            //    DGVDatos.CurrentRow.DefaultCellStyle.BackColor = Color.Cyan;
            //}
        }

        private void DGVDatos_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //if (DGVDatos.CurrentRow.Cells["estado"].Value.ToString() == "V")
            //{
            //    DGVDatos.CurrentRow.DefaultCellStyle.BackColor = Color.Cyan;
            //}
        }

        private void DGVDatos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        }

        private void CargarSaldos()
        {
            FormPrincipal.MensajeEstado("Cargando Saldos...");
            N_Saldos_Diarios SaldosDiarios = new N_Saldos_Diarios();
            N_Saldos_Diarios SaldosDiariosB = new N_Saldos_Diarios();
            //SaldosDiarios.Cadena(Program.GsPathData, Program.gsServidor);
            if (DTPDesde.Value <= DateTime.Today)
            {
                SaldosDiarios = SaldosDiarios.SaldoAnterior(DTPDesde.Value, 2);
                SaldosDiariosB = SaldosDiariosB.SaldoAnterior(DTPDesde.Value, 21);
            }
            
            LblSaldoAnterior.Text = SaldosDiarios.C_Saldos_Diarios.Saldo_anterior.ToString("N2");
            LblNuevoSaldo.Text = SaldosDiarios.C_Saldos_Diarios.Nuevo_saldo.ToString("N2");
            LblSaldoAnteriorB.Text = SaldosDiariosB.C_Saldos_Diarios.Saldo_anterior.ToString("N2");
            LblNuevoSaldoB.Text = SaldosDiariosB.C_Saldos_Diarios.Nuevo_saldo.ToString("N2");
            LblTSaldoAnterior.Text = (SaldosDiarios.C_Saldos_Diarios.Saldo_anterior + SaldosDiariosB.C_Saldos_Diarios.Saldo_anterior).ToString("N2");
            LblTNuevoSaldo.Text = (SaldosDiarios.C_Saldos_Diarios.Nuevo_saldo + SaldosDiariosB.C_Saldos_Diarios.Nuevo_saldo).ToString("N2");
            FormPrincipal.MensajeEstado("Listo");
        }

        private void DTPDesde_ValueChanged(object sender, EventArgs e)
        {
            CmdNuevo.Enabled = true;
            if (DTPDesde.Value.ToString("yyyy-MM-dd") != DateTime.Today.ToString("yyyy-MM-dd"))
            {
                CmdNuevo.Enabled = false;
            }
            //MessageBox.Show(DTPDesde.Value.ToString() + " - " + DateTime.Today);
            //DGVDatos.DataSource = OtrosComprobantes.ConsultaComprobantes(DTPDesde.Value.ToString("yyyy/MM/dd"), DTPDesde.Value.ToString("yyyy/MM/dd"));
            //TotalesOtrosComprobantes();
            //CargarSaldos();
            ActualizarDatos();
        }

        private void BtnReporteDiario_Click(object sender, EventArgs e)
        {
            FormPrincipal.MensajeEstado("Generando reporte...");
            N_Saldos_Diarios Diario = new N_Saldos_Diarios();
            //Diario.Cadena(Program.GsPathData, Program.gsServidor);
            //MessageBox.Show(DT.Rows.Count.ToString());
            FrmReporteDiarioOC Frm = new FrmReporteDiarioOC((DataTable)DGVDatos.DataSource, Diario.ConsultarDT(DTPDesde.Value));
            Frm.ShowDialog();
            FormPrincipal.MensajeEstado("Listo");
        }

        //private void DTPHasta_ValueChanged(object sender, EventArgs e)
        //{
        //    //if (DTPHasta.Value != DTPDesde.Value)
        //    //{
        //        DGVDatos.DataSource = OtrosComprobantes.ConsultaComprobantes(DTPDesde.Value.ToString("yyyy/MM/dd"), DTPDesde.Value.ToString("yyyy/MM/dd"));
        //    TotalesOtrosComprobantes();
        //    //}            
        //}
    }
}
