using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP.P.A.V.I.BLL;

namespace TP.P.A.V.I
{
    public partial class ReportesCiudad : Form
    {
        public ReportesCiudad()
        {
            InitializeComponent();
        }

        private void ReportesCiudad_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = CiudadBLL.ObtenerListadoCiudades();

            ReportDataSource ds = new ReportDataSource("DatosCiudades", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
