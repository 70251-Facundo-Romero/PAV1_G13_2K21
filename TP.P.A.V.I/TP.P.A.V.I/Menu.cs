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
<<<<<<< Updated upstream
=======

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

        private void btnTipoDoc_Click(object sender, EventArgs e)
        {
            TipoDocForm form = new TipoDocForm();
            form.Show();
            this.Hide();
        }
>>>>>>> Stashed changes
    }
}
