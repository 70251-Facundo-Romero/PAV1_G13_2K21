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
    public partial class EstadisticaHxPais : Form
    {
        public EstadisticaHxPais()
        {
            InitializeComponent();
        }

        private void EstadisticaHxPais_Load(object sender, EventArgs e)
        {

            this.reportHxPais.RefreshReport();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportHxPais_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = PaisBLL.ObtenerEstadisticaPais();

            ReportDataSource ds = new ReportDataSource("EstadisticasHxPais", tabla);

            reportHxPais.LocalReport.DataSources.Clear();
            reportHxPais.LocalReport.DataSources.Add(ds);
            reportHxPais.LocalReport.Refresh();
        }
    }
}
