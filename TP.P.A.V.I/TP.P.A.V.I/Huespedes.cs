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
    public partial class Huespedes : Form
    {
        public Huespedes()
        {
            InitializeComponent();
        }

        private void Huespedes_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void BtnHuespedes_Click(object sender, EventArgs e)
        {
            BtnFacturacion.Visible = false;
            BtnAlojamientoXHuesped.Visible = true;
            BtnDetalleFactura.Visible = false;
            BtnHuesped.Visible = true;
            BtnInstalacionXHuesped.Visible = true;
            BtnServicioXHuesped.Visible = true;
            BtnTarjetas.Visible = false;


        }

        private void BtnFacturacionFiltro_Click(object sender, EventArgs e)
        {
            BtnFacturacion.Visible = true;
            BtnAlojamientoXHuesped.Visible = false;
            BtnDetalleFactura.Visible = true;
            BtnHuesped.Visible = false;
            BtnInstalacionXHuesped.Visible = false;
            BtnServicioXHuesped.Visible = false;
            BtnTarjetas.Visible = false;
        }

        private void BtnTarjetasFiltro_Click(object sender, EventArgs e)
        {
            BtnFacturacion.Visible = false;
            BtnAlojamientoXHuesped.Visible = false;
            BtnDetalleFactura.Visible = false;
            BtnHuesped.Visible = false;
            BtnInstalacionXHuesped.Visible = false;
            BtnServicioXHuesped.Visible = false;
            BtnTarjetas.Visible = true;
        }
    }
}
