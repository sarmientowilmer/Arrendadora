using Microsoft.Reporting.WinForms;
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
    public partial class FrmReporte : Form
    {
        DataTable DT = new DataTable();
        string Nombre_DataSet = "";
        string Nombre_Reporte = "";
        public FrmReporte()
        {
            InitializeComponent();
        }

        public FrmReporte(string NombreVentana, string NombreReporte, string NombreDataSet, DataTable Datos)
        {
            InitializeComponent();
            this.Text = NombreVentana;
            Nombre_Reporte = NombreReporte;
            Nombre_DataSet = NombreDataSet;
            DT = Datos;
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            RPVReporte.ProcessingMode = ProcessingMode.Local;
            RPVReporte.LocalReport.ReportPath = Application.StartupPath + "\\" + Nombre_Reporte;
            ReportDataSource datos = new ReportDataSource(Nombre_DataSet, DT);
            //ReportDataSource totales = new ReportDataSource("Totales", Totales);
            //datos.Name = "DataSet1";
            //datos.Value = Reporte; //MiDS.Tables[0];
            //RPVReporte.LocalReport.DataSources.Add(new ReportDataSource("DataSet1",Reporte));
            //MessageBox.Show(Totales.Rows[0]["saldo_anterior"].ToString());
            RPVReporte.LocalReport.DataSources.Clear();
            RPVReporte.LocalReport.DataSources.Add(datos);
            //RPVReporte.LocalReport.DataSources.Add(totales);
            RPVReporte.SetDisplayMode(DisplayMode.PrintLayout);

            this.RPVReporte.RefreshReport();
        }
    }
}
