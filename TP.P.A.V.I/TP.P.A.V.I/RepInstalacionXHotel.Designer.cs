
namespace TP.P.A.V.I
{
    partial class RepInstalacionXHotel
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BD3K7G13_2021DataSet = new TP.P.A.V.I.BD3K7G13_2021DataSet();
            this.BD3K7G13_2021DataSetParaReportes = new TP.P.A.V.I.BD3K7G13_2021DataSetParaReportes();
            this.CiudadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CiudadesTableAdapter = new TP.P.A.V.I.BD3K7G13_2021DataSetParaReportesTableAdapters.CiudadesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BD3K7G13_2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD3K7G13_2021DataSetParaReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CiudadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP.P.A.V.I.InstalacionXHotel.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // BD3K7G13_2021DataSet
            // 
            this.BD3K7G13_2021DataSet.DataSetName = "BD3K7G13_2021DataSet";
            this.BD3K7G13_2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BD3K7G13_2021DataSetParaReportes
            // 
            this.BD3K7G13_2021DataSetParaReportes.DataSetName = "BD3K7G13_2021DataSetParaReportes";
            this.BD3K7G13_2021DataSetParaReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CiudadesBindingSource
            // 
            this.CiudadesBindingSource.DataMember = "Ciudades";
            this.CiudadesBindingSource.DataSource = this.BD3K7G13_2021DataSetParaReportes;
            // 
            // CiudadesTableAdapter
            // 
            this.CiudadesTableAdapter.ClearBeforeFill = true;
            // 
            // RepInstalacionXHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RepInstalacionXHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado instalación por hotel";
            this.Load += new System.EventHandler(this.RepInstalacionXHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BD3K7G13_2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD3K7G13_2021DataSetParaReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CiudadesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BD3K7G13_2021DataSet BD3K7G13_2021DataSet;
        private System.Windows.Forms.BindingSource CiudadesBindingSource;
        private BD3K7G13_2021DataSetParaReportes BD3K7G13_2021DataSetParaReportes;
        private BD3K7G13_2021DataSetParaReportesTableAdapters.CiudadesTableAdapter CiudadesTableAdapter;
    }
}