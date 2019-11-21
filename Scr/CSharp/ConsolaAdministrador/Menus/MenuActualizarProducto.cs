using System;
using System.Collections.Generic;
using System.Text;
using Mercalibre15;
using MenuesConsola;

namespace ConsolaAdministrador.Menus
{
    public class MenuActualizarProducto : MenuListaProductosVentas
    {
        public Producto Producto { get; set; }
        public override void mostrar()
        {
            Console.Clear();
            Console.WriteLine(Producto);

            Producto = seleccionarElemento();
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

            if (preguntaCerrada("¿Incrementar stock?"))
            {
                var cantidad = Convert.ToInt16(prompt("Ingrese stock a incrementar"));
                Producto.cantidad += cantidad;
                cambio = true;
            }

            if (cambio)
            {
                try
                {
                    AdoGerete.ADO.aproducto(Producto);
                    Console.WriteLine("Producto actualizado con exito");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"No se pudo modificar por: {e.InnerException.Message}");
                }
                Console.ReadKey();
            }

            
        }
        private bool preguntaCerrada(string v)
        {
            throw new NotImplementedException();
        }
    }
}
