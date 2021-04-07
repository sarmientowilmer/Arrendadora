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
    public partial class FrmAutoriza : Form
    {
        N_Usuarios Usuarios = new N_Usuarios();
        N_Controlcambios ControlCambios = new N_Controlcambios();
        public FrmAutoriza()
        {
            InitializeComponent();
            //ControlCambios.Cadena(Program.GsPathData, Program.gsServidor);
            //Usuarios.Cadena(Program.GsPathData, Program.gsServidor);
        }

        public FrmAutoriza(N_Controlcambios ControlCambio)
        {
            InitializeComponent();
            //Usuarios.Cadena(Program.GsPathData, Program.gsServidor);
            ControlCambios = ControlCambio;
            //ControlCambios.Cadena(Program.GsPathData, Program.gsServidor);
        }

        private void FrmAutoriza_Load(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text != "" && TxtPass.Text != "" && TxtMotivo.Text!="")
            {
                switch (Usuarios.EsAdmin(Convert.ToInt32(TxtUsuario.Text), TxtPass.Text))
                {
                    case 0:
                        MessageBox.Show("El usuario no puede autorizar modificaciones", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 1:
                        ControlCambios.C_Controlcambios.Fecha = DateTime.Today;
                        ControlCambios.C_Controlcambios.Hora = DateTime.Now;
                        ControlCambios.C_Controlcambios.Tabla = "OtrosComprobantes";
                        ControlCambios.C_Controlcambios.Valornvo = "Anulado";
                        ControlCambios.C_Controlcambios.Autorizo = Convert.ToInt32(TxtUsuario.Text);
                        ControlCambios.C_Controlcambios.Motivo = TxtMotivo.Text;
                        if (ControlCambios.Insertar(ControlCambios.C_Controlcambios) == -1)
                        {
                            MessageBox.Show("No se pudo grabar el registro de control");
                        }
                        else
                        {
                            MessageBox.Show("Modificación exitosa");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        break;
                    case 2:
                        MessageBox.Show("La contraseña no coincide", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese información en todos los campos");
            }
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { TxtPass.Focus(); }
        }

        private void TxtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { TxtMotivo.Focus(); }
        }

        private void TxtMotivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { BtnAceptar.Focus(); }
        }
    }
}
