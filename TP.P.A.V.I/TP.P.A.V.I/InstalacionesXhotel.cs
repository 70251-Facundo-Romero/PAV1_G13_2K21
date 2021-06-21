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

namespace TP.P.A.V.I
{
    public partial class InstalacionesXhotel : Form
    {
        int IdIxH;
        public InstalacionesXhotel()
        {
            InitializeComponent();
        }

        private void InstalacionesXhotel_Load(object sender, EventArgs e)
        {
            CargarHotele();
            CargarInstalacion();
            CargarGrilla();
        }

        private void CargarHotele()
        {
            CmbHotel.DisplayMember = "Nombre";
            CmbHotel.ValueMember = "Id";
            CmbHotel.SelectedIndex = -1;
            CmbHotel.DataSource = HotelBLL.ObtenerListadoHoteles();

        }
        private void CargarInstalacion()
        {
            CmbInstalacion.DataSource = InstalacionesBLL.CargarGrilla();
            CmbInstalacion.DisplayMember = "Nombre";
            CmbInstalacion.ValueMember = "Id";
            CmbInstalacion.SelectedIndex = -1;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CmbHotel.Text))
            {
                errorHotel.SetError(CmbHotel, "Debe seleccionar un hotel");
                return;
            }
            else
                errorHotel.Clear();

            if (string.IsNullOrEmpty(CmbInstalacion.Text))
            {
                errorInstalacion.SetError(CmbInstalacion, "Debe seleccionar una instalación");
                return;
            }
            else
                errorInstalacion.Clear();

            if (InstalacionXHotelBLL.VerificarExisteCombinacion((int)CmbHotel.SelectedValue, (int)CmbInstalacion.SelectedValue))
            {
                MessageBox.Show("Esa instalacion ya se encuentra en ese hotel, elija otra combinacion.");
                return;
            }

            string message = "Desea guardar?";
            string title = "Guardar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                try
                {
                    Entities.InstalacionXHotel IxH = new Entities.InstalacionXHotel();
                    IxH.IdHotel = int.Parse(CmbHotel.SelectedValue.ToString());
                    IxH.IdInstalacion = int.Parse(CmbInstalacion.SelectedValue.ToString());
                    InstalacionXHotelBLL.SaveInstalacionXHotel(IxH);
                    MessageBox.Show("Se guardo con éxito!");
                    DgvInstalacionXHotel.DataSource = CargarGrilla();
                    LimpiarCampos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error!");
                    return;
                }
            }
        }
        private DataTable CargarGrilla()
        {
            return InstalacionXHotelBLL.cargarGrilla(int.Parse(CmbHotel.SelectedValue.ToString()));
        }

        private void CmbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbHotel.Text != "" && CmbHotel.Text != "System.Data.DataRowView")
            {
                try
                {
                    DgvInstalacionXHotel.DataSource = CargarGrilla();
                }
                catch (Exception ex)
                {
                    return;
                }
            }
        }

        private void DgvInstalacionXHotel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaselec = DgvInstalacionXHotel.Rows[e.RowIndex];
            IdIxH = int.Parse(filaselec.Cells["IdInstalacionXHotel"].Value.ToString());
            Entities.InstalacionXHotel InXHo = InstalacionXHotelBLL.SelectById(int.Parse(filaselec.Cells["IdInstalacionXHotel"].Value.ToString()));
            CmbInstalacion.SelectedValue = InXHo.IdInstalacion;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (IdIxH == 0)
            {
                MessageBox.Show("Debe seleccionar una instalación en la grilla", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string message = "Desea Eliminar?";
            string title = "Eliminar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                try
                {
                    InstalacionXHotelBLL.EliminarInstalacionXHotel(IdIxH);
                    MessageBox.Show("¡Se elimino con éxito!");
                    DgvInstalacionXHotel.DataSource = CargarGrilla();
                    LimpiarCampos();
                    IdIxH = 0;
                }
                catch (Exception)
                {
                    MessageBox.Show("¡Ocurrió un error!");
                    return;
                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (IdIxH == 0)
            {
                MessageBox.Show("Debe seleccionar una instalación en la grilla", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(CmbHotel.Text))
            {
                errorHotel.SetError(CmbHotel, "Debe seleccionar un hotel");
                return;
            }
            else
                errorHotel.Clear();

            if (string.IsNullOrEmpty(CmbInstalacion.Text))
            {
                errorInstalacion.SetError(CmbInstalacion, "Debe seleccionar una instalación");
                return;
            }
            else
                errorInstalacion.Clear();

            if (InstalacionXHotelBLL.VerificarExisteCombinacion((int)CmbHotel.SelectedValue, (int)CmbInstalacion.SelectedValue))
            {
                MessageBox.Show("Esa instalacion ya se encuentra en ese hotel, elija otra combinacion.");
                return;
            }

            string message = "Desea modificar?";
            string title = "Modificar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                try
                {
                    Entities.InstalacionXHotel InxHo = new Entities.InstalacionXHotel();
                    InxHo.IdInstalacionXHotel = IdIxH;
                    InxHo.IdHotel = int.Parse(CmbHotel.SelectedValue.ToString());
                    InxHo.IdInstalacion = int.Parse(CmbInstalacion.SelectedValue.ToString());
                    InstalacionXHotelBLL.ModificarInstalacionXHotel(InxHo);
                    MessageBox.Show("¡Se modificó con éxito!");
                    DgvInstalacionXHotel.DataSource = CargarGrilla();
                    LimpiarCampos();
                    IdIxH = 0;
                }
                catch (Exception)
                {
                    MessageBox.Show("¡Ocurrió un error!");
                    return;
                }
            }
        }

        private void LimpiarCampos()
        {
            CmbInstalacion.SelectedIndex = -1;
        }

        private void BtnListadoInstalacionXHotel_Click(object sender, EventArgs e)
        {
            RepInstalacionXHotel ventana = new RepInstalacionXHotel();
            ventana.Show();
        }
    }
}
