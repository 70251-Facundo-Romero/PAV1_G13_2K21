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
    public partial class AltaServicioXHotel : Form
    {
        public AltaServicioXHotel()
        {
            InitializeComponent();
            CargarComboHotel();
            CargarComboServicio();
            CargarGrilla();
            LimpiarCampos();
        }

        private void CargarGrilla()
        {
            dataGridView1.DataSource = ServicioXHotelBLL.ObtenerListadoServXHoteles();
        }

        private void LimpiarCampos()
        {
            txtPrecio.Text = "";
        }

        private void CargarComboHotel()
        {
            try
            {
                cmbHotel.DataSource = ServicioXHotelBLL.ObtenerListadoHoteles();
                cmbHotel.DisplayMember = "Nombre";
                cmbHotel.ValueMember = "Id";
                cmbHotel.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema al cargar el combo de hoteles");
            }
        }
        private void CargarComboServicio()
        {
            try
            {
                cmbServicio.DataSource = ServicioXHotelBLL.ObtenerListadoServicios();
                cmbServicio.DisplayMember = "Nombre";
                cmbServicio.ValueMember = "Id";
                cmbServicio.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema al cargar el combo de servicios");
            }
        }

        private void BtnLimpiarCampos_Click(object sender, EventArgs e)
        {
            CargarComboHotel();
            CargarComboServicio();
            LimpiarCampos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            BtnEliminar.Enabled = true;
            BtnModificarSerXHot.Enabled = true;
            DataGridViewRow filaSeleccionada = dataGridView1.Rows[indice];
            int id = (int)filaSeleccionada.Cells["IdServXHotel"].Value;
            ServXHotel s = ServicioXHotelBLL.ObtenerServXHotel(id);
            LimpiarCampos();
            CargarCampos(s);
        }

        private void CargarCampos(ServXHotel s)
        {
            cmbHotel.SelectedValue = s.Id_Hotel;
            cmbServicio.SelectedValue = s.Id_Servicio;
            txtPrecio.Text = s.PrecioServicio;
            txtId.Text = s.IdServXHot.ToString();
        }

        private void BtnAgregarSerXHot_Click(object sender, EventArgs e)
        {
            if (txtPrecio.Text.Equals("") || cmbHotel.SelectedIndex == -1 || cmbServicio.SelectedIndex == -1)
            {
                MessageBox.Show("Complete los campos");
                return;
            }

            if (ServicioXHotelBLL.VerificarExisteCombinacion((int)cmbHotel.SelectedValue, (int)cmbServicio.SelectedValue))
            {
                MessageBox.Show("Esta combinacion entre servicio y hotel ya existe, escoge otra o actualice el que ya existe");
                return;
            }

            ServXHotel s = new ServXHotel();
            s.PrecioServicio = txtPrecio.Text;
            s.Id_Hotel = (int)cmbHotel.SelectedValue;
            s.Id_Servicio = (int)cmbServicio.SelectedValue;
            try
            {
                bool resultado = ServicioXHotelBLL.AgregarServXHotel(s);

                if (resultado)
                {
                    LimpiarCampos();
                    CargarGrilla();
                    CargarComboHotel();
                    CargarComboServicio();
                    MessageBox.Show("Fila agregada con exito!");

                }
                else
                {
                    MessageBox.Show("Hubo un error al agregar la Fila");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al agregar la ciudad");
            }

        }

        private void BtnModificarSerXHot_Click(object sender, EventArgs e)
        {
            if (txtPrecio.Text.Equals("") || cmbHotel.SelectedIndex == -1 || cmbServicio.SelectedIndex == -1)
            {
                MessageBox.Show("Complete los campos");
                return;
            }

            if (ServicioXHotelBLL.VerificarExisteCombinacion2((int)cmbHotel.SelectedValue, (int)cmbServicio.SelectedValue, txtPrecio.Text))
            {
                MessageBox.Show("Esta combinacion entre servicio, hotel y precio ya existe, escoge otra o actualice el que ya existe");
                return;
            }
            
            if (txtId.Text.Equals(""))
            {
                MessageBox.Show("Seleccione la fila en la grilla");
                return;
            }

            ServXHotel s = new ServXHotel();
            s.PrecioServicio = txtPrecio.Text;
            s.IdServXHot = int.Parse(txtId.Text);
            s.Id_Servicio = (int)cmbServicio.SelectedValue;
            s.Id_Hotel = (int)cmbHotel.SelectedValue;
            bool resultado = ServicioXHotelBLL.ActualizarServXHotel(s);

            if (resultado)
            {
                LimpiarCampos();
                CargarGrilla();
                CargarComboHotel();
                CargarComboServicio();
                MessageBox.Show("Servicio por hotel actualizado con exito!");

            }
            else
            {
                MessageBox.Show("Hubo un error al actualizar la fila");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(""))
            {
                MessageBox.Show("Seleccione la fila en la grilla");
                return;
            }

            ServXHotel s = new ServXHotel();
            s.PrecioServicio = txtPrecio.Text;
            s.IdServXHot = int.Parse(txtId.Text);
            s.Id_Servicio = (int)cmbServicio.SelectedValue;
            s.Id_Hotel = (int)cmbHotel.SelectedValue;
            bool resultado = ServicioXHotelBLL.BorrarServXHotel(s);

            if (resultado)
            {
                LimpiarCampos();
                CargarGrilla();
                CargarComboHotel();
                CargarComboServicio();
                MessageBox.Show("Servicio por hotel eliminado con exito!");

            }
            else
            {
                MessageBox.Show("Hubo un error al eliminar la fila");
            }
        }
    }
}
