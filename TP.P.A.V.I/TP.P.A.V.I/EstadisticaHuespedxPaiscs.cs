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
    public partial class EstadisticaHuespedxPaiscs : Form
    {
        public EstadisticaHuespedxPaiscs()
        {
            InitializeComponent();
        }

        private void EstadisticaHuespedxPaiscs_Load(object sender, EventArgs e)
        {

            this.ReportHuespedXpais.RefreshReport();
        }

        private void ReportHuespedXpais_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = BLL.PaisBLL.ObtenerHuespedesxPais();


            ReportDataSource ds = new ReportDataSource("HuespedxPais", tabla);
            ReportHuespedXpais.LocalReport.DataSources.Clear();
            ReportHuespedXpais.LocalReport.DataSources.Add(ds);
            ReportHuespedXpais.LocalReport.Refresh();
        }
    }
    
}
