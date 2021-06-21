using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class AltaTarjeta : Form
    {
        public AltaTarjeta()
        {
            InitializeComponent();
            CargarGrilla();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtDescripcion.Text = "";
            txtid.Text = "";
            txtNombre.Text = "";
        }

        private void CargarGrilla()
        {
           GrillaTarjeta.DataSource = TarjetaBLL.ActualizarGrillaTarjeta();
        }

        private void CargarCampos(Tarjeta t)
        {
            txtNombre.Text = t.Nombre;
            txtid.Text = t.Id_Tarjeta.ToString();
            txtDescripcion.Text = t.Descripcion;
        }

        private void GrillaTarjeta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnEliminarTarjeta.Enabled = true;
            BtnModificarTarjeta.Enabled = true;
            DataGridViewRow filaSeleccionada = GrillaTarjeta.Rows[indice];
            int id = (int)filaSeleccionada.Cells["id"].Value;
            Tarjeta t = TarjetaBLL.ObtenerTarjeta(id);
            LimpiarCampos();
            CargarCampos(t);
        }

        private void BtnAgregarTarjeta_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Equals("") || txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Cargue todos los campos");
                return;
            }
            string nom = txtNombre.Text;
            string desc = txtDescripcion.Text;
            try
            {
                TarjetaBLL.AgregarTarjeta(nom, desc);
                LimpiarCampos();
                CargarGrilla();
                MessageBox.Show("Tarjeta agregada con exito.");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar la tarjeta.");
            }
        }

        private void btnEliminarTarjeta_Click(object sender, EventArgs e)
        {
            Tarjeta t = new Tarjeta();
            t.Descripcion = txtDescripcion.Text;
            t.Nombre = txtNombre.Text;
            t.Id_Tarjeta = int.Parse(txtid.Text);
            bool resultado = TarjetaBLL.BorrarTarjeta(t);

            if (resultado)
            {
                LimpiarCampos();
                CargarGrilla();
                MessageBox.Show("Tarjeta eliminada con exito!");

            }
            else
            {
                MessageBox.Show("Hubo un error al eliminar la fila");
            }
        }

        private void BtnModificarTarjeta_Click(object sender, EventArgs e)
        {
            Tarjeta t = new Tarjeta();
            t.Descripcion = txtDescripcion.Text;
            t.Nombre = txtNombre.Text;
            t.Id_Tarjeta = int.Parse(txtid.Text);
            bool resultado = TarjetaBLL.ModificarTarjeta(t);

            if (resultado)
            {
                LimpiarCampos();
                CargarGrilla();
                MessageBox.Show("Tarjeta actualizada con exito!");

            }
            else
            {
                MessageBox.Show("Hubo un error al actualizar la fila");
            }
        }

        private void btnReporteTarjeta_Click(object sender, EventArgs e)
        {
            ReporteTarjetas ventana = new ReporteTarjetas();
            ventana.ShowDialog();
        }

        private void panelFormulariosHijos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
