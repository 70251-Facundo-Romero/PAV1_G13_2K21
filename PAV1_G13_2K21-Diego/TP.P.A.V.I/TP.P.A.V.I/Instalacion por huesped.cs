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
    public partial class Instalacion_por_huesped : Form
    {
        public Instalacion_por_huesped()
        {
            InitializeComponent();
        }

        private void Instalacion_por_huesped_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnModificarIXH.Enabled = false;
            btnEliminarIXH.Enabled = false;
            CargarGrilla();
            CargarComboHoteles();
            CargarComboHabitaciones();
            CargarComboInstalaciones();


        }
        private void CargarComboHoteles()
        {
            cmb_Hotel.DataSource = InstalacionXHuespedBLL.ObtenerListadoHoteles();
            cmb_Hotel.DisplayMember = "Nombre";
            cmb_Hotel.ValueMember = "Id";
            cmb_Hotel.SelectedIndex = -1;
        }
        private void CargarComboHabitaciones()
        {
            cmb_Habitacion.DataSource = InstalacionXHuespedBLL.ObtenerListadoHabitaciones();
            cmb_Habitacion.DisplayMember = "Id";
            cmb_Habitacion.ValueMember = "Id";
            cmb_Habitacion.SelectedIndex = -1;
        }
        private void CargarComboInstalaciones()
        {
            cmb_Instalacion.DataSource = InstalacionXHuespedBLL.ObtenerListadoInstalaciones();
            cmb_Instalacion.DisplayMember = "Nombre";
            cmb_Instalacion.ValueMember = "Id";
            cmb_Instalacion.SelectedIndex = -1;
        }
        private void LimpiarCampos()
        {
            txt_Id.Text = "";
            cmb_Hotel.SelectedIndex = -1;
            cmb_Habitacion.SelectedIndex = -1;
            cmb_Instalacion.SelectedIndex = -1;
            msk_FechaAlojamiento.Text = "";
            msk_FechaUso.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void CargarGrilla()
        {
            try
            {
                grillaInstalacion.DataSource = InstalacionXHuespedBLL.ObtenerListadoInstalacionXHuesped();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error...");
            }
        }

        private void CargarCampos(InstalacionXHuespedes ih)
        {
            txt_Id.Text = ih.Id_IXH.ToString();
            cmb_Hotel.SelectedValue = ih.Id_Hotel;
            cmb_Habitacion.SelectedValue = ih.Id_Habitacion;
            cmb_Instalacion.SelectedValue = ih.Id_Instalacion;
            DateTime fechaA = ih.FechaAlojamiento;
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

            DateTime fechaS = ih.FechaUso;

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
            string hora = "";
            string minuto = "";
            hora = fechaS.Date.Hour.ToString();
            if (hora.Length==1)
            {
                hora = "0" + hora;
            }
            minuto = fechaS.Date.Minute.ToString();
            if (minuto.Length==1)
            {
                minuto = "0" + minuto;
            }

            msk_FechaUso.Text = dia + mes + año+ hora+ minuto;


        }

        private void grillaInstalacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = e.RowIndex;
                btnModificarIXH.Enabled = true;
                btnEliminarIXH.Enabled = true;
                DataGridViewRow filaSeleccionada = grillaInstalacion.Rows[indice];
                int id = (int)filaSeleccionada.Cells["Id_IXH"].Value;
                InstalacionXHuespedes ih = InstalacionXHuespedBLL.ObtenerInstalacionXHuesped(id);
                LimpiarCampos();
                CargarCampos(ih);
            }
            catch (Exception)
            {
                //MessageBox.Show("Seleccione una fila");
                throw;

            }
        }

        private void btnAgregarIXH_Click(object sender, EventArgs e)
        {
            {
                if (cmb_Hotel.Text.Equals("") || cmb_Habitacion.Text.Equals("") || cmb_Instalacion.Text.Equals("") || msk_FechaAlojamiento.Text.Equals("") || msk_FechaUso.Text.Equals("") )
                {
                    MessageBox.Show("Ingrese los datos faltantes");
                }
                else
                {
                    InstalacionXHuespedes ih = new InstalacionXHuespedes();
                    ih.Id_Hotel = (int)cmb_Hotel.SelectedValue;
                    ih.Id_Habitacion = (int)cmb_Habitacion.SelectedValue;
                    ih.Id_Instalacion = (int)cmb_Instalacion.SelectedValue;
                    ih.FechaAlojamiento = DateTime.Parse(msk_FechaAlojamiento.Text);
                    ih.FechaUso = DateTime.Parse(msk_FechaUso.Text);

                    bool resultado = InstalacionXHuespedBLL.AgregarInstalacionXHuesped(ih);

                    if (resultado)
                    {
                        MessageBox.Show("Agregación realizada con exito!!");
                        LimpiarCampos();
                        CargarGrilla();
                        CargarComboHoteles();
                        CargarComboInstalaciones();
                        CargarComboHabitaciones();

                    }
                    else
                    {
                        MessageBox.Show("Hubo un error...");
                    }
                }
            }
        }

        private void btnEliminarIXH_Click(object sender, EventArgs e)
        {
            InstalacionXHuespedes ih = new InstalacionXHuespedes();
            ih.Id_IXH = int.Parse(txt_Id.Text);
            ih.Id_Hotel = (int)cmb_Hotel.SelectedValue;
            ih.Id_Habitacion = (int)cmb_Habitacion.SelectedValue;
            ih.Id_Instalacion = (int)cmb_Instalacion.SelectedValue;
            ih.FechaAlojamiento = DateTime.Parse(msk_FechaAlojamiento.Text);
            ih.FechaUso = DateTime.Parse(msk_FechaUso.Text);

            bool resultado = InstalacionXHuespedBLL.BorrarInstalacionXHuesped(ih);

            if (resultado)
            {
                MessageBox.Show("Eliminacion realizada con exito!");
                LimpiarCampos();
                CargarGrilla();
                CargarComboHoteles();
                CargarComboHabitaciones();
                CargarComboInstalaciones();

            }
            else
            {
                MessageBox.Show("Hubo un error...");
            }

        }

        private void btnModificarIXH_Click(object sender, EventArgs e)
        {
            InstalacionXHuespedes ih = new InstalacionXHuespedes();
            ih.Id_IXH = int.Parse(txt_Id.Text);
            ih.Id_Hotel = (int)cmb_Hotel.SelectedValue;
            ih.Id_Habitacion = (int)cmb_Habitacion.SelectedValue;
            ih.Id_Instalacion = (int)cmb_Instalacion.SelectedValue;
            ih.FechaAlojamiento = DateTime.Parse(msk_FechaAlojamiento.Text);
            ih.FechaUso = DateTime.Parse(msk_FechaUso.Text);

            bool resultado = InstalacionXHuespedBLL.ActualizarInstalacionXHuesped(ih);

            if (resultado)
            {
                MessageBox.Show("Modificacion realizada con exito!");
                LimpiarCampos();
                CargarGrilla();
                CargarComboHoteles();
                CargarComboHabitaciones();
                CargarComboInstalaciones();
            }
            else
            {
                MessageBox.Show("Hubo un error...");
            }
        }
    }
}

