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

namespace TP.P.A.V.I
{
    public partial class AltaTarjeta : Form
    {
        public AltaTarjeta()
        {
            InitializeComponent();
            DAL.TarjetaDAL.ActualizarGrillaTarjeta(GrillaTarjeta);
            BtnModificarTarjeta.Enabled = false;
            btnEliminarTarjeta.Enabled = false;
        }

        private void panelFormulariosHijos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtid.Text = "";
            btnEliminarTarjeta.Enabled = false;
            BtnModificarTarjeta.Enabled = false;
        }

        private void BtnAgregarTarjeta_Click(object sender, EventArgs e)
        {
            string nombreTarjeta = txtNombre.Text;
            DAL.TarjetaDAL.AgregarTarjeta(nombreTarjeta);
            DAL.TarjetaDAL.ActualizarGrillaTarjeta(GrillaTarjeta);
        }

        private void BtnModificarTarjeta_Click(object sender, EventArgs e)
        {
            string nombretarjeta = txtNombre.Text;
            int id = int.Parse(txtid.Text);
            DAL.TarjetaDAL.ModificarTarjeta(nombretarjeta, id);
            DAL.TarjetaDAL.ActualizarGrillaTarjeta(GrillaTarjeta);
        }

        private void GrillaTarjeta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnModificarTarjeta.Enabled = true;
            btnEliminarTarjeta.Enabled = true;
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = GrillaTarjeta.Rows[indice];
            int Id = int.Parse(filaSeleccionada.Cells["Id_Tarjeta"].Value.ToString());
            (int, string) tupla = DAL.TarjetaDAL.ObtenerTarjeta(Id);
            txtNombre.Text = "";
            txtid.Text = "";
            CargarCampo(tupla);

            
        }

        private void CargarCampo((int, string)tupla)
        {
            txtid.Text = tupla.Item1.ToString();
            txtNombre.Text = tupla.Item2;
        }

        private void btnEliminarTarjeta_Click(object sender, EventArgs e)
        {
            string nombretarjeta = txtNombre.Text;
            int id = int.Parse(txtid.Text);
            DAL.TarjetaDAL.EliminarTarjeta(nombretarjeta, id);
            DAL.TarjetaDAL.ActualizarGrillaTarjeta(GrillaTarjeta);
        }
    }
    
}
