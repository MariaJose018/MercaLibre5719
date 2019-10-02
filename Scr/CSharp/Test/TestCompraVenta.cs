using Mercalibre15;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestPruebaMercalibre
{
    [TestClass]
    public class TestCompraVenta
    {
        Compraventa compraventa { get; set; }

        [TestInitialize]
        public void creaciondelaventacompra()
        {
            compraventa.Producto.Nombre = new Compraventa () {  };
            compraventa.Id = 010;
            compraventa.Usuario.Nombredeusuario = 
            Producto.cantidad = 1;
        }
    }
}
