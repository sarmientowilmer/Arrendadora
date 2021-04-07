namespace Arrendadora
{
    partial class FrmRptOtroComprobante
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
            this.AuxiliaresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Arrendadora.DataSet1();
            this.RPVReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.terceroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AuxiliaresTableAdapter = new Arrendadora.DataSet1TableAdapters.AuxiliaresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AuxiliaresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terceroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AuxiliaresBindingSource
            // 
            this.AuxiliaresBindingSource.DataMember = "Auxiliares";
            this.AuxiliaresBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RPVReporte
            // 
            this.RPVReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AuxiliaresBindingSource;
            this.RPVReporte.LocalReport.DataSources.Add(reportDataSource1);
            this.RPVReporte.LocalReport.ReportEmbeddedResource = "Arrendadora.Report1.rdlc";
            this.RPVReporte.Location = new System.Drawing.Point(0, 0);
            this.RPVReporte.Name = "RPVReporte";
            this.RPVReporte.ServerReport.BearerToken = null;
            this.RPVReporte.Size = new System.Drawing.Size(842, 357);
            this.RPVReporte.TabIndex = 0;
            this.RPVReporte.Load += new System.EventHandler(this.RPVReporte_Load);
            // 
            // AuxiliaresTableAdapter
            // 
            this.AuxiliaresTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRptOtroComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 357);
            this.Controls.Add(this.RPVReporte);
            this.Name = "FrmRptOtroComprobante";
            this.Text = "Imprimir Comprobante";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRptOtroComprobante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AuxiliaresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terceroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RPVReporte;
        private System.Windows.Forms.BindingSource terceroBindingSource;
        private System.Windows.Forms.BindingSource AuxiliaresBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.AuxiliaresTableAdapter AuxiliaresTableAdapter;
    }
}