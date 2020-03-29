﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using System.Diagnostics;

namespace Sistema_Inventario
{
    public partial class FormPrincipal : DevComponents.DotNetBar.Metro.MetroForm
    {
        FormProducto frmProducto;
        FormCategoria frmCategoria;
        LoginBL loginBL;
        int idUsuario;
        String nombreUsuario = "";
        
        public FormPrincipal(int idUsuario)
        {
            InitializeComponent();
            timer1.Enabled = true;
            this.idUsuario = idUsuario;

            loginBL = new LoginBL();
            consultarDatosUsuario(idUsuario);
        }

        //muestro fecha y hora
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = string.Format("{0:hh:mm:ss tt}", DateTime.Now);
        }

        //cierro aplicacion principal al presionar x
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            //valido si no esta abierto el form para solo abrir 1
            if (frmProducto == null)
            {
                frmProducto = new FormProducto();
                frmProducto.FormClosed += new FormClosedEventHandler(frmProducto_FormClosed);
                frmProducto.MdiParent = this;
                frmProducto.Show();
            }
            //si esta activo solo lo muestro
            else
                frmProducto.Activate();
        }

        //metodo para permitir abrir solo una vez form producto
        private void frmProducto_FormClosed(object sender, EventArgs e)
        {
            frmProducto = null;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReportes frmreportes = new FormReportes();
            frmreportes.ShowDialog();
        }

        private void consultarDatosUsuario(int idUsuario)
        {
            nombreUsuario = loginBL.consultarDatosUsuario(this.idUsuario);
            mostrarDatosUsuario(nombreUsuario);
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(loginBL.cerrarSesion(this.idUsuario))
            {
                Application.Exit();
            }
        }

        private void mostrarDatosUsuario(String nombreUsuario)
        {
            lblNombreUsuario.Text = nombreUsuario;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmProducto == null)
            {
                frmProducto = new FormProducto();
                frmProducto.FormClosed += new FormClosedEventHandler(frmProducto_FormClosed);
                frmProducto.MdiParent = this;
                frmProducto.Show();
            }
            else
                frmProducto.Activate();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //valido si no esta abierto el form para solo abrir 1
            if (frmCategoria == null)
            {
                frmCategoria = new FormCategoria();
                frmCategoria.FormClosed += new FormClosedEventHandler(frmCategoria_FormClosed);
                frmCategoria.MdiParent = this;
                frmCategoria.Show();
            }
            else
                frmCategoria.Activate();
        }

        private void frmCategoria_FormClosed(object sender, EventArgs e)
        {
            frmCategoria = null;
        }

        private void nuevaBodegaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormBodega frmbo = new FormBodega();
            frmbo.FormClosed += new FormClosedEventHandler(frmProducto_FormClosed);
            frmbo.MdiParent = this;
            frmbo.Show();

        }

        private void registrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuarios frmusu = new FormUsuarios();
            frmusu.FormClosed += new FormClosedEventHandler(frmProducto_FormClosed);
            frmusu.MdiParent = this;
            frmusu.Show();

        }
    }
}
