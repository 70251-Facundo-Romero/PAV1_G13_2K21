
namespace TP.P.A.V.I
{
    partial class EstadisticaHuespedxPaiscs
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
            this.ReportHuespedXpais = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ReportHuespedXpais
            // 
            this.ReportHuespedXpais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportHuespedXpais.LocalReport.ReportEmbeddedResource = "TP.P.A.V.I.Report HuespedxPais.rdlc";
            this.ReportHuespedXpais.Location = new System.Drawing.Point(0, 0);
            this.ReportHuespedXpais.Name = "ReportHuespedXpais";
            this.ReportHuespedXpais.ServerReport.BearerToken = null;
            this.ReportHuespedXpais.Size = new System.Drawing.Size(800, 450);
            this.ReportHuespedXpais.TabIndex = 0;
            this.ReportHuespedXpais.Load += new System.EventHandler(this.ReportHuespedXpais_Load);
            // 
            // EstadisticaHuespedxPaiscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReportHuespedXpais);
            this.Name = "EstadisticaHuespedxPaiscs";
            this.Text = "EstadisticaHuespedxPaiscs";
            this.Load += new System.EventHandler(this.EstadisticaHuespedxPaiscs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportHuespedXpais;
    }
}