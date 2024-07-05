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
    public partial class FrmLogin : Form
    {
        N_Usuarios Usuarios = new N_Usuarios();
        int intentos = 0;
        public FrmLogin()
        {
            InitializeComponent();
            //Usuarios.Cadena(Program.GsPathData, Program.gsServidor);
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13) { TxtPass.Focus(); }
        }

        private void TxtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { BtnAceptar.Focus(); }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text!="" && TxtPass.Text != "")
            {
                switch (Usuarios.ValidaUsuario(Convert.ToInt32(TxtUsuario.Text),TxtPass.Text))
                {
                    case 0:
                        MessageBox.Show("Usuario no registrado, por favor revise");
                        break;
                    case 1:
                        MessageBox.Show("Bienvenido al Sistema");
                        this.DialogResult = DialogResult.OK;
                        Program.IdUsuario = Convert.ToInt32(TxtUsuario.Text);
                        this.Close();
                        break;
                    case 2:
                        MessageBox.Show("La contraseña no coincide");
                        intentos++;
                        if (intentos == 4)
                        {
                            MessageBox.Show("Por favor contacte al administrador");
                            Application.Exit();
                        }
                        break;
                }
            }
        }
    }
}
