
namespace TP.P.A.V.I
{
    partial class ReporteAXH
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
            this.reportAXH = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BD3K7G13_2021_AXH = new TP.P.A.V.I.BD3K7G13_2021_AXH();
            this.AlojamientoXHotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AlojamientoXHotelTableAdapter = new TP.P.A.V.I.BD3K7G13_2021_AXHTableAdapters.AlojamientoXHotelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BD3K7G13_2021_AXH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlojamientoXHotelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportAXH
            // 
            this.reportAXH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.reportAXH.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DatosAXH";
            reportDataSource1.Value = this.AlojamientoXHotelBindingSource;
            this.reportAXH.LocalReport.DataSources.Add(reportDataSource1);
            this.reportAXH.LocalReport.ReportEmbeddedResource = "TP.P.A.V.I.ReporteAXH.rdlc";
            this.reportAXH.Location = new System.Drawing.Point(0, 0);
            this.reportAXH.Name = "reportAXH";
            this.reportAXH.ServerReport.BearerToken = null;
            this.reportAXH.Size = new System.Drawing.Size(800, 450);
            this.reportAXH.TabIndex = 0;
            // 
            // BD3K7G13_2021_AXH
            // 
            this.BD3K7G13_2021_AXH.DataSetName = "BD3K7G13_2021_AXH";
            this.BD3K7G13_2021_AXH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AlojamientoXHotelBindingSource
            // 
            this.AlojamientoXHotelBindingSource.DataMember = "AlojamientoXHotel";
            this.AlojamientoXHotelBindingSource.DataSource = this.BD3K7G13_2021_AXH;
            // 
            // AlojamientoXHotelTableAdapter
            // 
            this.AlojamientoXHotelTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteAXH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportAXH);
            this.Name = "ReporteAXH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte alojamiento por huésped";
            this.Load += new System.EventHandler(this.ReporteAXH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BD3K7G13_2021_AXH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlojamientoXHotelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportAXH;
        private System.Windows.Forms.BindingSource AlojamientoXHotelBindingSource;
        private BD3K7G13_2021_AXH BD3K7G13_2021_AXH;
        private BD3K7G13_2021_AXHTableAdapters.AlojamientoXHotelTableAdapter AlojamientoXHotelTableAdapter;
    }
}