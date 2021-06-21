
namespace TP.P.A.V.I
{
    partial class ReporteTarjetas
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
            this.panelFormulariosHijos = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.ReportViewerTarjetas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BD3K7G13_2021DataSetParaReportes = new TP.P.A.V.I.BD3K7G13_2021DataSetParaReportes();
            this.TarjetasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TarjetasTableAdapter = new TP.P.A.V.I.BD3K7G13_2021DataSetParaReportesTableAdapters.TarjetasTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelFormulariosHijos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BD3K7G13_2021DataSetParaReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TarjetasBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormulariosHijos
            // 
            this.panelFormulariosHijos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelFormulariosHijos.Controls.Add(this.tabControl1);
            this.panelFormulariosHijos.Controls.Add(this.label9);
            this.panelFormulariosHijos.Controls.Add(this.pictureBox2);
            this.panelFormulariosHijos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormulariosHijos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFormulariosHijos.Location = new System.Drawing.Point(0, 0);
            this.panelFormulariosHijos.Name = "panelFormulariosHijos";
            this.panelFormulariosHijos.Size = new System.Drawing.Size(800, 450);
            this.panelFormulariosHijos.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SkyBlue;
            this.label9.Location = new System.Drawing.Point(640, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 62;
            this.label9.Text = "Hoteleria";
            // 
            // ReportViewerTarjetas
            // 
            reportDataSource1.Name = "ReportesTarjetas";
            reportDataSource1.Value = this.TarjetasBindingSource;
            this.ReportViewerTarjetas.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewerTarjetas.LocalReport.ReportEmbeddedResource = "TP.P.A.V.I.ReporteTarjetas.rdlc";
            this.ReportViewerTarjetas.Location = new System.Drawing.Point(0, 62);
            this.ReportViewerTarjetas.Name = "ReportViewerTarjetas";
            this.ReportViewerTarjetas.ServerReport.BearerToken = null;
            this.ReportViewerTarjetas.Size = new System.Drawing.Size(792, 324);
            this.ReportViewerTarjetas.TabIndex = 63;
            this.ReportViewerTarjetas.Load += new System.EventHandler(this.ReportViewerTarjetas_Load);
            // 
            // BD3K7G13_2021DataSetParaReportes
            // 
            this.BD3K7G13_2021DataSetParaReportes.DataSetName = "BD3K7G13_2021DataSetParaReportes";
            this.BD3K7G13_2021DataSetParaReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TarjetasBindingSource
            // 
            this.TarjetasBindingSource.DataMember = "Tarjetas";
            this.TarjetasBindingSource.DataSource = this.BD3K7G13_2021DataSetParaReportes;
            // 
            // TarjetasTableAdapter
            // 
            this.TarjetasTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 412);
            this.tabControl1.TabIndex = 63;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ReportViewerTarjetas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado de Tarjetas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::TP.P.A.V.I.Properties.Resources.q;
            this.pictureBox2.Location = new System.Drawing.Point(615, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // ReporteTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFormulariosHijos);
            this.Name = "ReporteTarjetas";
            this.Text = "ReporteTarjetas";
            this.Load += new System.EventHandler(this.ReporteTarjetas_Load);
            this.panelFormulariosHijos.ResumeLayout(false);
            this.panelFormulariosHijos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BD3K7G13_2021DataSetParaReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TarjetasBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormulariosHijos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerTarjetas;
        private System.Windows.Forms.BindingSource TarjetasBindingSource;
        private BD3K7G13_2021DataSetParaReportes BD3K7G13_2021DataSetParaReportes;
        private BD3K7G13_2021DataSetParaReportesTableAdapters.TarjetasTableAdapter TarjetasTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}