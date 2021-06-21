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

namespace TP.P.A.V.I
{
    public partial class ReportInstalaciones : Form
    {
        public ReportInstalaciones()
        {
            InitializeComponent();
        }

        private void ReportInstalaciones_Load(object sender, EventArgs e)
        {


            this.reporteIntalaciones.RefreshReport();
        }

        private void reporteIntalaciones_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = BLL.InstalacionesBLL.CargarGrilla();

            ReportDataSource ds = new ReportDataSource("Instalaciones", tabla);
            reporteIntalaciones.LocalReport.DataSources.Clear();
            reporteIntalaciones.LocalReport.DataSources.Add(ds);
            reporteIntalaciones.LocalReport.Refresh();
        }
    }
    
}
