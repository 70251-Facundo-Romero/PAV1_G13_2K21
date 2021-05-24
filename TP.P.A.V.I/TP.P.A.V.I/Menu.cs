using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP.P.A.V.I
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            subMenuHoteles.Visible = false;
            subMenuHuespedes.Visible = false;
        }

        private void hideSubMenu()
        {
            if (subMenuHoteles.Visible == true) subMenuHoteles.Visible = false;
            if (subMenuHuespedes.Visible == true) subMenuHuespedes.Visible = false;
            if (subMenuUbicaciones.Visible == true) subMenuUbicaciones.Visible = false;
            if (subMenuServIns.Visible == true) subMenuServIns.Visible = false;
            if (subMenuFacturacion.Visible == true) subMenuFacturacion.Visible = false;
            if (subMenuEmpleados.Visible == true) subMenuEmpleados.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1000, 500);
            Location = new Point(180, 115);
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            MaximizeWindow();
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void MaximizeWindow()
        {
            var rectangle = Screen.FromControl(this).Bounds;
            this.FormBorderStyle = FormBorderStyle.None;
            Size = new Size(rectangle.Width, rectangle.Height);
            Location = new Point(0, 0);
            Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new Size(workingRectangle.Width, workingRectangle.Height);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuHoteles);
        }

        private void btnHuespedes_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuHuespedes);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuEmpleados);
        }

        private void btnUbicaciones_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuUbicaciones);
        }

        private void btnServIns_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuServIns);
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuFacturacion);
        }

        private Form activeForm = null;
        private void openChildForm(Form formHijo)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelFormulariosHijos.Controls.Add(formHijo);
            panelFormulariosHijos.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void btnGestionHoteles_Click(object sender, EventArgs e)
        {
            Hoteles ventana = new Hoteles();
            openChildForm(ventana);
            hideSubMenu();
        }

        private void btnGestionHabitaciones_Click(object sender, EventArgs e)
        {
            AltaServicioXHotel ventana = new AltaServicioXHotel();
            openChildForm(ventana);
            hideSubMenu();
        }

        private void btnGestionUbicaciones_Click(object sender, EventArgs e)
        {
            InstalacionesXhotel ventana = new InstalacionesXhotel();
            openChildForm(ventana);
            hideSubMenu();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormHabitacionXHotel ventana = new FormHabitacionXHotel();
            openChildForm(ventana);
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gestionar_Habitaciones ventana = new Gestionar_Habitaciones();
            openChildForm(ventana);
            hideSubMenu();
        }

        private void btnAlojXHuesped_Click(object sender, EventArgs e)
        {
            AlojamientoXHuesped ventana = new AlojamientoXHuesped();
            openChildForm(ventana);
            hideSubMenu();
        }

        private void btnInsXHuesped_Click(object sender, EventArgs e)
        {
            Instalacion_por_huesped ventana = new Instalacion_por_huesped();
            openChildForm(ventana);
            hideSubMenu();
        }

        private void btnTarjetas_Click(object sender, EventArgs e)
        {
            AltaTarjeta ventana = new AltaTarjeta();
            openChildForm(ventana);
            hideSubMenu();
        }

        private void btnGestEmpleados_Click(object sender, EventArgs e)
        {
            Empleados ventana = new Empleados();
            openChildForm(ventana);
            hideSubMenu();
        }

        private void btnPuestosDeTrabajo_Click(object sender, EventArgs e)
        {
            PuestosDeTrabajoABM ventana = new PuestosDeTrabajoABM();
            openChildForm(ventana);
            hideSubMenu();
        }

        private void btnPaises_Click(object sender, EventArgs e)
        {
            PaisABM ventana = new PaisABM();
            openChildForm(ventana);
            hideSubMenu();
        }

        private void btnCiudades_Click(object sender, EventArgs e)
        {
            CiudadABM ventana = new CiudadABM();
            openChildForm(ventana);
            hideSubMenu();
        }

        private void btnBarrios_Click(object sender, EventArgs e)
        {
            BarrioABM ventana = new BarrioABM();
            openChildForm(ventana);
            hideSubMenu();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            Servicios ventana = new Servicios();
            openChildForm(ventana);
            hideSubMenu();
        }

        private void btnInstalaciones_Click(object sender, EventArgs e)
        {
            Gestionar_Instalaciones ventana = new Gestionar_Instalaciones();
            openChildForm(ventana);
            hideSubMenu();
        }

        private void btnGestFacturacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidad corresponde a otra entrega");
        }

        private void btnDetalleFactura_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidad corresponde a otra entrega");
        }

        private void btnGestionHuespedes_Click(object sender, EventArgs e)
        {
            Huespedes ventana = new Huespedes();
            openChildForm(ventana);
            hideSubMenu();
        }
    }   
}
