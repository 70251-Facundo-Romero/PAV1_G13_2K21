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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            LimpiarCampos();
            btnActualizarEmpleado.Enabled = false;
            btnEliminar.Enabled = false;
            CargarComboHoteles();
            CargarComboPuestos();
            CargarComboTipoDocumentos();

        }

        private void btnAgregarHotel_Click(object sender, EventArgs e)
        {

        }


        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtId.Text = "";
            txtApellido.Text = "";
            txtNumeroDocumentos.Text = "";
            textFechaIngreso.Text = "";
            cmbPuestosTrabajos.SelectedIndex = -1;
            cmbTipoDocumento.SelectedIndex = -1;
            cmbHotel.SelectedIndex = -1;


            txtNombre.Focus();
        }
        private void CargarGrilla()
        {
            try
            {
                grillaEmpleados.DataSource = EmpleadosBLL.ObtenerListadoEmpleados();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al listar los hoteles");
            }
        }
        private void CargarCampos(Empleado em)
        {
            txtNombre.Text = em.NombreEmpleado;
            txtApellido.Text = em.ApellidoEmpleado;
            txtNumeroDocumentos.Text = em.NumeroDocumento;
            cmbHotel.SelectedValue = em.IdHotel;
            cmbTipoDocumento.SelectedValue = em.TipoDocumento;
            cmbPuestosTrabajos.SelectedValue = em.IdPuesto;
            DateTime fecha = em.FechaIngreso;
            string dia = "";
            string mes = "";
            string año = "";
            dia = fecha.Date.Day.ToString();
            if (dia.Length == 1)
            {
                dia = "0" + dia;
            }
            mes = fecha.Date.Month.ToString();
            if (mes.Length == 1)
            {
                mes = "0" + mes;
            }
            año = fecha.Date.Year.ToString();
            textFechaIngreso.Text = dia + mes + año;
            txtId.Text = em.Id.ToString();

        }
        private void CargarComboPuestos()
        {
            cmbPuestosTrabajos.DataSource = EmpleadosBLL.ObtenerListadoPuestos();
            cmbPuestosTrabajos.DisplayMember = "Nombre";
            cmbPuestosTrabajos.ValueMember = "Id";
            cmbPuestosTrabajos.SelectedIndex = -1;
        }

        private void CargarComboTipoDocumentos()
        {
            cmbTipoDocumento.DataSource = EmpleadosBLL.ObtenerListadoTipoDocumentos();
            cmbTipoDocumento.DisplayMember = "NombreTipoDocumento";
            cmbTipoDocumento.ValueMember = "Id_TipoDocumento";
            cmbTipoDocumento.SelectedIndex = -1;
        }
        private void CargarComboHoteles()
        {
            cmbHotel.DataSource = EmpleadosBLL.ObtenerListadoHoteles();
            cmbHotel.DisplayMember = "Nombre";
            cmbHotel.ValueMember = "Id";
            cmbHotel.SelectedIndex = -1;
        }



        private void grillaEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = e.RowIndex;
                btnActualizarEmpleado.Enabled = true;
                btnEliminar.Enabled = true;
                DataGridViewRow filaSeleccionada = grillaEmpleados.Rows[indice];
                int id = (int)filaSeleccionada.Cells["Id"].Value;
                Empleado em = EmpleadosBLL.ObtenerEmpleado(id);
                LimpiarCampos();
                CargarCampos(em);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione la fila");

            }


        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("")||txtApellido.Text.Equals("") || txtNumeroDocumentos.Text.Equals("") || cmbTipoDocumento.Text.Equals("")|| cmbHotel.Text.Equals("") ||cmbPuestosTrabajos.Text.Equals(""))
            {
                MessageBox.Show("Ingrese los datos que le faltan");
            }
            else
            {
                
                Empleado em = new Empleado();
                em.NombreEmpleado = txtNombre.Text;
                em.ApellidoEmpleado = txtApellido.Text;
                em.TipoDocumento = (int)cmbTipoDocumento.SelectedValue;
                em.NumeroDocumento = txtNumeroDocumentos.Text;
                em.IdHotel = (int)cmbHotel.SelectedValue;
                em.IdPuesto = (int)cmbPuestosTrabajos.SelectedValue;
                em.FechaIngreso = DateTime.Parse(textFechaIngreso.Text);
                bool resultado = EmpleadosBLL.AgregarEmpleadoABD(em);

                if (resultado)
                {
                    MessageBox.Show("Empleado agregado con exito!");
                    LimpiarCampos();
                    CargarGrilla();
                    CargarComboHoteles();
                    CargarComboPuestos();
                    CargarComboTipoDocumentos();
                }
                else
                {
                    MessageBox.Show("Hubo un error al agregar el Empleado");
                }

            }
        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            Empleado em = new Empleado();
            em.Id = int.Parse(txtId.Text);
            em.TipoDocumento= (int)cmbTipoDocumento.SelectedValue;
            em.NumeroDocumento = txtNumeroDocumentos.Text;
            em.ApellidoEmpleado = txtApellido.Text;
            em.NombreEmpleado = txtNombre.Text;
            em.FechaIngreso = DateTime.Parse(textFechaIngreso.Text);
            em.IdHotel = (int)cmbHotel.SelectedValue;
            em.IdPuesto = (int) cmbPuestosTrabajos.SelectedValue;

            bool resultado = EmpleadosBLL.ActualizarEmpleadoABD(em);

            if (resultado)
            {
                MessageBox.Show("Empleado actualizado con exito!");
                LimpiarCampos();
                CargarGrilla();
                CargarComboPuestos();
                CargarComboHoteles();
                CargarComboTipoDocumentos();
            }
            else
            {
               MessageBox.Show("Hubo un error al actualizar el Empleado");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Empleado em = new Empleado();
            em.Id = int.Parse(txtId.Text);
            em.TipoDocumento = (int)cmbTipoDocumento.SelectedValue;
            em.NumeroDocumento = txtNumeroDocumentos.Text;
            em.ApellidoEmpleado = txtApellido.Text;
            em.NombreEmpleado = txtNombre.Text;
            em.FechaIngreso = DateTime.Parse(textFechaIngreso.Text);
            em.IdHotel = (int)cmbHotel.SelectedValue;
            em.IdPuesto = (int)cmbPuestosTrabajos.SelectedValue;
            bool resultado = EmpleadosBLL.BorrarEmpleadoABD(em);


            if (resultado)
            {
                MessageBox.Show("Empleado eliminado con exito!");
                LimpiarCampos();
                CargarGrilla();
                CargarComboPuestos();
                CargarComboHoteles();
                CargarComboTipoDocumentos();
            }
            else
            {
                MessageBox.Show("Hubo un error al borrar el pais");
            }

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnListadoEmpleados_Click(object sender, EventArgs e)
        {
            ListadoEmpleados ventana = new ListadoEmpleados();
            ventana.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EstadisticaEmpleados ventana = new EstadisticaEmpleados();
            ventana.ShowDialog();
        }
    }


}
