using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP.P.A.V.I.BLL;

namespace TP.P.A.V.I
{
    public partial class ReporteTarjetas : Form
    {
        public ReporteTarjetas()
        {
            InitializeComponent();
        }

        private void ReporteTarjetas_Load(object sender, EventArgs e)
        {
            this.ReportViewerTarjetas.RefreshReport();
        }

        private void ReportViewerTarjetas_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = TarjetaBLL.ActualizarGrillaTarjeta();

            ReportDataSource ds = new ReportDataSource("ReportesTarjetas", tabla);

            ReportViewerTarjetas.LocalReport.DataSources.Clear();
            ReportViewerTarjetas.LocalReport.DataSources.Add(ds);
            ReportViewerTarjetas.LocalReport.Refresh();
        }
    }
}
