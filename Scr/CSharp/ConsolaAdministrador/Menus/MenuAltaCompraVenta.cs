﻿using System;
using System.Collections.Generic;
using System.Text;
using NETCore.Encrypt;
using MenuesConsola;
using Mercalibre15;
using ConsolaAdministrador.Menus;


namespace ConsolaAdministrador
{
    
        class MenuAltaCompraVenta : MenuComponente
    {
            private Compraventa compraventa { get; set; }
            private MenuListaProductosVentas MenuListaProductosVenta { get; set; }
            public menuListaUsuario MenuListaUsuario { get; set; }
            public MenuAltaCompraVenta(MenuListaProductosVentas menuListaProductosVentas, menuListaUsuario menuListaUsuario)
            {
                MenuListaProductosVenta = menuListaProductosVentas;
                MenuListaUsuario = menuListaUsuario;
                Nombre = "Alta Compra Venta";
            }

            public override void mostrar()
            {
                base.mostrar();

                var nombre = prompt("Ingrese nombre del producto");
                var usuario = (prompt("Ingrese el nombre del usuario"));
                var cantidad = Convert.ToInt16(prompt("Ingrese la cantidad"));
                
                var fechayhora = Convert.ToDateTime(prompt("Ingrese la fecha y hora"));
                Console.WriteLine("Seleccione el Producto x)");
                var producto = MenuListaProductosVenta.seleccionarElemento();
                var Usuario = MenuListaProductosVenta.seleccionarElemento();

                Compraventa compraventa = new Compraventa()
                {
                    Producto = producto,
                    Usuario = usuario,
                    Cantunidades = Cantunidades,
                    Precio = producto.PrecioUnitario,
                    Fechayhora = DateTime.Now,
                };

                try
                {
                    AdoGerete.ADO.Aproductoventa(compraventa);
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
