using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Diagnostics;
using System.Globalization;


namespace Datos
{
    public class LoginDAL
    {
        inventarioEntities bd;
        int banderaCredenciales;
        public LoginDAL()
        {
            bd = new inventarioEntities();
        }

        public int validarCredenciales(String usuario, String clave)
        {
            //Consulta solo usuarios activos y sin sesion iniciada
            var datosUsuarios = bd.vw_login.ToArray();
            for (int i = 0; i < datosUsuarios.Count(); i++)
            {
                //Debug.Write(i);
                if (datosUsuarios[i].usuario == usuario && datosUsuarios[i].clave == clave)
                {
                    if (datosUsuarios[i].estado_sesion == 0)
                    {
                        //Datos Correctos
                        banderaCredenciales = this.actualizarEstadoSesion(datosUsuarios[i].id_usuario); ;
                        // Finaliza el bucle y la busqueda ya que encontro un registro que coincide
                        break;
                    }
                }
                else
                {
                    //Datos incorrectos o está inactivo o ya ha iniciado sesión
                    banderaCredenciales = 0;
                }

            }
            return banderaCredenciales;
        }

        //metodo para actualizar estado de la sesión
        public int actualizarEstadoSesion(int idUsuario)
        {
            //obtenemos registro por medio de id
            var usuarios = bd.usuarios.First(indice => indice.id_usuario == idUsuario);
            //Seteamos el campo con el valor que queramos
            usuarios.estado_sesion = 1;
            String fechaActual = DateTime.Now.ToString("yyyy-MM-dd");
            String horaActual = DateTime.Now.ToString("hh:mm:ss");
            usuarios.fecha_ultimo_ingreso = DateTime.ParseExact(fechaActual, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            usuarios.hora_ultimo_ingreso = TimeSpan.Parse(horaActual);
            //Ejecutamos la accion de modificar
            bd.Entry(usuarios).State = System.Data.Entity.EntityState.Modified;
            //Guardamos cambios en la base datos
            bd.SaveChanges();
            // Retornamos el id de usuario
            return usuarios.id_usuario;
        }

        public bool CerrarSesion(int idUsuario)
        {
            //obtenemos registro por medio de id
            var usuarios = bd.usuarios.First(indice => indice.id_usuario == idUsuario);
            //Seteamos el campo con el valor que queramos
            usuarios.estado_sesion = 0;
            //Ejecutamos la accion de modificar
            bd.Entry(usuarios).State = System.Data.Entity.EntityState.Modified;
            //Guardamos cambios en la base datos
            bd.SaveChanges();
            // Retornamos el id de usuario
            return true;
        }

        public String consultarDatosUsuario(int idUsuario)
        {
            String nombreUsuario = "";
            var usuarios = bd.usuarios.First(indice => indice.id_usuario == idUsuario);
            return nombreUsuario = usuarios.nombre_completo;
        }
    }
}
