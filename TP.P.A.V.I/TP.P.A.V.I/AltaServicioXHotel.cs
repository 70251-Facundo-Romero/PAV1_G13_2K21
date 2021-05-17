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
    public partial class AltaServicioXHotel : Form
    {
        public AltaServicioXHotel()
        {
            InitializeComponent();
            DAL.ServicioXHotelDAL.ActualizarGrillaSerXHot(dataGridView1);
            DAL.ServicioXHotelDAL.CargarCombosHotel(cmbHotel);
            DAL.ServicioXHotelDAL.CargarCombosServicios(cmbServicio);
            BtnModificarSerXHot.Enabled = false;
            BtnEliminar.Enabled = false;

        }

        private void BtnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BtnEliminar.Enabled = false;
            BtnModificarSerXHot.Enabled = false;
        }

        private void BtnAgregarSerXHot_Click(object sender, EventArgs e)
        {
            string precio = txtPrecio.Text;
            int hotel = (int)cmbHotel.SelectedValue;
            int servicio = (int)cmbServicio.SelectedValue;

            DAL.ServicioXHotelDAL.AgregarServicioXHotel(hotel, servicio, precio);
            DAL.ServicioXHotelDAL.ActualizarGrillaSerXHot(dataGridView1);

        }

        private void BtnModificarSerXHot_Click(object sender, EventArgs e)
        {
            int idH = (int)cmbHotel.SelectedValue;
            int idS = (int)cmbServicio.SelectedValue;
            string precio = txtPrecio.Text;
            DAL.ServicioXHotelDAL.ModificarServicioXHotel(idH, idS, precio);
            DAL.ServicioXHotelDAL.ActualizarGrillaSerXHot(dataGridView1);
            BtnModificarSerXHot.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            BtnModificarSerXHot.Enabled = true;
            BtnEliminar.Enabled = true;
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = dataGridView1.Rows[indice];
            int IdHot = int.Parse(filaSeleccionada.Cells["Id_Hotel"].Value.ToString());
            int IdSer = int.Parse(filaSeleccionada.Cells["Id_Servicio"].Value.ToString());
            (int,int)t1 = (IdSer, IdHot);
            (int, int, string)tupla = DAL.ServicioXHotelDAL.ObtenerSerxHot(t1);
            LimpiarCampos();       
            CargarCampos(tupla);


        }

        private void CargarCampos((int,int,string)tupla)
        {
            cmbHotel.SelectedValue = tupla.Item2;
            cmbServicio.SelectedValue = tupla.Item1;
            txtPrecio.Text = tupla.Item3;
        }

        private void LimpiarCampos()
        {
            cmbHotel.SelectedValue = 0;
            cmbServicio.SelectedValue = 0;
            txtPrecio.Text = "";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            int idH = (int)cmbHotel.SelectedValue;
            int idS = (int)cmbServicio.SelectedValue;
            string precio = txtPrecio.Text;
            DAL.ServicioXHotelDAL.EliminarServicioXHotel(idH, idS, precio);
            DAL.ServicioXHotelDAL.ActualizarGrillaSerXHot(dataGridView1);
            BtnEliminar.Enabled = false;
        }
    }
}
