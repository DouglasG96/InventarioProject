using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class SucursalDAL
    {
        public static List<vw_sucursal> DetalleSucursales()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                return bd.vw_sucursal.ToList();
            }
        }
        public static List<sucursales> CargarSucursales()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                var todasucursales = bd.sucursales;

                return todasucursales.ToList();
            }
        }

        public static sucursales CrearSucursal(sucursales sucursal)
        {

            using (inventarioEntities bd = new inventarioEntities())
            {
                sucursales nuevasucursal = new sucursales();
                nuevasucursal.sucursal = sucursal.sucursal;
                nuevasucursal.estado = sucursal.estado;
                bd.sucursales.Add(nuevasucursal);
                bd.SaveChanges();


            }

            return sucursal;
        }

        public static sucursales EditarSucursal(sucursales sucursal)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {

                var sc = bd.sucursales.First(x => x.id_sucursal == sucursal.id_sucursal);//obtenemos registro por medio de id

                sc.id_sucursal = sucursal.id_sucursal;
                sc.sucursal = sucursal.sucursal;
                sc.estado = sucursal.estado;


                bd.Entry(sc).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
            }
            return sucursal;
        }


        public static sucursales ObtenerIdSucursales(int id)
        {
            sucursales bod = new sucursales();
            using (inventarioEntities bd = new inventarioEntities())
            {
                var sucursal = bd.sucursales.First(x => x.id_sucursal == id);

                sucursal.id_sucursal = sucursal.id_sucursal;
                sucursal.sucursal = sucursal.sucursal;
                sucursal.estado = sucursal.estado;
                return sucursal;
            }
        }

        public static int EliminarSucursal(int id)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                //var prod = (from p in bd.productos
                //              where p.id_producto == id
                //              select p).FirstOrDefault();

                var suc = bd.sucursales.First(x => x.id_sucursal == id);//obtenemos registro por medio de id
                suc.estado = 0;
                bd.Entry(suc).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
            }
            return id;
        }

        public static List<sucursales> BuscarSucursal(string nombre)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                //var producto = (from p in bd.productos
                //              where p.nombre == nombre
                //              select p).ToList();
                var sucursal = bd.sucursales.Where(x => x.sucursal.StartsWith(nombre)).ToList();

                return sucursal;
            }
        }
    }
}
