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
    public partial class Huespedes : Form
    {
        public Huespedes()
        {
            InitializeComponent();
        }

        private void Huespedes_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
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

        private void CargarCampos(Huesped c)
        {
            txtNombre.Text = c.NombreHuesped;
            txtApellido.Text = c.ApellidoHuesped;
            cmbPais.SelectedValue = c.IdPaisHuesped;
            txtNumPasaporte.Text = c.NroPasaporteHuesped.ToString();
            cmbTarjeta.SelectedValue = c.IdTarjetaHuesped;
            txtNumTarjeta.Text = c.NroTarjetaHuesped.ToString();
            txtId.Text = c.IdHuesped.ToString();
        }

        private void grillaHuespedes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = e.RowIndex;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                DataGridViewRow filaSeleccionada = grillaHuespedes.Rows[indice];
                int id = (int)filaSeleccionada.Cells["Id"].Value;
                Huesped h = HuespedesBLL.ObtenerHuesped(id);
                LimpiarCampos();
                CargarCampos(h);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al traer el huesped");
            }
        }

        private void CargarHuesped(Huesped h)
        {
            h.NombreHuesped = txtNombre.Text;
            h.ApellidoHuesped = txtApellido.Text;
            h.NroPasaporteHuesped = long.Parse(txtNumPasaporte.Text);
            h.NroTarjetaHuesped = long.Parse(txtNumTarjeta.Text);
            h.IdPaisHuesped = (int)cmbPais.SelectedValue;
            h.IdTarjetaHuesped = (int)cmbTarjeta.SelectedValue;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") || txtApellido.Text.Equals("") || txtNumPasaporte.Text.Equals("") || txtNumTarjeta.Text.Equals("") || cmbPais.SelectedIndex == -1 || cmbTarjeta.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese valores en todos los campos");
                return;
            }

            if (HuespedesBLL.VerificarExistenciaPasaportePais((int)cmbPais.SelectedValue, int.Parse(txtNumPasaporte.Text)))
            {
                MessageBox.Show("El huesped de ese pais con ese numero de pasaporte ya esta cargado en el sistema");
                return;
            }
            else
            {
                try
                {
                    Huesped h = new Huesped();
                    CargarHuesped(h);
                    HuespedesBLL.AgregarHuesped(h);
                    LimpiarCampos();
                    CargarGrilla();
                    MessageBox.Show("Huesped agregado con exito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el huesped al sistema");
                }
            }
        }
    }
}
