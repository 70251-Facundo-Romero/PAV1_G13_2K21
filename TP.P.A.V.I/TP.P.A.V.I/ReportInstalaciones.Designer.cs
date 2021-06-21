
namespace TP.P.A.V.I
{
    partial class ReportInstalaciones
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
            this.reporteIntalaciones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BD3K7G13_2021DataSetParaReportes = new TP.P.A.V.I.BD3K7G13_2021DataSetParaReportes();
            this.InstalacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InstalacionesTableAdapter = new TP.P.A.V.I.BD3K7G13_2021DataSetParaReportesTableAdapters.InstalacionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BD3K7G13_2021DataSetParaReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstalacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteIntalaciones
            // 
            this.reporteIntalaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Instalaciones";
            reportDataSource1.Value = this.InstalacionesBindingSource;
            this.reporteIntalaciones.LocalReport.DataSources.Add(reportDataSource1);
            this.reporteIntalaciones.LocalReport.ReportEmbeddedResource = "TP.P.A.V.I.ReportInstalaciones.rdlc";
            this.reporteIntalaciones.Location = new System.Drawing.Point(0, 0);
            this.reporteIntalaciones.Name = "reporteIntalaciones";
            this.reporteIntalaciones.ServerReport.BearerToken = null;
            this.reporteIntalaciones.Size = new System.Drawing.Size(800, 450);
            this.reporteIntalaciones.TabIndex = 0;
            this.reporteIntalaciones.Load += new System.EventHandler(this.reporteIntalaciones_Load);
            // 
            // BD3K7G13_2021DataSetParaReportes
            // 
            this.BD3K7G13_2021DataSetParaReportes.DataSetName = "BD3K7G13_2021DataSetParaReportes";
            this.BD3K7G13_2021DataSetParaReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InstalacionesBindingSource
            // 
            this.InstalacionesBindingSource.DataMember = "Instalaciones";
            this.InstalacionesBindingSource.DataSource = this.BD3K7G13_2021DataSetParaReportes;
            // 
            // InstalacionesTableAdapter
            // 
            this.InstalacionesTableAdapter.ClearBeforeFill = true;
            // 
            // ReportInstalaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reporteIntalaciones);
            this.Name = "ReportInstalaciones";
            this.Text = "ReportInstalaciones";
            this.Load += new System.EventHandler(this.ReportInstalaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BD3K7G13_2021DataSetParaReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstalacionesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporteIntalaciones;
        private System.Windows.Forms.BindingSource InstalacionesBindingSource;
        private BD3K7G13_2021DataSetParaReportes BD3K7G13_2021DataSetParaReportes;
        private BD3K7G13_2021DataSetParaReportesTableAdapters.InstalacionesTableAdapter InstalacionesTableAdapter;
    }
}