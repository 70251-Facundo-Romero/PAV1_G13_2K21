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
    public partial class ReporteServicios : Form
    {
        public ReporteServicios()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReporteServicios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BD3K7G13_2021DataSetParaReportes.Servicios' Puede moverla o quitarla según sea necesario.
            //this.ServiciosTableAdapter.Fill(this.BD3K7G13_2021DataSetParaReportes.Servicios);

            this.reporteServ.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = ServiciosBLL.ObtenerListadoServicios();

            ReportDataSource datas = new ReportDataSource("ListadoServicios", tabla);

            reporteServ.LocalReport.DataSources.Clear();
            reporteServ.LocalReport.DataSources.Add(datas);
            reporteServ.LocalReport.Refresh();
        }
    }
}
