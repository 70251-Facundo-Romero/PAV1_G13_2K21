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
    public partial class EstadisticaPdt : Form
    {
        public EstadisticaPdt()
        {
            InitializeComponent();
        }

        private void EstadisticaPdt_Load(object sender, EventArgs e)
        {

            this.estadPdt.RefreshReport();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = PuestoDeTrabajoBLL.ObtenerEstadisticaPdt();

            ReportDataSource ds = new ReportDataSource("DatosEstadisticasPdt", tabla);

            estadPdt.LocalReport.DataSources.Clear();
            estadPdt.LocalReport.DataSources.Add(ds);
            estadPdt.LocalReport.Refresh();
        }
    }
}
