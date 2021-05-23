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
    public partial class Gestionar_Instalaciones : Form
    {
        public Gestionar_Instalaciones()
        {
            InitializeComponent();
        }

        private void Gestionar_Instalaciones_Load(object sender, EventArgs e)
        {
            OptionsCb();
            limpiarInpunts();
            CargarGrilla();
        }
        private Instalaciones ObtenerDatosInstalaciones()
        {
            Instalaciones instalaciones = new Instalaciones();
            if (!str_Id.Text.Equals(""))
            {
                instalaciones.id = int.Parse(str_Id.Text);
            }
            instalaciones.Nombre = Str_Nombre_inst.Text;
            instalaciones.Descripcion = Str_Descripcion_Ints.Text;
            return instalaciones;

        }
        private void EnviarInstalaciones_Click(object sender, EventArgs e)
        {
            Str_Nombre_inst.Focus();
            Instalaciones Instalacion = ObtenerDatosInstalaciones();

            if (Instalacion.CamposNOclear())
            {
                if (Cb_Options_inst.Text == "Agregar")
                {

                    if (InstalacionesBLL.Validar_Instalacion(Instalacion.Nombre, Instalacion.Descripcion))
                    {
                        MessageBox.Show("Esta Instalacion ya esta cargada");
                    }
                    else
                    {
                        if (InstalacionesBLL.InsertInstalaciones(Instalacion))
                        {
                            MessageBox.Show("Se Agrego la Instalacion");
                            limpiarInpunts();
                            CargarGrilla();
                            Str_Nombre_inst.Focus();

                        }
                        else
                        {
                            MessageBox.Show("Error No se agrego la Instalacion");
                            limpiarInpunts();
                        }
                    }
                }

                if (Cb_Options_inst.Text == "Eliminar")
                {

                    if (InstalacionesBLL.Validar_Instalacion(Instalacion.Nombre, Instalacion.Descripcion))
                    {
                        if (InstalacionesBLL.Delete_Instalacion(Instalacion))
                        {
                            MessageBox.Show("Se elimino la Instalacion");
                            limpiarInpunts();
                            CargarGrilla();
                            Str_Nombre_inst.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar Instalacion");
                        }
                    }
                }
                if (Cb_Options_inst.Text == "Modificar")
                {
                    if (InstalacionesBLL.ActualizarInstalaciones(Instalacion))
                    {
                        MessageBox.Show("Su Instalacion se ha actualizado");
                        limpiarInpunts();
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Error:Su Instalacion no se ha actualizado");

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
            Cb_Options_inst.Items.Add("Agregar");
            Cb_Options_inst.Items.Add("Eliminar");
            if (Cb_Options_inst.Items.Count.Equals(3))
            {
                Cb_Options_inst.Items.Remove("Modificar");
            }
        }

        private void limpiarInpunts()
        {

            Str_Nombre_inst.Text = "";
            Str_Descripcion_Ints.Text = "";
            Cb_Options_inst.Items.Remove("Modificar");

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            limpiarInpunts();
        }

        private void CargarGrilla()
        {
            Viewer.DataSource = InstalacionesBLL.CargarGrilla();
        }


        private void cargarInpunt(Instalaciones instalaciones)

        {
            str_Id.Text = instalaciones.id.ToString();
            Str_Nombre_inst.Text = instalaciones.Nombre;
            Str_Descripcion_Ints.Text = instalaciones.Descripcion;

        }
        private Instalaciones ObtenerInstalacion(string ID)
        {
            return InstalacionesBLL.Obtenerinstalaciones(ID);
        }

        private void GestionarInstalaciones_Enter(object sender, EventArgs e)
        {

        }

        private void Viewer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow pointer = Viewer.Rows[index];
            string id = pointer.Cells["Id"].Value.ToString();
            Instalaciones hab = ObtenerInstalacion(id);
            limpiarInpunts();

            Cb_Options_inst.Items.Add("Modificar");
            cargarInpunt(hab);
        }
    }
    }
