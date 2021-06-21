using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP.P.A.V.I.BLL;
using TP.P.A.V.I.Entities;

namespace TP.P.A.V.I
{
    public partial class Hoteles : Form
    {
        public Hoteles()
        {
            InitializeComponent();
        }


        private void btnAgregarHotel_Click(object sender, EventArgs e)
        {
            if (txtNombreHotel.Text.Equals("") && txtNumeroCalle.Text.Equals("") && txtCalleHotel.Text.Equals(""))
            {
                MessageBox.Show("Ingrese los datos que le faltan");
            }
            else
            {
                Hotel h = new Hotel();
                h.NombreHotel = txtNombreHotel.Text;
                h.CalleHotel = txtCalleHotel.Text;
                h.NumeroCalle = txtNumeroCalle.Text;
                h.IdBarrio = (int)cmbBarrio.SelectedValue;
                bool resultado = HotelBLL.AgregarHotelABD(h);
                CargarComboBarrio();

                if (resultado)
                {
                    MessageBox.Show("Hotel agregado con exito!");
                    LimpiarCampos();
                    CargarGrilla();
                    CargarComboBarrio();
                }
                else
                {
                    MessageBox.Show("Hubo un error al agregar el Hotel");
                }

            }
        }


        private void LimpiarCampos()
        {
            txtNombreHotel.Text = "";
            txtCalleHotel.Text = "";
            txtNumeroCalle.Text = "";
            txtId.Text = "";
            cmbBarrio.SelectedIndex = -1;

            txtNombreHotel.Focus();
        }
        private void CargarGrilla()
        {
            try
            {
                grillaHoteles.DataSource = HotelBLL.ObtenerListadoHoteles();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al listar los hoteles");
            }
        }

        private void grillaHoteles_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int indice = e.RowIndex;
                btnActualizarHotel.Enabled = true;
                btnEliminarHotel.Enabled = true;
                DataGridViewRow filaSeleccionada = grillaHoteles.Rows[indice];
                int id = (int)filaSeleccionada.Cells["Id"].Value;
                Hotel h = HotelBLL.ObtenerHotel(id);
                LimpiarCampos();
                CargarCampos(h);
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione la fila");
            }
        }
        
        private void CargarCampos(Hotel h)
        {
            txtId.Text = h.IdHotel.ToString();
            txtNombreHotel.Text = h.NombreHotel;
            txtCalleHotel.Text = h.CalleHotel;
            txtNumeroCalle.Text = h.NumeroCalle;
            cmbBarrio.SelectedValue = h.IdBarrio;
        }

        private void btnActualizarHotel_Click(object sender, EventArgs e)
        {
            Hotel h = new Hotel();
            h.IdHotel = int.Parse(txtId.Text);
            h.NombreHotel = txtNombreHotel.Text;
            h.CalleHotel = txtCalleHotel.Text;
            h.NumeroCalle = txtNumeroCalle.Text;
            h.IdBarrio = (int)cmbBarrio.SelectedValue;
            bool resultado = HotelBLL.ActualizarHotelABD(h);

            if (resultado)
            {
                MessageBox.Show("Hotel actualizado con exito!");
                LimpiarCampos();
                CargarGrilla();
                CargarComboBarrio();
            }
            else
            {
                MessageBox.Show("Hubo un error al actualizar el Hotel");
            }
        }

        private void btnEliminarHotel_Click(object sender, EventArgs e)
        {
            Hotel h = new Hotel();
            h.IdHotel = int.Parse(txtId.Text);
            h.NombreHotel = txtNombreHotel.Text;
            h.CalleHotel = txtCalleHotel.Text;
            h.NumeroCalle = txtNumeroCalle.Text;
            h.IdBarrio = (int)cmbBarrio.SelectedValue;
            bool resultado = HotelBLL.BorrarHotelABD(h);


            if (resultado)
            {
                MessageBox.Show("Hotel eliminado con exito!");
                LimpiarCampos();
                CargarGrilla();
                CargarComboBarrio();
            }
            else
            {
                MessageBox.Show("Hubo un error al borrar el pais");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void CargarComboBarrio()
        {
            cmbBarrio.DataSource = HotelBLL.ObtenerListadoBarrios();
            cmbBarrio.DisplayMember = "Nombre";
            cmbBarrio.ValueMember = "Id";
            cmbBarrio.SelectedIndex = -1;
        }

        private void Hoteles_Load_1(object sender, EventArgs e)
        {
            CargarComboBarrio();
            LimpiarCampos();

            btnActualizarHotel.Enabled = false;
            btnEliminarHotel.Enabled = false;

            CargarGrilla();
         
        }

        private void btnListaHoteles_Click(object sender, EventArgs e)
        {
            ListadoDeHoteles ventana = new ListadoDeHoteles();
            ventana.ShowDialog();
        }

        private void btnEstadisticasHotel_Click(object sender, EventArgs e)
        {
            EstadisticasHoteles ventana = new EstadisticasHoteles();
            ventana.ShowDialog();
        }
    }
}

