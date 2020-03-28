﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Sistema_Inventario
{
    public partial class FormBodega : Form
    {
        public FormBodega()
        {
            InitializeComponent();
        }

        private void FormBodega_Load(object sender, EventArgs e)
        {
            //Cargar tipo de sucursales
            cbxsucursal.DisplayMember = "sucursal";
            cbxsucursal.ValueMember = "id_sucursal";
            cbxsucursal.DataSource = SucursalBL.CargarSucursales();


            //Cargar tipo de bodegas
            cbxbodega.DisplayMember = "tipo";
            cbxbodega.ValueMember = "id_tipo_bodega";
            cbxbodega.DataSource = TipoBodegasBL.CargarTipoBodega();
        }
    }
}
