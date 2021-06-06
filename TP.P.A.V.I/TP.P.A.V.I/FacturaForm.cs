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
using TP.P.A.V.I.Entities;

namespace TP.P.A.V.I
{
    public partial class FacturaForm : Form
    {
        public FacturaForm()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (HuespedBLL.GetByPasaport(int.Parse(txtPasaporte.Text)) == null)
            {
                MessageBox.Show("El huesped no existe");
                txtPasaporte.Text = "";
                txtPasaporte.Focus();
                return;
            }
            Factura f = FacturaBLL.ObtenerFactura(txtPasaporte.Text);
            txtNomHuesped.Text = f.nombreHuesped;
            txtApellido.Text = f.apellidoHuesped;
            DateTime fechaA = f.FechaAloj;
            string diaA = "";
            string mesA = "";
            string añoA = "";
            diaA = fechaA.Date.Day.ToString();
            if (diaA.Length == 1)
            {
                diaA = "0" + diaA;
            }
            mesA = fechaA.Date.Month.ToString();
            if (mesA.Length == 1)
            {
                mesA = "0" + mesA;
            }
            añoA = fechaA.Date.Year.ToString();
            mskFechaAloj.Text = diaA + mesA + añoA;
            txtNomHotel.Text = f.NomHotel;
            txtPais.Text = f.NomPais;
            txtIdHotel.Text = f.IdHotel.ToString();
            
            DateTime fechaB = DateTime.Now;
            string diaB = "";
            string mesB = "";
            string añoB = "";
            diaB = fechaB.Date.Day.ToString();
            if (diaB.Length == 1)
            {
                diaB = "0" + diaB;
            }
            mesB = fechaB.Date.Month.ToString();
            if (mesB.Length == 1)
            {
                mesB = "0" + mesB;
            }
            añoB = fechaB.Date.Year.ToString();
            mskFechaFactura.Text = diaB + mesB + añoB;
            txtNumFactura.Text = FacturaBLL.MaxNum().ToString();
            grillaDetalles.DataSource = FacturaBLL.ObenerDetalles(DateTime.Parse(mskFechaAloj.Text), txtPasaporte.Text, int.Parse(txtIdHotel.Text));
            grillaDetalles.Columns["NroFactura"].Visible = false;
            grillaDetalles.Columns["IdAloj"].Visible = false;
            grillaDetalles.Columns["IdHuesped"].Visible = false;
            grillaDetalles.Columns["FechaFactura"].Visible = false;
            grillaDetalles.Columns["FechaAloj"].Visible = false;
            grillaDetalles.Columns["pasaporte"].Visible = false;
            grillaDetalles.Columns["IdPais"].Visible = false;
            grillaDetalles.Columns["IdHotel"].Visible = false;
            grillaDetalles.Columns["nombreHuesped"].Visible = false;
            grillaDetalles.Columns["apellidoHuesped"].Visible = false;
            grillaDetalles.Columns["NomHotel"].Visible = false;
            grillaDetalles.Columns["NomPais"].Visible = false;

            btnGenerar.Enabled = true;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Factura f = FacturaBLL.ObtenerFactura(txtPasaporte.Text);
            f.FechaFactura = DateTime.Now;
            f.NroFactura = int.Parse(txtNumFactura.Text);
            List<Factura> lista = FacturaBLL.ObenerDetalles(DateTime.Parse(mskFechaAloj.Text), txtPasaporte.Text, int.Parse(txtIdHotel.Text));
            if (FacturaBLL.AgregarFactura(f, lista))
            {
                MessageBox.Show("Facturacion generada con exito!");
            }
            
            
            
            btnGenerar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtApellido.Text = "";
            txtIdHotel.Text = "";
            txtNomHotel.Text = "";
            txtNomHuesped.Text = "";
            txtNumFactura.Text = "";
            txtPais.Text = "";
            txtPasaporte.Text = "";
            mskFechaAloj.Text = "";
            mskFechaFactura.Text = "";
            
            grillaDetalles.DataSource = FacturaBLL.ObenerDetalles(DateTime.Now, txtPasaporte.Text, 0);
            grillaDetalles.Columns["NroFactura"].Visible = false;
            grillaDetalles.Columns["IdAloj"].Visible = false;
            grillaDetalles.Columns["IdHuesped"].Visible = false;
            grillaDetalles.Columns["FechaFactura"].Visible = false;
            grillaDetalles.Columns["FechaAloj"].Visible = false;
            grillaDetalles.Columns["pasaporte"].Visible = false;
            grillaDetalles.Columns["IdPais"].Visible = false;
            grillaDetalles.Columns["IdHotel"].Visible = false;
            grillaDetalles.Columns["nombreHuesped"].Visible = false;
            grillaDetalles.Columns["apellidoHuesped"].Visible = false;
            grillaDetalles.Columns["NomHotel"].Visible = false;
            grillaDetalles.Columns["NomPais"].Visible = false;

            btnGenerar.Enabled = false;
        }

        

        private void FacturaForm_Load(object sender, EventArgs e)
        {
            btnGenerar.Enabled = false;
        }
    }
}
