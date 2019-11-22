using Mercalibre15;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolaUsuario
{
    class ActualizarPrecioyStock :MenuListaProductosVentas
    {
        public ActualizarPrecioyStock(Usuario usuario) : base(usuario)
        {
        }

        public Producto Producto { get; set; }
        public override void mostrar()
        {
            Console.Clear();
            Console.WriteLine(Nombre);

            Producto = seleccionarElemento();
            Console.WriteLine();
            menuModificiarProducto();
        }

        private void menuModificiarProducto()
        {
            bool cambio = false;

            if (preguntaCerrada("¿Cambiar precio unitario?"))
            {
                var precio = float.Parse(prompt("Precio Unitario"));
                Producto.cambiarPrecio(precio);
                cambio = true;
            }

            if (preguntaCerrada("¿Incrementar stock?"))
            {
                var cantidad = Convert.ToInt16(prompt("Ingrese stock a incrementar"));
                Producto.cantidad += cantidad;
                cambio = true;
            }

            if (preguntaCerrada("¿Decrementar stock?"))
            {
                var cantidad = Convert.ToInt16(prompt("Ingrese stock a decrementar"));
                Producto.cantidad -= cantidad;
                cambio = true;
            }

            if (cambio)
            {
                try
                {
                    AdoUsuario.ADO.aproducto(Producto);
                    Console.WriteLine("Producto actualizado con exito");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"No se pudo modificar por: {e.InnerException.Message}");
                }
                Console.ReadKey();
            }   }

        private bool preguntaCerrada(string v)
        {
            throw new NotImplementedException();
        }
    }
}
