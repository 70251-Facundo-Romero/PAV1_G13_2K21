using System;
using System.Windows.Forms;
using TP.P.A.V.I.BLL;
using TP.P.A.V.I.Entities;

namespace TP.P.A.V.I
{
    public partial class HuespedABM : Form
    {
        public HuespedABM()
        {
            InitializeComponent();
        }

        private void HuespedABM_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("test");
            LimpiarCampos();

            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;

            CargarGrilla();

            LoadComboPais();
            LoadComboTarjeta();
        }

        private void CargarGrilla()
        {
            try
            {
                //MessageBox.Show("probando grilla");
                grillaHuesped.DataSource = HuespedBLL.GetListadoHuespedes();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error al listar los Huéspedes" + e.Message);
            }
        }

        /// <summary>
        /// descomentar linea nro 48 al agregar el modulo 
        /// de gestion de paises
        /// </summary>
        private void LoadComboPais()
        {
            try
            {
                cmbPais.DataSource = PaisBLL.ObtenerListadoPaises();
                cmbPais.DisplayMember = "Nombre";
                cmbPais.ValueMember = "Id";
                cmbPais.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error al listar Países" + e.Message);
            }
           
        }

        /// <summary>
        /// descomentar linea nro 68 al agregar el modulo
        /// de gestion de tarjetas
        /// </summary>
        private void LoadComboTarjeta()
        {
            try
            {
                cmbTarjeta.DataSource = TarjetaBLL.ActualizarGrillaTarjeta();
                cmbTarjeta.DisplayMember = "Nombre";
                cmbTarjeta.ValueMember = "Id_Tarjeta";
                cmbTarjeta.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error al listar Tarjetas" + e.Message);
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
            txtNroTarjeta.Text = "";
            txtNroPasaporte.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtApellido.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un apellido");
            }
            else
            {
                Huesped h = new Huesped();
                h.NroPasaporte = int.Parse(txtNroPasaporte.Text);
                h.Id_Pais = (int)cmbPais.SelectedValue;
                h.Apellido = txtApellido.Text;
                h.Nombre = txtNombre.Text;
                h.NroTarjetaDeCredito = int.Parse(txtNroTarjeta.Text);
                h.Id_Tarjeta = (int)cmbTarjeta.SelectedValue;
                bool resultado = HuespedBLL.InsertHuesped(h);
                
                if (resultado)
                {
                    MessageBox.Show("Huésped insertado con éxito!");
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Hubo un error al agregar Huésped");
                }
            }
        }

        private void CargarCampos(Huesped model)
        {
            txtNroPasaporte.Text = model.NroPasaporte.ToString();
            cmbPais.SelectedValue = model.Id_Pais;
            txtApellido.Text = model.Apellido;
            txtId.Text = model.IdHuesped.ToString();
            txtNombre.Text = model.Nombre;
            txtNroTarjeta.Text = model.NroTarjetaDeCredito.ToString();
            cmbTarjeta.SelectedValue = model.Id_Tarjeta;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Huesped h = new Huesped();

            h.IdHuesped = int.Parse(txtId.Text);
            h.NroPasaporte = int.Parse(txtNroPasaporte.Text);
            h.Id_Pais = (int)cmbPais.SelectedValue;
            h.Apellido = txtApellido.Text;
            h.Nombre = txtNombre.Text;
            h.NroTarjetaDeCredito = int.Parse(txtNroTarjeta.Text);
            h.Id_Tarjeta = (int)cmbTarjeta.SelectedValue;

            bool resultado = HuespedBLL.ActualizarHuesped(h);

            if (resultado)
            {
                MessageBox.Show("El Huésped ha sido actualizado con exito!");
                LimpiarCampos();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Hubo un error al actualizar datos del Huésped");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Huesped h = new Huesped();
            h.IdHuesped = int.Parse(txtId.Text);
            h.NroPasaporte = int.Parse(txtNroPasaporte.Text);
            h.Id_Pais = (int)cmbPais.SelectedValue;
            h.Apellido = txtApellido.Text;
            h.Nombre = txtNombre.Text;
            h.NroTarjetaDeCredito = int.Parse(txtNroTarjeta.Text);
            h.Id_Tarjeta = (int)cmbTarjeta.SelectedValue;

            bool resultado = HuespedBLL.DeleteHuesped(h);

            if (resultado)
            {
                MessageBox.Show("Huésped eliminado con exito!");
                LimpiarCampos();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Hubo un error al dar de baja el Huésped");
            }
        }

        private void grillaHuesped_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            btnBorrar.Enabled = true;

            int index = e.RowIndex;
            DataGridViewRow rowSelected = grillaHuesped.Rows[index];
            int pasaport = (int)rowSelected.Cells["Id"].Value;
            Huesped h = HuespedBLL.GetByPasaport(pasaport);
            LimpiarCampos();
            CargarCampos(h);

        }

        private void btnHxPais_Click(object sender, EventArgs e)
        {
            EstadisticaHxPais ventana = new EstadisticaHxPais();
            ventana.ShowDialog();
        }
    }
    }

