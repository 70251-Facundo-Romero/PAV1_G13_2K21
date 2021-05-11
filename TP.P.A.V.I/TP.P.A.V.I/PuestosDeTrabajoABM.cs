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
    public partial class PuestosDeTrabajoABM : Form
    {
        public PuestosDeTrabajoABM()
        {
            InitializeComponent();
        }

        private void PuestosDeTrabajoABM_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnActualizarPdt.Enabled = false;
            btnEliminarPdt.Enabled = false;
            CargarGrilla();
            
        }

        private void CargarGrilla()
        {
            try
            {
                grillaPuestosTrabajo.DataSource = PuestoDeTrabajoBLL.ObtenerListaPuesto();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al listar los puestos de trabajo");
            }

        }
        private void LimpiarCampos()
        {
            txtDescripcionPdt.Text = "";
            txtNomPuesto.Text = "";
            txtMatricula.Text = "";
            txtNomPuesto.Focus();
        }
        private void CargarCampos(PuestoTrabajo pdt)
        {
            txtNomPuesto.Text = pdt.NombrePdT;
            txtDescripcionPdt.Text = pdt.DescPdT;
            txtMatricula.Text = pdt.MatriculaPdT.ToString();
            txtId.Text = pdt.IdPdT.ToString();
        }


        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnAgregarPdt_Click(object sender, EventArgs e)
        {
            if (txtDescripcionPdt.Text.Equals("") || txtNomPuesto.Text.Equals(""))
            {
                MessageBox.Show("Ingrese Puesto de Trabajo y Descripción");
            }
            else
            {
                PuestoTrabajo pdt = new PuestoTrabajo();
                pdt.DescPdT = txtDescripcionPdt.Text;
                pdt.NombrePdT = txtNomPuesto.Text;
                pdt.MatriculaPdT = int.Parse(txtMatricula.Text);
                
                bool res = PuestoDeTrabajoBLL.AgregarPuestoABD(pdt);

                if (res)
                {
                    MessageBox.Show("Su puesto de trabajo se ha cargado correctamente!");
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("No se ha podido Cargar puesto de trabajo. Intente nuevamente");
                }
            }
        }

        private void grillaPuestosTrabajo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = e.RowIndex;
                btnActualizarPdt.Enabled = true;
                btnEliminarPdt.Enabled = true;
                DataGridViewRow filaSeleccionada = grillaPuestosTrabajo.Rows[indice];
                int id = (int)filaSeleccionada.Cells["Id"].Value;
                PuestoTrabajo pdt = PuestoDeTrabajoBLL.ObtenerPuesto(id);
                LimpiarCampos();
                CargarCampos(pdt);
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione el campo correspondiente");
            }
            
        }

        private void btnActualizarPdt_Click(object sender, EventArgs e)
        {
            PuestoTrabajo pdt = new PuestoTrabajo();
            pdt.DescPdT = txtDescripcionPdt.Text;
            pdt.NombrePdT = txtNomPuesto.Text;
            pdt.IdPdT = int.Parse(txtId.Text);
            pdt.MatriculaPdT = int.Parse(txtMatricula.Text);


            bool res = PuestoDeTrabajoBLL.ActualizarPuestoABD(pdt);

            if (res)
            {
                MessageBox.Show("Puesto de Trabajo Actualizado!");
                LimpiarCampos();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar puesto de trabajo");
            }
        }

        private void btnEliminarPdt_Click(object sender, EventArgs e)
        {
            PuestoTrabajo pdt = new PuestoTrabajo();
            pdt.DescPdT = txtDescripcionPdt.Text;
            pdt.NombrePdT = txtNomPuesto.Text;
            pdt.IdPdT = int.Parse(txtId.Text);
           

            bool res = PuestoDeTrabajoBLL.EliminarPuestoABD(pdt);

            if (res)
            {
                MessageBox.Show("Puesto de Trabajo Eliminado!");
                LimpiarCampos();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("No se pudo Eliminar puesto de trabajo");
            }
        }


    }
}
