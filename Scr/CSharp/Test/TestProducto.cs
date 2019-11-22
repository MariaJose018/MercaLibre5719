using Mercalibre15;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestPruebaMercalibre
{
    [TestClass]
    public class TestProducto
    {
       

        [TestInitialize]
        [TestMethod]
        public void creacionProducto()
        {
            Producto unProducto = new Producto();
            unProducto.Nombre = "Air Jordan 3 OG";
            unProducto.PrecioUnitario = 12000;
            unProducto.cantidad = 1;
            unProducto.DecrementarCantidad(1);
            Assert.AreEqual(0, unProducto.cantidad);
            unProducto.cambiarPrecio(10000F);
            Assert.AreEqual(10000F, unProducto.PrecioUnitario, 0.00001);
        }
    }
}
