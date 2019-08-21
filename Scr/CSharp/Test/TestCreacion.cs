using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using MercaLibre5to7ma.ADO;


namespace Test
{
    [TestClass]
    public class TestCreacion
    {
        public static AdoMySQLEntityCore AdoMySQL { get; set; }

        [ClassInitialize]
        public static void setUpClase(TestContext context)
        {
            AdoMySQL = new AdoMySQLEntityCore();
            AdoMySQL.Database.EnsureDeleted();
        }
        
        [TestMethod]
        public void SeCreaDB()
        {
            AdoMySQL.Database.EnsureCreated();
        }
    }
}
