using System;
using System.Windows.Forms;
using TP.P.A.V.I.BLL;
using TP.P.A.V.I.Entities;

namespace TP.P.A.V.I
{
    public partial class TipoDocumentoABM : Form
    {
        public TipoDocumentoABM()
        {
            InitializeComponent();
        }

        private void TipoDocumentoABM_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("test");
            LimpiarCampos();

            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;

            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                grillaTipoDoc.DataSource = TipoDocumentoBLL.GetListadoTipoDoc();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error al listar los tipos de documentos disponibles" + e.Message);
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
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un tipo");
            }
            else
            {
                TipoDocumento td = new TipoDocumento();
                td.NombreTipoDocumento = txtNombre.Text;
                bool resultado = TipoDocumentoBLL.InsertTipoDoc(td);
                
                if (resultado)
                {
                    MessageBox.Show("Tipo de Documento insertado con éxito!");
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Hubo un error al agregar el Tipo de Documento");
                }
            }
        }

        private void CargarCampos(TipoDocumento model)
        {
            txtNombre.Text = model.NombreTipoDocumento;
            txtId.Text = model.Id.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            TipoDocumento td = new TipoDocumento();
            td.NombreTipoDocumento = txtNombre.Text;
            td.Id = int.Parse(txtId.Text);
            bool resultado = TipoDocumentoBLL.ActualizarTipo(td);

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
            TipoDocumento td = new TipoDocumento();
            td.NombreTipoDocumento = txtNombre.Text;
            td.Id = int.Parse(txtId.Text);
            bool resultado = TipoDocumentoBLL.BorrarTipoDoc(td);

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

        private void grillaTipoDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            btnActualizar.Enabled = true;
            btnBorrar.Enabled = true;

            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grillaTipoDoc.Rows[indice];
            int id = (int)filaSeleccionada.Cells["Id"].Value;
            MessageBox.Show("" + id);
            TipoDocumento td = TipoDocumentoBLL.GetById(id);
            LimpiarCampos();
            CargarCampos(td);
            }
        }
    }

