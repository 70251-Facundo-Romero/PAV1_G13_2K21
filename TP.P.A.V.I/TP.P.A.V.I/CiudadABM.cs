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
    public partial class CiudadABM : Form
    {
        public CiudadABM()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboPais();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text.Equals("") || txtNombre.Text.Equals("") || cmbPaises.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un nombre, una descripción y seleccione un pais");
            }
            else
            {
                Ciudad c = new Ciudad();
                c.DescCiudad = txtDesc.Text;
                c.NombreCiudad = txtNombre.Text;
                c.IdPaisCiudad = (int)cmbPaises.SelectedValue;
                try
                {
                    bool resultado = CiudadBLL.AgregarCiudadABD(c);

                    if (resultado)
                    {
                        MessageBox.Show("Ciudad agregada con exito!");
                        LimpiarCampos();
                        CargarGrilla();
                        CargarComboPais();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al agregar la ciudad");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error al agregar la ciudad");
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Ciudad c = new Ciudad();
            c.DescCiudad = txtDesc.Text;
            c.NombreCiudad = txtNombre.Text;
            c.IdCiudad = int.Parse(txtId.Text);
            c.IdPaisCiudad = (int)cmbPaises.SelectedValue;
            bool resultado = CiudadBLL.ActualizarCiudadABD(c);

            if (resultado)
            {
                MessageBox.Show("Ciudad actualizada con exito!");
                LimpiarCampos();
                CargarGrilla();
                CargarComboPais();
            }
            else
            {
                MessageBox.Show("Hubo un error al actualizar la ciudad");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Ciudad c = new Ciudad();
            c.DescCiudad = txtDesc.Text;
            c.NombreCiudad = txtNombre.Text;
            c.IdCiudad = int.Parse(txtId.Text);
            c.IdPaisCiudad = (int)cmbPaises.SelectedValue;
            bool resultado = CiudadBLL.BorrarCiudadABD(c);

            if (resultado)
            {
                MessageBox.Show("Ciudad eliminada con exito!");
                LimpiarCampos();
                CargarGrilla();
                CargarComboPais();
            }
            else
            {
                MessageBox.Show("Hubo un error al borrar la ciudad");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CiudadABM_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;

            CargarComboPais();
            CargarGrilla();
        }

        private void CargarComboPais()
        {
            try
            {
                cmbPaises.DataSource = PaisBLL.ObtenerListadoPaises();
                cmbPaises.DisplayMember = "Nombre";
                cmbPaises.ValueMember = "Id";
                cmbPaises.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema al cargar el combo paises");
            }
        }

        private void CargarGrilla()
        {
            grillaCiudades.DataSource = CiudadBLL.ObtenerListadoCiudades();
        }

        private void LimpiarCampos()
        {
            txtDesc.Text = "";
            txtNombre.Text = "";
            txtId.Text = "";
        }

        private void grillaCiudades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizar.Enabled = true;
            btnBorrar.Enabled = true;
            DataGridViewRow filaSeleccionada = grillaCiudades.Rows[indice];
            int id = (int)filaSeleccionada.Cells["Id"].Value;
            Ciudad c = CiudadBLL.ObtenerCiudad(id);
            LimpiarCampos();
            CargarCampos(c);
        }

        private void CargarCampos(Ciudad c)
        {
            txtNombre.Text = c.NombreCiudad;
            txtDesc.Text = c.DescCiudad;
            cmbPaises.SelectedValue = c.IdPaisCiudad;
            txtId.Text = c.IdCiudad.ToString();
        }
    }
}
