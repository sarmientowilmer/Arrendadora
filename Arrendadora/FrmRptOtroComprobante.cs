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
using Negocio;
using System.Configuration;

namespace Arrendadora
{
    public partial class FrmRptOtroComprobante : Form
    {
        public List<NR_OtroComprobante> Reporte = new List<NR_OtroComprobante>();
        public FrmRptOtroComprobante()
        {
            InitializeComponent();
        }

        public FrmRptOtroComprobante(NR_OtroComprobante Clase)
        {
            InitializeComponent();
            Reporte.Add(Clase);
        }

        private void FrmRptOtroComprobante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Auxiliares' Puede moverla o quitarla según sea necesario.
            //this.AuxiliaresTableAdapter.Fill(this.DataSet1.Auxiliares);
            
            this.RPVReporte.ProcessingMode = ProcessingMode.Local;
            this.RPVReporte.LocalReport.ReportPath = Application.StartupPath + "\\RptOtroComprobante.rdlc";
            ReportDataSource datos = new ReportDataSource("DataSet1", Reporte);
            //datos.Name = "DataSet1";
            //datos.Value = Reporte; //MiDS.Tables[0];
            //RPVReporte.LocalReport.DataSources.Add(new ReportDataSource("DataSet1",Reporte));
            this.RPVReporte.LocalReport.DataSources.Clear();
            this.RPVReporte.LocalReport.DataSources.Add(datos);
            this.RPVReporte.SetDisplayMode(DisplayMode.PrintLayout);

            var pagesett = RPVReporte.GetPageSettings();

            pagesett.Landscape = ConfigurationManager.AppSettings["Landscape"].Equals("true") ? true : false;
            pagesett.PaperSize.RawKind = Convert.ToInt32(ConfigurationManager.AppSettings["RawKind"]); //6
            pagesett.PaperSize.Width = Convert.ToInt32(ConfigurationManager.AppSettings["Width"]);//550;
            pagesett.PaperSize.Height = Convert.ToInt32(ConfigurationManager.AppSettings["Height"]);//850;
            pagesett.PaperSize.PaperName = ConfigurationManager.AppSettings["PaperName"];
            //Console.WriteLine("tamaño de papel page:" + pagesett.PaperSize.ToString());
            RPVReporte.SetPageSettings(pagesett);


            //this.RPVReporte.PrintDialog();
            
            this.RPVReporte.RefreshReport();

        }

        private void RPVReporte_Load(object sender, EventArgs e)
        {
            //var pagesett = RPVReporte.GetPageSettings();
            //pagesett.Landscape = true;
            //pagesett.PaperSize.RawKind = 6;
            //pagesett.PaperSize.Width = 550;
            //pagesett.PaperSize.Height = 850;
            //pagesett.PaperSize.PaperName = "Estamento";
            //Console.WriteLine("tamaño de papel page:" + pagesett.PaperSize.ToString());
            //RPVReporte.SetPageSettings(pagesett);
            Console.WriteLine("entro al load del reporte");

        }
    }
}
