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
    public partial class Servicios : Form
    {
        public Servicios()
        {
            InitializeComponent();
        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnActualizarServ.Enabled = false;
            btnEliminarServ.Enabled = false;
            CargarGrilla();
        }
        private void CargarGrilla()
        {
            try
            {
                grillaServicios.DataSource = ServiciosBLL.ObtenerListaServicios();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al listar los Servicios");

            }
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtNomServ.Text = "";
            txtNomServ.Focus();
        }

        private void CargarCampos(Servicio ser)
        {
            txtNomServ.Text = ser.NombreServicio;
            txtId.Text = ser.IdServicio.ToString();
        }

        private void btnLimpiarCampos_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnAgregarPdt_Click(object sender, EventArgs e)
        {
            if (txtNomServ.Text.Equals(""))
            {
                MessageBox.Show("Ingrese Nombre de servicio");
            }
            else
            {
                Servicio ser = new Servicio();
                ser.NombreServicio = txtNomServ.Text;
                

                bool res = ServiciosBLL.AgregarServicioABD(ser);

                if (res)
                {
                    MessageBox.Show("Su Servicio se ha cargado correctamente!");
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("No se ha podido Cargar Servicio. Intente nuevamente");
                }
            }
        }

        private void btnActualizarServ_Click(object sender, EventArgs e)
        {
            Servicio ser = new Servicio();
            
            ser.NombreServicio = txtNomServ.Text;
            ser.IdServicio = int.Parse(txtId.Text);
         


            bool res = ServiciosBLL.ActualizarServicioABD(ser);

            if (res)
            {
                MessageBox.Show("Servicio Actualizado!");
                LimpiarCampos();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar Servicio");
            }
        }

        private void btnEliminarServ_Click(object sender, EventArgs e)
        {
            Servicio ser = new Servicio();

            ser.NombreServicio = txtNomServ.Text;
            ser.IdServicio = int.Parse(txtId.Text);

            bool res = ServiciosBLL.EliminarServicioABD(ser);

            if (res)
            {
                MessageBox.Show("Servicio Eliminado!");
                LimpiarCampos();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("No se pudo Eliminar Servicio");
            }
        }

        private void grillaServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = e.RowIndex;
                btnActualizarServ.Enabled = true;
                btnEliminarServ.Enabled = true;
                DataGridViewRow filaSeleccionada = grillaServicios.Rows[indice];
                int id = (int)filaSeleccionada.Cells["Id"].Value;
                Servicio ser = ServiciosBLL.ObtenerServicio(id);
                LimpiarCampos();
                CargarCampos(ser);
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione el campo correspodiente");
            }
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            ReporteServicios ventana = new ReporteServicios();
            ventana.ShowDialog();
            
        }
    }
}
