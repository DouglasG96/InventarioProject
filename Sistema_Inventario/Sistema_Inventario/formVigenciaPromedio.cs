using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidades;

namespace CrudVigenciaPromedio
{
    public partial class FmVigenciaPromedio : Form
    {
        public FmVigenciaPromedio()
        {
            InitializeComponent();
            //Instruccion para que el Data Grid View no genere clumnas automaticamente
            this.dtgVigenciaPromedio.AutoGenerateColumns = false;
        }

        //--------------------------------------------------------------------------
        //Boton Consultar
        private void btnConsultarVP_Click(object sender, EventArgs e)
        {
            /*
            using ( conexion = new inventarioEntitiesVigenciaPromedio())
            {
                if (String.IsNullOrEmpty(this.txtIdVigenciaPromedio.Text))
                {
                    MessageBox.Show("Ingrese un id vigencia promedio a consultar");
                }
                else
                {
                    int id = Convert.ToInt32(this.txtIdVigenciaPromedio.Text);
                    var miIdVigenciaPromedio = conexion.vigencia_promedio.Where(p =>
                     p.id_vigencia_promedio == id).FirstOrDefault();

                    if (miIdVigenciaPromedio == null)
                    {
                        MessageBox.Show("No hay resultados");
                        this.txtIdVigenciaPromedio.Text = String.Empty;
                        this.txtDias.Text = String.Empty;
                    }
                    else
                    {
                        this.txtIdVigenciaPromedio.Text = Convert.ToString(miIdVigenciaPromedio.id_vigencia_promedio);
                        this.txtDias.Text = Convert.ToString(miIdVigenciaPromedio.dias);
                        this.nudEstado.Text = Convert.ToString(miIdVigenciaPromedio.estado);
                    }
                }
            }
            */
        }
        //----------------------------------------------------------------------------------
        //Boton Insertar
        private void btnInsertarVP_Click(object sender, EventArgs e)
        {
            /*
            if (campoValidos())
            {
                vigencia_promedio miVigenciaPromedio = new vigencia_promedio();
                miVigenciaPromedio.id_vigencia_promedio = Convert.ToInt32(this.txtIdVigenciaPromedio.Text);
                miVigenciaPromedio.dias = Convert.ToInt32(this.txtDias.Text);
                miVigenciaPromedio.estado = Convert.ToInt32(this.nudEstado.Value);

                using (inventarioEntitiesVigenciaPromedio conexion = new inventarioEntitiesVigenciaPromedio())
                {
                    conexion.vigencia_promedio.Add(miVigenciaPromedio);
                    MessageBox.Show("Vigencia promedio ingresada");
                    conexion.SaveChanges();
                    btnConsultarActivos_Click(sender, e);
                }
            }
            */
        }
        //---------------------------------------------------------------------------------
        //metodo para validar los campos TextBox
        private bool campoValidos()
        {
            if (String.IsNullOrEmpty(this.txtIdVigenciaPromedio.Text))
            {
                MessageBox.Show("El identificador de vigecia promedio se genera automaticamente");
                return false;
            }
            if (String.IsNullOrEmpty(this.txtDias.Text))
            {
                MessageBox.Show("Ingrese numero de dias");
                return false;
            }
            return true; ;

        }
        //---------------------------------------------------------------------------------
        //Boton Modificar
        private void btnModificarVP_Click(object sender, EventArgs e)
        {
            /*
            if (campoValidos())
            {
                using (inventarioEntitiesVigenciaPromedio conexion = new inventarioEntitiesVigenciaPromedio())
                {
                    int id = Convert.ToInt32(this.txtIdVigenciaPromedio.Text);
                    var miIdVigenciaPromedio = conexion.vigencia_promedio.Where(p =>
                     p.id_vigencia_promedio == id).FirstOrDefault();

                    if (miIdVigenciaPromedio == null)
                    {
                        MessageBox.Show("No es posible actualizar una vigencia promedio que no existe");
                    }
                    else
                    {
                        miIdVigenciaPromedio.id_vigencia_promedio = Convert.ToInt32(this.txtIdVigenciaPromedio.Text);
                        miIdVigenciaPromedio.dias = Convert.ToInt32(this.txtDias.Text);
                        miIdVigenciaPromedio.estado = Convert.ToInt32(this.nudEstado.Value);

                        conexion.SaveChanges();
                        btnConsultarActivos_Click(sender, e);
                        MessageBox.Show("Vigencia promedio Modificada");
                    }
                }
            }
            */
        }
        //---------------------------------------------------------------------------------
        //Boton Eliminar
        private void btnEliminarVP_Click(object sender, EventArgs e)
        {
            /*
            using (inventarioEntitiesVigenciaPromedio conexion = new inventarioEntitiesVigenciaPromedio())
            {
                if (String.IsNullOrEmpty(this.txtIdVigenciaPromedio.Text))
                {
                    MessageBox.Show("Ingrese un identificador de vigencia promedio a consultar");
                }
                else
                {
                    int id = Convert.ToInt32(this.txtIdVigenciaPromedio.Text);
                    var miIdVigenciaPromedio = conexion.vigencia_promedio.Where(p =>
                     p.id_vigencia_promedio == id).FirstOrDefault();

                    if (miIdVigenciaPromedio == null)
                    {
                        MessageBox.Show("No hay resultados");

                        this.txtIdVigenciaPromedio.Text = String.Empty;
                        this.txtDias.Text = String.Empty;
                    }
                    else
                    {
                        miIdVigenciaPromedio.estado = 0;
                        // conexion.vigencia_promedio.Remove(miIdVigenciaPromedio);
                        conexion.SaveChanges();
                        btnConsultarActivos_Click(sender, e);
                        MessageBox.Show("La vigencia promedio ha sido Eliminada");
                    }
                }
            }
            */
        }

        private void btnConsultarTodos_Click(object sender, EventArgs e)
        {
            /*
            using (inventarioEntitiesVigenciaPromedio conexion = new inventarioEntitiesVigenciaPromedio())
            {
                this.dtgVigenciaPromedio.DataSource = conexion.vigencia_promedio.ToList();
            }
            */
        }
        //---------------------------------------------------------------------------------------------------
        //Boton casos activos 
        private void btnConsultarActivos_Click(object sender, EventArgs e)
        {
            /*
            {
                using (inventarioEntitiesVigenciaPromedio conexion = new inventarioEntitiesVigenciaPromedio())
                {
                    this.dtgVigenciaPromedio.DataSource = conexion.vigencia_promedio.Where(p =>
                 p.estado == 1).ToList();
                }
            }
            */
        }

        private void btnEliminados_Click(object sender, EventArgs e)
        {
            /*
            {
                using (inventarioEntitiesVigenciaPromedio conexion = new inventarioEntitiesVigenciaPromedio())
                {
                    this.dtgVigenciaPromedio.DataSource = conexion.vigencia_promedio.Where(p =>
                 p.estado == 0).ToList();
                }
            }
            */
        }
    }
}
