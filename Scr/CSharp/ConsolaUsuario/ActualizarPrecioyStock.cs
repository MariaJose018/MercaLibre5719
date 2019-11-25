using Mercalibre15;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolaUsuario
{
    public class ActualizarPrecioyStock : MenuListaProductosVentas
    {
        public ActualizarPrecioyStock(Usuario usuario) : base(usuario)
        {

        }

        public Producto producto { get; set; }
        public override void mostrar()
        {
            Console.Clear();
            Console.WriteLine(Nombre);

            producto = seleccionarElemento();
            Console.WriteLine();
            menuModificiarProducto();
        }

        private void menuModificiarProducto()
        {
            bool cambio = false;

            if (preguntaCerrada("¿Cambiar precio unitario?"))
            {
                var precio = float.Parse(prompt("Precio Unitario"));
                producto.cambiarPrecio(precio);
                cambio = true;
            }

            if (preguntaCerrada("¿Incrementar stock?"))
            {
                var cantidad = Convert.ToInt16(prompt("Ingrese stock a incrementar"));
                producto.cantidad += cantidad;
                cambio = true;
            }

            if (preguntaCerrada("¿Decrementar stock?"))
            {
                var cantidad = Convert.ToInt16(prompt("Ingrese stock a decrementar"));
                producto.cantidad -= cantidad;
                cambio = true;
            }
            if (cambio)
            {
                try
                {
                    AdoUsuario.ADO.aproducto(producto);
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