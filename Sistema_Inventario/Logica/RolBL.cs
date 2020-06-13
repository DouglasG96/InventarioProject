using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;
using Datos;
using Entidades;

namespace Logica
{
    public class RolBL
    {
        public static List<roles> CargarRoles()
        {
            return RolDAL.CargarRoles();
        }
    }
}
