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

    }
}
