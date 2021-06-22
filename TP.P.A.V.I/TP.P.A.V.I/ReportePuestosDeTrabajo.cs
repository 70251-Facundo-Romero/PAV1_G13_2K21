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
    public partial class ReportePuestosDeTrabajo : Form
    {
        public ReportePuestosDeTrabajo()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportePuestosDeTrabajo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BD3K7G13_2021DataSetParaReportes.Puestos_Trabajo' Puede moverla o quitarla según sea necesario.
            //this.Puestos_TrabajoTableAdapter.Fill(this.BD3K7G13_2021DataSetParaReportes.Puestos_Trabajo);

            this.reportePdT.RefreshReport();
        }

        private void reportePdT_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = PuestoDeTrabajoBLL.ObtenerListadoPdt();

            ReportDataSource datas = new ReportDataSource("ListadoPuestoDeTrabajo", tabla);

            reportePdT.LocalReport.DataSources.Clear();
            reportePdT.LocalReport.DataSources.Add(datas);
            reportePdT.LocalReport.Refresh();
        }
    }
}
