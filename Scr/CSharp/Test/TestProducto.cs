using Mercalibre15;
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
            Jordan3.PrecioUnitario = 12000;
            Jordan3.cantidad = 1;
        }
        [TestMethod]
        public void cambiarPrecio()
        {
            Assert.AreEqual(2, Jordan3);
            Jordan3.cambiarPrecioUnitario(145000F);
            Assert.AreEqual(145000F, Jordan3);
        }
        


    }
}
