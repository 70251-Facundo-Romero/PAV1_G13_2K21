﻿using System;
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
    public partial class EstadisticaAXH : Form
    {
        public EstadisticaAXH()
        {
            InitializeComponent();
        }

        private void EstadisticaAXH_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AlojamientoXHuespedBLL.ObtenerEstadisticaAXH();
            ReportDataSource ds = new ReportDataSource("EstadisticaAXH", tabla);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
