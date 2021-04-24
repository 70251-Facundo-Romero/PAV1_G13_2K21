using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP.P.A.V.I
{
    public partial class Hoteles : Form
    {
        public Hoteles()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnHoteles_Click(object sender, EventArgs e)
        {
            BtmBarrios.Visible = false;
            BtmCiudades.Visible = false;
            BtmHabitaciones.Visible = false;
            BtmHabitacionesXHoteles.Visible = true;
            BtmHoteles.Visible = true;
            BtmInstalacionesXHoteles.Visible = true;
            BtmPaises.Visible = false;
            BtmServiciosXHoteles.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BtmBarrios.Visible = false;
            BtmCiudades.Visible = false;
            BtmHabitaciones.Visible = true;
            BtmHabitacionesXHoteles.Visible = false;
            BtmHoteles.Visible = false;
            BtmInstalacionesXHoteles.Visible = false;
            BtmPaises.Visible = false;
            BtmServiciosXHoteles.Visible = false;
        }

        private void BtnUbicaciones_Click(object sender, EventArgs e)
        {
            BtmBarrios.Visible = true;
            BtmCiudades.Visible = true;
            BtmHabitaciones.Visible = false;
            BtmHabitacionesXHoteles.Visible = false;
            BtmHoteles.Visible = false;
            BtmInstalacionesXHoteles.Visible = false;
            BtmPaises.Visible = true;
            BtmServiciosXHoteles.Visible = false;
        }
    }
}
