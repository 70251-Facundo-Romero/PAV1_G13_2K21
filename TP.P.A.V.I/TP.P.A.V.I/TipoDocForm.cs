using System;
using System.Drawing;
using System.Windows.Forms;
using TP.P.A.V.I.DAL;

namespace TP.P.A.V.I
{
    public partial class TipoDocForm : Form
    {
        public TipoDocForm()
        {
            InitializeComponent();
        }

        private void LoadGrid()
        {
            try
            {
                grdTipoDoc.DataSource = TipoDocumentoDAL.GetListadoTipoDoc();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //Devuelve el cliente al tamaño inicial
                this.Size = new Size(1000, 500);
                Location = new Point(180, 115);
                btnRestaurar.Visible = false;
                btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TipoDocForm_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show("test");
            LoadGrid();
        }
    }
}
