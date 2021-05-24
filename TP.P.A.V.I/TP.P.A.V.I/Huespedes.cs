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
    public partial class Huespedes : Form
    {
        public Huespedes()
        {
            InitializeComponent();
        }

        private void Huespedes_Load(object sender, EventArgs e)
        {
            CargarComboPais();
            CargarComboTarjeta();
            CargarGrilla();
            LimpiarCampos();
        }

        private void CargarGrilla()
        {
            grillaHuespedes.DataSource = HuespedesBLL.ObtenerListadoHuespedes();
        }

        private void CargarComboTarjeta()
        {
            try
            {
                cmbPais.DataSource = PaisBLL.ObtenerListadoPaises();
                cmbPais.DisplayMember = "Nombre";
                cmbPais.ValueMember = "Id";
                cmbPais.SelectedIndex = -1;
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar el combo pais");
            }
        }

        private void CargarComboPais()
        {
            try
            {
                cmbTarjeta.DataSource = TarjetaBLL.ActualizarGrillaTarjeta();
                cmbTarjeta.DisplayMember = "Nombre";
                cmbTarjeta.ValueMember = "Id_Tarjeta";
                cmbTarjeta.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el combo tarjeta");
            }
        }

        private void LimpiarCampos()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtNumPasaporte.Text = "";
            txtNumTarjeta.Text = "";
            CargarComboPais();
            CargarComboTarjeta();
        }
    }
}
