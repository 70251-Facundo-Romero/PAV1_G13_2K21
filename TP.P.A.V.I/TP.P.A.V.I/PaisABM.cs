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
    public partial class PaisABM : Form
    {
        public PaisABM()
        {
            InitializeComponent();
        }

        private void PaisABM_Load(object sender, EventArgs e)
        {
            LimpiarCampos();

            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;

            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                grillaPaises.DataSource = PaisBLL.ObtenerListadoPaises();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al listar los paises");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtDesc.Text = "";
            txtId.Text = "";
            txtNombre.Text = "";
            txtNombre.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text.Equals("") || txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un nombre y una descripción");
            }
            else
            {
                Pais p = new Pais();
                p.DescPais = txtDesc.Text;
                p.NombrePais = txtNombre.Text;
                bool resultado = PaisBLL.AgregarPaisABD(p);
                
                if (resultado)
                {
                    MessageBox.Show("Pais agregado con exito!");
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Hubo un error al agregar el pais");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizar.Enabled = true;
            btnBorrar.Enabled = true;
            DataGridViewRow filaSeleccionada = grillaPaises.Rows[indice];
            int id = (int)filaSeleccionada.Cells["Id"].Value;
            Pais p = PaisBLL.ObtenerPais(id);
            LimpiarCampos();
            CargarCampos(p);
        }

        private void CargarCampos(Pais p)
        {
            txtNombre.Text = p.NombrePais;
            txtId.Text = p.IdPais.ToString();
            txtDesc.Text = p.DescPais;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Pais p = new Pais();
            p.DescPais = txtDesc.Text;
            p.NombrePais = txtNombre.Text;
            p.IdPais = int.Parse(txtId.Text);
            bool resultado = PaisBLL.ActualizarPaisABD(p);

            if (resultado)
            {
                MessageBox.Show("Pais actualizado con exito!");
                LimpiarCampos();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Hubo un error al actualizar el pais");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Pais p = new Pais();
            p.DescPais = txtDesc.Text;
            p.NombrePais = txtNombre.Text;
            p.IdPais = int.Parse(txtId.Text);
            bool resultado = PaisBLL.BorrarPaisABD(p);

            if (resultado)
            {
                MessageBox.Show("Pais eliminado con exito!");
                LimpiarCampos();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Hubo un error al borrar el pais");
            }
        }
    }
}
