using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class UsuarioDAL
    {
        public static usuarios CrearUsuario(usuarios nuevousuario)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                usuarios usu = new usuarios();
                usu.usuario = nuevousuario.usuario;
                usu.clave = nuevousuario.clave;
                usu.nombre_completo = nuevousuario.nombre_completo;
                usu.dui = nuevousuario.dui;
                usu.estado = nuevousuario.estado;
                usu.estado_sesion = nuevousuario.estado_sesion;
                usu.fecha_ultimo_ingreso = nuevousuario.fecha_ultimo_ingreso;
                usu.hora_ultimo_ingreso = nuevousuario.hora_ultimo_ingreso;
                usu.id_rol = nuevousuario.id_rol;
                bd.usuarios.Add(usu);
                bd.SaveChanges();
            }

            return nuevousuario;

        }
    }
}
