using Microsoft.VisualStudio.TestTools.UnitTesting;
using MercaLibre5to7ma;
using MercaLibre5to7ma.ADO;

namespace Test
{
    [TestClass]
    public class TestCreacionDB
    {
        public static AdoMySQLEntityCore AdoMySQL { get; set; }

        [ClassInitialize]
        public static void SetUpClase(TestContext context)
        {
            AdoMySQL = new AdoMySQLEntityCore();
            AdoMySQL.Database.EnsureCreated();
        }

        [TestMethod]
        public void AltaUsuario()
        {
            var ado = new MySQLADO();
            AdoMySQL.Database.EnsureDeleted();
            AdoMySQL.Database.EnsureCreated();
            Usuario u = new Usuario() { };
           ado.AltaUsuario(u);

        }
        [TestMethod]
        public void AltaProducto()
        {
            var ado = new MySQLADO();
            AdoMySQL.Database.EnsureDeleted();
            AdoMySQL.Database.EnsureCreated();
            Producto P = new Producto() { };
           ado.AltaProducto(P);

        }
    }

    
}
