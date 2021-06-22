
namespace TP.P.A.V.I
{
    partial class ReportePuestosDeTrabajo
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
            this.Puestos_TrabajoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BD3K7G13_2021DataSetParaReportes = new TP.P.A.V.I.BD3K7G13_2021DataSetParaReportes();
            this.panelServicios = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.reportePdT = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Puestos_TrabajoTableAdapter = new TP.P.A.V.I.BD3K7G13_2021DataSetParaReportesTableAdapters.Puestos_TrabajoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Puestos_TrabajoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD3K7G13_2021DataSetParaReportes)).BeginInit();
            this.panelServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Puestos_TrabajoBindingSource
            // 
            this.Puestos_TrabajoBindingSource.DataMember = "Puestos_Trabajo";
            this.Puestos_TrabajoBindingSource.DataSource = this.BD3K7G13_2021DataSetParaReportes;
            // 
            // BD3K7G13_2021DataSetParaReportes
            // 
            this.BD3K7G13_2021DataSetParaReportes.DataSetName = "BD3K7G13_2021DataSetParaReportes";
            this.BD3K7G13_2021DataSetParaReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelServicios
            // 
            this.panelServicios.BackColor = System.Drawing.Color.SkyBlue;
            this.panelServicios.Controls.Add(this.btnCerrar);
            this.panelServicios.Controls.Add(this.pictureBox4);
            this.panelServicios.Location = new System.Drawing.Point(0, 0);
            this.panelServicios.Name = "panelServicios";
            this.panelServicios.Size = new System.Drawing.Size(782, 42);
            this.panelServicios.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::TP.P.A.V.I.Properties.Resources.cerrar16px;
            this.btnCerrar.Location = new System.Drawing.Point(724, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(46, 32);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox4.Image = global::TP.P.A.V.I.Properties.Resources.Qblanca;
            this.pictureBox4.Location = new System.Drawing.Point(31, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // reportePdT
            // 
            this.reportePdT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            reportDataSource1.Name = "ListadoPuestoDeTrabajo";
            reportDataSource1.Value = this.Puestos_TrabajoBindingSource;
            this.reportePdT.LocalReport.DataSources.Add(reportDataSource1);
            this.reportePdT.LocalReport.ReportEmbeddedResource = "TP.P.A.V.I.ReportePuestoDeTrabajo.rdlc";
            this.reportePdT.Location = new System.Drawing.Point(0, 39);
            this.reportePdT.Name = "reportePdT";
            this.reportePdT.ServerReport.BearerToken = null;
            this.reportePdT.Size = new System.Drawing.Size(779, 411);
            this.reportePdT.TabIndex = 2;
            this.reportePdT.Load += new System.EventHandler(this.reportePdT_Load);
            // 
            // Puestos_TrabajoTableAdapter
            // 
            this.Puestos_TrabajoTableAdapter.ClearBeforeFill = true;
            // 
            // ReportePuestosDeTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.reportePdT);
            this.Controls.Add(this.panelServicios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportePuestosDeTrabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportePuestosDeTrabajo";
            this.Load += new System.EventHandler(this.ReportePuestosDeTrabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Puestos_TrabajoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD3K7G13_2021DataSetParaReportes)).EndInit();
            this.panelServicios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelServicios;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Microsoft.Reporting.WinForms.ReportViewer reportePdT;
        private System.Windows.Forms.BindingSource Puestos_TrabajoBindingSource;
        private BD3K7G13_2021DataSetParaReportes BD3K7G13_2021DataSetParaReportes;
        private BD3K7G13_2021DataSetParaReportesTableAdapters.Puestos_TrabajoTableAdapter Puestos_TrabajoTableAdapter;
    }
}