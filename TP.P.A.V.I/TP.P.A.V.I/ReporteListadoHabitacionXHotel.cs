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
    public partial class ReporteListadoHabitacionXHotel : Form
    {
        public ReporteListadoHabitacionXHotel()
        {
            InitializeComponent();
        }

        private void ReporteListadoHabitacionXHotel_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BD3K7G13_2021DataSet.HabitacionXHotel' Puede moverla o quitarla según sea necesario.
            //this.HabitacionXHotelTableAdapter.Fill(this.BD3K7G13_2021DataSet.HabitacionXHotel);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable dt = HabitacionXHotelBLL.ListadoHabXhoteles();

            ReportDataSource ds = new ReportDataSource("ListadoHabitacionXhotel", dt);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
