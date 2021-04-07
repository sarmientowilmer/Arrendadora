using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Arrendadora
{
    public partial class FormControlCambios : Form
    {
        FrmPrincipal FormPrincipal = new FrmPrincipal();
        public FormControlCambios()
        {
            InitializeComponent();
        }

        public FormControlCambios(FrmPrincipal _Frm)
        {
            InitializeComponent();
            FormPrincipal = _Frm;
            FormPrincipal.MensajeEstado("Listo");
        }

        private void FormControlCambios_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }



        private void CargarDatos()
        {
            N_Controlcambios ControlCambios = new N_Controlcambios();
            FormPrincipal.MensajeEstado("Cargando datos del reporte");
            //ControlCambios.Cadena(Program.GsPathData, Program.gsServidor);
            DGVDetalle.DataSource = ControlCambios.ConsultaReporte(DTPFecha.Value);
            FormPrincipal.MensajeEstado("Listo");
        }

        private void DTPFecha_ValueChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void BtnReporteDiario_Click(object sender, EventArgs e)
        {
            FrmReporte Frm = new FrmReporte("Reporte de Modificaciones Autorizadas","RptControlCambios.rdlc", "ControlCambios", (DataTable)DGVDetalle.DataSource);
            Frm.ShowDialog();
        }
    }
}
