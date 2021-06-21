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
    public partial class FormHabitacionXHotel : Form
    {
        int IdHxH;
        public FormHabitacionXHotel()
        {
            InitializeComponent();
        }

        private void FormHabitacionXHotel_Load(object sender, EventArgs e)
        {
            CargarHotele();
            CargarHabitacion();
            CargarGrilla();
        }

        private void CargarHotele()
        {
            CmbHotel.DisplayMember = "Nombre";
            CmbHotel.ValueMember = "Id";
            CmbHotel.SelectedIndex = -1;
            CmbHotel.DataSource = HotelBLL.ObtenerListadoHoteles();
        }

        private void CargarHabitacion()
        {
            CmbHabitacion.DataSource = HabitacionesBLL.CargarGrilla();
            CmbHabitacion.DisplayMember = "Nombre";
            CmbHabitacion.ValueMember = "Id";
            CmbHabitacion.SelectedIndex = -1;
        }

        private void DgvHabitacionXHotel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaselec = DgvHabitacionXHotel.Rows[e.RowIndex];
            IdHxH = int.Parse(filaselec.Cells["Id"].Value.ToString());
            Entities.HabitacionXHotel HxH =  HabitacionXHotelBLL.SelectById(int.Parse(filaselec.Cells["Id"].Value.ToString()));
            CmbHabitacion.SelectedValue = HxH.habitacion;
            TxtPrecio.Text = HxH.Precio;
        }

        private void CmbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarCampos();

            if (CmbHotel.Text != "")
            {
                try
                {
                    DgvHabitacionXHotel.DataSource = CargarGrilla();
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        private DataTable CargarGrilla()
        {
            return HabitacionXHotelBLL.cargarGrilla(int.Parse(CmbHotel.SelectedValue.ToString())); ;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtPrecio.Text))
            {
                errorPrecio.SetError(TxtPrecio, "Debe ingresar un Precio");
                return;
            }
            else
                errorPrecio.Clear();

            if (string.IsNullOrEmpty(CmbHotel.Text))
            {
                errorHotel.SetError(CmbHotel, "Debe seleccionar un hotel");
                return;
            }
            else
                errorHotel.Clear();

            if (string.IsNullOrEmpty(CmbHabitacion.Text))
            {
                errorHabitacion.SetError(CmbHabitacion, "Debe seleccionar una habitación");
                return;
            }
            else
                errorHabitacion.Clear();

            if (HabitacionXHotelBLL.VerificarExisteCombinacion((int)CmbHotel.SelectedValue, (int)CmbHabitacion.SelectedValue))
            {
                MessageBox.Show("Esta combinacion entre hotel y habitacion ya existe");
                return;
            }

            string message = "¿Desea guardar?";
            string title = "Guardar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                try
                {
                    Entities.HabitacionXHotel HxH = new Entities.HabitacionXHotel();
                    HxH.hotel = int.Parse(CmbHotel.SelectedValue.ToString());
                    HxH.habitacion = int.Parse(CmbHabitacion.SelectedValue.ToString());
                    HxH.Precio = TxtPrecio.Text;
                    HabitacionXHotelBLL.SaveHabitacionXHotel(HxH);
                    MessageBox.Show("¡Se guardó con éxito!");
                    DgvHabitacionXHotel.DataSource = CargarGrilla();
                    LimpiarCampos();
                }
                catch (Exception)
                {
                    MessageBox.Show("¡Ocurrió un error!");
                    return;
                }
            }
        }

        private void LimpiarCampos()
        {
            CmbHabitacion.SelectedIndex = -1;
            TxtPrecio.Text = "";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (IdHxH == 0)
            {
                MessageBox.Show("Debe seleccionar una habitación en la grilla", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string message = "¿Desea Eliminar?";
            string title = "Eliminar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                try
                {
                    HabitacionXHotelBLL.EliminarHabitacionXHotel(IdHxH);
                    MessageBox.Show("¡Se eliminó con éxito!");
                    DgvHabitacionXHotel.DataSource = CargarGrilla();
                    LimpiarCampos();
                    IdHxH = 0;
                }
                catch (Exception)
                {
                    MessageBox.Show("¡Ocurrió un error!");
                    return;
                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (IdHxH == 0)
            {
                MessageBox.Show("Debe seleccionar una habitación en la grilla", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(TxtPrecio.Text))
            {
                errorPrecio.SetError(TxtPrecio, "Debe ingresar un precio");
                return;
            }
            else
                errorPrecio.Clear();

            if (string.IsNullOrEmpty(CmbHotel.Text))
            {
                errorHotel.SetError(CmbHotel, "Debe seleccionar un hotel");
                return;
            }
            else
                errorHotel.Clear();

            if (string.IsNullOrEmpty(CmbHabitacion.Text))
            {
                errorHabitacion.SetError(CmbHabitacion, "Debe seleccionar una habitación");
                return;
            }
            else
                errorHabitacion.Clear();

            if (HabitacionXHotelBLL.VerificarExisteCombinacion2((int)CmbHotel.SelectedValue, (int)CmbHabitacion.SelectedValue, TxtPrecio.Text))
            {
                MessageBox.Show("Esta combinacion entre hotel, habitacion y precio ya existe");
                return;
            }

            string message = "¿Desea modificar?";
            string title = "Modificar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                try
                {
                    Entities.HabitacionXHotel HxH = new Entities.HabitacionXHotel();
                    HxH.hotel = int.Parse(CmbHotel.SelectedValue.ToString());
                    HxH.habitacion = int.Parse(CmbHabitacion.SelectedValue.ToString());
                    HxH.Precio = TxtPrecio.Text;
                    HxH.Id = IdHxH;
                    HabitacionXHotelBLL.ModificarHabitacionXHotel(HxH);
                    MessageBox.Show("¡Se modificó con éxito!");
                    DgvHabitacionXHotel.DataSource = CargarGrilla();
                    LimpiarCampos();
                    IdHxH = 0;
                }
                catch (Exception)
                {
                    MessageBox.Show("¡Ocurrió un error!");
                    return;
                }
            }
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BtnListado_Click(object sender, EventArgs e)
        {
            ReporteListadoIntalacionXHotel ventana = new ReporteListadoIntalacionXHotel();
            ventana.Show();
        }
    }
}
