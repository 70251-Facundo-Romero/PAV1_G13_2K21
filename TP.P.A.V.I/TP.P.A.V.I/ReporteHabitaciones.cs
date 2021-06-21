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
    public partial class ReporteHabitaciones : Form
    {
        public ReporteHabitaciones()
        {
            InitializeComponent();
        }

        private void ReporteHabitaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BD3K7G13_2021DataSetParaReportes.Habitaciones' Puede moverla o quitarla según sea necesario.
            this.HabitacionesTableAdapter.Fill(this.BD3K7G13_2021DataSetParaReportes.Habitaciones);
            // TODO: esta línea de código carga datos en la tabla 'BD3K7G13_2021DataSetParaReportes.Instalaciones' Puede moverla o quitarla según sea necesario.
            this.InstalacionesTableAdapter.Fill(this.BD3K7G13_2021DataSetParaReportes.Instalaciones);

            this.reportHabitaciones.RefreshReport();
        }

        private void reportHabitaciones_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = BLL.HabitacionesBLL.CargarGrilla();

            ReportDataSource ds = new ReportDataSource("Habitaciones",tabla);
            reportHabitaciones.LocalReport.DataSources.Clear();
            reportHabitaciones.LocalReport.DataSources.Add(ds);
            reportHabitaciones.LocalReport.Refresh();
        }
    }
}
