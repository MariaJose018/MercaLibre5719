using Mercalibre15;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;



namespace TestPruebaMercalibre
{
    [TestClass]
    public class TestProducto
    {
        Producto Producto { get; set; }

        [TestInitialize]

        public void creacionProducto()
        {
            Producto = new Producto() { Nombre = "Jordan 3" };
            Producto.Nombre = "Air Jordan 3 OG";
            Producto.PrecioUnitario = 12000;
            Producto.cantidad = 1;
        }

        [TestMethod]
        public void DecrementarCantidad()
        {
            Producto.DecrementarCantidad(1);
            Assert.AreEqual(12000, Producto.cantidad);
        }

        [TestMethod]
        public void ProductoCambiarPrecio()
        {
            Assert.AreEqual(1, Producto);
            Producto.cambiarPrecio(10000);
            Assert.AreEqual(2, Producto);
            Assert.AreEqual(10000, Producto.PrecioUnitario, 0.01);
        }



    }
}
