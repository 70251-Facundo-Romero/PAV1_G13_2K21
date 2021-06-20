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
    public partial class BarrioABM : Form
    {
        public BarrioABM()
        {
            InitializeComponent();
        }

        private void BarrioABM_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;

            CargarComboCiudades();
            CargarGrilla();
        }
        private void CargarCampos(Barrio b)
        {
            txtNombre.Text = b.NombreBarrio;
            txtDesc.Text = b.DescBarrio;
            cmbCiudades.SelectedValue = b.IdCiudadBarrio;
            txtId.Text = b.IdBarrio.ToString();
        }

        private void LimpiarCampos()
        {
            txtDesc.Text = "";
            txtNombre.Text = "";
            txtId.Text = "";
        }

        private void CargarComboCiudades()
        {
            try
            {
                cmbCiudades.DataSource = CiudadBLL.ObtenerListadoCiudades();
                cmbCiudades.DisplayMember = "Nombre";
                cmbCiudades.ValueMember = "Id";
                cmbCiudades.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema al cargar el combo paises");
            }
        }
        private void CargarGrilla()
        {
            grillaBarrios.DataSource = BarrioBLL.ObtenerListadoBarrios();
        }

        private void grillaBarrios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizar.Enabled = true;
            btnBorrar.Enabled = true;
            DataGridViewRow filaSeleccionada = grillaBarrios.Rows[indice];
            int id = (int)filaSeleccionada.Cells["Id"].Value;
            Barrio b = BarrioBLL.ObtenerBarrio(id);
            LimpiarCampos();
            CargarCampos(b);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboCiudades();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text.Equals("") || txtNombre.Text.Equals("") || cmbCiudades.SelectedItem.Equals(null))
            {
                MessageBox.Show("Ingrese un nombre, una descripción y seleccione un pais");
            }
            else
            {
                Barrio b = new Barrio();
                b.DescBarrio = txtDesc.Text;
                b.NombreBarrio = txtNombre.Text;
                b.IdCiudadBarrio = (int)cmbCiudades.SelectedValue;
                try
                {
                    bool resultado = BarrioBLL.AgregarBarrioABD(b);

                    if (resultado)
                    {
                        MessageBox.Show("Barrio agregado con exito!");
                        LimpiarCampos();
                        CargarGrilla();
                        CargarComboCiudades();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al agregar el barrio");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error al agregar el barrio");
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Barrio b = new Barrio();
            b.DescBarrio = txtDesc.Text;
            b.NombreBarrio = txtNombre.Text;
            b.IdBarrio = int.Parse(txtId.Text);
            b.IdCiudadBarrio = (int)cmbCiudades.SelectedValue;
            bool resultado = BarrioBLL.ActualizarBarrioABD(b);

            if (resultado)
            {
                MessageBox.Show("Barrio actualizado con exito!");
                LimpiarCampos();
                CargarGrilla();
                CargarComboCiudades();
            }
            else
            {
                MessageBox.Show("Hubo un error al actualizar el barrio");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Barrio b = new Barrio();
            b.DescBarrio = txtDesc.Text;
            b.NombreBarrio = txtNombre.Text;
            b.IdBarrio = int.Parse(txtId.Text);
            b.IdCiudadBarrio = (int)cmbCiudades.SelectedValue;
            bool resultado = BarrioBLL.BorrarBarrioABD(b);

            if (resultado)
            {
                MessageBox.Show("Barrio eliminado con exito!");
                LimpiarCampos();
                CargarGrilla();
                CargarComboCiudades();
            }
            else
            {
                MessageBox.Show("Hubo un error al borrar el barrio");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportesBarrio ventana = new ReportesBarrio();
            ventana.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EstadisticaBarrios ventana = new EstadisticaBarrios();
            ventana.ShowDialog();
        }
    }
}
