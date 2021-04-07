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
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            Funciones Func = new Funciones();
            //Func.IniciarAccess();
            Timer1.Interval = 3000;
            Timer1.Enabled = true;
            Timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
