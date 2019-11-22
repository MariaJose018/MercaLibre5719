using System;
using System.Collections.Generic;
using System.Text;
using MenuesConsola;
using Mercalibre15;

namespace ConsolaAdministrador.Menus
{
    public class MenuAltaProducto : MenuComponente
    {
        private Producto Producto { get; set; }

        public override void mostrar()
        {
            base.mostrar();
            

            var nombre = prompt("Ingrese nombre del producto");
            var precio = float.Parse(prompt("Ingrese precio unitario"));
            var cantidad = Convert.ToInt16(prompt("Ingrese stock"));
            string fecha = prompt("Ingrese fecha de publicación");
            DateTime dateTime10 = Convert.ToDateTime(fecha);

            
            
            

            Producto = new Producto()
            {
                fechapublicacion = dateTime10,
                cantidad = cantidad,
                PrecioUnitario = precio,
                Nombre = nombre,
            };

            try
            {
                AdoAdministrador.ADO.aproducto(Producto);
                Console.WriteLine("Producto dado de alta con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo dar de alta el producto: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}
