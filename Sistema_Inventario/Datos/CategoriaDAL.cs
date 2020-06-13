using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CategoriaDAL
    {
        //metodo para cargar listado de categoria
        public static List<clasificacion> CargarCategorias()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {

                return bd.clasificacion.Where(x => x.estado == 1).ToList();
            }
        }

        //metodo para cargar listado de categorias item opcional
        public static List<clasificacion> CargarCategoriasOpcional()
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                List<clasificacion> list = CargarCategorias();

                list.Insert(0, new clasificacion() { id_clasificacion = 0, nombre_clasificacion = "Seleccione" });

                return list;
            }
        }

        //Metodo para buscar  categoria por id
        public static clasificacion DetalleCategoria(int id)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                var categoria = bd.clasificacion.First(x => x.id_clasificacion == id);

                return categoria;
            }
        }

        //Metodo para buscar  categoria por nombre
        public static List<clasificacion> BuscarCategoria(string nombre)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                
                var categoria = bd.clasificacion.Where(x => x.nombre_clasificacion.StartsWith(nombre)).ToList();

                return categoria;
            }
        }

        public static clasificacion CrearCategoria(clasificacion categoria)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                clasificacion cat = new clasificacion();
                cat.nombre_clasificacion = categoria.nombre_clasificacion;
                cat.estado = 1;
                bd.clasificacion.Add(cat);
                bd.SaveChanges();
            }

            return categoria;
        }

        public static clasificacion EditarCategoria(clasificacion categoria)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {

                var cat = bd.clasificacion.First(x => x.id_clasificacion == categoria.id_clasificacion);//obtenemos registro por medio de id
                cat.nombre_clasificacion = categoria.nombre_clasificacion;
                bd.Entry(cat).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
            }
            return categoria;
        }

        public static int EliminarCategoria(int id)
        {
            using (inventarioEntities bd = new inventarioEntities())
            {
                var cat = bd.clasificacion.First(x => x.id_clasificacion == id);//obtenemos registro por medio de id
                cat.estado = 0;
                bd.Entry(cat).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
            }
            return id;
        }
    }
}
