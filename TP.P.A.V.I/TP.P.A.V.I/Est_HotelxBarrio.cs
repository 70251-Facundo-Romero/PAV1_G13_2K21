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
    public partial class Est_HotelxBarrio : Form
    {
        public Est_HotelxBarrio()
        {
            InitializeComponent();
        }

        private void Est_HotelxBarrio_Load(object sender, EventArgs e)
        {

            this.reportHotelxBarrio.RefreshReport();
        }

        private void reportHotelxBarrio_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = BLL.BarrioBLL.ObtenerHotelesxBarrios();

            ReportDataSource ds = new ReportDataSource("HotelxBarrio", tabla);
            reportHotelxBarrio.LocalReport.DataSources.Clear();
            reportHotelxBarrio.LocalReport.DataSources.Add(ds);
            reportHotelxBarrio.LocalReport.Refresh();
        }
    }
}
