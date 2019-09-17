﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Restaurante
{
    public partial class frm_Inicial : Form
    {

        /// <summary>
        ///  Ayuda que pueda mover el form
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void pnl_Principal_BarraNavegacion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        Mensajes mensajes = new Mensajes();
        
        public frm_Inicial()
        {
            InitializeComponent();

        }


        /////////////////////////////////////-----  PRINCIPAL
        private void btn_Principal_Saludar_Click(object sender, EventArgs e)
        {
            mensajes.bienvenido();
        }


        




        /////////////////////////////////////-----  INVENTARIO



       
    }
}
