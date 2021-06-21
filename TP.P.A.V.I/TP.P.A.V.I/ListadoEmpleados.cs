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
using TP.P.A.V.I.DAL;

namespace TP.P.A.V.I
{
    public partial class ListadoEmpleados : Form
    {
        public ListadoEmpleados()
        {
            InitializeComponent();
        }

        private void ListadoEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BD3K7G13_2021DataSetParaReportes.Empleados' Puede moverla o quitarla según sea necesario.
            //this.EmpleadosTableAdapter.Fill(this.BD3K7G13_2021DataSetParaReportes.Empleados);
            // TODO: esta línea de código carga datos en la tabla 'BD3K7G13_2021DataSetParaReportes.Empleados' Puede moverla o quitarla según sea necesario.
            // this.EmpleadosTableAdapter.Fill(this.BD3K7G13_2021DataSetParaReportes.Empleados);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = EmpleadosDAL.ObtenerListadoEmpleados();

            ReportDataSource ds = new ReportDataSource("ListadoEmpleados", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
