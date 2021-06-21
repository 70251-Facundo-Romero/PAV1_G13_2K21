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
    public partial class ReporteInstalacionXhotel : Form
    {
        public ReporteInstalacionXhotel()
        {
            InitializeComponent();
        }

        private void ReporteInstalacionXhotel_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable dt = InstalacionXHotelBLL.InstalacionXHotel();

            ReportDataSource ds = new ReportDataSource("estadisticaInstalacionXHotel", dt);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
