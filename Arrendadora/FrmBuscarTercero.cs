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
    public partial class FrmBuscarTercero : Form
    {
        N_Auxiliares Terceros = new N_Auxiliares();
        public string _Tipo_aux;
        public string _Id_aux;
        public string _Nombre_aux;

        public FrmBuscarTercero()
        {
            InitializeComponent();
            //Terceros.Cadena(Program.GsPathData, Program.gsServidor);
        }

        private void Buscar()
        {
            DGVDatos.DataSource = Terceros.ConsultarTerceros(TxtApellido1.Text, TxtApellido2.Text, TxtNombres.Text,CHKPropietario.Checked,CHKInquilino.Checked);
        }

        private void FrmBuscarTercero_Load(object sender, EventArgs e)
        {

        }

        private void TxtApellido1_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void TxtApellido2_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void TxtNombres_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void DGVDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar();
        }

        public void Seleccionar()
        {
            if (DGVDatos.CurrentRow == null)
                return;
            _Tipo_aux = Convert.ToString(DGVDatos.CurrentRow.Cells[0].Value);
            _Id_aux = DGVDatos.CurrentRow.Cells[1].Value.ToString();
            _Nombre_aux = DGVDatos.CurrentRow.Cells[3].Value.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            FrmTerceros Form = new FrmTerceros();
            Form.ShowDialog();
        }

        private void CHKInquilino_CheckedChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void CHKPropietario_CheckedChanged(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
