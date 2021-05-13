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
using System.Runtime.InteropServices;

namespace TP.P.A.V.I
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtUserName.Focus();
            if (true)
            {
                MessageBox.Show("Hello World");
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (UsuarioBLL.ValiadarLogin(TxtUserName.Text,TxtPassword.Text))
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error al ingresar");
            }
            
        }

        //Cierra el cliente y la app
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Maximiza el cliente
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            MaximizeWindow();
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        //Devuelve el cliente al tamaño inicial
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1000, 500);
            Location = new Point(180, 115);
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        //Minimiza el cliente
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Este bloque de codigo permite arrastrar el cliente por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Metodo para maximizar el ciente sin tapar la barra de tareas
        private void MaximizeWindow()
        {
            var rectangle = Screen.FromControl(this).Bounds;
            this.FormBorderStyle = FormBorderStyle.None;
            Size = new Size(rectangle.Width, rectangle.Height);
            Location = new Point(0, 0);
            Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new Size(workingRectangle.Width, workingRectangle.Height);
        }
    }
}
