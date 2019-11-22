using Mercalibre15;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestPruebaMercalibre
{
    [TestClass]
    public class TestUsuario
    {
        

        [TestInitialize]
        [TestMethod]

        public void CrearUsuario()
        {
            
            Usuario unUsuario = new Usuario();
            unUsuario.Nombre = "Alberto";
            unUsuario.Apellido = "Fernandez";
            unUsuario.Telefono = 1134552177;
            unUsuario.Nombredeusuario = "AlbertocuAbierto";
            unUsuario.Email = "Alberto@gmail.com";
            unUsuario.Contrasenia ="123456789";
            

        }


    }
}
