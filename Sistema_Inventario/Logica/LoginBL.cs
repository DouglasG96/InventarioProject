using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LoginBL
    {
        LoginDAL loginDAL;
        public LoginBL()
        {
            loginDAL = new LoginDAL();
        }

        public int validarCampos(String usuario, String clave)
        {
            return loginDAL.validarCredenciales(usuario, clave);
        }

        public bool cerrarSesion(int idUsuario)
        {
            return loginDAL.CerrarSesion(idUsuario);
        }

        public String consultarDatosUsuario(int idUsuario)
        {
           return loginDAL.consultarDatosUsuario(idUsuario);
        }

    }        
}
