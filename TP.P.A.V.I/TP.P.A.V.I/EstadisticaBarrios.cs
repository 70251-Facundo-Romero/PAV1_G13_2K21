﻿using Microsoft.Reporting.WinForms;
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
using TP.P.A.V.I.BLL;

namespace TP.P.A.V.I
{
    public partial class EstadisticaBarrios : Form
    {
        public EstadisticaBarrios()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

       //private void reportviewer1_load(object sender, eventargs e)
      //private void reportViewer1_Load(object sender, EventArgs e)
        //{

        //}
        //{
        //    datatable tabla = new datatable();
        //    tabla = barriobll.obtenerbarriosxciudades();

        //    reportdatasource ds = new reportdatasource("datosciudades", tabla);

        //    reportviewer1.localreport.datasources.clear();
        //    reportviewer1.localreport.datasources.add(ds);
        //    reportviewer1.localreport.refresh();
    //}

     private void EstadisticaBarrios_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
