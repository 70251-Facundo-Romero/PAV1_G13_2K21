
namespace TP.P.A.V.I
{
    partial class Est_HotelxBarrio
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
            this.reportHotelxBarrio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportHotelxBarrio
            // 
            this.reportHotelxBarrio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportHotelxBarrio.LocalReport.ReportEmbeddedResource = "TP.P.A.V.I.Est_HotelesxBarrios.rdlc";
            this.reportHotelxBarrio.Location = new System.Drawing.Point(0, 0);
            this.reportHotelxBarrio.Name = "reportHotelxBarrio";
            this.reportHotelxBarrio.ServerReport.BearerToken = null;
            this.reportHotelxBarrio.Size = new System.Drawing.Size(800, 450);
            this.reportHotelxBarrio.TabIndex = 0;
            this.reportHotelxBarrio.Load += new System.EventHandler(this.reportHotelxBarrio_Load);
            // 
            // Est_HotelxBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportHotelxBarrio);
            this.Name = "Est_HotelxBarrio";
            this.Text = "Est_HotelxBarrio";
            this.Load += new System.EventHandler(this.Est_HotelxBarrio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportHotelxBarrio;
    }
}