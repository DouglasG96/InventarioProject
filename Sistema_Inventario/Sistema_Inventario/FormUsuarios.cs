using System;
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
    public partial class FormUsuarios : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            cbxroles.DisplayMember = "rol";
            cbxroles.ValueMember = "id_rol";
            cbxroles.DataSource = RolBL.CargarRoles();

            cbxestado.Items.Add("Activo");
            cbxestado.Items.Add("Inactivo");

        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            usuarios nu = new usuarios();
            nu.usuario = txtusuario.Text.Trim();
            nu.clave = txtclave.Text;
            nu.nombre_completo = txtnombre.Text;
            nu.dui = txtdui.Text;
            string estado = cbxestado.SelectedItem.ToString();
            if (estado == "Activo")
            {
                nu.estado = 1;
            }
            else
            {
                nu.estado = 2;
            }
            
            nu.estado_sesion = 0;
            nu.fecha_ultimo_ingreso = null;
            nu.hora_ultimo_ingreso = null;
            nu.id_rol = Int32.Parse(cbxroles.SelectedValue.ToString());

            UsuarioBL.CrearUsuario(nu);
            MessageBox.Show("Usuario registrado Correctamente", "Registro Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();


        }
    }
}
