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
    public partial class FormHabitacionXHotel : Form
    {
        public FormHabitacionXHotel()
        {
            InitializeComponent();
        }

        private void FormHabitacionXHotel_Load(object sender, EventArgs e)
        {
            CargarHotele();
        }

        private void CargarHotele()
        {
            CmbHotel.DataSource = HabitacionesBLL.CargarGrilla();
            CmbHotel.DisplayMember = "Nombre";
            CmbHotel.ValueMember = "Id";
            CmbHotel.SelectedIndex = -1;
        }

        private void CargarHabitacion()
        {
            //CmbHabitacion.DataSource = PersonaBLL.SelectAllCarreras();
            //CmbHabitacion.DisplayMember = "Nombre";
            //CmbHabitacion.ValueMember = "Id";
            //CmbHabitacion.SelectedIndex = -1;

        }
    }
}
