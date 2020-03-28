using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Datos
{
    public class RolDAL
    {
        public static List<roles> CargarRoles()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                var mostrarroles = bd.roles;

                return mostrarroles.ToList();
            }
        }
    }
}
