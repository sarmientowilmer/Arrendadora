namespace Arrendadora
{
    partial class FrmReporteDiarioOC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteDiarioOC));
            this.RPVReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NR_ListadoOtrosComprobantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NR_ListadoOtrosComprobantesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RPVReporte
            // 
            this.RPVReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.NR_ListadoOtrosComprobantesBindingSource;
            this.RPVReporte.LocalReport.DataSources.Add(reportDataSource1);
            this.RPVReporte.LocalReport.ReportEmbeddedResource = "Arrendadora.RptListadoOtrosComp.rdlc";
            this.RPVReporte.Location = new System.Drawing.Point(0, 0);
            this.RPVReporte.Name = "RPVReporte";
            this.RPVReporte.Size = new System.Drawing.Size(764, 370);
            this.RPVReporte.TabIndex = 0;
            // 
            // NR_ListadoOtrosComprobantesBindingSource
            // 
            this.NR_ListadoOtrosComprobantesBindingSource.DataSource = typeof(Negocio.NR_ListadoOtrosComprobantes);
            // 
            // FrmReporteDiarioOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 370);
            this.Controls.Add(this.RPVReporte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteDiarioOC";
            this.Text = "Reporte Diario de Otros Comprobantes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReporteDiarioOC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NR_ListadoOtrosComprobantesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RPVReporte;
        private System.Windows.Forms.BindingSource NR_ListadoOtrosComprobantesBindingSource;
    }
}