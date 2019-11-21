using Mercalibre15;
using System;

namespace ConsolaAdministrador.Menus
{
    public class MenuActualizarProducto : MenuListaProductoVenta
    {
        public Producto Producto { get; set; }
        public override void mostrar()
        {
            Console.Clear();
            Console.WriteLine(Producto);

            Producto = 
            Console.WriteLine();
            menuModificiarProducto();
        }

        private void menuModificiarProducto()
        {
            bool cambio = false;
            if (preguntaCerrada("¿Cambiar nombre?"))
            {
                Producto.Nombre = prompt("Ingrese nombre");
                cambio = true;
            }

            if (preguntaCerrada("¿Cambiar precio unitario?"))
            {
                var precio = float.Parse(prompt("Precio Unitario"));
                Producto.cambiarPrecioUnitario(precio);
                cambio = true;
            }

            if (preguntaCerrada("¿Incrementar stock?"))
            {
                var cantidad = Convert.ToInt16(prompt("Ingrese stock a incrementar"));
                Producto.Cantidad += cantidad;
                cambio = true;
            }

            if (cambio)
            {
                try
                {
                    AdoGerente.ADO.actualizarProducto(Producto);
                    Console.WriteLine("Producto actualizado con exito");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"No se pudo modificar por: {e.InnerException.Message}");
                }
                Console.ReadKey();
            }
        }
    }
}
