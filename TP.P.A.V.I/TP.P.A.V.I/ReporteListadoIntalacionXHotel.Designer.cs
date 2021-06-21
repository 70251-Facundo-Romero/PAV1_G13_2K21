
namespace TP.P.A.V.I
{
    partial class ReporteListadoIntalacionXHotel
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BD3K7G13_2021DataSet = new TP.P.A.V.I.BD3K7G13_2021DataSet();
            this.InstalacionXHotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InstalacionXHotelTableAdapter = new TP.P.A.V.I.BD3K7G13_2021DataSetTableAdapters.InstalacionXHotelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BD3K7G13_2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstalacionXHotelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ListadoInstalacionXHotel";
            reportDataSource1.Value = this.InstalacionXHotelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
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
            // InstalacionXHotelBindingSource
            // 
            this.InstalacionXHotelBindingSource.DataMember = "InstalacionXHotel";
            this.InstalacionXHotelBindingSource.DataSource = this.BD3K7G13_2021DataSet;
            // 
            // InstalacionXHotelTableAdapter
            // 
            this.InstalacionXHotelTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteListadoIntalacionXHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteListadoIntalacionXHotel";
            this.Text = "ReporteListadoIntalacionXHotel";
            this.Load += new System.EventHandler(this.ReporteListadoIntalacionXHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BD3K7G13_2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstalacionXHotelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InstalacionXHotelBindingSource;
        private BD3K7G13_2021DataSet BD3K7G13_2021DataSet;
        private BD3K7G13_2021DataSetTableAdapters.InstalacionXHotelTableAdapter InstalacionXHotelTableAdapter;
    }
}