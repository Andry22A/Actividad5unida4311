using System;
using System.Collections.Generic;

namespace Proyecto_1_Sistema_de__Manejo_de_un_almacen
{
    public static class Datos
    {
        public static List<Producto> ListaProductos = new List<Producto>();

        public static bool AgregarProducto(Producto producto)
        {
            if (ListaProductos.Exists(p => p.Nombre == producto.Nombre))
                return false;
            ListaProductos.Add(producto);
            return true;
        }

        public static Producto BuscarProducto(string nombre)
        {
            return ListaProductos.Find(p => p.Nombre == nombre);
        }

        public static bool ActualizarProducto(Producto producto)
        {
            int index = ListaProductos.FindIndex(p => p.Nombre == producto.Nombre);
            if (index == -1)
                return false;
            ListaProductos[index] = producto;
            return true;
        }

        public static bool EliminarProducto(string nombre)
        {
            var producto = BuscarProducto(nombre);
            if (producto == null)
                return false;
            return ListaProductos.Remove(producto);
        }

        public static List<Producto> ObtenerTodos()
        {
            return new List<Producto>(ListaProductos);
        }
    }
}