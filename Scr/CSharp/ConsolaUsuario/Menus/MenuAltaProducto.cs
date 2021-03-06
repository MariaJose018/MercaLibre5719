﻿using System;
using System.Collections.Generic;
using System.Text;
using MenuesConsola;
using Mercalibre15;

namespace ConsolaUsuario
{
    public class MenuAltaProducto : MenuComponente
    {
        public Usuario usuario;

        public MenuAltaProducto(Usuario usuario)
        {
            this.usuario = usuario;
        }

        private Producto Producto { get; set; }
        
        public override void mostrar()
        {
            base.mostrar();

            var nombre = prompt("Ingrese nombre del producto");
            var precio = float.Parse(prompt("Ingrese precio unitario"));
            var cantidad = Convert.ToInt16(prompt("Ingrese stock"));
            var fecha = Convert.ToDateTime(prompt("Ingrese fecha de publicación"));
           
            Producto = new Producto()
            {
                fechapublicacion = fecha,
                cantidad = cantidad,
                PrecioUnitario = precio,
                Nombre = nombre,
            };
            usuario.agregarproducto(Producto);
            try
            {
                AdoUsuario.ADO.aproducto(Producto);
                Console.WriteLine("Producto dado de alta con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo dar de alta el producto: {e.InnerException.Message}");
            }
            Console.ReadKey();
        }
    }
}

