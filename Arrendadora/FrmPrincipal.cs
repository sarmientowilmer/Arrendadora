using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrendadora
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void InmueblesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmInmuebles F = new FrmInmuebles();
            MostrarFormulario(F);
        }

        private void PruebaLiquidaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPruebaLiquidarInquilino F = new FrmPruebaLiquidarInquilino();
            MostrarFormulario(F);
        }

        public void MostrarFormulario(Form F)
        {
            TCPrincipal.TabPages.Add(F);
            F.Show();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("Está seguro de salir del sistema", "Cerrar Sistema", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (Resultado == DialogResult.Yes) Application.Exit();
        }

        private void OtrosComprobantesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmOtrosComprobantes F = new FrmOtrosComprobantes(this);
            MostrarFormulario(F);
        }

        private void LiquidarPagoAPropietarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPagoAPropietario F = new FrmPagoAPropietario(this);
            //F.Parent = this;
            MostrarFormulario(F);
        }
        public void MensajeEstado(string Mensaje)
        {
            TSSEstado.Text = Mensaje;
            SSBarraEstado.Refresh();
        }

        private void TransferirWEBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGrabarWeb F = new FrmGrabarWeb();
            MostrarFormulario(F);
        }

        private void PruebaReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporte F = new FrmReporte();
            MostrarFormulario(F);
        }

        private void CarteraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCartera F = new FrmCartera();
            MostrarFormulario(F);
        }

        private void ControlCambiosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormControlCambios F = new FormControlCambios(this);
            MostrarFormulario(F);
        }

        private void PasarFotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPasarFotos F = new FrmPasarFotos();
            MostrarFormulario(F);
        }

        private void registrarseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generarFotosRedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenerarFotosRedes F = new FrmGenerarFotosRedes();
            MostrarFormulario(F);
        }
    }
}
