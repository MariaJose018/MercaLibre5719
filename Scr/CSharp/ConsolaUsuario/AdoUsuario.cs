﻿using System;
using System.Collections.Generic;
using System.Text;
using Mercalibre15.ADO;

namespace ConsolaUsuario
{
    public static class AdoUsuario
    {
        public static IADO ADO { get; set; } =
            FactoryADOMysql.GetAdoDesdeJson("appsettings.json", "usuario");
    }
}
