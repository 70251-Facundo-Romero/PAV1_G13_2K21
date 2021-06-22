
namespace TP.P.A.V.I
{
    partial class ReporteServicios
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
            this.panelServicios = new System.Windows.Forms.Panel();
            this.reporteServ = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BD3K7G13_2021DataSetParaReportes = new TP.P.A.V.I.BD3K7G13_2021DataSetParaReportes();
            this.ServiciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ServiciosTableAdapter = new TP.P.A.V.I.BD3K7G13_2021DataSetParaReportesTableAdapters.ServiciosTableAdapter();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BD3K7G13_2021DataSetParaReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelServicios
            // 
            this.panelServicios.BackColor = System.Drawing.Color.SkyBlue;
            this.panelServicios.Controls.Add(this.btnCerrar);
            this.panelServicios.Controls.Add(this.pictureBox4);
            this.panelServicios.Location = new System.Drawing.Point(0, 1);
            this.panelServicios.Name = "panelServicios";
            this.panelServicios.Size = new System.Drawing.Size(802, 36);
            this.panelServicios.TabIndex = 0;
            // 
            // reporteServ
            // 
            this.reporteServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            reportDataSource1.Name = "ListadoServicios";
            reportDataSource1.Value = this.ServiciosBindingSource;
            this.reporteServ.LocalReport.DataSources.Add(reportDataSource1);
            this.reporteServ.LocalReport.ReportEmbeddedResource = "TP.P.A.V.I.ReporteServicios.rdlc";
            this.reporteServ.Location = new System.Drawing.Point(0, 34);
            this.reporteServ.Name = "reporteServ";
            this.reporteServ.ServerReport.BearerToken = null;
            this.reporteServ.Size = new System.Drawing.Size(802, 417);
            this.reporteServ.TabIndex = 1;
            this.reporteServ.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // BD3K7G13_2021DataSetParaReportes
            // 
            this.BD3K7G13_2021DataSetParaReportes.DataSetName = "BD3K7G13_2021DataSetParaReportes";
            this.BD3K7G13_2021DataSetParaReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ServiciosBindingSource
            // 
            this.ServiciosBindingSource.DataMember = "Servicios";
            this.ServiciosBindingSource.DataSource = this.BD3K7G13_2021DataSetParaReportes;
            // 
            // ServiciosTableAdapter
            // 
            this.ServiciosTableAdapter.ClearBeforeFill = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::TP.P.A.V.I.Properties.Resources.cerrar16px;
            this.btnCerrar.Location = new System.Drawing.Point(742, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(46, 35);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox4.Image = global::TP.P.A.V.I.Properties.Resources.Qblanca;
            this.pictureBox4.Location = new System.Drawing.Point(34, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // ReporteServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reporteServ);
            this.Controls.Add(this.panelServicios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteServicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteServicios";
            this.Load += new System.EventHandler(this.ReporteServicios_Load);
            this.panelServicios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BD3K7G13_2021DataSetParaReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelServicios;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnCerrar;
        private Microsoft.Reporting.WinForms.ReportViewer reporteServ;
        private System.Windows.Forms.BindingSource ServiciosBindingSource;
        private BD3K7G13_2021DataSetParaReportes BD3K7G13_2021DataSetParaReportes;
        private BD3K7G13_2021DataSetParaReportesTableAdapters.ServiciosTableAdapter ServiciosTableAdapter;
    }
}