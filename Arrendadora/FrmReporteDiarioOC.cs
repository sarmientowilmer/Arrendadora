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
    public partial class FrmReporteDiarioOC : Form
    {
        public DataTable MiDT = new DataTable();
        public DataTable Totales = new DataTable();
        public FrmReporteDiarioOC()
        {
            InitializeComponent();
        }

        public FrmReporteDiarioOC(DataTable DT)
        {
            InitializeComponent();
            MiDT = DT;
        }

        public FrmReporteDiarioOC(DataTable DT, DataTable Totales_reporte)
        {
            InitializeComponent();
            MiDT = DT;
            Totales = Totales_reporte;
        }

        private void FrmReporteDiarioOC_Load(object sender, EventArgs e)
        {
            RPVReporte.ProcessingMode = ProcessingMode.Local;
            RPVReporte.LocalReport.ReportPath = Application.StartupPath + "\\RptListadoOtrosComp.rdlc";
            ReportDataSource datos = new ReportDataSource("DataSet2", MiDT);
            ReportDataSource totales = new ReportDataSource("Totales", Totales);
            //datos.Name = "DataSet1";
            //datos.Value = Reporte; //MiDS.Tables[0];
            //RPVReporte.LocalReport.DataSources.Add(new ReportDataSource("DataSet1",Reporte));
            //MessageBox.Show(Totales.Rows[0]["saldo_anterior"].ToString());
            RPVReporte.LocalReport.DataSources.Clear();
            RPVReporte.LocalReport.DataSources.Add(datos);
            RPVReporte.LocalReport.DataSources.Add(totales);
            RPVReporte.SetDisplayMode(DisplayMode.PrintLayout);

            RPVReporte.RefreshReport();
        }
    }
}
