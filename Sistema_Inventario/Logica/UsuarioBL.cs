using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
namespace Logica
{
    public class UsuarioBL
    {
        public static usuarios CrearUsuario(usuarios nuevousuario)
        {
            return UsuarioDAL.CrearUsuario(nuevousuario);
        }
    }
}
