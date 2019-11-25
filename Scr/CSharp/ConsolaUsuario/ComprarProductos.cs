using System;
using System.Collections.Generic;
using System.Text;
using Mercalibre15;

namespace ConsolaUsuario
{
    public class ComprarProductos : MenuListaProductosVentas
    {
        public string Busqueda { get; set; }
        public ComprarProductos(Usuario usuario) : base(usuario)
        {
        }

        public override List<Producto> obtenerLista()
        {
            return AdoUsuario.ADO.buscarProductos(Busqueda, Usuario);
        }

        public override void mostrar()
        {
            Console.Clear();
            Console.WriteLine(Nombre);

            Busqueda = prompt("Ingrese nombre");
            var producto = seleccionarElemento();
            
            var cantidad = Convert.ToInt32(prompt("ingrese cantidad"));
            try
            {
                Usuario.comprar(producto, cantidad);
                AdoUsuario.ADO.mUsuario(Usuario);
                Console.WriteLine("la compra se realizo con esito");

            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo realizar la busqueda: {e.InnerException.Message}");

            }
            Console.ReadKey();
        }
    }
}
