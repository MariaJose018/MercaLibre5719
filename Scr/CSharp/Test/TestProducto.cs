using MercaLibre5to7ma;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;



namespace Test
{
    [TestClass]
    public class TestProducto
    {
        Producto Jordan3 { get; set; }

        [TestInitialize]

        public void creacionProducto()
        {
            Jordan3 = new Producto() { Nombre = "Jordan 3" };
            Jordan3.Nombre = "Air Jordan 3 OG";
            Jordan3.Precio = 12000;
            Jordan3.cantidad = 1;
        }
        [TestMethod]
        public void cambiarPrecio()
        {

        }
        


    }
}
