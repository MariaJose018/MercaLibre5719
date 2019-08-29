using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mercalibre15;
using Mercalibre15.ADO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestIADOMysql

{
    [TestClass]
    class TestCreacionPersistencia
    {
        static Producto jordan { get; set; }
        static Producto nike720 { get; set; }
        static AdoMySQLEntityCore Ado { get; set; }

        [ClassInitialize]
        public static void iniciarMERCA (TestContext context)
        {
            intanciarPropiedadesEstaticas();
            Ado = new AdoMySQLEntityCore();
            Ado.Database.EnsureDeleted();
            Ado.Database.EnsureCreated();
            
        }
        private static void intanciarPropiedadesEstaticas()
        {
            Gaseosa = new Categoria("Gaseosa");
            Cereal = new Categoria("Cereal");
            Cola = new Producto(45)
            {
                Nombre = "Manaos Cola 2.25L",
                Cantidad = 100,
                Categoria = Gaseosa
            };
            Sprite = new Producto(120)
            {
                Nombre = "Sprite 2.25L",
                Cantidad = 20,
                Categoria = Gaseosa
            };
            CerealTrix = new Producto(75)
            {
                Nombre = "Cereal Trix 500gr.",
                Cantidad = 100,
                Categoria = Cereal
            };

            TicketGaseosas = new Ticket();
            TicketGaseosas.FechaHora = new DateTime(2019, 1, 1, 12, 0, 0);
            TicketGaseosas.agregarProducto(Cola, 2);
            TicketGaseosas.agregarProducto(Cola, 1);
            TicketGaseosas.agregarProducto(Sprite, 3);

            TicketMix = new Ticket();
            TicketMix.FechaHora = new DateTime(2019, 6, 15, 18, 0, 0);
            TicketMix.agregarProducto(CerealTrix, 5);
            TicketMix.agregarProducto(Sprite, 2);
        }
        private static void agregarObjetosAPersistir()
        {
            Ado.Producto();
            Ado.agregarCategoria(Cereal);
            Ado.agregarProducto(Cola);
            Ado.agregarProducto(Sprite);
            Ado.agregarTicket(TicketGaseosas);
            Ado.agregarTicket(TicketMix);
        }
        [TestInitialize]
        public void instanciarAdo()
        {
            Ado = new AdoMySQLEntityCore();
        }
        [TestMethod]
        public void persistprod()
        {
            
        }

        [TestMethod]
        public void actualizarProducto()
        {
            
        }

        [TestMethod]
        public void persistUsu()
        {
            
        }
    }
}
