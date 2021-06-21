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
    public partial class RepInstalacionXHotel : Form
    {
        public RepInstalacionXHotel()
        {
            InitializeComponent();
        }

        private void RepInstalacionXHotel_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BD3K7G13_2021DataSetParaReportes.Ciudades' Puede moverla o quitarla según sea necesario.
            //this.CiudadesTableAdapter.Fill(this.BD3K7G13_2021DataSetParaReportes.Ciudades);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable dt = InstalacionXHotelBLL.InstalacionXHotel();

            ReportDataSource ds = new ReportDataSource("ListadoInstalacionXHotel", dt);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
