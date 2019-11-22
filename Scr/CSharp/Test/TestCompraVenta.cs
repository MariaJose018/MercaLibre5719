using Mercalibre15;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestPruebaMercalibre
{
    [TestClass]
    public class TestCompraVenta
    {
       

        [TestInitialize]
        public void creaciondelaventacompra()
        {

            Producto unProducto = new Producto();
            unProducto.Nombre = "Air Jordan 3 OG";
            unProducto.PrecioUnitario = 12000;
            unProducto.cantidad = 1;

            Usuario unUsuario = new Usuario();
            unUsuario.Nombre = "Alberto";
            unUsuario.Apellido = "Fernandez";
            unUsuario.Telefono = 1134552177;
            unUsuario.Nombredeusuario = "AlbertocuAbierto";
            unUsuario.Email = "Alberto@gmail.com";
            unUsuario.Contrasenia = "AlbertoyCristina";

            Compraventa unaCompraventa = new Compraventa();
            unaCompraventa.Cantunidades = 1;
            unaCompraventa.Precio = 10000;
        }
    }
}
