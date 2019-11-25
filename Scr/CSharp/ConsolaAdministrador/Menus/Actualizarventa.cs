using System;
using System.Collections.Generic;
using System.Text;
using Mercalibre15;
using MenuesConsola;
using System.Linq;

namespace ConsolaAdministrador.Menus
{
    public class Actualizarventa : MenuListaProductosVentas
    {       
        Producto producto { get; set; }
        public Compraventa compravent { get; set; }
        public MenuListaProductosVentas MenuListaProductosVentas { get; set; }
        public override void mostrar()
        {
            Console.Clear();
            Console.WriteLine(compravent);

            Console.WriteLine();
            eliminarVenta();
        }

        private void eliminarVenta()
        {
            bool cambio = false;
           

            
                var venta = MenuListaProductosVentas.seleccionarElemento();
                if (venta == null)
                {
                    Console.WriteLine("Perdon aun no poseemos ventas realizadas");
                }
                else
                {
                  var ideliminar = Convert.ToInt32(prompt("ingrese el id de la venta"));
                  if ( ideliminar == compravent.Id && ideliminar == producto.Id)
                  {
                    producto.eliminarventa(compravent);
                  }
                }


                cambio = true;
            
            

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
