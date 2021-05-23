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
    public partial class Gestionar_Habitaciones : Form
    {
        public Gestionar_Habitaciones()
        {
            InitializeComponent();
        }

        private void Gestionar_Habitaciones_Load(object sender, EventArgs e)
        {
            OptionsCb();
            limpiarInpunts();
            CargarGrilla();
        }
        private Habitaciones ObtenerDatosHabitacion()
        {
            Habitaciones habitaciones = new Habitaciones();
            if (!str_Id.Text.Equals(""))
            {
                habitaciones.id = int.Parse(str_Id.Text);
            }
            habitaciones.Nombre = Str_Nombre_hab.Text;
            habitaciones.Descripcion = Str_Descripcion_Hab.Text;
            return habitaciones;
            
        }
        private void EnviarHabitaciones_Click(object sender, EventArgs e)
        {
            Str_Nombre_hab.Focus();
            Habitaciones habitacion = ObtenerDatosHabitacion();

            if (habitacion.CamposNOclear())
            {
                if (Cb_Options_hab.Text == "Agregar")
                {
                   
                    if (HabitacionesBLL.Validar_Habitacion(habitacion.Nombre, habitacion.Descripcion))
                    {
                        MessageBox.Show("Esta habitacion ya esta cargada");
                    }
                    else
                    {
                        if (HabitacionesBLL.InsertHabitaciones(habitacion))
                        {
                            MessageBox.Show("Se Agrego la habitacion");
                            limpiarInpunts();
                            CargarGrilla();
                            Str_Nombre_hab.Focus();

                        }
                        else
                        {
                            MessageBox.Show("Error No se agrego la habitacion");
                            limpiarInpunts();
                        }
                    }
                }

                if (Cb_Options_hab.Text == "Eliminar")
                {
                
                    if (HabitacionesBLL.Validar_Habitacion(habitacion.Nombre, habitacion.Descripcion))
                    {
                        if(HabitacionesBLL.Delete_Habitacion(habitacion))
                        {
                            MessageBox.Show("Se elimino la habitacion");
                            limpiarInpunts();
                            CargarGrilla();
                            Str_Nombre_hab.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar habitacion");
                        }
                    }
                }
                if (Cb_Options_hab.Text == "Modificar")
                {
                    if (HabitacionesBLL.ActualizarHabitaciones(habitacion))
                    {
                        MessageBox.Show("Su Habitacion se ha actualizado");
                        limpiarInpunts();
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Error:Su Habitacion no se ha actualizado");

                    }
                }
            }
            else
            {
                MessageBox.Show("Ingregar Nombre de habitación");
            }
        }
        private void OptionsCb()
        {
            Cb_Options_hab.Items.Add("Agregar");
            Cb_Options_hab.Items.Add("Eliminar");
            if (Cb_Options_hab.Items.Count.Equals(3))
            {
                Cb_Options_hab.Items.Remove("Modificar");
            }
        }

        private void  limpiarInpunts()
        {
        
            Str_Nombre_hab.Text = "";
            Str_Descripcion_Hab.Text = "";
            Cb_Options_hab.Items.Remove("Modificar");

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            limpiarInpunts();
        }

        private void CargarGrilla()
        {
            Viewer.DataSource = HabitacionesBLL.CargarGrilla();
        }

        

  
        private void cargarInpunt(Habitaciones habitaciones)

        {
            str_Id.Text = habitaciones.id.ToString();
            Str_Nombre_hab.Text = habitaciones.Nombre;
            Str_Descripcion_Hab.Text = habitaciones.Descripcion;

        }
        private Habitaciones ObtenerHabitacion(string ID )
        {
            return HabitacionesBLL.Obtenerhabitaciones(ID);
        }

        private void GestionarHabitaciones_Enter(object sender, EventArgs e)
        {

        }

        private void Viewer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow pointer = Viewer.Rows[index];
            string id = pointer.Cells["Id"].Value.ToString();
            Habitaciones hab = ObtenerHabitacion(id);
            limpiarInpunts();

            Cb_Options_hab.Items.Add("Modificar");
            cargarInpunt(hab);
        }
    }
}
