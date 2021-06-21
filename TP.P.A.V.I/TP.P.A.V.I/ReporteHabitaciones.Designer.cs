
namespace TP.P.A.V.I
{
    partial class ReporteHabitaciones
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
            this.HabitacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BD3K7G13_2021DataSetParaReportes = new TP.P.A.V.I.BD3K7G13_2021DataSetParaReportes();
            this.reportHabitaciones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HabitacionesTableAdapter = new TP.P.A.V.I.BD3K7G13_2021DataSetParaReportesTableAdapters.HabitacionesTableAdapter();
            this.InstalacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InstalacionesTableAdapter = new TP.P.A.V.I.BD3K7G13_2021DataSetParaReportesTableAdapters.InstalacionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HabitacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD3K7G13_2021DataSetParaReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstalacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HabitacionesBindingSource
            // 
            this.HabitacionesBindingSource.DataMember = "Habitaciones";
            this.HabitacionesBindingSource.DataSource = this.BD3K7G13_2021DataSetParaReportes;
            // 
            // BD3K7G13_2021DataSetParaReportes
            // 
            this.BD3K7G13_2021DataSetParaReportes.DataSetName = "BD3K7G13_2021DataSetParaReportes";
            this.BD3K7G13_2021DataSetParaReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportHabitaciones
            // 
            this.reportHabitaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Habitaciones";
            reportDataSource1.Value = this.HabitacionesBindingSource;
            this.reportHabitaciones.LocalReport.DataSources.Add(reportDataSource1);
            this.reportHabitaciones.LocalReport.ReportEmbeddedResource = "TP.P.A.V.I.ReportHabitaciones.rdlc";
            this.reportHabitaciones.Location = new System.Drawing.Point(0, 0);
            this.reportHabitaciones.Name = "reportHabitaciones";
            this.reportHabitaciones.ServerReport.BearerToken = null;
            this.reportHabitaciones.Size = new System.Drawing.Size(800, 450);
            this.reportHabitaciones.TabIndex = 0;
            this.reportHabitaciones.Load += new System.EventHandler(this.reportHabitaciones_Load);
            // 
            // HabitacionesTableAdapter
            // 
            this.HabitacionesTableAdapter.ClearBeforeFill = true;
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
            // ReporteHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportHabitaciones);
            this.Name = "ReporteHabitaciones";
            this.Text = "ReporteHabitaciones";
            this.Load += new System.EventHandler(this.ReporteHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HabitacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD3K7G13_2021DataSetParaReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstalacionesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportHabitaciones;
        private System.Windows.Forms.BindingSource HabitacionesBindingSource;
        private BD3K7G13_2021DataSetParaReportes BD3K7G13_2021DataSetParaReportes;
        private BD3K7G13_2021DataSetParaReportesTableAdapters.HabitacionesTableAdapter HabitacionesTableAdapter;
        private System.Windows.Forms.BindingSource InstalacionesBindingSource;
        private BD3K7G13_2021DataSetParaReportesTableAdapters.InstalacionesTableAdapter InstalacionesTableAdapter;
    }
}