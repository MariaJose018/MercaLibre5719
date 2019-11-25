using System;
using System.Collections.Generic;
using System.Text;
using MenuesConsola;
using Mercalibre15;

namespace ConsolaAdministrador
{
    class ActualizarStock : MenuComponente
    {
        private Producto producto { get; set; } 
        private void menuModificiarProducto()
        {
            bool cambio = false;

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
                    AdoAdministrador.ADO.aproducto(producto);
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
