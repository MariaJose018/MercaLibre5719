using System;
using MenuesConsola;
using Mercalibre15;
using NETCore.Encrypt;
using System.Collections.Generic;

namespace ConsolaUsuario
{
   public class MenuListaProductosVentas : MenuListador <Producto>
   {
        private Usuario usuario;

        public MenuListaProductosVentas(Usuario usuario)
        {
            this.usuario = usuario;
        }

        public override void imprimirElemento(Producto p)
            => Console.WriteLine($"{p.Nombre} - ${p.PrecioUnitario:0.00} - {p.cantidad}");

        public override List<Producto> obtenerLista() => AdoUsuario.ADO.obtenerproductos();
    }
}
