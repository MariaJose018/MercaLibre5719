using System;
using MenuesConsola;
using Mercalibre15;
using NETCore.Encrypt;
using System.Collections.Generic;

namespace ConsolaAdministrador
{
        public class MenuListaProductosVentas : MenuListador<Producto>
        {
            public override void imprimirElemento(Producto producto) => Console.WriteLine($"ID:{producto.Id} Nombre: {producto.Nombre}");

            public override List<Producto> obtenerLista() => AdoAdministrador.ADO.obtenerproductos();
       }
    
}
