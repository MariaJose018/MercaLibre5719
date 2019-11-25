using System;
using MenuesConsola;
using Mercalibre15;
using NETCore.Encrypt;
using System.Collections.Generic;

namespace ConsolaUsuario
{
   public class MenuListaProductosVentas : MenuListador <Producto>
   {
        public Usuario Usuario { get; set; }

        public MenuListaProductosVentas(Usuario usuario)
        {
            this.Usuario = usuario;
        }

        public override void imprimirElemento(Producto p)
            => Console.WriteLine($"{p.Nombre} - ${p.PrecioUnitario:0.00} - {p.cantidad}");

        public override List<Producto> obtenerLista() => AdoUsuario.ADO.obtenerproductos();
    }
}
