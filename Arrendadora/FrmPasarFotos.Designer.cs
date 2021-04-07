namespace Arrendadora
{
    partial class FrmPasarFotos
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
            this.BtnDetalleInv = new System.Windows.Forms.Button();
            this.DGVDetalle = new System.Windows.Forms.DataGridView();
            this.PBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDetalleInv
            // 
            this.BtnDetalleInv.Location = new System.Drawing.Point(678, 25);
            this.BtnDetalleInv.Name = "BtnDetalleInv";
            this.BtnDetalleInv.Size = new System.Drawing.Size(75, 23);
            this.BtnDetalleInv.TabIndex = 0;
            this.BtnDetalleInv.Text = "Pasar Fotos";
            this.BtnDetalleInv.UseVisualStyleBackColor = true;
            this.BtnDetalleInv.Click += new System.EventHandler(this.BtnDetalleInv_Click);
            // 
            // DGVDetalle
            // 
            this.DGVDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDetalle.Location = new System.Drawing.Point(12, 95);
            this.DGVDetalle.Name = "DGVDetalle";
            this.DGVDetalle.Size = new System.Drawing.Size(776, 343);
            this.DGVDetalle.TabIndex = 1;
            // 
            // PBar
            // 
            this.PBar.Location = new System.Drawing.Point(12, 66);
            this.PBar.Name = "PBar";
            this.PBar.Size = new System.Drawing.Size(776, 23);
            this.PBar.TabIndex = 2;
            // 
            // FrmPasarFotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PBar);
            this.Controls.Add(this.DGVDetalle);
            this.Controls.Add(this.BtnDetalleInv);
            this.Name = "FrmPasarFotos";
            this.Text = "FrmPasarFotos";
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnDetalleInv;
        private System.Windows.Forms.DataGridView DGVDetalle;
        private System.Windows.Forms.ProgressBar PBar;
    }
}