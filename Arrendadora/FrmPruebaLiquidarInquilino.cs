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
using Modelo; 

namespace Arrendadora
{
    public partial class FrmPruebaLiquidarInquilino : Form
    {
        N_Contrato_Arren Contratos = new N_Contrato_Arren();
        N_Contrato_Arren ContratoMariaDB = new N_Contrato_Arren();
        N_Control Control = new N_Control();
        N_Auxiliares Tercero = new N_Auxiliares();

        public FrmPruebaLiquidarInquilino()
        {
            InitializeComponent();
        }

        private void FrmPruebaLiquidarInquilino_Load(object sender, EventArgs e)
        {
            //Control.Cadena(Program.GsPathData, Program.gsServidor);
            Control.Existe(true);
            //Tercero.Cadena(Program.GsPathData, Program.gsServidor);
            //Contratos.ConectarA(null);
            //Contratos.DatosServidoryPath(Application.StartupPath);
            //Console.Write(Contratos.GsPath);
            dataGridView1.DataSource = Contratos.Consultar();
            ContratoMariaDB.ConectarA("wilmer_portatil");
            ContratoMariaDB.DatosServidoryPath(Application.StartupPath);
            Console.Write(ContratoMariaDB.GsPath);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool bFacturo = false;
            M_DatosDeudaContrato DeudaContrato = new M_DatosDeudaContrato();
            DateTime TiempoIni = DateTime.Now;
            Contratos.Existe(Convert.ToInt32(textBox1.Text), true);
            Tercero.Existe(Contratos.C_Contrato_Arren.Tipo_id, Contratos.C_Contrato_Arren.Id_inquilino, true);
            dataGridView2.DataSource = Contratos.LiquidarContratoInquilino(Control, Contratos.C_Contrato_Arren, Convert.ToInt32(textBox1.Text), DateTime.Today, DateTime.Today, DateTime.Today, 0, "RC", -1, true, false, -1, ref bFacturo, ref DeudaContrato);
            DateTime TiempoFinal = DateTime.Now;
            MessageBox.Show("tiempo del proceso " + (TiempoFinal.Subtract(TiempoIni).TotalSeconds));
            //dataGridView2.DataSource = Contratos.LiquidarContratosPropietario("CC", Convert.ToInt32(textBox1.Text), "", DateTime.Today, "EG", -1, 201901, 0, DateTime.Today, true, -1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DateTime TiempoIni = DateTime.Now;
            dataGridView3.DataSource = Contratos.LiquidarContratosPropietario("CC", Convert.ToInt32(textBox2.Text), "", DateTime.Today, "EG", -1, 201901, 0, DateTime.Today, true, -1);
            DateTime TiempoFinal = DateTime.Now;
            MessageBox.Show("tiempo del proceso " + (TiempoFinal.Subtract(TiempoIni).TotalSeconds));
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DateTime TiempoIni = DateTime.Now;
            DataGridView4.DataSource = ContratoMariaDB.LiquidarContratosPropietario("CC", Convert.ToInt32(textBox3.Text), "", DateTime.Today, "EG", -1, 201901, 0, DateTime.Today, true, -1);
            DateTime TiempoFinal = DateTime.Now;
            MessageBox.Show("tiempo del proceso " + (TiempoFinal.Subtract(TiempoIni).TotalSeconds));

        }

    }
}
