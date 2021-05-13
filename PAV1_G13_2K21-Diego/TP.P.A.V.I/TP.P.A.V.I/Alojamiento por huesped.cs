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
    public partial class AlojamientoXHuesped : Form
    {
        public AlojamientoXHuesped()
        {
            InitializeComponent();
        }

        private void AlojamientoXHuesped_Load(object sender, EventArgs e)
        {
            btnModificarAXH.Enabled = false;
            btnEliminarAXH.Enabled = false;
            LimpiarCampos();
            CargarGrilla();
            CargarComboHoteles();
            CargarComboPaises();
            CargarComboHabitaciones();
        }
        private void CargarComboHoteles()
        {
            cmb_Hotel.DataSource = AlojamientoXHuespedBLL.ObtenerListadoHoteles();
            cmb_Hotel.DisplayMember = "Nombre";
            cmb_Hotel.ValueMember = "Id";
            cmb_Hotel.SelectedIndex = -1;
        }
        private void CargarComboPaises()
        {
            cmb_Pais.DataSource = AlojamientoXHuespedBLL.ObtenerListadoPaises();
            cmb_Pais.DisplayMember = "Nombre";
            cmb_Pais.ValueMember = "Id";
            cmb_Pais.SelectedIndex = -1;
        }
        private void CargarComboHabitaciones()
        {
            cmb_Habitacion.DataSource = AlojamientoXHuespedBLL.ObtenerListadoHabitaciones();
            cmb_Habitacion.DisplayMember = "Id";
            cmb_Habitacion.ValueMember = "Id";
            cmb_Habitacion.SelectedIndex = -1;
        }

        private void LimpiarCampos()
        {
            cmb_Hotel.SelectedIndex = -1;
            cmb_Habitacion.SelectedIndex = -1;
            cmb_Pais.SelectedIndex = -1;
            msk_FechaAlojamiento.Text = "";
            msk_FechaSalida.Text = "";
            msk_numPasaporte.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void CargarGrilla()
        {
            try
            {
                grillaAlojamiento.DataSource = AlojamientoXHuespedBLL.ObtenerListadoAlojamientoXHuesped();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error...");
            }
        }
        private void CargarCampos(AlojamientoXHuespedes al)
        {
            txt_Id.Text = al.Id_AXH.ToString();
            cmb_Hotel.SelectedValue = al.Id_Hotel;
            cmb_Habitacion.SelectedValue = al.Id_Habitacion;
            msk_numPasaporte.Text = al.NroPasaporte.ToString();
            cmb_Pais.SelectedValue = al.Id_Pais;
            DateTime fechaA = al.FechaAlojamiento;
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
            msk_FechaAlojamiento.Text = diaA + mesA + añoA;

            DateTime fechaS = al.FechaSalida;
            string dia = "";
            string mes = "";
            string año = "";
            dia = fechaS.Date.Day.ToString();
            if (dia.Length == 1)
            {
                dia = "0" + dia;
            }
            mes = fechaS.Date.Month.ToString();
            if (mes.Length == 1)
            {
                mes = "0" + mes;
            }
            año = fechaS.Date.Year.ToString();
            msk_FechaSalida.Text = dia + mes + año;

        }

        private void grillaAlojamiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = e.RowIndex;
                btnModificarAXH.Enabled = true;
                btnEliminarAXH.Enabled = true;
                DataGridViewRow filaSeleccionada = grillaAlojamiento.Rows[indice];
                int id = (int)filaSeleccionada.Cells["Id_AXH"].Value;
                AlojamientoXHuespedes al = AlojamientoXHuespedBLL.ObtenerAlojamientoXHuesped(id);
                LimpiarCampos();
                CargarCampos(al);
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una fila");

            }
        }

        private void btnAgregarAXH_Click(object sender, EventArgs e)
        {
            if (cmb_Hotel.Text.Equals("") || cmb_Habitacion.Text.Equals("") || cmb_Pais.Text.Equals("") || msk_FechaSalida.Text.Equals("") || msk_FechaAlojamiento.Text.Equals("") || msk_numPasaporte.Text.Equals(""))
            {
                MessageBox.Show("Ingrese los datos faltantes");
            }
            else
            {
                AlojamientoXHuespedes al = new AlojamientoXHuespedes();
                al.Id_Hotel = (int)cmb_Hotel.SelectedValue;
                al.Id_Habitacion = (int)cmb_Habitacion.SelectedValue;
                al.Id_Pais = (int)cmb_Pais.SelectedValue;
                al.FechaAlojamiento = DateTime.Parse(msk_FechaAlojamiento.Text);
                al.FechaSalida = DateTime.Parse(msk_FechaSalida.Text);
                al.NroPasaporte = int.Parse(msk_numPasaporte.Text);

                bool resultado = AlojamientoXHuespedBLL.AgregarAlojamientoXHuespedABD(al);

                if (resultado)
                {
                    MessageBox.Show("Alojamiento agregado con exito!");
                    LimpiarCampos();
                    CargarGrilla();
                    CargarComboHoteles();
                    CargarComboPaises();
                    CargarComboHabitaciones();

                }
                else
                {
                    MessageBox.Show("Hubo un error...");
                }
            }
        }

        private void btnEliminarAXH_Click(object sender, EventArgs e)
        {
            AlojamientoXHuespedes al = new AlojamientoXHuespedes();
            al.Id_AXH = int.Parse(txt_Id.Text);
            al.Id_Hotel = (int)cmb_Hotel.SelectedValue;
            al.Id_Habitacion = (int)cmb_Habitacion.SelectedValue;
            al.Id_Pais = (int)cmb_Pais.SelectedValue;
            al.FechaAlojamiento = DateTime.Parse(msk_FechaAlojamiento.Text);
            al.FechaSalida = DateTime.Parse(msk_FechaSalida.Text);
            al.NroPasaporte = int.Parse(msk_numPasaporte.Text);

            bool resultado = AlojamientoXHuespedBLL.BorrarAlojamientoXHuespedABD(al);

            if (resultado)
            {
                MessageBox.Show("Alojamiento eliminado con exito!");
                LimpiarCampos();
                CargarGrilla();
                CargarComboHoteles();
                CargarComboPaises();
                CargarComboHabitaciones();

            }
            else
            {
                MessageBox.Show("Hubo un error...");
            }

        }

        private void btnModificarAXH_Click(object sender, EventArgs e)
        {
            AlojamientoXHuespedes al = new AlojamientoXHuespedes();
            al.Id_AXH = int.Parse(txt_Id.Text);
            al.Id_Hotel = (int)cmb_Hotel.SelectedValue;
            al.Id_Habitacion = (int)cmb_Habitacion.SelectedValue;
            al.Id_Pais = (int)cmb_Pais.SelectedValue;
            al.FechaAlojamiento = DateTime.Parse(msk_FechaAlojamiento.Text);
            al.FechaSalida = DateTime.Parse(msk_FechaSalida.Text);
            al.NroPasaporte = int.Parse(msk_numPasaporte.Text);

            bool resultado = AlojamientoXHuespedBLL.ActualizarAlojamientoXHuespedABD(al);

            if (resultado)
            {
                MessageBox.Show("Alojamiento eliminado con exito!");
                LimpiarCampos();
                CargarGrilla();
                CargarComboHoteles();
                CargarComboPaises();
                CargarComboHabitaciones();
            }
            else
            {
                MessageBox.Show("Hubo un error...");
            }
        }
    }
}
