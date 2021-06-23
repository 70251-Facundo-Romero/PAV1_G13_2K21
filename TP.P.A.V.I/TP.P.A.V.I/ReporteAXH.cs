using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TP.P.A.V.I.BLL;

namespace TP.P.A.V.I
{
    public partial class ReporteAXH : Form
    {
        public ReporteAXH()
        {
            InitializeComponent();
        }

        private void ReporteAXH_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BD3K7G13_2021_AXH.AlojamientoXHotel' Puede moverla o quitarla según sea necesario.
            //this.AlojamientoXHotelTableAdapter.Fill(this.BD3K7G13_2021_AXH.AlojamientoXHotel);

            this.reportAXH.RefreshReport();
        }
        private void reportHabitaciones_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AlojamientoXHuespedBLL.ObtenerAXH();

            ReportDataSource ds = new ReportDataSource("DatosAXH", tabla);
            reportAXH.LocalReport.DataSources.Clear();
            reportAXH.LocalReport.DataSources.Add(ds);
            reportAXH.LocalReport.Refresh();
        }
    }
}
