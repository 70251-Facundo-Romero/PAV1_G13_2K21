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
    public partial class ReporteServicioXHotel : Form
    {
        public ReporteServicioXHotel()
        {
            InitializeComponent();
        }

        private void ReporteServicioXHotel_Load(object sender, EventArgs e)
        {
            

  

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();



        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = ServicioXHotelBLL.ObtenerListadoServXHoteles();

            ReportDataSource ds = new ReportDataSource("ReporteHotel", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();

            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(ds);
            reportViewer2.LocalReport.Refresh();

            reportViewer3.LocalReport.DataSources.Clear();
            reportViewer3.LocalReport.DataSources.Add(ds);
            reportViewer3.LocalReport.Refresh();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {
            
        }

        private void reportViewer3_Load(object sender, EventArgs e)
        {
           
        }
    }
}
